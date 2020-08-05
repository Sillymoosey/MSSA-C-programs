using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyCoins
{
    public class Bank
    {
        static string[] coins = { "penny", "nickel", "dime", "quarter" };

        Random Randomnum;

        public Bank()
        {
            Randomnum = new Random();
        }
        public Bank( int myRandomSeed)
        {
            Randomnum = new Random(myRandomSeed);
        }
        public int CountMyCoins()
        {
            return Randomnum.Next(10,50);
        }
        public string[] GetCoins(int howMany)
        {
            string[] myCoins = new string[howMany];
            for (int i = 0; i < howMany; i++)
            {
                myCoins[i] = coins[Randomnum.Next(0, 4)];
                Console.Write(myCoins[i] + ' ');
            }
            return myCoins;
        }

        public int HowMuch( string[] allTheCoins )
        {
            int total = 0;

            for (int i = 0; i < allTheCoins.Length; i++)
            {
                if(allTheCoins[i] == "penny")
                {
                    total++;
                }
                else if(allTheCoins[i] == "nickel")
                {
                    total += 5;
                }
                else if(allTheCoins[i] == "dime")
                {
                    total += 10;
                }
                else if (allTheCoins[i] == "quarter")
                {
                    total += 25;
                }
            }
            return total;
        }
    }
}
