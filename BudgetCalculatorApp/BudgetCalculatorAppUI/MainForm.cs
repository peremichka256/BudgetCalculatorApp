using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BudgetCalculatorApp;
using Microsoft.EntityFrameworkCore;
using AppContext = DBWrapper.AppContext;


namespace BudgetCalculatorAppUI
{
    /// <summary>
    /// Класс хранящий и обрабатывающий пользовательский интерфейс
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле определяющее в каком режиме ведется работа
        /// </summary>
        private ViewMods _currentViewMode = ViewMods.Users;

        /// <summary>
        /// Поле хранящее объект контекста БД
        /// </summary>
        private AppContext _context = new AppContext();

        /// <summary>
        /// Поле хранящее последнего выбранного пользователся
        /// </summary>
        private User _selectedUser = null;

        /// <summary>
        /// Поле хранящее последнюю выбранную транзакцию
        /// </summary>
        private Transaction _selectedTransaction = null;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            goBackButton.Visible = false;
        }

        /// <summary>
        /// Метод выгружающий данные из БД
        /// </summary>
        private void LoadDataFromDatabase()
        {
            if (_currentViewMode == ViewMods.Users)
            {
                var usersWithTransactionsAndCategories = _context.Users
                    .Include(u => u.Transactions)
                    .ThenInclude(t => t.Category) // Включаем связанную категорию для каждой транзакции
                    .ToList();

                dataGridView.DataSource = usersWithTransactionsAndCategories;
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                var transactionsToShow = new List<Transaction>();

                foreach (var transaction in _selectedUser.Transactions)
                {
                    transactionsToShow.Add(transaction);
                }

                dataGridView.DataSource = transactionsToShow;
            }
            else if (_currentViewMode == ViewMods.Categories)
            {
                var categoryToShow = new List<TransactionCategory>
                    { _selectedTransaction.Category };
                dataGridView.DataSource = categoryToShow;
            }
        }

        /// <summary>
        /// Метод добавляющий запись в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == ViewMods.Users)
            {
                UserDialog editUserDialog = new UserDialog();
                DialogResult result = editUserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _context.Users.Add(editUserDialog.User);
                    _context.SaveChanges();
                    LoadDataFromDatabase();
                }
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                TransactionDialog editTransactionDialog = 
                    new TransactionDialog();
                DialogResult result = editTransactionDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _selectedUser.AddTransaction(
                        editTransactionDialog.Transaction);
                    _context.SaveChanges();
                    LoadDataFromDatabase();
                }
            }
        }

        /// <summary>
        /// Метод удаляющий запись из таблицы
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == ViewMods.Users)
            {
                if (dataGridView.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = 
                        dataGridView.Rows[selectedRowIndex];
                    var userToRemove = (User)selectedRow.DataBoundItem;
                    _context.Users.Remove(userToRemove);
                    _context.SaveChanges();
                    LoadDataFromDatabase();
                }
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                if (dataGridView.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = 
                        dataGridView.Rows[selectedRowIndex];
                    var transactionToRemove = 
                        (Transaction)selectedRow.DataBoundItem;
                    _selectedUser.RemoveTransaction(transactionToRemove);
                    _context.Transactions.Remove(transactionToRemove);
                    _context.SaveChanges();
                    LoadDataFromDatabase();
                }
            }
        }

        /// <summary>
        /// Метод отображающий фамилию и имя выбранного пользователя в углу
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0 && selectedRowIndex 
                < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[selectedRowIndex]; 
                selectedRow.Selected = true;

                if (_currentViewMode == ViewMods.Users)
                {
                    _selectedUser = (User)selectedRow.DataBoundItem;
                    userFirstnameLabel.Text = $"{_selectedUser.Firstname} {_selectedUser.Surname}";
                    userDataLabel.Text = $"Родился {_selectedUser.BirthDate.ToString("dd.MM.yyyy")}";
                }
                else if (_currentViewMode == ViewMods.Transactions)
                {
                    _selectedTransaction = (Transaction)selectedRow.DataBoundItem;
                }
            }
        }

        /// <summary>
        /// Навигация между таблицами вглубь
        /// </summary>
        private void dataGridView_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0 && selectedRowIndex 
                < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[selectedRowIndex];

                if (_currentViewMode == ViewMods.Users)
                {
                    _selectedUser = (User)selectedRow.DataBoundItem;
                    SwitchViewMode(ViewMods.Transactions);
                }
                else if (_currentViewMode == ViewMods.Transactions)
                {
                    _selectedTransaction = (Transaction)selectedRow.DataBoundItem;
                    SwitchViewMode(ViewMods.Categories);
                }
            }
        }

        /// <summary>
        /// Навигация между таблицами в обратную сторону
        /// </summary>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == ViewMods.Categories)
            {
                SwitchViewMode(ViewMods.Transactions);
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                SwitchViewMode(ViewMods.Users);
            }
        }

        /// <summary>
        /// Метод переключающий режимы
        /// </summary>
        /// <param name="viewMod">Режим на который
        /// необходимо переключиться</param>
        private void SwitchViewMode(ViewMods viewMod)
        {
            _currentViewMode = viewMod;

            switch (viewMod)
            {
                case ViewMods.Users:
                    SwitchToUsersViewMode();
                    break;
                case ViewMods.Transactions:
                    SwitchToTransactionsViewMode();
                    break;
                case ViewMods.Categories:
                    SwitchToCategoriesViewMode();
                    break;
            }
        }

        /// <summary>
        /// Метод переводящий работу приложения в режим просмотра пользователя
        /// </summary>
        private void SwitchToUsersViewMode()
        {
            goBackButton.Visible = false;
            dataGridView.DataSource = null;
            _currentViewMode = ViewMods.Users;
            LoadDataFromDatabase();
        }

        /// <summary>
        /// Метод переводящий работу приложения в режим просмотра транзакций
        /// </summary>
        /// <param name="user">Пользователь</param>
        private void SwitchToTransactionsViewMode()
        {
            addButton.Visible = true;
            removeButton.Visible = true;
            goBackButton.Visible = true;
            dataGridView.DataSource = null;
            _currentViewMode = ViewMods.Transactions;
            LoadDataFromDatabase();
        }

        /// <summary>
        /// Метод переводящий работу в режим просмотра категории транзакции
        /// </summary>
        /// <param name="transaction"></param>
        private void SwitchToCategoriesViewMode()
        {
            addButton.Visible = false;
            removeButton.Visible = false;
            dataGridView.DataSource = null;
            _currentViewMode = ViewMods.Categories;
            var categoryToShow = 
                new List<TransactionCategory> { _selectedTransaction.Category };
            dataGridView.DataSource = categoryToShow;
        }

        /// <summary>
        /// Кнопка редактирования записей
        /// </summary>
        private void entryEditingButton_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == ViewMods.Users)
            {
                if (_selectedUser != null)
                {
                    UserDialog editUserDialog = new UserDialog(_selectedUser);
                    DialogResult result = editUserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _context.SaveChanges();
                        LoadDataFromDatabase();
                    }
                }
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                if (_selectedTransaction != null)
                {
                    TransactionDialog editTransactionDialog 
                        = new TransactionDialog(_selectedTransaction);
                    DialogResult result = editTransactionDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _context.SaveChanges();
                        LoadDataFromDatabase();
                    }
                }
            }
            else if (_currentViewMode == ViewMods.Categories)
            {
                if (_selectedTransaction != null)
                {
                    CategoryDialog editCategoryDialog 
                        = new CategoryDialog(_selectedTransaction.Category);
                    DialogResult result = editCategoryDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _context.SaveChanges();
                        LoadDataFromDatabase();
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка завршения работы
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
