using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
           




        }
    }

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees

        public List<Employee> employeeList = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void addEmployee (Employee newEmp) {
            employeeList.Add(newEmp);
        }     
        // Create a method that allows external code to remove an employee
         public void removeEmployee (Employee newEmp) {
            employeeList.Remove(newEmp);
        }     

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
    }

    public class Employee {

    }
}
