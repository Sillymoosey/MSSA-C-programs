using System;

namespace TheFarm
{
    class Farm
    {

        static void Main(string[] args)
        {
            Array();
        }
        //calling all hte animals on the farm so we can look at their traits.
        static void Array()
        {
            Object[] myFarm = new Object[4] { new Cow(), new Pig(), new Chicken(), new Horse() };
            for (int i = 0; i < myFarm.Length; i++)
            {
                Console.Write($"\nWell I am a {myFarm[i]}.");
                Animal farmAnimal;
                farmAnimal = myFarm[i] as Animal;
                if (farmAnimal != null)
                {
                    farmAnimal.Detail();
                }
            }
        }

    }
}
