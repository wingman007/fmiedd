using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWeek10.Tools;
using projectWeek10.Entity;
using projectWeek10.Service;

namespace projectWeek10.View
{
    class TableView
    {
        static OleDbConnection aConnection;

        public void Show()
        {
            aConnection = new OleDbConnection("Provider=SQLNCLI11;Data Source=VELKO-PC\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=users");

            Console.Clear();

            if (AuthenticationService.LoggedUser.RoleID != 1)
            {


                while (true)
                {
                    Repository.TableRepository.TableMember();
                    Menu choice = RenderMenuMember();
                    switch (choice)
                    {


                        case Menu.Update:
                            {
                                Repository.TableRepository.UpdateMember();
                                break;
                            }

                        case Menu.Exit:
                            {
                                return;
                            }

                    }

                }
            }
            else
            {
                while (true)
                {
                    Repository.TableRepository.Table();

                    Menu choice = RenderMenu();

                    switch (choice)
                    {

                        case Menu.Insert:
                            {
                                Repository.TableRepository.Add();
                                break;
                            }
                        case Menu.Update:
                            {
                                Repository.TableRepository.Update();
                                break;
                            }
                        case Menu.Delete:
                            {
                                Repository.TableRepository.Delete();
                                break;
                            }
                        case Menu.Exit:
                            {
                                return;
                            }
                    }
                }
            }
        }
        
        

        private Menu RenderMenu()
        {
            while (true)
            {

                Console.WriteLine("[C]reate ");
                Console.WriteLine("[U]pdate");
                Console.WriteLine("[D]elete ");
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {

                    case "C":
                        {
                            return Menu.Insert;
                        }
                    case "U":
                        {
                            return Menu.Update;
                        }
                    case "D":
                        {
                            return Menu.Delete;
                        }
                    case "X":
                        {
                            return Menu.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Неправилен избор ! Опитайте отново .");
                            Console.ReadKey(true);
                            break;                          
                        }

                }
            }
        }


        private Menu RenderMenuMember()
        {
            while (true)
            {

                Console.WriteLine("[U]pdate");
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {

                    case "U":
                        {
                            return Menu.Update;
                        }
                    case "X":
                        {
                            return Menu.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Неправилен избор ! Опитайте отново .");
                            Console.ReadKey(true);
                            break;
                        }

                }           
            }
        }
    }
}
