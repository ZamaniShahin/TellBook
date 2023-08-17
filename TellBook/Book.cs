using System.Security.AccessControl;

namespace TellBook;

public class Book
{
    private readonly ContactDbContext _context;

    public Book(ContactDbContext context)
    {
        _context = context;
    }

    public void Create(string firstName, string lastName, string phoneNumber, string emailAddress, string city)
    {
        var contact = new Contact(
            firstName, lastName, phoneNumber, emailAddress, city
            );

        _context.Add(contact);
    }
}