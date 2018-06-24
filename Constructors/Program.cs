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

            Person personThree = new Person();

            Console.WriteLine(personOne.FirstName);
            Console.WriteLine(personTwo.FirstName);
            Console.WriteLine(personThree.FirstName);
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

        public Person()
        {
            firstName = "Unknown";
        }
    }
}
