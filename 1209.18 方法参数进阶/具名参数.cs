using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法参数进阶
{
    class 具名参数
    {
        /// <summary>
        /// 1.具名参数可增加可读性
        /// 2.调用时可以调换顺序;
        /// </summary>
        public static void ZanShi()
        {
            Student.Add(加数2:4, 加数:3);
            StudentE.Add();
            
        }
    }
    class Student
    {
        public static void Add(int 加数,int 加数2)
        {
            int c = 加数 + 加数2;
            Console.WriteLine(c);
        }
    }
    /// <summary>
    /// 方法参数声明时初始化,变为可选参数,调用时可不填写默认使用;
    /// </summary>
    class StudentE
    {
        public static void Add(int 加数=7, int 加数2=9)
        {
            int c = 加数 + 加数2;
            Console.WriteLine(c);
        }
    }
}
