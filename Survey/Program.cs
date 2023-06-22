using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

// Do a Commit and push 1 change on the Main branch

namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (name == "")
            {
                name = WriteTryAgain();
            }

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            if (age == "")
            {
                WriteTryAgain();
                age = Console.ReadLine();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            if (month == "")
            {
                WriteTryAgain();
                month = Console.ReadLine();
            }

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (month == "april")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (month == "june")
            {
                Console.WriteLine("You are a Gemini");
            }
        }

        // On Branch1 create at least 1 commit and push those changes 

        static string WriteTryAgain()
        {
            Console.WriteLine("You didn't type anything, please try again");
            return Console.ReadLine();
        }
    }
}
