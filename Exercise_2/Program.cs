using System;
using System.Collections.Generic;

namespace Exercise_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> payroll = new List<Employee>();

            payroll.Add(new PartTimeEmployee("", 0, 0));
            payroll.Add(new FullTimeEmployee("", 0));
            payroll.Add(new PartTimeEmployee("", 0, 0));
            payroll.Add(new FullTimeEmployee("", 0));
            
        }
    }
}
