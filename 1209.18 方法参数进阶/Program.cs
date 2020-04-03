using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法参数进阶
{
    class Program
    {
        /*
             概念:方法有四种形参：
            •	值形参，声明时不带任何修饰符。
            •	引用形参，用 ref[日五啊福] 修饰符声明。
            •	输出形参，用 out 修饰符声明。
            •	形参数组，用 params[参数] 修饰符声明。

            使用:
            1.传值:参数的默认传递方式
            2.输出:用于除返回值职位还需要输出的场景
            3.引用:用于需要修改时间参数值的场景
            4.数组:用于简化方法的调用
            5.具名:提高可读性
            6.可选:参数拥有默认值
            7.扩展方法:为目标数据类型"追加"方法
        */
        //prop 快速创建属性段
        static void Main(string[] args)
        {
            //值参数 cz = new 值参数();
            //cz.展示();
            //Console.WriteLine();//写入线

            //引用参数 yy = new 引用参数();
            //yy.展示();
            //Console.WriteLine();

            //输出形参 sc = new 输出形参();
            //sc.展现();

            //数组参数.zanXian();
            //数组参数.StrSplit();
            This参数.ExtensionMethod();
            Console.ReadKey();Console.ReadKey();
        }

    }
}
