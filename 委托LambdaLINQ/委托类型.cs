using System;
using System.Collections.Generic;
using System.Text;

namespace 委托LambdaLINQ
{
    class 委托类型
    {
        public static void main()
        {
            MyDele myDele = new MyDele(M1);

           static void M1()
            {
                Console.WriteLine("xingwenjei");
            }
        }

    }
    delegate void MyDele();

    /// <summary>
    ///  0.委托是引用类型
    ///  1. 委托类型与类类型的区别
    ///     1.1.功能区别
    ///         普通类是映射事物的
    ///         委托只是为了封装一个方法
    ///     1.2.声明区别
    ///         delegate 修饰
    ///         长得像字段
    /// </summary>
}
