using System;
using System.Collections.Generic;

namespace classes
{

    public class Employees
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string Title { get; set; }

        public DateTime startDate { get; set; }
    }
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employees> employeeList = new List<Employees>();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created


            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime companyCreated)
        {
            Name = companyName;
            CreatedOn = companyCreated;
        }

        public void addEmployee(Employees employee)
        {
            employeeList.Add(employee);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company macroManager = new Company(companyName: "MACROmanager", companyCreated: DateTime.Now) { };

            // Create three employees

            Employees robert = new Employees()
            {
                firstName = "Robert",
                lastName = "Leedy",
                Title = "President/CEO",
                startDate = DateTime.Now
            };

            Employees melia = new Employees()
            {
                firstName = "Melia",
                lastName = "Leedy",
                Title = "COO",
                startDate = DateTime.Now
            };

            Employees aaron = new Employees()
            {
                firstName = "Aaron",
                lastName = "Miller",
                Title = "CFO",
                startDate = DateTime.Now
            };

            // Assign the employees to the company



            macroManager.addEmployee(robert);
            macroManager.addEmployee(melia);
            macroManager.addEmployee(aaron);



            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employees emp in macroManager.employeeList)
            {
                Console.WriteLine($"{emp.firstName} {emp.lastName} works for {macroManager.Name} as {emp.Title} since {emp.startDate}");
            }
        }
    }
}
