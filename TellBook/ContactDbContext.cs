using Microsoft.EntityFrameworkCore;
using TellBook.Mapping;

namespace TellBook
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                @"Data Source =.\SQL2019; Initial Catalog=EFCore; Persist Security Info=True; User ID=sa;Password=123; TrustServerCertificate=True\r\n";
            optionsBuilder.UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactModelMapping());
        }
    }
}
