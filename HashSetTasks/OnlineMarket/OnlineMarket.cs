using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineMarket
{
    class Program
    {
        static Dictionary<string, Product> productByName = new Dictionary<string, Product>();
        static Dictionary<string, SortedSet<Product>> productByType = new Dictionary<string, SortedSet<Product>>();
        static SortedSet<Product> productByPrice = new SortedSet<Product>();

        static void Main()
        {
            var nextLine = Console.ReadLine();
            var sb = new StringBuilder();

            while (nextLine != "end")
            {
                var splitInput = nextLine
                                .Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries);
                var command = splitInput[0];

                if (command == "add")
                {
                    var args = splitInput.Skip(1).ToArray();
                    var txt = AddCommand(args);
                    sb.AppendLine(txt);
                }
                else
                {
                    var args = splitInput.Skip(1).ToArray();
                    var filterBy = args[1];

                    if (filterBy == "type")
                    {
                        var type = args[2];
                        var txt = FilterByTypeCommand(type);
                        sb.AppendLine(txt);
                    }
                    else
                    {
                        if (args.Length == 6)
                        {
                            double minPrice = double.Parse(args[3]);
                            double maxPrice = double.Parse(args[5]);
                            var txt = FilterByPriceCommand(minPrice, maxPrice);
                            sb.AppendLine(txt);
                        }
                        else if (args.Length < 6 && args.Contains("to"))
                        {
                            double maxPrice = double.Parse(args[3]);
                            var txt = FilterByPriceCommand(0, maxPrice);
                            sb.AppendLine(txt);
                        }
                        else if (args.Length < 6 && args.Contains("from"))
                        {
                            double minPrice = double.Parse(args[3]);
                            var txt = FilterByPriceCommand(minPrice, double.MaxValue);
                            sb.AppendLine(txt);
                        }
                    }
                }
                nextLine = Console.ReadLine();
            }
            Console.Write(sb.ToString());
        }
        private static string AddCommand(string[] args)
        {
            //add PRODUCT_NAME PRODUCT_PRICE PRODUCT_TYPE
            var name = args[0];
            var type = args[2];
            var price = double.Parse(args[1]);
            var product = new Product(name, type, price);

            if (productByName.ContainsKey(name))
            {
                return $"Error: Product {name} already exists";
            }

            if (!productByType.ContainsKey(type))
            {
                productByType.Add(type, new SortedSet<Product>());
                productByType[type].Add(product);
            }
            else
            {
                productByType[type].Add(product);
            }
            productByPrice.Add(product);
            productByName.Add(name, product);
            return $"Ok: Product {name} added successfully";
        }

        private static string FilterByTypeCommand(string type)
        {

            if (!productByType.ContainsKey(type))
            {
                return $"Error: Type {type} does not exists";
            }

            return $"Ok: {string.Join(", ", productByType[type].Take(10))}";
        }

        private static string FilterByPriceCommand(double minPrice, double maxPrice)
        {
            return $"Ok: {string.Join(", ", productByPrice.Where(x => x.price > minPrice && x.price < maxPrice).Take(10))}";           
        }
    }
    class Product : IComparable<Product>
    {
        // Fields
        private string name;
        private string type;
        public double price;

        // Constructor
        public Product(string name, string type, double price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        // Implement CompareTo Method
        public int CompareTo(Product obj)
        {
            var comperision = this.price.CompareTo(obj.price);

            if (comperision == 0)
            {
                comperision = this.name.CompareTo(obj.name);

                if (comperision == 0)
                {
                    return 0;
                }
                return comperision;
            }
            return comperision;
        }

        // Overriding ToString() Method
        public override string ToString()
        {
            return $"{this.name}({this.price})";
        }
    }
}
