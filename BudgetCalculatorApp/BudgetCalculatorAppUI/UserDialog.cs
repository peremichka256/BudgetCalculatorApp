using System;
using System.Windows.Forms;
using BudgetCalculatorApp;

namespace BudgetCalculatorAppUI
{
    /// <summary>
    /// Форма для редактирования и добавления пользователя
    /// </summary>
    public partial class UserDialog : Form
    {
        /// <summary>
        /// Поле хранящее изменяемого пользователя
        /// </summary>
        private User _editingUser;

        /// <summary>
        /// Поле хранящее создаваемого в форме пользователя
        /// </summary>
        public User User { get; private set; }

        /// <summary>
        /// Конструктор вызываемый при создании нового пользователя
        /// </summary>
        public UserDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор вызываемый при редактировании пользователя
        /// </summary>
        /// <param name="user">Редактируемый пользователь</param>
        public UserDialog(User user)
        {
            InitializeComponent();
            _editingUser = user;
            nameTextBox.Text = _editingUser.Firstname;
            surnameTextBox.Text = _editingUser.Surname;
            birthdateTimePicker.Value = _editingUser.BirthDate;
        }

        /// <summary>
        /// Обработчик завершения редактирования/создания пользователя
        /// </summary>
        private void doneButton_Click(object sender, EventArgs e)
        {
            if (_editingUser != null) // Если редактируется существующий
            {
                _editingUser.Firstname = nameTextBox.Text;
                _editingUser.Surname = surnameTextBox.Text;
                _editingUser.BirthDate = birthdateTimePicker.Value.Date;
            }
            else // Если создается новый
            {
                User = new User(nameTextBox.Text, 
                    surnameTextBox.Text, birthdateTimePicker.Value.Date);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
