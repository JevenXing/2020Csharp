using BabyCarriage.SDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Lib2
{
    class Cow : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("嚒嚒嚒...");
            }
        }
    }
}
