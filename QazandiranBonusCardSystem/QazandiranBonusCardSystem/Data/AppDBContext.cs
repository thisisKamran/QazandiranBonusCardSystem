using Microsoft.EntityFrameworkCore;
using QazandiranBonusCardSystem.Models.Entities;

namespace QazandiranBonusCardSystem.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Card>()
                .HasOne<User>()
                .WithMany(u => u.Cards)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
