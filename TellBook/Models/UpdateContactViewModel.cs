namespace TellBook.Models
{
    public class UpdateContactViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }

        public UpdateContactViewModel(string firstName, string lastName, string phoneNumber, string emailAddress = "test@gmail.com", string city = "Unknown")
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            City = city;
        }
    }
}
