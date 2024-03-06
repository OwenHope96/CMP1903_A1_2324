using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

        public Game() {
            
        }
        public int Play() {

            // 3 Die class instantiated 
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            // All 3 Die class are rolled

            Console.WriteLine("Dice roll 1 = " + dice1.RollDie());
            Console.WriteLine("Dice roll 2 = " + dice2.RollDie());
            Console.WriteLine("Dice roll 3 = " + dice3.RollDie());

            // Added the values of the Die

            int sum = (dice1.gsNumber + dice2.gsNumber + dice3.gsNumber);

            // Returns the total of the 3 Die

            return sum;
        }
    }
}
