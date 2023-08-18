using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetCalculatorApp;
using DBWrapper;
using AppContext = DBWrapper.AppContext;


namespace BudgetCalculatorAppUI
{
    /// <summary>
    /// Класс хранящий и обрабатывающий пользовательский интерфейс
    /// </summary>
    public partial class MainForm : Form
    {
        private User _selectedUser = null;

        public MainForm()
        {
            InitializeComponent();

            var wrapper = new AppContext();
            using (var context = new AppContext())
            {
                var user1 = new User("John", "Doe", 
                    new DateTime(1990, 5, 15));
                var transaction1 = new Transaction(new TransactionCategory(
                    "food", TransactionType.Expense), 50.0, DateTime.Now);
                user1.AddTransaction(transaction1);
                var transaction3 = new Transaction(new TransactionCategory(
                    "taxi", TransactionType.Expense), 10.0, DateTime.Now);
                user1.AddTransaction(transaction3);

                var user2 = new User("Bob", "Brown",
                    new DateTime(1940, 10, 19));
                var transaction2 = new Transaction(new TransactionCategory(
                    "pension", TransactionType.Arrival), 150.0, DateTime.Now);
                user2.AddTransaction(transaction2);

                context.Users.Add(user1);
                context.Users.Add(user2);
                context.SaveChanges();

                //отображение записей на форме
                var users = context.Users.ToList();
                dataGridView.DataSource = users;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                _selectedUser = (User)selectedRow.DataBoundItem; 
                userFirstnameLabel.Text = 
                    $"{_selectedUser.Firstname} {_selectedUser.Surname}";
                userDataLabel.Text = 
                    $"Родился {_selectedUser.BirthDate.ToString("dd.MM.yyyy")}";
            }
            else
            {
                userFirstnameLabel.Text = "Выберите пользователя";
            }
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            // Создание новой записи
            _selectedUser.Transactions.Add(new Transaction(
                new TransactionCategory(
                    "nothing", TransactionType.Arrival), 0, DateTime.Now));

            // Добавление записи в источник данных
            dataGridView.DataSource = _selectedUser.Transactions;
        }

        private void removeTransactionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                _selectedUser.Transactions.Remove((Transaction)dataGridView
                    .SelectedRows[0].DataBoundItem);

                // Удаление записи из источника данных
                dataGridView.DataSource = _selectedUser.Transactions;
            }
        }
    }
}
