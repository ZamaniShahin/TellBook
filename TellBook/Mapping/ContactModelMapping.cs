using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TellBook.Mapping
{
    internal class ContactModelMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("ContactBook");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(15).IsRequired();
        }
    }
}
