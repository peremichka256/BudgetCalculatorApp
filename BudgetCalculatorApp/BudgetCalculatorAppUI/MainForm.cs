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

        public MainForm()
        {
            InitializeComponent();

            var wrapper = new AppContext();
            using (var context = new AppContext())
            {
                var user = new User("John", "Doe", 
                    new DateTime(1990, 5, 15));
                var transaction = new Transaction(TransactionType.Expense,
                    "food", 50.0, DateTime.Now);
                user.AddTransaction(transaction);

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
