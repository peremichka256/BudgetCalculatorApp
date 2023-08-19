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
    public partial class CategoryDialog : Form
    {
        /// <summary>
        /// Поле хранящее редактируемую в форме категорию.
        /// </summary>
        private TransactionCategory _editingCategory;

        /// <summary>
        /// Конструктор вызываемый при изменении категории
        /// </summary>
        public CategoryDialog(TransactionCategory category)
        {
            InitializeComponent();
            _editingCategory = category;
            nameTextBox.Text = _editingCategory.Name;
            arrivalTypeRadioButton.Checked = (_editingCategory.Type
                                              == TransactionTypes.Arrival);
        }

        /// <summary>
        /// Обработчик завершения редактирования категории
        /// </summary>
        private void doneButton_Click(object sender, EventArgs e)
        {
            if (arrivalTypeRadioButton.Checked)
            {
                _editingCategory.Type = TransactionTypes.Arrival;
            }
            else
            {
                _editingCategory.Type = TransactionTypes.Expense;
            }

            _editingCategory.Name = nameTextBox.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
