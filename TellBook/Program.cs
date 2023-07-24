using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TellBook
{
    internal class Program
    {
        static void GetAndSetInfo(ref string firstName, ref string lastName, ref string city
            , ref string phoneNumber, ref string email, ref Contact contact)
        {
            WriteLine("Please Enter Contact's FirstName:");
            firstName = ReadLine();
            WriteLine("Please Enter Contact's LastName:");
            lastName = ReadLine();
            WriteLine("Please Enter Contact's City:");
            city = ReadLine();
            WriteLine("Please Enter Contact's Email:");
            email = ReadLine();
            WriteLine("Please Enter Contact's PhoneNumber:");
            phoneNumber = ReadLine();

            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.City = city;
            contact.PhoneNumber = phoneNumber;
            contact.EmailAddress = email;
        }
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            Book tellBook = new Book();
            string oldPhoneNumber;
            string firstName, lastName, city, phoneNumber, email;
            int index;
            while (true)
            {
                firstName = "";
                lastName = "";
                city = "";
                phoneNumber = "";
                email = "";
                oldPhoneNumber = "";
                index = 0;
                contact = null;
                contact = new Contact();
                Clear();
                WriteLine($"You Have {tellBook.numberOfContacts} Contacts.");
                WriteLine("-------------------------");
                WriteLine("1.Add");
                WriteLine("2.Update");
                WriteLine("3.Delete");
                WriteLine("4.Search By Name");
                WriteLine("5.Search By PhoneNumber");
                WriteLine("6.Exit");
                WriteLine("-------------------------");
                Write("Please Choose An Option:");
                string option = ReadLine();

                switch (int.Parse(option))
                {
                    case 1:
                        GetAndSetInfo(ref firstName, ref lastName, ref city, ref phoneNumber
                            , ref email, ref contact);
                        tellBook.AddContact(contact);
                        break;
                    case 2:
                        WriteLine("Please Enter The Old Number Of Contact That You Want To Update.");
                        oldPhoneNumber = ReadLine();
                        GetAndSetInfo(ref firstName, ref lastName, ref city, ref phoneNumber, ref email, ref contact);
                        tellBook.UpdateContact(contact, oldPhoneNumber);
                        break;
                    case 3:
                        WriteLine("Please Enter The Old Number Of Contact That You Want To Delete.");
                        oldPhoneNumber = ReadLine();
                        tellBook.RemoveContact(oldPhoneNumber);
                        break;
                    case 4:
                        WriteLine("Please Enter Contact's FirstName:");
                        firstName = ReadLine();
                        WriteLine("Please Enter Contact's LastName:");
                        lastName = ReadLine();
                        index = tellBook.SearchByName(firstName, lastName);
                        tellBook.DisplayContact(index);
                        WriteLine("-------------------------");
                        WriteLine("Press Any Key To Continue.");
                        ReadKey();
                        break;
                    case 5:
                        WriteLine("Please Enter Contact's PhoneNumber:");
                        phoneNumber = ReadLine();
                        index = tellBook.SearchByNumber(phoneNumber);
                        tellBook.DisplayContact(index);
                        WriteLine("-------------------------");
                        WriteLine("Press Any Key To Continue.");
                        ReadKey();
                        break;
                    case 6:
                        return;
                    default:
                        WriteLine("Please Choose A Number Between 1 to 6.");
                        break;
                }
            }
        }
    }
}
