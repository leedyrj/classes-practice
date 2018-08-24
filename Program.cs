using System;
using System.Collections.Generic;

namespace classes
{
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
