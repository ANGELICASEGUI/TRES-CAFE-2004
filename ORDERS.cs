using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tres_Cafe;

namespace Tres_Cafe_Finals.Tres_Cafe_Menu
{
    internal class order
    {
        public Dictionary<string, int> Items { get; }
        public int Total { get; }

        public order(Dictionary<string, int> items, int total)
        {
            Items = items;
            Total = total;
        }

        public void Display()
        {
            Console.WriteLine($"Total: {Total} PHP");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Key} - Quantity: {item.Value} - Subtotal: {item.Value * GetPrice(item.Key)} PHP");
            }
            Console.WriteLine();
        }

        private int GetPrice(string itemName)
        {
            // This method should retrieve price
            MENU menu = new MENU();
            return menu.GetPrice(itemName);
        }
    }

}

