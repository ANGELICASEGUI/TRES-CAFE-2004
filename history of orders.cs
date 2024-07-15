using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tres_Cafe_Finals.Tres_Cafe_Menu
{
    internal class historyoforders
    {
        private List<order> orders;

        public historyoforders()
        {
            orders = new List<order>();
        }

        public void AddOrder(Dictionary<string, int> orderItems, int total)
        {
            order newOrder = new order(orderItems, total);
            orders.Add(newOrder);
        }

        public void DisplayOrderHistory()
        {
            Console.WriteLine("\nOrder History for the Day:");
            foreach (var order in orders)
            {
                order.Display();
            }
        }
    }
}

