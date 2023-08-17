using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Класс описывающий транзакцию 
    /// </summary>
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// Тип транзакции
        /// </summary>
        private TransactionType _type;

        /// <summary>
        /// Категория транзакции
        /// </summary>
        private ITransactionCategory _category;

        /// <summary>
        /// Размер транзакции
        /// </summary>
        private double _value;

        /// <summary>
        /// Дата совершения транзакции
        /// </summary>
        private DateTime _dateTime;

        /// <summary>
        /// Передаёт или задаёт тип транзакции
        /// </summary>
        public TransactionType Type
        {
            get => _type;
        }

        /// <summary>
        /// Передаёт или задаёт категорию транзакции
        /// </summary>
        public ITransactionCategory Category
        {
            get => _category;
        }

        /// <summary>
        /// Метод который устанавливает категорию
        /// транзакции исходя из её типа
        /// </summary>
        /// <param name="type"></param>
        /// <param name="category"></param>
        public void SetTypeAndCategory(TransactionType type, string category)
        {
            _type = type;

            if (_type is TransactionType.Arrival)
            {
                _category = new ArrivalCategory(category);
            }
            else if (_type is TransactionType.Expense)
            {
                _category = new ExpenseCategory(category);
            }
        }

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
                                        " used TransactionType");
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
        public Transaction(TransactionType type, 
            string category, double value, DateTime dateTime)
        {
            SetTypeAndCategory(type, category);
            Value = value;
            DateTime = dateTime;
        }

        public Transaction()
        {

        }
    }
}
