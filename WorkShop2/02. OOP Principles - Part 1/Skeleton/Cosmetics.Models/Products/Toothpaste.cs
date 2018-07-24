using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics.Products
{
    public class Toothpaste : IToothpaste, IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        private string ingredients;       

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
                GenderType parsedGender;
                bool isValid = Enum.TryParse(value.ToString(), out parsedGender);
                if (!isValid)
                {
                    throw new ArgumentException();
                }
                this.gender = parsedGender;
            }
        }

        public string Ingredients
        {
            get => this.ingredients;
            set
            {
                List<string> ingredient = value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                StringBuilder sb = new StringBuilder();

                sb.Append(string.Join(", ", ingredient));

                this.ingredients = sb.ToString();
            }
        }

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Ingredients = ingredients;
        }

        public string Print()
        {
            throw new System.NotImplementedException();
        }
    }
}