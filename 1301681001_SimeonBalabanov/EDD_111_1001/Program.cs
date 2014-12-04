using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDD_111_1001.Presentation;
using System.Threading;

namespace EDD_111_1001
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Title = "Simeon Balabanov";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            StartView sview = new StartView();

            Console.ReadKey(true);
        }
    }
}
