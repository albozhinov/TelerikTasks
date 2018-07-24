using System;
using System.Collections.Generic;

namespace OOPPrinciples_Part1
{
    //Classes have unique text identifier. Each class has a set of teachers
    class Classes : School
    {
        private string textidentifier;
        private List<Teacher> myTeachers;

        public string TextIdentifier
        {
            get
            {
                return this.textidentifier;
            }
            set
            {
                if (value.Length < 1 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (textidentifier == null)
                {
                    throw new ArgumentNullException();
                }
                this.textidentifier = value;
            }
        }
        public Classes()
        {
            this.myTeachers = new List<Teacher>();
        }

        public Classes(string textIdentifier) : this()
        {
            this.TextIdentifier = textIdentifier;
        }
    }
}



