using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Класс для категории приходной транзакции
    /// </summary>
    public class ArrivalCategory : ITransactionCategory
    {
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// Поле имени категории
        /// </summary>
        private string _name;

        /// <summary>
        /// Передаёт или задёт категорию транзакции
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void AddCategory(ITransactionCategory category)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategory(ITransactionCategory category)
        {
            throw new NotImplementedException();
        }

        public ArrivalCategory(string name)
        {
            Name = name;
        }
    }
}
