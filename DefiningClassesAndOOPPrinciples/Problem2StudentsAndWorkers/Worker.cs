using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2StudentsAndWorkers
{
    public class Worker : Human
    {
        // Fields
        private decimal weekSalary;
        private int workHoursPerDay;

        // Constructors
        public Worker(string firstName, string lastName, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
        }

        // Properties
        public decimal WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            set
            {
                if (value < 1 || 24 < value)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.workHoursPerDay = value;
            }
        }

        // Methods
        public decimal MoneyPerHour()
        {
            int workHoursPerWeek = this.WorkHoursPerDay * 5;
            decimal hourSalary = this.weekSalary / workHoursPerWeek;

            return Math.Round(hourSalary);
        }
    }
}
