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
            , ref string phoneNumber, ref string email)
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
        }
        static void Main(string[] args)
        {
            var dbContext = new ContactDbContext();
            Book tellBook = new Book(dbContext);
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
                Clear();
                WriteLine($"You Have {dbContext.Contacts.Count()} Contacts.");
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
                            , ref email);
                        tellBook.Create(firstName, lastName, phoneNumber, email, city);
                        break;
                    case 2:
                        WriteLine("Please Enter The Old Number Of Contact That You Want To Update.");
                        oldPhoneNumber = ReadLine();
                        GetAndSetInfo(ref firstName, ref lastName, ref city, ref phoneNumber, ref email);
                        tellBook.Update(firstName, lastName, phoneNumber, email, city);
                        break;
                    case 3:
                        WriteLine("Please Enter The Old Number Of Contact That You Want To Delete.");
                        oldPhoneNumber = ReadLine();
                        tellBook.Remove(oldPhoneNumber);
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
