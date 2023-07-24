using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellBook
{
    internal class Book
    {
        int numberOfContacts = 0;
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
        public Contact ReturnContactByIndex(int index)
        {
            return tellBook[index];
        }
        private void AddContact(Contact newContact)
        {
            int emptyIndex = SearchForEmptyIndex();
            CreateContact(ref tellBook[emptyIndex], newContact);
            numberOfContacts++;
        }
        private void UpdateContact(Contact newContact,string phoneNumber)
        {
            int oldContactIndex = SearchByNumber(phoneNumber);
            if (oldContactIndex != -1)
            {
                CreateContact(ref tellBook[oldContactIndex], newContact);
            }
            else
                Console.WriteLine("There is No Contact With This Number.");
        }
        private void RemoveContact(string phoneNumber)
        {
            int theContactIndex = SearchByNumber(phoneNumber);
            tellBook[theContactIndex] = null;
        }
        private int SearchByName(string firstName, string lastName)
        {
            for (int i = 0; i < tellBook.Length; i++)
            {
                if (tellBook[i].FirstName.ToLower() == firstName.ToLower()
                    && tellBook[i].LastName.ToLower() == lastName.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        private int SearchByNumber(string phoneNumber)
        {
            for (int i = 0; i < tellBook.Length; i++)
            {
                if (tellBook[i].PhoneNumber == phoneNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
