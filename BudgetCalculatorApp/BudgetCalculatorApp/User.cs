using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculatorApp
{
    /// <summary>
    /// Класс хранящий информацию пользователя
    /// </summary>
    public class User
    {
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        private string _firstname;

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        private string _surname;

        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime _birthDate;

        /// <summary>
        /// Список всех транзакций
        /// </summary>
        private List<Transaction> _transactions = new List<Transaction>();

        /// <summary>
        /// Передаёт или задаёт имя пользователя
        /// </summary>
        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        /// <summary>
        /// Передаёт или задаёт фамилию пользователя.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        /// <summary>
        /// Передаёт или задаёт дату рождения пользователя
        /// </summary>
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        /// <summary>
        /// Список транзакций пользователя
        /// </summary>
        public List<Transaction> Transactions
        {
            get => _transactions;
        }

        /// <summary>
        /// Добавляет транзакцию в список пользователя
        /// </summary>
        /// <param name="transaction">Транзакция для добавления</param>
        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        /// <summary>
        /// Удаляет транзакцию из списка пользователя
        /// </summary>
        /// <param name="transaction">Транзакция для добавления</param>
        public void RemoveTransaction(Transaction transaction)
        {
            Transactions.Remove(transaction);
        }

        /// <summary>
        /// Конструктор класса пользователя
        /// </summary>
        /// <param name="firstname">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birthDate">Дата рождения</param>
        public User(string firstname, string surname, DateTime birthDate)
        {
            Firstname = firstname;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
