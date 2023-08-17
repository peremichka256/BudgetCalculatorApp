using System;
using System.Data;
using BudgetCalculatorApp;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace DBWrapper
{
    /// <summary>
    /// Класс контекста базы данных для взаимодействия с таблицами
    /// </summary>
    public class AppContext : DbContext
    {
        /// <summary>
        /// Строка подлкючения к локальной БД со всеми необходимыми данными
        /// </summary>
        private const string CONNECTION_STRING = "Server=localhost;" +
                                                "Port=5432;" +
                                                "Database=familyBudget;" +
                                                "User Id=postgres;" +
                                                "Password=root;";
        /// <summary>
        /// Набор данных для доступа к таблице пользователей
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Набор данных для доступа к таблице транзакций
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }

        /// <summary>
        /// Набор данных для доступа к таблице категорий расходных транзакций
        /// </summary>
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        /// <summary>
        /// Набор данных для доступа к таблице категорий приходных транзакций
        /// </summary>
        public DbSet<ArrivalCategory> ArrivalCategories { get; set; }

        /// <summary>
        /// Метод для настройки подключения к базе данных
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Установка подключения к БД
            optionsBuilder.UseNpgsql(CONNECTION_STRING);
        }
    }
}
