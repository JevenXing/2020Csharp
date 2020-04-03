using System;
using System.Collections.Generic;
using System.Text;

namespace 委托LambdaLINQ
{
    class Lambda表达式
    {
        public static void Main() {
            var func = new Func<int, int, int>((a,b) => { return a + b; });
            //如果使用显式的变量类型,还可以省略委托的实例过程  Lambda表达式的结果就是返回一个委托实例
            Func<int, int, int> func1 = (a, b) => { return b + b; };


            var z=0;
            DoSomeCalc((a, b) => { return a + b; }, 23, 43, out z);
        }

        static void DoSomeCalc<T>(Func<T,T,T> func,T x,T y,out T z)
        {
            z = func(x, y);
        }

    }
    ///
    /// 概念:调用时声明的匿名方法 就是lambda表达式
    /// 1.匿名方法
    /// 2.Inline方法 调用时声明的方法
    /// 3.
    ///
}
