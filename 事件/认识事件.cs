using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace 事件
{
    class 认识事件
    {
        /// <summary>
        /// 事件的五个要素:
        ///     拥有者和响应者是两个对象
        ///     拥有者的事件通过 += 与处理器链接
        ///     
        /// 使用技巧:
        ///     处理器通常用IDE自动生成
        /// </summary>
        public static void Invoke()
        {
            //事件拥有者 timer
            Timer timer = new Timer();

            timer.Interval = 300;//时间间隔
            //事件响应者 boy
            Boy boy = new Boy();
            Girl girl = new Girl();

            //事件 Elapsed    事件处理器 Action
            //事件订阅 += 操作符
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;

            timer.Start();

            Console.ReadLine();
        }
    }
    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump");
        }
    }
    class Girl
    {
        public int X { get; set; }
        internal void Action(object sender, ElapsedEventArgs e)
        {
            
            while (true)
            {
                X++;
                Console.WriteLine(X);
            }
        }
    }
}
 