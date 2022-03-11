using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingSimulations
{
    internal class Gambler
    {
        const int BET = 1;
        const int STAKE = 100;
        //int win = 1;


        public void gamblerstake()
        {
            Console.WriteLine("stake" + STAKE + "bet" + BET);

            Random random = new Random();
            int stakeholder = random.Next(0, 2);

            if (stakeholder == 1)
                Console.WriteLine("wins");
            else
                Console.WriteLine("loss");
        }
        public void Win_Loss()
        {
            int winningAmount = (STAKE + (STAKE / 2));
            int lossingAmount = (STAKE / 2);
            int stakeholder = STAKE;
            int win = 1;
            while (stakeholder <= winningAmount && stakeholder > lossingAmount)
            {
                Random random = new Random();
                int check = random.Next(0, 2);
                if (check == win)
                {
                    stakeholder = stakeholder + BET;
                }
                else
                {
                    stakeholder = stakeholder - BET;
                }

            }
            Console.WriteLine(stakeholder);



        }



    }
}