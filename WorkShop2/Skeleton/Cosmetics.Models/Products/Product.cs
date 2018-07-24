using System;
using Cosmetics.Contracts;
using Cosmetics.Common;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;        

        public string Name
        {
            get => this.name;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
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
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
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

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;            
        }

        public virtual string Print()
        {
            return $"#{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}";
            
        }
    }
}
