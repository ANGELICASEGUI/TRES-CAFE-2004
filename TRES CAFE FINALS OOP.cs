 using System;
 using System.Collections.Generic;
using Tres_Cafe_Finals.Tres_Cafe_Menu;

namespace Tres_Cafe
    {
        class Program
        {
            static void Main()
            {
                Menu menu = new Menu();
                historyoforders orderHistory = new historyoforders();


            // Order list
            Dictionary<string, int> order = new Dictionary<string, int>();
                int total = 0;

                Console.WriteLine("Welcome to Tres Café!");

                // Display menu
                menu.Display();

                // Order
                while (true)
                {
                    Console.WriteLine("\nEnter item (or type 'order completed' to finish): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "order completed")
                        break;

                    if (menu.ContainsItem(input))
                    {
                    Console.Write("Enter quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    if (order.ContainsKey(input))
                    {
                        order[input] += quantity;
                    }
                    else
                    {
                        order.Add(input, quantity);
                    }

                    total += menu.GetPrice(input) * quantity;
                    Console.WriteLine($"{input} ({quantity}x) added to the order. Current total: {total} PHP");
                }
                else
                {
                    Console.WriteLine("Item is not available");
                }
            }

            // Record the order in history
            orderHistory.AddOrder(order, total);

            // Order Summary
            Console.WriteLine("\nOrder Summary:");
            foreach (var item in order)
            {
                Console.WriteLine($"{item.Key} - Quantity: {item.Value} - Subtotal: {menu.GetPrice(item.Key) * item.Value}");
            }
            Console.WriteLine($"Total: {total} PHP");

            // Display order history
            orderHistory.DisplayOrderHistory();

        }
    }
}

    
