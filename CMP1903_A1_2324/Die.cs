using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int Number = 0;
        static Random R = new Random();

        //Method
        public int RollDie()
        {
            
            Number = R.Next(1,7);
            return 0;
        }

        public int GSNumber
        {
            get { return Number; }
            set { Number = value; }
        }

    }
}
