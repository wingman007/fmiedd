using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsolePhonebookDB.Tools;
using ConsolePhonebookDB.Service;
using ConsolePhonebookDB.Repository;
using ConsolePhonebookDB.Entity;

namespace ConsolePhonebookDB.View
{
    class ContactManager
    {
        public void Show()
        {
            while(true)
            {
                UserManagementEnum choice = RenderMenu();
                switch (choice)
                {
                    case UserManagementEnum.GetAll:
                    {
                        GetAll();
                        break;
                    }
                    case UserManagementEnum.Add:
                    {
                        Add();  
                        break;
                    }
                    case UserManagementEnum.Edit:
                    {
                        Edit();
                        break;
                    }
                    case UserManagementEnum.Delete:
                    {
                        Delete();
                        break;
                    }
                    case UserManagementEnum.Logout:
                    {
                        AuthenticationService.AuthenticatLogoutAccount(AuthenticationService.LoggedUser);
                        break;
                    }
                    case UserManagementEnum.Exit:
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                }
                if (AuthenticationService.LoggedUser == null)
                    break;
            }
        }

        private UserManagementEnum RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Contacts management:");
                Console.WriteLine("[G]et all Contacts");
                Console.WriteLine("[A]dd Contact");
                Console.WriteLine("[E]dit Contact");
                Console.WriteLine("[D]elete Contact");
                Console.WriteLine("[L]ogout");
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "G":
                        return UserManagementEnum.GetAll;
                    case "A":
                        return UserManagementEnum.Add;
                    case "E":
                        return UserManagementEnum.Edit;
                    case "D":
                        return UserManagementEnum.Delete;
                    case "L":
                        return UserManagementEnum.Logout;
                    case "X":
                        return UserManagementEnum.Exit;
                    default:
                    {
                        Console.WriteLine("Invalid choice.");
                        Console.ReadKey(true);
                        break;
                    }
                }
            }
        }

        private void GetAll()
        {
            Console.Clear();

            Console.WriteLine("All contacts of {0}", AuthenticationService.LoggedUser.ToString());

            ContactsRepository contactRepo = new ContactsRepository();
            List<Contact> contacts = contactRepo.GetContacts(AuthenticationService.LoggedUser.ID);

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }

            Console.ReadKey(true);
        }

        private void Add()
        {
            Console.Clear();

            Contact contact = new Contact();

            contact.UserId = AuthenticationService.LoggedUser.ID;
            Console.WriteLine("Add new phone!");
            Console.Write("Phone number: ");
            contact.Phone = Console.ReadLine();

            ContactsRepository contactRepo = new ContactsRepository();
            contactRepo.AddPhone(contact);

            Console.WriteLine("Contact saved successfully.");
            Console.ReadKey(true);
        }

        private void Edit()
        {
            Console.Clear();

            Console.WriteLine("Edit Phone!");
            Console.WriteLine();

            ContactsRepository contactRepo = new ContactsRepository();
            List<Contact> contacts = contactRepo.GetContacts(AuthenticationService.LoggedUser.ID);
            Contact originalContact = new Contact();
            Console.WriteLine("PHONE ID:");
            foreach (Contact con in contacts)
            {
                originalContact.ID = con.ID;
                originalContact.UserId = con.UserId;
                Console.WriteLine("           " + con.ID + "     " + con.ToString());
            }

            Console.Write("Chooce ID: ");
            int id = int.Parse(Console.ReadLine());

            Contact contact = contactRepo.GetContactById(id);
            if (contact.ID == originalContact.ID && contact.UserId == originalContact.UserId)
            {
                Console.WriteLine("Enter your new phone!");
                Console.Write("Here: ");
                contact.Phone = Console.ReadLine();
                contactRepo.EditPhone(contact);
            }
            else
            {
                Console.WriteLine("No match!");
                Console.ReadKey(true);
            }
        }

        private void Delete()
        {
            Console.Clear();

            Console.WriteLine("Delete phone!");
            Console.WriteLine();

            ContactsRepository contactRepo = new ContactsRepository();
            List<Contact> contacts = contactRepo.GetContacts(AuthenticationService.LoggedUser.ID);
            Console.WriteLine("PHONE ID:");
            foreach (Contact con in contacts)
            {
                Console.WriteLine("           " + con.ID + "     " + con.ToString());
            }
            Console.Write("Chooce ID: ");
            int id = int.Parse(Console.ReadLine());

            Contact contact = contactRepo.GetContactById(id);
            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                contactRepo.DeletePhone(contact);
                Console.WriteLine("Contact deleted successfully.");
            }
            Console.ReadKey(true);
        }
    }
}
