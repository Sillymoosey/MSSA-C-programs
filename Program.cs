using System;
using System.Runtime.CompilerServices;

namespace Pie
{
    class Program
    {
        //creates Random double
        static (double, double) Rand(Random r)
        {

            double rDouble =  r.NextDouble();
            double r1Double = r.NextDouble();
            return (rDouble, r1Double);
        }
        //does the math for the hypotenuse
        static double Hyp(double x, double y)
        {
            double c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return c;
        }
        //the while loop counter
        static void Main(string[] args)
        {
            Random r = new Random();
            double pie = 0;
            int iterations = 0;
            int inCircleCount = 0;
            while (iterations < 10000000)
            {
                iterations++;
                //assign random floating points to x and y
                (double x, double y) = Rand(r);
                double inCircle = Hyp(x, y);
                //the in circle numbers counters and equation
                if (inCircle <= 1)
                {
                    inCircleCount++;
                }
                pie = inCircleCount / (double)iterations * 4;

            }
            Console.WriteLine($"Monty Carlo method of pie is {pie}, and regular pie is {Math.PI}");
           //40, 400, 4000.... why is this happening!
           //if we switch it up to pie = incricle... I get 4 everytime? where is the math going wrong?
           // so if we change to input to just inCircle <= 1 now i get new number all of wich are multipuls of 4... is it supposed to equal PI?
           // figured it out difference means subtraction of course! now I get 3.14!
           //no it was actually that i forgot to make iterations into a double DUH!

        }
    }
}
