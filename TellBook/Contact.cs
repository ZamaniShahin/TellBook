namespace TellBook;

public class Contact
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public string City { get; set; }
    public bool IsRemoved { get; set; }

    public Contact(string firstName, string lastName, string phoneNumber, string emailAddress = "Test@gmail.com", string city = "Unknown")
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        City = city;
        IsRemoved = false;
    }
}