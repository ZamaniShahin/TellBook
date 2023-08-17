using System.Security.AccessControl;
using TellBook.Models;

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

        _context.Contacts.Add(contact);
    }

    public void Update(string firstName, string lastName, string phoneNumber, string email, string city)
    {
        var contact = new UpdateContactViewModel(firstName, lastName, phoneNumber, email, city);
        throw new NotImplementedException();
    }

    public void Remove(string oldPhoneNumber)
    {
        var contact = _context.Contacts.FirstOrDefault(x => x.PhoneNumber == oldPhoneNumber);
        _context.Contacts.Remove(contact);
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