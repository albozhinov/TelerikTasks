namespace MobilePhone
{
    using System;

    class Display
    {
        private string size;
        private string colors;

        public string Size
        {
            get { return this.size; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.size = value;
            }
        }

        public string Colors
        {
            get { return this.colors; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.colors = value;
            }
        }

        public Display()
        {
            this.Size = "n/a";
            this.Colors = "n/a";
        }

        public Display(string size) :this()
        {
            this.Size = size;
        }

        public Display(string size, string colors) :this(size)
        {
            this.Colors = colors;
        }

    }
}
