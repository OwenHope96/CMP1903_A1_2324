using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            //Testing class instatiated

            Testing Test = new Testing();

            //Game class made

            Game Game1 = new Game();

            //Variables for keeping a total and starting the loop

            int Total = 0;
            string Choice = "y";

            //loops until the user inputs anything but y.

            while (Choice == "y")
            {
                Console.WriteLine("Would you like to play? y/n");
                Choice = Console.ReadLine();
                if (Choice == "y")
                {
                    // New integer for the sum of the 3 Die on the current roll.
                    int NewAdd = Game1.Play();
                    Total += NewAdd;
                    Console.WriteLine("The 3 dice rolled a total of " + NewAdd+ ". Adding this to previous rolls = " + Total);
                    Console.ReadLine();

                }
            }
        }
    }
}
