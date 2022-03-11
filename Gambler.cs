using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingSimulations
{
    internal class Gambler
    {
        public void winLoss()
        {
            Random random = new Random();
            int value = random.Next(2);
            if (value == 1)
            {
                Console.WriteLine("Gambler own");
            }
            else
                Console.WriteLine("Gambler Loss");
        }

    }
}
    

