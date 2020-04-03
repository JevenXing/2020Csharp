using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类_数据相关成员
{
    class field字段
    {
        public void 展现()
        {
            Student stu1 = new Student();
        stu1.Age = 10;
            stu1.Score = 40;
            Student stu2 = new Student();
        stu2.Age = 23;
            stu2.Score = 44;
            //public 定义的实例字段  表示实例后的对象的状态
            //stu1与stu2的Age字段是独立存在的不同数据
            Console.WriteLine("有几个同学:{0}",Student.Amount);
            //public static 静态字段  表示类型的状态;静态方法同
        }
}
    class Student
    {
        public  int Age;//实例字段
        public int Score;
        public static int Average;
        public static int AverageScore;
        public static int Amount;//静态字段
        //实例字段的初始化时机 是实例化时;***会被执行多次
        //静态字段的初始化时机 是运行环境加载到这个类型时;***只会执行一次
        public readonly int ID;//只读实例字段 不可赋值 
        public Student() //构造函数(也称 实例构造器)会在每一次实例化时运行一次;
        {
            Student.Amount++;
            Age = 0;
            //构造函数中初始化与声明并初始化是等价的;
        }
        static Student()//静态构造器 只执行一次
        {
            Average = 90;
        }
        public static void ReportAmount()//静态方法
        {
            Console.WriteLine(Student.Amount);
        }
    }
}
