using System;

namespace 方法参数进阶
{
    //需求:想让一个数据类型快速添加一个方法
    //方法必须是公有的,静态的,即public static修饰的
    //由this修饰第一个形参
    //类目必须按规范:被添加方法的类名+extension
    //
    class This参数
    {
       public static void ExtensionMethod()
        {
            double x = 3.1415926;
          
            Console.WriteLine(x.Round(3));
        }
       
    }
    static class DoubleExtension
    {
        public static double Round(this double input, int dijiwei)
        {
            double result = Math.Round(input, dijiwei);
            return result;
        }
    }
}
