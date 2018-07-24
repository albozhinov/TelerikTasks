using Cosmetics.Common;
using Cosmetics.Contracts;
using System;

namespace Cosmetics.Products
{
        //    Shampoo
        // Implements IShampoo  
        
    public class Shampoo : IShampoo, IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        private int milliliters;
        private UsageType usage;

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 3 || 10 < value.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get => this.brand;
            set
            {
                if (value.Length < 2 || 10 < value.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.brand = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get => this.gender;
            set
            {
                GenderType genderParsed;
                bool isValid = Enum.TryParse(value.ToString(), out genderParsed);

                if (!isValid)
                {
                    throw new ArgumentException();
                }
                this.gender = genderParsed;
            }
        }

        public int Milliliters
        {
            get => this.milliliters;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get => this.usage;
            set
            {
                UsageType parsedUsageType;
                bool isValid = Enum.TryParse(value.ToString(), out parsedUsageType);
                if (!isValid)
                {
                    throw new ArgumentException();
                }
                this.usage = parsedUsageType;
            }
        }        

        public Shampoo(string name, string brand, decimal price, GenderType gender, int milliliters, UsageType usage)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public string Print()
        {
            
        }
    }
}
