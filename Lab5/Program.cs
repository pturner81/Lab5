using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate the facotrial of a number
            // input
            int UserNumber;
            long Factorial;
            string UserChoice;
            
            //process
            //UserContinue loop
            UserChoice = "y";
            while (UserChoice.ToLower() == "y")
            {
                Console.WriteLine("Enter a number you would like the facotrial of (1-31)");
                UserNumber = int.Parse(Console.ReadLine());

                for (int i = UserNumber - 1; i > 0; i--)
                {
                    UserNumber = UserNumber * i;
                }
                Factorial = UserNumber;  // converts output to long

                //output
                Console.WriteLine($"The factorial is {Factorial}.");

                Console.WriteLine("Would you like to calculate another number? \"(y/n)\"");
                UserChoice = Console.ReadLine();
            }
        }
    }
}
