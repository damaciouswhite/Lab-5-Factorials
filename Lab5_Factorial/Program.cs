using System;

namespace Lab5_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, f = 1, UserNumber;

            Console.WriteLine("Lab 5 Factorials");
        Found:
            Console.WriteLine("Please Enter an Integer 1-10");
            UserNumber = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= UserNumber; i++)
                f = f * i;

            Console.WriteLine("You Entered {0}, The Factorial is: {1}!", UserNumber, f);

            Console.WriteLine("Would You Like to Continue? (Y or N)");
            string Choice = (Console.ReadLine());


            if (Choice == "Y" || Choice == "y")
            {
                goto Found;
            }

            else
            {
                Console.WriteLine("Thank You!");
            }
        }
    }
}
