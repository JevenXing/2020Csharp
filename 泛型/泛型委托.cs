using System;

namespace 泛型partial类枚举结构体
{
    public class 泛型委托
    {
        public static void invoke()
        {
            // Action 委托 封装一个方法 且这个方法没有返回值
            Action<string> a1 = Say;
            a1("邢文杰");
            //Func 委托 封装一个方法 且这个方法有返回值
            Func<int, int, int> fonc1 = Add;
            Console.WriteLine(fonc1(100,200));

        }

        static void Say(string str)
        {
            Console.WriteLine($"hello,{str}");
        }

        static void Mul(int x)
        {
            Console.WriteLine(x*100);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
    
}