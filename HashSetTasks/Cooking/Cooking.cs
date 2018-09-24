using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace Cooking
{
    class Cooking
    {
        // HINT: Опитай се да обърнеш всички мерни единици към cups понеже всяка е сравнима с cups!!!
        
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            try
            {                
                Dictionary<string, Product> allProducts = new Dictionary<string, Product>();
                Dictionary<string, Product> krissProduct = new Dictionary<string, Product>();

                int N = int.Parse(Console.ReadLine());

                string[] recipeProduct;
                double quantity;
                string unit;
                string productName;

                // Read and Add Recipe products
                for (int i = 0; i < N; i++)
                {
                    recipeProduct = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    quantity = double.Parse(recipeProduct[0]);
                    unit = recipeProduct[1];
                    productName = recipeProduct[2];
                    AddProduct(allProducts, productName, unit, quantity);
                }

                int M = int.Parse(Console.ReadLine());

                // Read and Add Kriss products
                for (int i = 0; i < M; i++)
                {
                    recipeProduct = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    quantity = double.Parse(recipeProduct[0]);
                    unit = recipeProduct[1];
                    if (recipeProduct.Length == 2)
                    {
                        continue;
                    }
                    productName = recipeProduct[2];

                    AddProduct(krissProduct, productName, unit, quantity);
                }

                CalcResult(allProducts, krissProduct);
                
                foreach (var item in allProducts.Values)
                {
                    Converter(item);
                    sb.AppendLine(item.ToString());
                }

                Console.Write(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Converter(Product prod)
        {
            switch (prod.Unit)
            {
                case "tablespoons":
                case "tbsps":
                    prod.Quantity *= 16;
                    break;
                case "teaspoons":
                case "tsps":
                    prod.Quantity *= 48;
                    break;
                case "milliliters":
                case "mls":
                    prod.Quantity *= 240;
                    break;
                case "liters":
                case "ls":
                    prod.Quantity *= 0.240;
                    break;
                case "fluid ounces":
                case "fl ozs":
                    prod.Quantity *= 8;
                    break;
                case "pints":
                case "pts":
                    prod.Quantity /= 2;
                    break;
                case "quarts":
                case "qts":
                    prod.Quantity /= 4;
                    break;
                case "gallons":
                case "gals":
                    prod.Quantity /= 16;
                    break;
            }
        }

        private static void AddProduct(Dictionary<string, Product> allProducts, string productName, string unit, double quantity)
        {
            // 16 tablespoons(tbsps) = 1 cups
            // 48 teaspoons(tsps) = 1 cups
            // 240 milliliters(mls) = 1 cups
            // 0.240 liter(ls) = 1 cups
            // 8 fluid ounces(fl ozs) = 1 cups
            // 1 pints(pts) = 2 cups
            // 1 quarts(qts) = 4 cups
            // 1 gallons(gals) = 16 cups            

            double cups = 0.0;
            switch (unit)
            {
                case "tablespoons":
                case "tbsps":
                    cups = quantity / 16;
                    break;
                case "teaspoons":
                case "tsps":
                    cups = quantity / 48;
                    break;
                case "milliliters":
                case "mls":
                    cups = quantity / 240;
                    break;
                case "liters":
                case "ls":
                    cups = quantity / 0.240;
                    break;
                case "fluid ounces":
                case "fl ozs":
                    cups = quantity / 8;
                    break;
                case "pints":
                case "pts":
                    cups = quantity * 2;
                    break;
                case "quarts":
                case "qts":
                    cups = quantity * 4;
                    break;
                case "gallons":
                case "gals":
                    cups = quantity * 16;
                    break;
                case "cups":
                    cups = quantity;
                    break;
            }

            var newProduct = new Product(productName, unit, cups);
            string findName = productName.ToLower();

            if (!allProducts.ContainsKey(findName))
            {
                allProducts.Add(findName ,newProduct);
            }
            else
            {
                Product findProduct = allProducts[findName];
                findProduct.Quantity += cups;
            }
        }

        private static void CalcResult(Dictionary<string, Product> allProducts, Dictionary<string, Product> krissProducts)
        {
            foreach (var product in krissProducts.Values)
            {
                var findProd = product.Name.ToLower();
                if (allProducts.ContainsKey(findProd))
                {
                    var currProd = allProducts[findProd];
                    if (currProd.Quantity <= product.Quantity)
                    {
                        allProducts.Remove(findProd);
                    }
                    else
                    {
                        var diff = Math.Abs(currProd.Quantity - product.Quantity);
                        currProd.Quantity = diff;
                    }
                }
            }
        }

        //{Quantity}:{Measurement unit}:{Product}
        public class Product
        {
            public string Name { get; set; }

            public double Quantity { get; set; }

            public string Unit { get; set; }

            public Product(string name, string unit, double quantity)
            {
                this.Name = name;
                this.Unit = unit;
                this.Quantity = quantity;
            }

            public override string ToString()
            {
                return $"{this.Quantity:F2}:{this.Unit}:{this.Name}";
            }            
        }
    }
}
