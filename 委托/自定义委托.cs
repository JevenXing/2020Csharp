using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._1._28委托
{

    /// <summary>
    /// 委托是什么:
    /// 1.委托是类,数据类型
    /// 
    /// 委托的使用场景:
    /// 
    /// 1.模板方法,"借用"制定外部方法来产生结果
    ///     常位于代码中部
    ///     委托有返回值
    ///     相当于"填空题"
    /// 2.回调(callback)方法,调用制定的外部方法
    ///     常位于代码尾部
    ///     委托无返回值
    ///     相当于"流水线"
    ///     
    /// 注意事项:
    /// 
    /// 
    /// </summary>
    static class 自定义委托
    {
        public static void Invoke()
        {
            //实例化
            Calculator2 cal = new Calculator2();
            //使用自定义委托
            Calc calc1 = new Calc(cal.Add);
            Calc calc2 = new Calc(cal.Sub);
            Calc calc3 = new Calc(cal.Mul);
            Calc calc4 = new Calc(cal.Div);

            int x = 100, y = 200;
            //调用并打印
            Console.WriteLine("自定义委托打印结果:");
            Console.WriteLine(calc1(x, y));
            Console.WriteLine(calc2(x, y));
            Console.WriteLine(calc3(x, y));
            Console.WriteLine(calc4(x, y));

            Console.ReadKey();
        }
    }
    
    /// <summary>
    /// 声明自定义委托:
    /// 1.结构: 访问修饰符 + delegate[[委派;授权]] + 约束返回值类型 + 委托名 + (约束参数n);
    /// 2.与类同级 全局
    /// 3.类型必须兼容
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    /// 
    public delegate double Calc(double x, double y);//calc 计算器
    class Calculator2
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }

    }
}
