using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // And && operator
            bool  HasLicence = false;
            bool KnowHowToDrive = true;

            if(HasLicence == true && KnowHowToDrive == true)
            {
                Console.WriteLine("You're good to go!");
            }
            else if (HasLicence == true && KnowHowToDrive == false)
            {
                Console.WriteLine("Cheateeer!!!");
            }
            else if (HasLicence == false && KnowHowToDrive == true)
            {
                Console.WriteLine("You need to get a licence");
            }
            else{
                Console.WriteLine("That is not gonna happen pal!");
            }

            // Or || operator
            bool WentForSwim = false;
            bool TookAShower = false;

            if (WentForSwim || TookAShower)
            {
                Console.WriteLine("Pal you are so wet");
            }
            else
            {
                Console.WriteLine("You're not wet");
            }

            // Not ! operator
            if (!WentForSwim || !TookAShower)
            {
                Console.WriteLine("Pal you are so wet");
            }
            else
            {
                Console.WriteLine("You're not wet");
            }

            bool username = true;
            bool email = true;
            bool password = true;

            if (username || email && password)
            {
                Console.WriteLine("User is valid.");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }

        }
    }
}
