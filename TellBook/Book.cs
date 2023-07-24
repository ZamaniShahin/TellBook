using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellBook
{
    internal class Book
    {
        public int numberOfContacts = 0;
        Contact[] tellBook = new Contact[40];
        private Contact CreateContact(ref Contact newContact, Contact oldContact)
        {
            newContact.FirstName = oldContact.FirstName;
            newContact.LastName = oldContact.LastName;
            newContact.PhoneNumber = oldContact.PhoneNumber;
            newContact.EmailAddress = oldContact.EmailAddress;
            newContact.City = oldContact.City;
            return newContact;
        }
        private int SearchForEmptyIndex()
        {
            for (int i = 0; i < tellBook.Length; i++)
            {
                if (tellBook[i] == null)
                    return i;
            }
            return -1;
        }
        public void DisplayContact(int index)
        {
            Console.WriteLine($"FirstName:{tellBook[index].FirstName}");
            Console.WriteLine($"LastName:{tellBook[index].LastName}");
            Console.WriteLine($"EmailAddress:{tellBook[index].EmailAddress}");
            Console.WriteLine($"City:{tellBook[index].City}");
            Console.WriteLine($"PhoneNumber:{tellBook[index].PhoneNumber}");
        }
        public void AddContact(Contact newContact)
        {
            int emptyIndex = SearchForEmptyIndex();
            if (tellBook[emptyIndex] == null)
                tellBook[emptyIndex] = newContact;
            CreateContact(ref tellBook[emptyIndex], newContact);
            numberOfContacts++;
        }
        public void UpdateContact(Contact newContact, string phoneNumber)
        {
            int oldContactIndex = SearchByNumber(phoneNumber);
            if (tellBook[oldContactIndex] != null && oldContactIndex != -1)
            {
                CreateContact(ref tellBook[oldContactIndex], newContact);
            }
            else
                Console.WriteLine("There is No Contact With This Number.");
        }
        public void RemoveContact(string phoneNumber)
        {
            int theContactIndex = SearchByNumber(phoneNumber);
            tellBook[theContactIndex] = null;
            numberOfContacts--;
        }
        public int SearchByName(string firstName, string lastName)
        {
            for (int i = 0; i < tellBook.Length; i++)
            {
                if (tellBook[i].FirstName.ToLower() == firstName.ToLower()
                    && tellBook[i].LastName.ToLower() == lastName.ToLower()
                    && tellBook[i] != null)
                {
                    return i;
                }
            }
            return -1;
        }
        public int SearchByNumber(string phoneNumber)
        {
            for (int i = 0; i < tellBook.Length; i++)
            {
                if (tellBook[i] != null && tellBook[i].PhoneNumber == phoneNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
