using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Интерфейс для категории транзакции
    /// </summary>
    public interface ITransactionCategory
    {
        [Key]
        int CategoryId { get; set; }

        /// <summary>
        /// Передаёт или задёт категории транзакции строковым значением
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Добавляет категорию
        /// </summary>
        /// <param name="category"></param>
        void AddCategory(ITransactionCategory category);

        /// <summary>
        /// Удаляет категорию
        /// </summary>
        /// <param name="category"></param>
        void RemoveCategory(ITransactionCategory category);
    }
}
