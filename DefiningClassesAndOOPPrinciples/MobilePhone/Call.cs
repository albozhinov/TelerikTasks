using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    //date, time, dialled phone number and duration (in seconds)
    class Call
    {
        private DateTime date;
        private string dialledPhone;
        private int seconds;
        private string phonenumber;

        public string PhoneNumber
        {
            get {return this.phonenumber; }
            set {this.phonenumber = value; }
        }

        public DateTime Date
        {
            get {return this.date; }
            set { this.date = value; }
        }
        public string DialledPhone
        {
            get {return this.dialledPhone; }
            set {this.dialledPhone = value; }
        }
        public int Seconds
        {
            get {return this.seconds; }
            set {this.seconds = value; }
        }
        public Call(string dialledPhone)
        {
            this.date = DateTime.Now;
            this.dialledPhone = dialledPhone;
        }
        public Call(string dialledPhone, int seconds)
            :this(dialledPhone)
        {
            this.seconds = seconds;
        }
    }
}
