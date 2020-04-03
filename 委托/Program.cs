using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2020._1._28委托2;

namespace _2020._1._28委托
{
    /// <summary>
    /// 委托使用的注意事项:
    ///     1.这是一种方法级的耦合,现实工作中要慎重使用.
    ///     2.使用不当会使可读性下降,debug难度增加
    ///     3.把委托回到,异步调用和多线程纠缠在一起,会使代码极其难维护;
    ///     4.委托使用不当有可能造成内存泄漏和程序性能下降
    ///     被委托的方法不会被GC回收.
    ///     
    ///     在现实使用中尽可能少使用委托,用接口代替
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            委托的简单使用.Invoke();
            自定义委托.Invoke();
            模板方法使用场景.Invoke();
            _2020._1._28委托2.回调方法使用场景.Invoke();
            委托的高级使用.Invoke();
        }
    }
    
}
