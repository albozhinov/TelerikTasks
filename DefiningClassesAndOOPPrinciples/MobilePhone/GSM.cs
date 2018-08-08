using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MobilePhone
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private static string iphone4S;
        private Battery myBattery;
        private Display myDisplay;
        private List<Call> callhistory;

        public static string  IPhone4S { get {return iphone4S; } set {iphone4S = value; } }

        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callhistory); }
            private set
            {
                this.callhistory = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model cannot be null or empty!");
                }                
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The manufacturer cannot be null or empty!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price cannot be negative value!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The owner cannot be null or empty!");
                }
                if (value.Length < 2 || 10 < value.Length)
                {
                    throw new ArgumentOutOfRangeException("The model should be more then 2 letters and shorter more then 10 letters!");
                }
                this.owner = value;
            }
        }

        public Battery MyBattery
        {
            get { return this.myBattery; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.myBattery = value;
            }
        }

        public Display MyDisplay
        {
            get { return this.myDisplay; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.myDisplay = value;
            }
        }
                
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.owner = "n/a";
            this.callhistory = new List<Call>();
            this.MyBattery = new Battery();
            this.MyDisplay = new Display();            
        }

        public GSM(string model, string manufacturer, decimal price = 0, string owner = "n/a")
           : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public void AddCall(Call newCall)
        {
             this.CallHistory.Add(newCall);
        }

        public List<Call> RemoveCall(List<Call> callhistory, Call callToRemove)
        {
            if (callhistory.Contains(callToRemove))
            {
                callhistory.Remove(callToRemove);
            }
            else
            {
                throw new ArgumentException();
            }
            return callhistory;
        }

        public decimal CalculateTotalPrice(List<Call> callHistory, decimal pricePerMinute)
        {
            decimal sumAllSeconds = callhistory.Sum(x => x.Seconds) / 60;
            decimal totalPrice = sumAllSeconds * pricePerMinute;
            return totalPrice;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"#Model: {Model}\n #Manufacturer: {Manufacturer}\n #Price: {Price}\n #Owner: {Owner}".ToString());

            foreach (var call in CallHistory)
            {
                sb.AppendLine($"  #DateAndTime: {call.Date}\n  #Dialled phone: {call.DialledPhone}\n  #Phone number: {call.PhoneNumber}\n  #Duration: {call.Seconds}");
            }
            return sb.ToString();
        }

        
    }
}
