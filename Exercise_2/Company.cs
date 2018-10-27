using System;
using System.Collections.Generic;

namespace Exercise_2
{
    public class Company
    {
        private List<Employee> employees;

        public Company()
        {
            this.employees = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            // must return the total salary of all employees
            int salaryTotal = 0;
            for(int index = 0; index < employees.Count; index++)
            {
                // if(employees.Equals(employees[index].GetMonthlySalary()))
                // {
                //     // returns monthly salary from each object and adds it to running total
                //     // ... += salaryTotal;
                // }

                // employees[index].GetMonthlySalary() += salaryTotal;
            }
            // returns running total
            return salaryTotal;
        }
        // I'm having an issue with extracting the GetMonthlySalary() method from the objects in the employee list.  
        // I first tried comparing objects, but I thought that might be unnecessary because I am only looking for
        // the return method, which shouldn't care about the index beyond iterating through the list.
        // the second method I tried complains about a missing variable and I'm not sure how to resolve that.

        public void EmployNewEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
    }
}