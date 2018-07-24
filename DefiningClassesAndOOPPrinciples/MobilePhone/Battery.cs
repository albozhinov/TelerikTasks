namespace MobilePhone
{
    using System;

    class Battery
    {        
        private string model;
        private string hoursIdle;
        private string hoursTalk;
        private BatteryType type;

        public string Model
        {
            get {return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public string HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.hoursIdle = value;
            }
        }

        public string HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Battery()
        {
            this.Model = "n/a";            
            this.HoursIdle = "n/a";
            this.HoursTalk = "n/a";
        }

        public Battery(string model, BatteryType type, string hoursidle, string hoursetalk) : this()
        {
            this.Model = model;
            this.Type = type;
            this.HoursTalk = hoursetalk;
            this.HoursIdle = hoursidle;
        }
    }
}
