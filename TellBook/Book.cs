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

    public void Create(string firstName, string lastName, string phoneNumber, string emailAddress, string city)
    {
        if (string.IsNullOrWhiteSpace(city))
            city = "Unknown";
        if (string.IsNullOrWhiteSpace(emailAddress))
            emailAddress = "Unknown";
        var contact = new Contact(
            firstName, lastName, phoneNumber, emailAddress, city
            );

        _context.Contacts.Add(contact);
        _context.SaveChanges();
    }
    public void Remove(string oldPhoneNumber)
    {
        var contact = SearchByNumber(oldPhoneNumber);
        _context.Contacts.Remove(contact);
        _context.SaveChanges();
    }

    public void Update(string firstName, string lastName, string phoneNumber, string email, string city)
    {
        var contact = new UpdateContactViewModel(firstName, lastName, phoneNumber, email, city);
        throw new NotImplementedException();
    }

    public Contact SearchByNumber(string phoneNumber)
    {
        return _context.Contacts
            .Where(x=>x.IsRemoved == false)
            .FirstOrDefault(x => x.PhoneNumber == phoneNumber);
    }

    public Contact SearchByName(string firstName, string lastName)
    {
        return _context.Contacts
            .Where(x => x.IsRemoved == false)
            .FirstOrDefault(x => x.FirstName.ToLower() + x.LastName.ToLower() == firstName.ToLower() + lastName.ToLower());
    }

    public void DisplayContact(Contact contact)
    {
        Console.WriteLine("First Name: " + contact.FirstName);
        Console.WriteLine("Last Name: " + contact.LastName);
        Console.WriteLine("Phone Number: " + contact.PhoneNumber);
        Console.WriteLine("City : " + contact.City);
        Console.WriteLine("Email Address: " + contact.EmailAddress);
    }

}