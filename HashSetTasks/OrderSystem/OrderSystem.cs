using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Wintellect.PowerCollections;

namespace OrderSystem
{
    class OrderSystem
    {
        //static Dictionary<string, Order> ordersByConsumer = new Dictionary<string, Order>();
        //static Dictionary<double, SortedSet<Order>> ordersByPrice = new Dictionary<double, SortedSet<Order>>();
        static HashSet<Order> allOrders = new HashSet<Order>();

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var nextLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = nextLine[0];

                if (command == "AddOrder")
                {
                    var args = nextLine.Skip(1).ToList();
                    string parameters = string.Join(" ", args);
                    var result = AddOrder(parameters);
                    sb.AppendLine(result);
                }
                else if (command == "DeleteOrders")
                {
                    var args = nextLine.Skip(1).ToList();
                    string parameters = string.Join(" ", args);
                    var result = DeleteOrders(parameters);
                    sb.Append(result);
                }
                else if (command == "FindOrdersByPriceRange")
                {
                    var minAndMaxPrice = nextLine.Skip(1).ToList();
                    var parameters = string.Join("", minAndMaxPrice);
                    var result = FindOrdersByPriceRange(parameters);
                    sb.Append(result);
                }
                else
                {
                    var consumers = nextLine.Skip(1).ToList();
                    var parameters = string.Join(" ", consumers);
                    var result = FindOrdersByConsumer(parameters);
                    sb.Append(result);
                }
            }
            Console.Write(sb.ToString());
        }
        public static string AddOrder(string orders)
        {
            // AddOrder IdeaPad Z560;1536.50;Ivan Petrov
            var parameters = orders.Split(new char[] { ';' });

            string name = parameters[0];
            double price = double.Parse(parameters[1]);
            string consumer = parameters[2];

            Order newOrder = new Order(name, price, consumer);
            allOrders.Add(newOrder);

            return "Order added";
        }

        public static string DeleteOrders(string args)
        {
            // DeleteOrders Ivan Petrov;Gosho PEshov
            var currConsumer = args;
            StringBuilder deletedConsumers = new StringBuilder();
            
            if (!allOrders.Any(x => x.consumer == currConsumer))
            {
                deletedConsumers.AppendLine("No orders found");
            }
            else
            {
                int count = allOrders.Count(x => x.consumer == currConsumer);
                allOrders.RemoveWhere(x => x.consumer == currConsumer);

                deletedConsumers.AppendLine($"{count} orders deleted");
            }

            return deletedConsumers.ToString();
        }

        public static string FindOrdersByPriceRange(string prices)
        {
            var splitPrices = prices.Split(new char[] { ';' });
            double minPrice = double.Parse(splitPrices[0]);
            double maxPrice = double.Parse(splitPrices[1]);

            var ordersByPriceRange = allOrders.Where(x => x.price >= minPrice && x.price <= maxPrice).OrderBy(k => k.name).ToList();

            var sb = new StringBuilder();

            if (ordersByPriceRange.Count == 0)
            {
                return sb.AppendLine("No orders found").ToString();
            }

            return sb.AppendLine($"{string.Join("\n", ordersByPriceRange)}").ToString();
        }

        public static string FindOrdersByConsumer(string consumers)
        {
            var splitConsumers = consumers.Split(new char[] { ';' });
            var sb = new StringBuilder();

            foreach (var item in splitConsumers)
            {
                if (!allOrders.Any(x => x.consumer == item))
                {
                    sb.AppendLine("No orders found");
                }
                else
                {
                    var findConsumers = allOrders.Where(x => x.consumer == item).OrderBy(k => k.name).ToList();
                    sb.AppendLine($"{string.Join("\n", findConsumers)}");
                }
            }
            return sb.ToString();
        }
    }

    class Order : IComparable<Order>
    {
        // Fields
        public string name;
        public double price;
        public string consumer;

        // Constructor
        public Order(string name, double price, string consumer)
        {
            this.name = name;
            this.price = price;
            this.consumer = consumer;
        }

        public int CompareTo(Order other)
        {
            var compare = this.name.CompareTo(other.name);

            if (compare == 0)
            {
                compare = this.price.CompareTo(other.price);
                if (compare == 0)
                {
                    compare = this.consumer.CompareTo(other.consumer);
                }
            }

            return compare;
        }

        public override string ToString()
        {
            return "{" + $"{this.name};{this.consumer};{this.price:F2}" + "}";
        }
    }
}
