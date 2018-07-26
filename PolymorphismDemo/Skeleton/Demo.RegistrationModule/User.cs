using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.RegistrationModule
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The username cannot be null or empty", "username");
                }

                if (value.Any(c => char.IsSymbol(c) || char.IsPunctuation(c)))
                {
                    throw new ArgumentException("The username cannot contain any special characters", "username");
                }

                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The password cannot be null or empty", "password");
                }

                if (!value.Any(c => char.IsDigit(c)))
                {
                    throw new ArgumentException("The password should contain at least one digit", "password");
                }

                this.password = value;
            }
        }
    }
}
