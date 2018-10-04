using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace OrderSystem
{
    public class OrederSystem
    {
        private static StringBuilder sb = new StringBuilder();
        private static HashSet<Order> allConsumers = new HashSet<Order>();
        

        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string inputline = Console.ReadLine();
                var command = inputline.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "AddOrder":                        
                        AddOrderCommand(inputline);
                        break;
                    case "DeleteOrders":
                        DeleteOrdersCommand(inputline);
                        break;
                    case "FindOrdersByPriceRange":
                        FindOrdersCommand(command[1]);
                        break;
                    case "FindOrdersByConsumer":
                        FindOrderByConsumerCommand(inputline);
                        break;
                }
            }
            Console.Write(sb.ToString());
        }

        private static void FindOrderByConsumerCommand(string inputLine)
        {
            var currParams = inputLine.Split().Skip(1).ToArray();
            var consumer = string.Join(" ", currParams);

            if (!allConsumers.Any(x => x.Consumer == consumer))
            {
                sb.AppendLine("No orders found");
                return;
            }
            
            sb.AppendLine($"{string.Join("\r\n", allConsumers.Where(x => x.Consumer == consumer).OrderBy(x => x.Price))}");
        }

        private static void FindOrdersCommand(string parameters)
        {
            var numbers = parameters.Split(';').Select(double.Parse).ToList();

            var orderInGivenRange = allConsumers.Where(x => x.Price >= numbers[0] && x.Price <= numbers[1]).OrderBy(x => x.Name).ToList();

            if (orderInGivenRange.Count == 0)
            {
                sb.AppendLine("No orders found");
                return;
            }
            
            sb.AppendLine($"{string.Join("\r\n", orderInGivenRange)}");
        }

        private static void DeleteOrdersCommand(string inputLine)
        {
            var currParams = inputLine.Split(' ').Skip(1).ToArray();
            var consumer = string.Join(" ", currParams);

            if (!allConsumers.Any(x => x.Consumer == consumer))
            {
                sb.AppendLine("No orders found");
                return;
            }

            int orderCount = allConsumers.Count(x => x.Consumer == consumer);
            allConsumers.RemoveWhere(x => x.Consumer == consumer);           

            sb.AppendLine($"{orderCount} orders deleted");
        }

        private static void AddOrderCommand(string parameters)
        {
            var firstElement = parameters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
            string newParams = string.Join(" ", firstElement);
            var currParams = newParams.Split(';');
                                   
            var consumer = currParams[currParams.Length - 1];
            var price = double.Parse(currParams[currParams.Length - 2]);
            string name = currParams[0];

            var newOrder = new Order(name, price, consumer);                        
                        
            allConsumers.Add(newOrder);

            sb.AppendLine("Order added");
        }
    }
    public class Order
    {
        // Constructor
        public Order(string name, double price, string consumer)
        {
            this.Name = name;
            this.Price = price;
            this.Consumer = consumer;
        }
               
        // Properties
        public string Name { get; set; }

        public double Price { get; set; }

        public string Consumer { get; set; }

        //// Implement ComparTo method
        //public int CompareTo(Order other)
        //{
        //    var result = this.Name.CompareTo(other.Name);

        //    if (result == 0)
        //    {
        //        result = this.Consumer.CompareTo(other.Consumer);

        //        if (result == 0)
        //        {
        //            result = this.Price.CompareTo(other.Price);
        //        }
        //    }
        //    return result;
        //}

        // Override ToString Method
        public override string ToString()
        {
            return "{"+ $"{this.Name};" + $"{this.Consumer};"+ $"{this.Price:F2}" + "}";
        }
    }
}
