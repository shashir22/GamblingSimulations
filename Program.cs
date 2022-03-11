using System;

namespace GamblingSimulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to gambing simulation");
            int stakeHold = 100;
            const int bet = 1;

            Gambler Gambler = new Gambler();
            Gambler.winLoss();
        }
    }

}