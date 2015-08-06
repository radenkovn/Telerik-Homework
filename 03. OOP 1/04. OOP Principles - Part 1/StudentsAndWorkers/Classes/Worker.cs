namespace StudentsAndWorkers.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public Worker(string firstName, string secondName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get { return this.weekSalary; } set { this.weekSalary = value; } }
        public decimal WorkHoursPerDay { get { return this.workHoursPerDay; } set { this.workHoursPerDay = value; } }
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / 5 / workHoursPerDay;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} - {2:0.00}", this.FirstName, this.SecondName, this.MoneyPerHour());
        }
    }
}
