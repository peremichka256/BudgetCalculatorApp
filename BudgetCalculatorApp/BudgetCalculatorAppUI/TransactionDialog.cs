using System;
using System.Linq;
using System.Windows.Forms;
using BudgetCalculatorApp;
using DBWrapper;
using AppContext = DBWrapper.AppContext;

namespace BudgetCalculatorAppUI
{
    public partial class TransactionDialog : Form
    {
        /// <summary>
        /// Поле хранящее редактируемую в форме транзакци.
        /// </summary>
        private Transaction _editingTransaction;

        /// <summary>
        /// Поле хранящее создаваемую в форме транзакцию
        /// </summary>
        public Transaction Transaction { get; private set; }

        /// <summary>
        /// Поле хранящее тип категории
        /// </summary>
        private TransactionTypes _chosenType;

        private AppContext Context { set; get; }

        /// <summary>
        /// Конструктор вызываемый при создании новой транзакции
        /// </summary>
        public TransactionDialog(AppContext context)
        {
            InitializeComponent();
            Context = context;
        }

        /// <summary>
        /// Конструктор вызываемый при изменении существующей транзакции
        /// </summary>
        /// <param name="transaction"></param>
        public TransactionDialog(AppContext context, Transaction transaction)
        {
            InitializeComponent();
            Context = context;
            _editingTransaction = transaction;
            arrivalTypeRadioButton.Checked = (_editingTransaction.Category.Type 
                                             == TransactionTypes.Arrival);
            categoryNameTextBox.Text = transaction.Category.Name;
            valueTextBox.Text = _editingTransaction.Value.ToString();
            dateTimePicker.Value = _editingTransaction.DateTime;
        }

        /// <summary>
        /// Обработчик завершения редактирования/создания транзаакции
        /// </summary>
        private void doneButton_Click(object sender, EventArgs e)
        {
            if (_editingTransaction != null)
            {
                _editingTransaction.Category.Type = IsTransactionTypeArrival();
                TransactionCategory category = AppContextExtensions
                    .GetOrCreateCategory(Context, categoryNameTextBox.Text,
                        _editingTransaction.Category.Type);
                _editingTransaction.Category = category;
                _editingTransaction.Value = double.Parse(valueTextBox.Text);
                _editingTransaction.DateTime = dateTimePicker.Value.Date;
            }
            else
            {
                _chosenType = IsTransactionTypeArrival();
                TransactionCategory category = AppContextExtensions
                    .GetOrCreateCategory(Context, 
                        categoryNameTextBox.Text, _chosenType);
                Transaction = new Transaction(
                    category,
                    double.Parse(valueTextBox.Text),
                    dateTimePicker.Value.Date);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Метод возвращающий значение выбранного типа транзакции
        /// </summary>
        /// <returns>Значение типа транзакции</returns>
        private TransactionTypes IsTransactionTypeArrival()
        {
            if (arrivalTypeRadioButton.Checked)
            {
                return TransactionTypes.Arrival;
            }

            return TransactionTypes.Expense;
        }
    }
    
}
