using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2020._1._28委托
{
    class 委托的高级使用
    {
        /// <summary>
        /// 多播委托(multicast)
        ///     一个委托可以封装多个方法
        /// 
        /// 隐式异步委托
        ///     使用异步的BeginInvo方法 可以自动分配多线程执行
        /// 
        /// </summary>
        public static void Invoke()
        {
            //有三个学生
            Student student1 = new Student() { ID=1,PenColor=ConsoleColor.Yellow};
            Student student2 = new Student() { ID=2,PenColor=ConsoleColor.Green};
            Student student3= new Student() { ID=3,PenColor=ConsoleColor.Red};

            //委托各自的作业
            Action action1 = new Action(student1.DoHomework);
            Action action2 = new Action(student2.DoHomework);
            Action action3 = new Action(student3.DoHomework);

            action1();
            action2();
            action3();
           
            //action1 = action1 + action2 + action3;
            //action1();

            Console.WriteLine("以上都是同步调用.");

            action1.BeginInvoke(null,null);
            action2.BeginInvoke(null,null);
            action3.BeginInvoke(null,null);

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("主线程作业{0}",i);
                Thread.Sleep(200);
            }

            Console.ReadKey();
        }
    }
    class Student
    {
        public int ID { get; set; }
        /// <summary>
        /// 笔的颜色由控制台字体颜色模拟
        /// </summary>
        public ConsoleColor PenColor { get; set; }
        /// <summary>
        /// 做作业
        /// </summary>
        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student{0} doing honework{1} hour(s).",this.ID,i);
                Thread.Sleep(300);

            }
            
        }
    }
}
