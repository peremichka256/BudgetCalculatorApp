using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
        public double GetTotalSum()
        {
            return GetTotalArrival() - GetTotalExpense();
        }

        /// <summary>
        /// Возвращает сумму всех приходных транзакций
        /// </summary>
        /// <returns>Сумма прихода</returns>
        public double GetTotalArrival()
        {
            return Transactions.Where
                    (t => t.Category.Type == TransactionTypes.Arrival)
                .Sum(t => t.Value);
        }

        /// <summary>
        /// Возвращает сумму всех расходных транзакий
        /// </summary>
        /// <returns>Сумма расхода</returns>
        public double GetTotalExpense()
        {
            return Transactions.Where
                    (t => t.Category.Type == TransactionTypes.Expense)
                .Sum(t => t.Value);
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

        /// <summary>
        /// Возвращает имя и фамилию пользователя
        /// </summary>
        /// <returns>Строка с именем и фамилией</returns>
        public override string ToString()
        {
            return $"{Firstname} {Surname}";
        }
    }
}
