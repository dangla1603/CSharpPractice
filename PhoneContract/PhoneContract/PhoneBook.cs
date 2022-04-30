using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneContact
{
    class PhoneBook
    {
        //initialazation the list of contacts 
        // _contacts to indicate this is the private field
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: { contact.Name}, { contact.Number}");
        }

        private void DisplayListContactDetails(List<Contact> contacts)
        {
            //using foreach loop to print out each elements in the loop
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void addContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        //display contact as given number
        public void DisplayContact(String number)
        {
            //using lamba expression
            //using c ( as contact ) to see if number will match with given number
            var contact = _contacts.FirstOrDefault(c => c.Number == number);

            // if given contact is wrong
            if (contact == null)
            {
                Console.WriteLine("Contact not found !");
            }
            else
            {
                //print out if contact is match
                DisplayContactDetails(contact);
            }
        }
        
        //display all contact 
        public void DisplayAllContact()
        {
            DisplayListContactDetails(_contacts);
        }

        //search the contact by given name
        public void DisplayMatchingContacts( string searchName)
        {
            //name search : Dang
            //searchName : ng
            //this will look for any element that has "ng"

            var matchingName = _contacts.Where(c => c.Name.Contains(searchName)).ToList();

            DisplayListContactDetails(matchingName);
        }

    }
}
