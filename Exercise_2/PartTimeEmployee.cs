using System;

namespace Exercise_2
{
    public class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;

        public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }

        public override double GetMonthlySalary()
        {
            return hourlyWage * hoursPerMonth;
        }

        public override string ToString()
        {
            return "Hourly Wage: " + hourlyWage +
                    "\nHours Per Month: " + hoursPerMonth +
                    "Total Monthly Salary: " + GetMonthlySalary();
        }
    }
}