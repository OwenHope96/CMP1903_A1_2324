using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int _Number = 0;
        static Random R = new Random();

        //Method
        public int RollDie() {
            // Random function generates a number from 1 to 6
            
            _Number = R.Next(1,7);
            return _Number;
        }

        // Getter/Setter for the Number

        public int gsNumber {
            get { return _Number; }
            set { _Number = value; }
        }

    }
}
