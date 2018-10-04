using System;
using System.Text;
using System.Collections.Generic;

using System.Linq;

namespace OnlineMarket
{
    public class OnlineMarket
    {
        private static StringBuilder sb = new StringBuilder();
        private static SortedSet<Product> productsByPrice = new SortedSet<Product>();
        private static Dictionary<string, SortedSet<Product>> productsByType = new Dictionary<string, SortedSet<Product>>();
        private static HashSet<string> productsNames = new HashSet<string>();

        static void Main(string[] args)
        {
            string nextLine;
            string[] command;

            while ((nextLine = Console.ReadLine()) != "end")
            {
                command = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "add":
                        AddCommand(command[1], command[3], command[2]);
                        break;
                    case "filter":
                        FilterCommand(command);
                        break;
                }
            }

            Console.Write(sb.ToString());
        }

        private static void FilterCommand(string[] parameters)
        {
            if (parameters.Length == 4)
            {
                string type = parameters[3];
                if (productsByType.ContainsKey(type))
                {
                    sb.AppendFormat("Ok: " + string.Join(", ", productsByType[type].Take(10)));
                    sb.AppendLine();
                    return;
                }
                sb.AppendLine($"Error: Type {type} does not exists");
                return;
            }
            else if (parameters.Length == 7)
            {
                double minPrice = double.Parse(parameters[parameters.Length - 3]);
                double maxPrice = double.Parse(parameters[parameters.Length - 1]);

                sb.AppendFormat("Ok: " + string.Join(", ", productsByPrice.Where(x => x.Price > minPrice && x.Price < maxPrice).Take(10)));
                sb.AppendLine();
                return;
            }
            else
            {
                double price = double.Parse(parameters[parameters.Length - 1]);
                if (parameters[parameters.Length - 2] == "from")
                {
                    sb.AppendFormat($"Ok: " + string.Join(", ", productsByPrice.Where(x => x.Price > price).Take(10)));
                    sb.AppendLine();
                    return;
                }
                sb.AppendFormat($"Ok: " + string.Join(", ", productsByPrice.Where(x => x.Price < price).Take(10)));
                sb.AppendLine();
            }
        }

        private static void AddCommand(string name, string type, string price)
        {
            if (productsNames.Contains(name))
            {
                sb.AppendLine($"Error: Product {name} already exists");
                return;
            }

            var parsePrice = double.Parse(price);
            var newProduct = new Product(name, type, parsePrice);

            if (!productsByType.ContainsKey(type))
            {
                productsByType.Add(type, new SortedSet<Product>());
                productsByType[type].Add(newProduct);
            }
            else
            {
                productsByType[type].Add(newProduct);
            }

            productsByPrice.Add(newProduct);
            productsNames.Add(name);

            sb.AppendLine($"Ok: Product {name} added successfully");
        }
    }
    public class Product : IComparable<Product>
    {
        // Constructor
        public Product(string name, string type, double price)
        {
            this.Name = name;
            this.Type = type;
            this.Price = price;
        }

        // Properties
        public string Name { get; set; }

        public string Type { get; set; }

        public double Price { get; set; }

        // CompareTo Method
        public int CompareTo(Product other)
        {
            var result = this.Price.CompareTo(other.Price);

            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);

                if (result == 0)
                {
                    result = this.Type.CompareTo(other.Type);
                }
            }
            return result;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Name}({this.Price})";
        }
    }
}
