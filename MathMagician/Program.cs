using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");
            // "How" you provide the user useful info is up to you.
            // Think, "How will the user pick a command?"
            // Is it better to modify the original question? Make it more useful?
            Console.WriteLine("Choose either:");
            Console.WriteLine("1: Natural Numbers | 2: Even Numbers | 3: Odd Numbers | (and so on once project is complete)");

            string command = Console.ReadLine();
            // Once I have the command, how do I check it?
            // Is it a valid command?


            // When should you actually create an instance of your number class? Now or later?
            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();
            // When do I check if the "How Many" response is too big?
            // Remember, the istructions say no more than 30
            // If the number is >30, how do I responds AND exit the program?

            int userInputHowMany = Int32.Parse(how_many);
            if (userInputHowMany <= 30 && userInputHowMany > 0)
            {
                Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            }
            else
            {
                Console.WriteLine("Sorry, please select a number between 1 and 30");
            }


            

            // Okay, let's print some stuff:

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
