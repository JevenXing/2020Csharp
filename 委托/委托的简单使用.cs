using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._1._28委托
{
   static class 委托的简单使用
    {
        public static void Invoke()
        {
            //实例化
            Calculator calculator = new Calculator();

            //使用Action 无返回值的方法
            Action cal = new Action(calculator.Report);
            cal.Invoke();

            //使用func 有返回值的方法
            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2= new Func<int, int, int>(calculator.Sub);
            int x = 100, y = 200;

            Console.WriteLine(func1(x,y));
            Console.WriteLine(func2(x,y));
        }
    }
    class Calculator//计算器
    {
        
        public void Report()
        {
            Console.WriteLine("I have 3 methods");//我有三个方法
            
        }
        public int Add(int a, int b)//加法
        {
            int result = a + b;
            return result;

        }
        public int Sub(int a, int b)//减法
        {
            int result = a - b;
            return result;

        }
    }
}
