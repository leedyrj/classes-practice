using System;
using System.Collections.Generic;

namespace classes
{


    public class Employees
    {
        public string firstName { get; }

        public string lastName { get; }

        public string Title { get; }

        public DateTime startDate { get; }

        public Employees(string first, string last, string jobTitle, DateTime start)
        {
            firstName = first;
            lastName = last;
            Title = jobTitle;
            startDate = start;
        }
    }
}