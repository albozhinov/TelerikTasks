using Cosmetics.Common;
using System;
 

namespace Cosmetics.Products
{
    public class Product
    {
        private decimal price;
        private string name;
        private string brand;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Price = price;
            this.Name = name;
            this.Brand = brand;
            this.Gender = gender;
        }

        public decimal Price
        {
            get {return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.name = value;
                }                
            }
        }

        public string Brand
        {
            get { return this.brand; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.brand = value;
                }
            }
        }

        public GenderType Gender { get { return this.gender; } set { this.gender = value;} }

        public string Print()
        {            
            return $" #{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n ===";
        }
    }
}
