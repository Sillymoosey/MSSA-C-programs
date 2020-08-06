using System;
using System.Collections.Generic;
using System.Text;
using TheFarm;

namespace TheFarm
{
    //The base class for all other animals
    public class Animal
    {
        //what type of noise?
        public virtual void Sound(string noise)
        {
            Console.WriteLine(noise);
        }
        //dumby class to call all methods
        public virtual void Detail()
        {
            //left blank intentionally
        }
        // the Eat method, will return what type of food the animal eats as a string
        public virtual void Eat(int type = 0)
        {
            string food;
            switch(type)
            {
                case 0:
                    food = " I eat grass.";
                    break;
                case 1:
                    food = " I consume everything.";
                    break;
                case 2:
                    food = " bugs, worms, seeds thats my jam!";
                    break;
                case 3:
                    food = " I love me some hay!";
                    break;
                default:
                    food = " nothing";
                    break;
            
            }
            Console.Write(food);

        }
        // What each animal provides
        public virtual void Produce(int type = 0)
        {
            string produce;
            switch(type)
            {
                case 0:
                    produce = " I give you beef.";
                    break;
                case 1:
                    produce = " I provide pork!";
                    break;
                case 2:
                    produce = " I have but eggs and chicken.";
                    break;
                case 3:
                    produce = " I can take you to far away lands!";
                    break;
                default:
                    produce = " Nothing but a money pit!";
                    break; 
            }
            Console.Write(produce);
        }
        public virtual void Speed(int type = 0)
        {
            switch(type)
            {
                case 0:
                    Console.Write("I can move up to 25 mph.");
                    break;
                case 1:
                    Console.Write("I can move up to 11 mph.");
                    break;
                case 2:
                    Console.Write("I can move up to 9 mph.");
                    break;
                case 3:
                    Console.Write("I can move up to 55 mph.");
                    break;
            }
        }
    }
}
