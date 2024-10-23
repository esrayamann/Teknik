using Microsoft.EntityFrameworkCore;
using Teknik.Concrete;

namespace Teknik
{
    public class AddDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-IEH31APK;database=TeknikServis;user id=sa;password=1234;TrustServerCertificate=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ServisKayit> Kayitlar { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ServisKayit>()
            //    .HasOne(a => a.User)
            //    .WithMany(u => u.Basvurular)
            //    .HasForeignKey(a => a.UserId);
            //base.OnModelCreating(modelBuilder);
        }
    }
}
