using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company macroManager = new Company("MACROmanager", DateTime.Now) { };

            // Create three employees

            Employees robert = new Employees(
                "Robert",
                "Leedy",
                "President/CEO",
                DateTime.Now
            );

            Employees melia = new Employees(

                "Melia",
                "Leedy",
                "COO",
                DateTime.Now
            );

            Employees aaron = new Employees(

                "Aaron",
                "Miller",
                "CFO",
                DateTime.Now
            );

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
                Console.WriteLine($"{emp.firstName} {emp.lastName} has worked for {macroManager.Name} as {emp.Title} since {emp.startDate}");
            }
        }
    }
}
