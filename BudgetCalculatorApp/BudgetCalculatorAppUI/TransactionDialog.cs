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

        /// <summary>
        /// Конструктор вызываемый при создании новой транзакции
        /// </summary>
        public TransactionDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор вызываемый при изменении существующей конструкции
        /// </summary>
        /// <param name="transaction"></param>
        public TransactionDialog(Transaction transaction)
        {
            InitializeComponent();
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
                _editingTransaction.Category.Name = categoryNameTextBox.Text;
                _editingTransaction.Value = double.Parse(valueTextBox.Text);
                _editingTransaction.DateTime = dateTimePicker.Value.Date;
            }
            else
            {
                _chosenType = IsTransactionTypeArrival();

                Transaction = new Transaction(
                    new TransactionCategory(categoryNameTextBox.Text, _chosenType),
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
