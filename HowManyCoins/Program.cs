using System;

namespace HowManyCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howmanycoins.Program.Main()\n");

            Bank MyBank = new Bank( 73 );

            int nrCoins = MyBank.CountMyCoins();
            Console.WriteLine($"Wow! I have {nrCoins} coins in my bank!\n");
            
            string[] allMyCoins = MyBank.GetCoins(nrCoins);
            Console.WriteLine($"\nI have {MyBank.HowMuch(allMyCoins)} cents!");
        }
    }
}
