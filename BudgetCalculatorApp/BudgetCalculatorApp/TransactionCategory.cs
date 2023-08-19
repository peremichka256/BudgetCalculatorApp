using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Класс категории транзакции
    /// </summary>
    public class TransactionCategory
    {
        /// <summary>
        /// Поле имени категории
        /// </summary>
        private string _name;

        /// <summary>
        /// Тип категории
        /// </summary>
        private TransactionTypes _type;

        /// <summary>
        /// Первичный ключ категории
        /// </summary>
        [Key]
        public int Id { get; set; }

        // Навигационное свойство для связи "один-ко-многим" с транзакциями
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Передаёт или задёт категорию транзакции
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Передаёт или задёт категорию транзакции
        /// </summary>
        public TransactionTypes Type
        {
            get => _type;
            set => _type = value;
        }

        /// <summary>
        /// Конструктор класса категории
        /// </summary>
        /// <param name="name">Название категории</param>
        /// <param name="type">Тиа приход/расход</param>
        public TransactionCategory(string name, TransactionTypes type)
        {
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Возвращает название категории
        /// </summary>
        /// <returns>Название категории</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
