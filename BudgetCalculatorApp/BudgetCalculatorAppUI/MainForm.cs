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
                dataGridView.DataSource = 
                    LoadUsersWithTransactionsAndCategories();
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                dataGridView.DataSource = LoadTransactionsToShow();
            }
            else if (_currentViewMode == ViewMods.Categories)
            {
                dataGridView.DataSource = LoadCategoriesToShow();
            }
        }

        /// <summary>
        /// Выгружает пользователей из БД
        /// </summary>
        /// <returns>Список пользователей</returns>
        private List<User> LoadUsersWithTransactionsAndCategories()
        {
            return _context.Users
                .Include(u => u.Transactions)
                .ThenInclude(t => t.Category)
                .ToList();
        }

        /// <summary>
        /// Выгружает транзакции какждого пользователя
        /// </summary>
        /// <returns>Список транзакций</returns>
        private List<Transaction> LoadTransactionsToShow()
        {
            return _selectedUser?.Transactions.ToList() 
                   ?? new List<Transaction>();
        }

        /// <summary>
        /// Выгружает категорию транзакции 
        /// </summary>
        /// <returns>Список категорий из одного элемента</returns>
        private List<TransactionCategory> LoadCategoriesToShow()
        {
            return _selectedTransaction != null
                ? new List<TransactionCategory> { _selectedTransaction.Category }
                : new List<TransactionCategory>();
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
                AddNewUser();
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                AddNewTransaction();
            }
        }

        /// <summary>
        /// Добавляет пользователя
        /// </summary>
        private void AddNewUser()
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

        /// <summary>
        /// Добавляет транзакцию
        /// </summary>
        private void AddNewTransaction()
        {
            TransactionDialog editTransactionDialog = new TransactionDialog(_context);
            DialogResult result = editTransactionDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _selectedUser.AddTransaction(editTransactionDialog.Transaction);
                _context.SaveChanges();
                LoadDataFromDatabase();
            }
        }

        /// <summary>
        /// Метод удаляющий запись из таблицы
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == ViewMods.Users)
            {
                RemoveUser();
            }
            else if (_currentViewMode == ViewMods.Transactions)
            {
                RemoveTransaction();
            }
        }

        /// <summary>
        /// Удаляет пользователя
        /// </summary>
        private void RemoveUser()
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
        
        /// <summary>
        /// Удаляет транзакцию
        /// </summary>
        private void RemoveTransaction()
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0]
                    .RowIndex;
                DataGridViewRow selectedRow = dataGridView
                    .Rows[selectedRowIndex];
                var transactionToRemove = (Transaction)selectedRow
                    .DataBoundItem;
                _selectedUser.RemoveTransaction(transactionToRemove);
                _context.Transactions.Remove(transactionToRemove);
                _context.SaveChanges();
                LoadDataFromDatabase();
            }
        }

        /// <summary>
        /// Метод отображающий фамилию и имя выбранного пользователя в углу
        /// </summary>
        private void dataGridView_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            HandleDataGridViewCellClick(e.RowIndex);
        }

        /// <summary>
        /// Навигация между таблицами вглубь
        /// </summary>
        private void dataGridView_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            HandleDataGridViewCellClick(e.RowIndex);
            HandleDoubleClickNavigation();
        }

        /// <summary>
        /// Запоминает выбранный элемент и подсвечивает всю строку
        /// </summary>
        /// <param name="rowIndex"></param>
        private void HandleDataGridViewCellClick(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                selectedRow.Selected = true;

                if (_currentViewMode == ViewMods.Users)
                {
                    _selectedUser = (User)selectedRow.DataBoundItem;
                    UpdateUserLabels();
                }
                else if (_currentViewMode == ViewMods.Transactions)
                {
                    _selectedTransaction = (Transaction)selectedRow
                        .DataBoundItem;
                }
            }
        }

        /// <summary>
        /// Переводит работу в необходимый режим
        /// </summary>
        private void HandleDoubleClickNavigation()
        {
            if (_currentViewMode == ViewMods.Users && _selectedUser != null)
            {
                SwitchViewMode(ViewMods.Transactions);
            }
            else if (_currentViewMode == ViewMods.Transactions 
                     && _selectedTransaction != null)
            {
                SwitchViewMode(ViewMods.Categories);
            }
        }

        /// <summary>
        /// Обновляет информацию о выбранном пользователе в углу
        /// </summary>
        private void UpdateUserLabels()
        {
            userFirstnameLabel.Text = 
                $"{_selectedUser.Firstname} {_selectedUser.Surname}";
            userDataLabel.Text = 
                $"Родился {_selectedUser.BirthDate.ToString("dd.MM.yyyy")}";
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
            entryEditingButton.Visible = true;
            dataGridView.DataSource = null;
            _currentViewMode = ViewMods.Transactions;
            LoadDataFromDatabase();
        }

        /// <summary>
        /// Метод переводящий работу в режим просмотра категории транзакции
        /// </summary>
        private void SwitchToCategoriesViewMode()
        {
            addButton.Visible = false;
            removeButton.Visible = false;
            entryEditingButton.Visible = false;
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
            if (_currentViewMode == ViewMods.Users && _selectedUser != null)
            {
                EditUser();
            }
            else if (_currentViewMode == ViewMods.Transactions 
                     && _selectedTransaction != null)
            {
                EditTransaction();
            }
        }

        /// <summary>
        /// Редактирует пользоватея
        /// </summary>
        private void EditUser()
        {
            using (var editUserDialog = new UserDialog(_selectedUser))
            {
                DialogResult result = editUserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _context.SaveChanges();
                    LoadDataFromDatabase();
                }
            }
        }

        /// <summary>
        /// Редактирует трназакцию
        /// </summary>
        private void EditTransaction()
        {
            using (var editTransactionDialog = 
                   new TransactionDialog(_context, _selectedTransaction))
            {
                DialogResult result = editTransactionDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _context.SaveChanges();
                    LoadDataFromDatabase();
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

        /// <summary>
        /// Выводит финансовый отчёт
        /// </summary>
        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null)
            {
                double userBalance = _selectedUser.GetTotalSum();

                string reportMessage = $"Финансовый отчёт для пользователя " +
                                       $"{_selectedUser.Firstname}" +
                                       $" {_selectedUser.Surname}:\n";
                reportMessage += $"Всего приходов: " +
                                 $"{_selectedUser.GetTotalArrival():F2}\n";
                reportMessage += $"Всего расходов: " +
                                 $"{_selectedUser.GetTotalExpense():F2}\n";
                reportMessage += $"Итоговый баланс: {userBalance:F2}";

                MessageBox.Show(reportMessage, "Финансовый отчёт",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
