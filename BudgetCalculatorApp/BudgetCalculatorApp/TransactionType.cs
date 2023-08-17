using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Перечисление содержащие тип транзакции
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Транзакция расхода
        /// </summary>
        Expense,

        /// <summary>
        /// Транзакция прихода
        /// </summary>
        Arrival
    }
}
