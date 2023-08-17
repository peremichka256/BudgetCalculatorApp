using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBWrapper
{
    public partial class familyBudgetContext : DbContext
    {
        public familyBudgetContext()
        {
        }

        public familyBudgetContext(DbContextOptions<familyBudgetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArrivalCategories> ArrivalCategories { get; set; }
        public virtual DbSet<ExpenseCategories> ExpenseCategories { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=familyBudget;Username=postgres;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArrivalCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
            });

            modelBuilder.Entity<ExpenseCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.HasIndex(e => e.UserTransactionId);

                entity.HasOne(d => d.UserTransaction)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.UserTransactionId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.TransactionId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
