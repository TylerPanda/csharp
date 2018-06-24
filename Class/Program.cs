using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person personOne = new Person();
            personOne.FirstName = "Ahmad";
            personOne.LastName = "Mohey";
            personOne.Country = "Egypt";

            Person personTwo = new Person();
            personTwo.FirstName = "Tim";
            personTwo.LastName = "David";
            personTwo.Country = "Australia";

            Console.WriteLine(personOne.FirstName);
            Console.WriteLine(personOne.Country);
            Console.WriteLine(personOne.LastName);
        }
    }

    class Person
    {
        string firstName;
        string lastName;
        DateTime birthday;
        string country;

        public string FirstName
        {
            get{ return firstName; }
            set{ firstName = value; }
        }

        public string LastName
        {
            get{ return lastName; }
            set{ lastName = value; }
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }
    }
}
