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
                @"Data Source =.\SQL2019; Initial Catalog=TellBookDb; Persist Security Info=True; User ID=sa;Password=123; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactModelMapping());
        }
    }
}
