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
        public int Id { get; set; }

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
        public List<Transaction> Transactions { get; set; } 
            = new List<Transaction>();

        /// <summary>
        /// Добавляет транзакцию в список пользователя
        /// </summary>
        /// <param name="transaction">Транзакция для добавления</param>
        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            transaction.UserId = Id; // Устанавливаем внешний ключ
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
        /// Метод расчитывающий итоговый вклад пользователя в бюджет
        /// </summary>
        /// <returns>Сумма расходов и приходов пользователя</returns>
        public double Calculate()
        {
            //TODO: LINQ
            return 0;
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
