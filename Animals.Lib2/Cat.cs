using System;
using BabyCarriage.SDK;
namespace Animals
{
    public class Cat:IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("喵喵喵...");
            }
        }
    }
}
