using System;
using System.Collections.Generic;
using System.Text;

namespace 委托LambdaLINQ
{

    class 泛型委托
    {
        public static void main()
        {
            //自己声明的泛型委托为什么不用加参数类型约束呢?
            //Func是框架声明的,不知道你有声明参数,所以用func时要定义自己的参数类型约束
            //使用var 可以省略func变量类型
            MyDele<int> myDele = new MyDele<int>(add);

            var func = new Func<double, double, double>(add);
            func(1,2);

            var action = new Action<long, int>(add);
            action(123123,2);
        }
        static void add(long a,int b)
        {
            Console.WriteLine("111");
        }
        static int add(int a,int b)
        {
            return a + b;
        }
        static double add(double a, double b)
        {
            return a + b;
        }
    }
    public delegate T MyDele<T>(T a, T b);

    ///
    /// 通常情况下使用框架给我们申请好的泛型委托就行了
    ///  action 和 func
    ///
}
