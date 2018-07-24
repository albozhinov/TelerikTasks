using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples_Part1
{
    //In the school there are classes of students.
    class School
    {
        private List<Classes> schoolClasses;

        public List<Classes> SchoolClasses
        {
            get {return new List<Classes>(this.schoolClasses); }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.schoolClasses = value;
            }
        }

        public School()
        {
            this.schoolClasses = new List<Classes>();
        }
        public School(List<Classes> myClasses)
            :this()
        {
            this.schoolClasses = myClasses;
        }
    }
}
