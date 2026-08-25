using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_POS
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            Console.ReadKey();
        }
        private static void DisplayMenu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("     Welcome to the POS System   ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("[1] Add Item");
            Console.WriteLine("[2] View Item");
            Console.WriteLine("[3] Remove Item");
            Console.WriteLine("[4] View Cart");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("================================");
            Console.WriteLine("Please select an option:");

        }
    }
}