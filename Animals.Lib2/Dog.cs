using BabyCarriage.SDK;
using System;

namespace Animals.Lib2
{
    public class Dog : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("汪汪汪...");
            }
        }
    }
}
