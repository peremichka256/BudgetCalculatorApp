using System;
using System.Windows.Forms;
using BudgetCalculatorApp;
using DBWrapper;
using AppContext = DBWrapper.AppContext;

namespace BudgetCalculatorAppUI
{
    public partial class CategoryDialog : Form
    {
        /// <summary>
        /// Поле хранящее редактируемую в форме категорию.
        /// </summary>
        private TransactionCategory _editingCategory;

        private AppContext Context { set; get; }

        public TransactionCategory Category { get; set; }

        /// <summary>
        /// Конструктор вызываемый при изменении категории
        /// </summary>
        public CategoryDialog(AppContext context, TransactionCategory category)
        {
            InitializeComponent();
            _editingCategory = category;
            nameTextBox.Text = _editingCategory.Name;
            arrivalTypeRadioButton.Checked = (_editingCategory.Type
                                              == TransactionTypes.Arrival);
            Context = context;
        }

        /// <summary>
        /// Обработчик завершения редактирования категории
        /// </summary>
        private void doneButton_Click(object sender, EventArgs e)
        {
            var categoryName = nameTextBox.Text;
            var categoryType = arrivalTypeRadioButton.Checked 
                ? TransactionTypes.Arrival : TransactionTypes.Expense;

            var newOrExistingCategory = AppContextExtensions
                .GetOrCreateCategory(Context, categoryName, categoryType);

            _editingCategory = newOrExistingCategory;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
