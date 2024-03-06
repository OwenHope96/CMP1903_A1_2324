using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program {
        static void Main(string[] args) {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            //Testing class instatiated

            Testing test = new Testing();

            //Game class made

            Game game1 = new Game();

            //Variables for keeping a total and starting the loop

            int total = 0;
            string choice = "y";

            //loops until the user inputs anything but y.

            while (choice == "y") {
                Console.WriteLine("Would you like to play? y/n");
                choice = Console.ReadLine();
                if (choice == "y") {
                    // New integer for the sum of the 3 Die on the current roll.
                    int newAdd = game1.Play();
                    total += newAdd;
                    Console.WriteLine("The 3 dice rolled a total of " + newAdd+ ". Adding this to previous rolls = " + total);
                    Console.ReadLine();

                }
            }
        }
    }
}
