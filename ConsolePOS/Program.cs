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

        // Cart to hold selected items
        static string[] cartItems = new string[100];
        static decimal[] cartQuantities = new decimal[100];

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                switch (option)
                {
                    case 1:
                        AddItemToCart();
                        break;

                    case 2:
                        RemoveItemFromCart();
                        break;
                    case 3:
                        ViewCart();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }

        static void DisplayItems()
        {
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($" [{i + 1}] {items[i],-15} P{prices[i]}");
            Console.WriteLine("-------------------------------");
        }

        static void AddItemToCart()
        {
            Console.Clear();
            DisplayItems();
            Console.Write("Choose Item: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > items.Length)
            {
                Console.WriteLine("Invalid choice. Press any key...");
                Console.ReadKey();
                return;
            }

            Console.Write("Quantity: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Press any key...");
                Console.ReadKey();
                return;
            }

            int index = choice - 1;
            cartItems[index] = items[index];
            cartQuantities[index] += quantity; // accumulate if added multiple times

            Console.WriteLine($"Added {items[index]} x{quantity} to the cart. Press any key...");
            Console.ReadKey();
        }

        static void ViewCart()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            CART");
            Console.WriteLine("-------------------------------");

            decimal total = 0;

            for (int i = 0; i < cartItems.Length; i++)
            {
                if (!string.IsNullOrEmpty(cartItems[i]) && cartQuantities[i] > 0)
                {
                    decimal itemTotal = prices[i] * cartQuantities[i];
                    total += itemTotal;
                    Console.WriteLine($" {cartItems[i],-15} x{cartQuantities[i],-5} - P{itemTotal}");
                }
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($" Total: P{total}");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static void RemoveItemFromCart()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("         REMOVE ITEM");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < cartItems.Length; i++)
            {
                if (!string.IsNullOrEmpty(cartItems[i]))
                    Console.WriteLine($" [{i + 1}] {cartItems[i],-15} x{cartQuantities[i],-5}");
            }

            Console.WriteLine("-------------------------------");

            Console.Write("Choose item to remove: ");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > cartItems.Length || string.IsNullOrEmpty(cartItems[choice - 1]))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                return;
            }

            cartItems[choice - 1] = null;
            cartQuantities[choice - 1] = 0;
            Console.WriteLine("Item removed from the cart.");
        }
    }
}