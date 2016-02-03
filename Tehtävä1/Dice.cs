using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Dice
    {

        private Random rand = new Random();
        public int Throw()
        {
             
            return rand.Next(1, 6);      
        }
    }
}
