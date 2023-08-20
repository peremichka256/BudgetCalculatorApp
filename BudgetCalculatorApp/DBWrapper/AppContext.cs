using BudgetCalculatorApp;
using Microsoft.EntityFrameworkCore;

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
        /// Набор данных для доступа к таблице категорий транзакций
        /// </summary>
        public DbSet<TransactionCategory> TransactionCategories { get; set; }

        /// <summary>
        /// Метод для настройки подключения к базе данных
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Установка подключения к БД
            optionsBuilder.UseNpgsql(CONNECTION_STRING);
        }

        /// <summary>
        /// Определяет связи между таблицами
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Transaction>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<TransactionCategory>()
                .HasKey(tc => tc.Id);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Transactions)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Category)
                .WithMany(tc => tc.Transactions)
                .HasForeignKey(t => t.CategoryId);
        }
    }
}
