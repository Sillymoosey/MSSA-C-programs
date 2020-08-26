using System;
using System.Dynamic;
using System.Globalization;

namespace EX9A
{
    class Program
    {
        static void GuessingComputer()
        {
            Random num = new Random();
            int answer = Convert.ToInt32(num.Next(0, 1000));
            Console.WriteLine("Now it is the computers turn!");
            int count = 0;
            int min = 0;
            int max = 1000;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (answer == mid)
                {
                    Console.WriteLine($"The Computers guess {mid} was just right! it took {count + 1} trys!");
                    break;
                }
                else if (answer < mid)
                {
                    Console.WriteLine($"The Computers guess {mid} was too high!");
                    max = mid - 1;
                    count++;
                }
                else
                {
                    Console.WriteLine($"The Computers guess {mid} was too low!");
                    min = mid + 1;
                    count++;
                }
            }
        }
        static void Guessing()
        {
            Random num = new Random();
            int answer = Convert.ToInt32(num.Next(0,1000));
            Console.WriteLine("You need to guess a number between 0 and 1000.\nInput your number");
            bool toLarge = false;
            bool right = false;
            int count = 0;
            do
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > 1000)
            {
                toLarge = true;
            }
            while (toLarge == true)
            {
                Console.WriteLine("Your number is too large. Select a number between 1 and 10");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess <= 1000)
                {
                    toLarge = false;
                }
            }
           
                if (guess == answer)
                {
                    Console.WriteLine($"Your guess {guess}, was correct it took {count + 1} trys!");
                    right = true;
                    
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Your a little low there bud...");
                    count++;
                }
                else
                {
                    Console.WriteLine("Shooting for the stars, bring it down a lil...");
                    count++;
                }
            } while (right == false);
        }
        static void Bisect()
        {
            bool toLarge = false;
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("select a number between 1 and 10");
            int value = Convert.ToInt32(Console.ReadLine());

            // check to ensure proper number is used
            if(value > 10)
            {
                toLarge = true;
            }
            while (toLarge == true)
            {
                    Console.WriteLine("Your number is too large. Select a number between 1 and 10");
                    value = Convert.ToInt32(Console.ReadLine());
                    if(value <= 10)
                    {
                        toLarge = false;
                    }
            }
            
            int i = list.Length - 1;
            int j = 0;

            Console.WriteLine(BinarySearch(list, value, j, i));
            
        }
        public static object BinarySearch(int[] input, int key, int min, int max)
        {
            while (min <= max)
            {
                 int mid = (min + max) / 2;
                 if (key == input[mid])
                 {
                    return $"The computer is looking at {mid + 1} the number is {key} congrats!";
                   
                 }
                 else if (key < input[mid])
                 {
                    Console.WriteLine($"The computer is looking at {mid + 1} the number is {key} it's too high!");
                     max = mid - 1;
                 }
                 else
                 {
                    Console.WriteLine($"The computer is looking at {mid + 1} the number is {key} it's too low!");
                    min = mid + 1;
                 }
            }
                return "null";
        }

        static void Main(string[] args)
        {
            try
            {
                Bisect();
                Guessing();
                GuessingComputer();
            }
            catch(Exception eX)
            {
                
                Console.WriteLine(eX.Message);
            }
            finally
            {
                Console.WriteLine("hit any key to end the program");
                Console.ReadLine();
            }
        }
    }
}
