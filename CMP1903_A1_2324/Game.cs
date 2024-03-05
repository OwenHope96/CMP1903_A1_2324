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

        public Game() 
        {
            
        }
        public int Play()
        {
            // 3 Die class instantiated 
            Die Dice1 = new Die();
            Die Dice2 = new Die();
            Die Dice3 = new Die();

            // All 3 Die class are rolled

            Dice1.RollDie();
            Dice2.RollDie();
            Dice3.RollDie();

            // Added the values of the Die

            int sum = (Dice1.GSNumber + Dice2.GSNumber + Dice3.GSNumber);

            // Returns the total of the 3 Die

            return sum;
        }
    }
}
