using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class InputView
    {
        Operations oprarations = new Operations();
        private string name;
        private string email;
        private string pass;
        private int id;


        public void Start()
        {
            while(true)
            {
                Read();
                Console.WriteLine("Choose operation: 1 for adding, 2 for Edit,3 for deleting, Esc for closing the program");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape: Environment.Exit(0);
                        break;
                    case ConsoleKey.D1: Add();
                        break;
                    case ConsoleKey.D2: Update();
                        break;
                    case ConsoleKey.D3: Delete();
                        break;
                    default:Console.WriteLine("Choose operation: 1 for adding, 2 for Edit,3 for deleting, Esc for closing the program");
                        break;
                }
            }
        }
        private void Read()
        {
            oprarations.Read();
        }
        private void Add()
        {
            Console.Clear();
	        Console.WriteLine("Enter username");
            name = Console.ReadLine();
            if(name=="")
            {
                Console.WriteLine("user name is empty");
                Console.WriteLine("Enter username");
            }
            
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            if(email=="")
            {
                Console.WriteLine("email is empty");
                Console.WriteLine("Enter email");
            }
 
	        Console.WriteLine("Enter password");
            pass = Console.ReadLine();	
            if (pass == "")
            {
                Console.WriteLine("pass is empty");
                Console.WriteLine("Enter password");
            }

	        Console.WriteLine("Press 'Enter' to add the info or press 'Esc' to cancel");
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.Enter: oprarations.Add(name, email, pass); Start();
                    break;
                case ConsoleKey.Escape: Start();
                    break;
                default: Console.WriteLine("Press 'Enter' to add the info or press 'Esc' to cancel");
                    break;
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter the id of the person you want to edint");
            try
            {
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Press 'Enter' to update the info or press 'Esc' to cancel");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter: oprarations.getByID(id); ParmUpdate();
                        break;
                    case ConsoleKey.Escape: Start();
                        break;
                    default: Console.WriteLine("Press 'Enter' to edit the info or press 'Esc' to cancel");
                        break;
                }
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only int number");
                Console.WriteLine("Enter the id of the person you want to edint");
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter the id of the person you want to delete");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Press 'Enter' to delete the info or press 'Esc' to cancel");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter: oprarations.Delete(id); Start();
                        break;
                    case ConsoleKey.Escape: Start();
                        break;
                    default: Console.WriteLine("Press 'Enter' to delete the info or press 'Esc' to cancel");
                        break;
                }
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only int number");
                Console.WriteLine("Enter the id of the person you want to delete");
            }  
        }
        private void ParmUpdate()
        {
            Console.WriteLine("Enter username");
            name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("user name is empty");
                Console.WriteLine("Enter username");
            }

            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            if (email == "")
            {
                Console.WriteLine("email is empty");
                Console.WriteLine("Enter email");
            }

            Console.WriteLine("Enter password");
            pass = Console.ReadLine();
            if (pass == "")
            {
                Console.WriteLine("pass is empty");
                Console.WriteLine("Enter password");
            }

            Console.WriteLine("Press 'Enter' to finish editing the info or press 'Esc' to cancel");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Enter: oprarations.Update(id,name ,email, pass); Start();
                    break;
                case ConsoleKey.Escape: Start();
                    break;
                default: Console.WriteLine("Press 'Enter' to add the info or press 'Esc' to cancel");
                    break;
            }
        }
   }      
}