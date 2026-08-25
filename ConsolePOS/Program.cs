using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_POS
{
    internal class Program
    {
        static string[] items =
        {
            "Fries",
            "FootLong",
            "Salad",
            "Pizza",
            "Ice Cream",
            "Coffee",
            "Tea",
            "Juice",
            "Soda",
            "Water "
        };

        static decimal[] prices =
        {
            30,
            50,
            80,
            120,
            25,
            60,
            40,
            30,
            20,
            15
        };

        static void Main(string[] args)
        {
            while (true)
            {
                int option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        DisplayItems();
                        Console.ReadKey();
                        break;
                    case 2:
                        // Remove Item
                        break;
                    case 3:
                        // View Cart
                        break;
                    case 4:
                        // Checkout
                        break;
                    case 5:
                        // Exit
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.ReadKey();
            }
        }

        private static int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("    Welcome to the POS System  ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" [1] Add Item");
            Console.WriteLine(" [2] Remove Item");
            Console.WriteLine(" [3] View Cart");
            Console.WriteLine(" [4] Checkout");
            Console.WriteLine(" [5] Exit");
            Console.WriteLine("==============================");
            Console.Write("Please select an option: ");

            int option;
            int.TryParse(Console.ReadLine(), out option);
            return option;
        }

        static void DisplayItems()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            MENU");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($" [{i + 1}] {items[i],-15} P{prices[i]}");
        }
    }
}