using System;
using System.Collections;

namespace 接口与单元测试
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num1 = new[] {1, 2, 3, 4, 5};
            ArrayList num2 = new ArrayList {1, 2, 3, 4, 5};
            // Console.WriteLine(Sum(num1));
            // Console.WriteLine(Sum(num2));
            // 类之间的依赖.Invoke();
            电风扇.Invoke();
            //引入接口.Invoke();
        }
        
        public static int Sum(IEnumerable  nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }

            return sum;
        }

        public static double Avg(IEnumerable nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }

            return sum / count;
        }
    }
}
/*
 *  接口的概念:
 *     #接口是由抽象类进化而来,继承同一个接口的类
 */