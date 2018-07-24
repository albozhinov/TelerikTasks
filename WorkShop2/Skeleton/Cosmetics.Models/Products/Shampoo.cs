using Cosmetics.Common;
using Cosmetics.Contracts;
using System;

namespace Cosmetics.Products
{
        //    Shampoo
        // Implements IShampoo  
        
    public class Shampoo : Product, IShampoo
    {
        
        private uint milliliters;
        private UsageType usage;         
        

        public uint Milliliters
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
                this.usage = value;
            }
        }        

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage) 
            :base(name, brand, price, gender)
        {            
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override string Print()
        {
            return $"#{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n #Milliliters: {this.Milliliters}\r\n #Usage: {this.Usage}";
        }
    }
}
