using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Contact> myContacts = new List<Contact>();

            start();

            void start()
            {
                Console.WriteLine("What would you like to do");
                Console.WriteLine("enter 'add contact' to create a contact");
                Console.WriteLine("enter 'list contacts' to list contacts");
                Console.WriteLine("enter 'remove contacts' to remove a contact");
                string choice = Console.ReadLine();
                if (choice == "add contact"){
                    createContact();
                }else if (choice == "list contacts")
                {
                    listContacts();
                }
                else if (choice == "remove contacts")
                {
                    removeContact();
                }
            }
                void createContact()
                {
                    Console.WriteLine("enter contacts name");
                    string Cname = Console.ReadLine();
                    Console.WriteLine("enter contacts number");
                    int Cnum = Convert.ToInt32(Console.ReadLine());
                    myContacts.Add(new Contact
                    {
                        Name = Cname,
                        Num = Cnum,
                    });
                    Console.WriteLine("contacts has been made");
                start();
                }
                void listContacts()
                {
                    foreach (var contact in myContacts)
                    {
                        Console.WriteLine(contact.Name);
                        Console.WriteLine(contact.Num);
                        Console.WriteLine("**********");

                    }
                start();
                }
            void removeContact()
            {
                Console.WriteLine("which contact would you like to remove? The list starts at 0");
               int remove = Convert.ToInt32(Console.ReadLine());
                myContacts.RemoveAt(remove);
                Console.WriteLine("Contact has been removed");
                start();
            }
            
        }
    }
    public class Contact
    {
        public string Name { get; set; }
        public int Num { get; set; }


    }
}
