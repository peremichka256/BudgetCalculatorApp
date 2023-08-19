using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Класс описывающий транзакцию 
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Категория транзакции
        /// </summary>
        private TransactionCategory _category;

        /// <summary>
        /// Размер транзакции
        /// </summary>
        private double _value;

        /// <summary>
        /// Дата совершения транзакции
        /// </summary>
        private DateTime _dateTime;

        /// <summary>
        /// Первичный ключ транзакции
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Передаёт или задаёт категорию
        /// транзакции исходя из её типа
        /// </summary>
        public TransactionCategory Category
        {
            get => _category;
            set => _category = value;
        }

        /// <summary>
        /// Внешний ключ для связи с категорией транзакции
        /// </summary>
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Передаёт или задаёт пользователя транзакции
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Внешний ключ для связи с пользователем
        /// </summary>
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        /// <summary>
        /// Передаёт или задаёт размер транзакции
        /// </summary>
        public double Value
        {
            get => _value;

            set
            {
                if (value < 0)
                {
                    throw new Exception("Value should be more that" +
                                        " zero, for expense transaction is" +
                                        " used TransactionTypes");
                }

                _value = value;
            }
        }

        /// <summary>
        /// Передаёт или задёт дату совершения транзакции
        /// </summary>
        public DateTime DateTime
        {
            get => _dateTime;
            set => _dateTime = value;
        }

        /// <summary>
        /// Конструктор класса транзакции
        /// </summary>
        /// <param name="type">Тип</param>
        /// <param name="category">Категория</param>
        /// <param name="value">Размер</param>
        /// <param name="dateTime">Время</param>
        public Transaction(TransactionCategory category, double value,
            DateTime dateTime)
        {
            Category = category;
            CategoryId = category.Id;
            Value = value;
            DateTime = dateTime;
        }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Transaction()
        {
        }
    }
}
