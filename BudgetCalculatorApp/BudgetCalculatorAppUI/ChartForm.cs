using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BudgetCalculatorApp;
using AppContext = DBWrapper.AppContext;

namespace BudgetCalculatorAppUI
{
    /// <summary>
    /// Форма с финальным отчетом и графиками
    /// </summary>
    public partial class ChartForm : Form
    {
        /// <summary>
        /// Поле хранящее контекст БД
        /// </summary>
        private AppContext _context;
        private double _totalArrival;
        private double _totalExpense;

        public ChartForm(AppContext context)
        {
            InitializeComponent();
            _context = context;

            PrintTotalBudgetData();
            DrawFirstChart();
            DrawSecondChart();
        }

        /// <summary>
        /// Метод выводящий основную информацию в лэйблы
        /// </summary>
        private void PrintTotalBudgetData()
        {
            _totalArrival = _context.Users
                .Sum(user => user.Transactions
                    .Where(transaction => transaction.Category.Type
                                          == TransactionTypes.Arrival)
                    .Sum(transaction => transaction.Value));

            _totalExpense = _context.Users
                .Sum(user => user.Transactions
                    .Where(transaction => transaction.Category.Type
                                          == TransactionTypes.Expense)
                    .Sum(transaction => transaction.Value));

            totalArrivalLabel.Text = $"Всего приходов: {_totalArrival:F2}\n";
            totalExpenseLabel.Text = $"Всего расходов: {_totalExpense:F2}\n";
            totalResultLabel.Text = $"Итоговый баланс: " +
                                    $"{_totalArrival - _totalExpense:F2}";


            var mostExpensiveCategory = _context.TransactionCategories
                .Select(category => new
                {
                    Category = category,
                    TotalExpense = _context.Transactions
                        .Where(transaction => transaction.CategoryId == category.Id)
                        .Sum(transaction => transaction.Category.Type
                                            == TransactionTypes.Expense
                            ? transaction.Value
                            : 0)
                })
                .OrderByDescending(item => item.TotalExpense)
                .FirstOrDefault();

            mostPopularCategoryLabel.Text = $"Категория с наибольшими расходами: " +
                                            $"{mostExpensiveCategory.Category.Name}\n" +
                                            $"Сумма расходов: {mostExpensiveCategory.TotalExpense:F2}";
        }

        private void DrawFirstChart()
        {
            List<CategoryExpense> categoryExpenses = _context.TransactionCategories
                .Select(category => new CategoryExpense
                {
                    CategoryName = category.Name,
                    TotalExpense = _context.Transactions
                        .Where(transaction => transaction.CategoryId == category.Id && transaction.Category.Type == TransactionTypes.Expense)
                        .Sum(transaction => transaction.Value)
                })
                .ToList();

            chart1.Series["Expenses"].Points.Clear(); // Очистка данных перед добавлением новых

            foreach (var categoryExpense in categoryExpenses)
            {
                chart1.Series["Expenses"].Points.AddXY(categoryExpense.CategoryName, categoryExpense.TotalExpense);
            }

            chart1.Series["Expenses"].IsValueShownAsLabel = true;
            chart1.Series["Expenses"].Color = Color.Blue;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Добавление подписи к оси Y
            chart1.ChartAreas[0].AxisY.Title = "Сумма";
            // Добавление заголовка к графику
            chart1.Titles.Add("Расходы и доходы по категориям");
        }

        private void DrawSecondChart()
        {
            List<ExpenseIncome> expenseIncomes = new List<ExpenseIncome>
            {
                new ExpenseIncome { Label = "Расходы", Value = _totalExpense },
                new ExpenseIncome { Label = "Доходы", Value = _totalArrival }
            };

            chart2.Series["ExpensesIncomes"].Points.Clear(); // Очистка данных перед добавлением новых

            foreach (var expenseIncome in expenseIncomes)
            {
                chart2.Series["ExpensesIncomes"].Points.AddXY(expenseIncome.Label, expenseIncome.Value);
            }

            chart2.Series["ExpensesIncomes"].Label = "#PERCENT{P0}";
            chart2.Series["ExpensesIncomes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chart2.Legends[0].Enabled = true;
            chart2.Legends[0].Alignment = StringAlignment.Center;
            // Добавление заголовка к графику
            chart2.Titles.Add("Соотношение расходов и доходов");
        }
    }
}
