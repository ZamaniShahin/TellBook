using System.Security.AccessControl;

namespace TellBook;

public class Book
{
    private readonly ContactDbContext _context;

    public Book(ContactDbContext context)
    {
        _context = context;
    }

    public void Create(string firstName, string lastName, string phoneNumber, string emailAddress = "test@gmail.com", string city = "Unknown")
    {
        var contact = new Contact(
            firstName, lastName, phoneNumber, emailAddress, city
            );

        _context.Add(contact);
    }

    public void Update(string firstName, string lastName, string phoneNumber, string email, string city)
    {
        throw new NotImplementedException();
    }

    public void Remove(string? oldPhoneNumber)
    {
        throw new NotImplementedException();
    }

    public int SearchByName(string? firstName, string? lastName)
    {
        throw new NotImplementedException();
    }

    public void DisplayContact(int index)
    {
        throw new NotImplementedException();
    }

    public int SearchByNumber(string? phoneNumber)
    {
        throw new NotImplementedException();
    }
}