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

            Game Game1 = new Game();
            int Total = 0;
            string Choice = "n";
            while (Choice == "n")
            {
                Console.WriteLine("Would you like to play? y/n");
                Choice = Console.ReadLine();
                if (Choice == "y")
                {
                    Total += Game1.Play();
                    Console.WriteLine("The 3 dice rolled a total of " + Total);
                    Console.ReadLine();

                }
            }
        }
    }
}
