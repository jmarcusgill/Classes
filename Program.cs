using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // contructor method for creating new company:
            Company newCompany = new Company ("ComicGetIt", DateTime.Now);

            // create instances for new employees
            Employee newEmp1 = new Employee ("Marcus", "CEO/ Full-Stack", DateTime.Now);
            Employee newEmp2 = new Employee ("Krissy", "Front-End", DateTime.Now);
            Employee newEmp3 = new Employee ("Mitchell", "Back-End", DateTime.Now);
           
            // referencing public class Company, calling add methods I created
            newCompany.addEmployee(newEmp1);
            newCompany.addEmployee(newEmp2);
            newCompany.addEmployee(newEmp3);

            // referencing public class Company, calling list method I created
            newCompany.ListEmployees();


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
        public Company (string nameInput, DateTime dateInput) 
        {
            Name = nameInput;
            CreatedOn = dateInput;
        }
        public void ListEmployees() 
        {
            foreach (Employee each in this.employeeList) {
                Console.WriteLine($"{each.EmployeeName}: {each.JobTitle}");
            }

        }
    }

    // Create a class that gets and sets employee data
    public class Employee 
    {
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public DateTime startDate { get; set; }

        public Employee (string name, string title, DateTime date)
        {
            EmployeeName = name;
            JobTitle = title;
            startDate = date;
        }


    }
}
