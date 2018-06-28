using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee newEmployee = new Employee();
            newEmployee.employeeName = "James";
            newEmployee.employeeJob = "Programmer";
            newEmployee.Salary = 5000;
            Console.WriteLine($"Employee name is {newEmployee.employeeName} and the job is {newEmployee.employeeJob} and salary is {newEmployee.Salary} ");
            newEmployee.SayHi();
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hi, from the method in struct.");
        }
    }
}
