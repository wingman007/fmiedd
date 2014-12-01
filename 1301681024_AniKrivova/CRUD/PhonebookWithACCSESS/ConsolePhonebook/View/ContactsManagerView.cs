//using ConsolePhonebook.Entity;
//using ConsolePhonebook.Repository;
//using ConsolePhonebook.Service;
//using ConsolePhonebook.Tools;

//using System;
//using System.Collections.Generic;

//namespace ConsolePhonebook.View
//{
//    public class ContactsManagerView
//    {
//        public void Show()
//        {
//            while (true)
//            {
//                UserManagementEnum choice = RenderMenu();

//                switch (choice)
//                {
//                    case UserManagementEnum.Select:
//                    {
//                        GetAll();
//                        break;
//                    }
//                    case UserManagementEnum.Insert:
//                    {
//                        Add();
//                        break;
//                    }
//                    case UserManagementEnum.Update: 
//                    {
//                        Update();
//                        break;
//                    }
//                    case UserManagementEnum.Delete:
//                    {
//                        Delete();
//                        break;
//                    }
//                    case UserManagementEnum.Exit:
//                    {
//                        return;
//                    }
//                }
//            }
//        }

//        private UserManagementEnum RenderMenu()
//        {
//            while(true)
//            {
//                Console.Clear();
//                Console.WriteLine("Contacts management:");
//                Console.WriteLine("[C]reate Contact");
//                Console.WriteLine("[R]ead all Contacts");
//                Console.WriteLine("[U]pdate Contact");
//                Console.WriteLine("[D]elete Contact");
//                Console.WriteLine("E[x]it");

//                string choice = Console.ReadLine();
//                switch(choice.ToUpper())
//                {
//                    case "R":
//                    {
//                        return UserManagementEnum.Select;
//                    }
//                    case "C":
//                    {
//                        return UserManagementEnum.Insert;
//                    }
//                    case "U":
//                    {
//                        return UserManagementEnum.Update;
//                    }
//                    case "D":
//                    {
//                        return UserManagementEnum.Delete;
//                    }
//                    case "X":
//                    {
//                        return UserManagementEnum.Exit;
//                    }
//                    default :
//                    {
//                        Console.WriteLine("Invalid choice.");
//                        Console.ReadKey(true);
//                        break;
//                    }
//                }
//            }
//        }

//        private void GetAll()
//        {
//            Console.Clear();

//            ContactsRepository contactsRepository = new ContactsRepository(); 
//            List<Contact> contacts = contactsRepository.GetAll(AuthenticationService.LoggedUser.Id);

//            foreach(Contact contact in contacts)
//            {
//                Console.WriteLine("ID:" + contact.Id);
//                Console.WriteLine("Name :" + contact.FirstName + " " + contact.LastName);
//                Console.WriteLine("Email :" + contact.Email);
//                Console.WriteLine("***************************************************");
//            }

//            Console.ReadKey(true);
//        }

//        private void Add()
//        {
//            Console.Clear();

//            Contact contact = new Contact();
//            contact.ParentUserId = AuthenticationService.LoggedUser.Id;

//            Console.WriteLine("Add new Contact:");
//            Console.Write("First Name: ");
//            contact.FirstName = Console.ReadLine();
//            Console.Write("Last Name: ");
//            contact.LastName = Console.ReadLine();
//            Console.Write("Email: ");
//            contact.Email = Console.ReadLine();

//            ContactsRepository contactsRepository = new ContactsRepository();
//            contactsRepository.Insert(contact);

//            Console.WriteLine("Contact saved successfully.");
//            Console.ReadKey(true);
//        }

//        private void Update()
//        {
//            ContactsRepository contactsRepository = new ContactsRepository();

//            Console.Clear();

//            Console.WriteLine("Update Contact:");
//            Console.Write("Contact Id: ");
//            int contactId = Convert.ToInt32(Console.ReadLine());

//            Contact contact = contactsRepository.GetById(contactId);
//            Console.WriteLine("Update Contact:");
//            Console.Write("First Name: ");
//            contact.FirstName = Console.ReadLine();
//            Console.Write("Last Name: ");
//            contact.LastName = Console.ReadLine();
//            Console.Write("Email: ");
//            contact.Email = Console.ReadLine();
//            contactsRepository.Update(contact);

//            Console.ReadKey(true);

//        }

//        private void Delete()
//        {
//            ContactsRepository contactsRepository = new ContactsRepository(); 

//            Console.Clear();

//            Console.WriteLine("Delete Contact:");
//            Console.Write("Contact Id: ");
//            int contactId = Convert.ToInt32(Console.ReadLine());

//            Contact contact = contactsRepository.GetById(contactId);
//            if (contact == null)
//            {
//                Console.WriteLine("Contact not found!");
//            }
//            else
//            {
//                contactsRepository.Delete(contact);
//                Console.WriteLine("Contact deleted successfully.");
//            }
//            Console.ReadKey(true);
//        }
//    }
//}
