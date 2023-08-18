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

        public virtual DbSet<TransactionCategories> TransactionCategories { get; set; }
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
            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
