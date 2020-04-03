using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    /// <summary>
    /// 4.类修饰符-访问级别
    ///     默认访问级别:interanal 限制项目内可访问
    ///     public   实例化可访问
    ///     public static 静态可访问
    ///     
    /// </summary>
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public double Add2(double x, double y)
        {
            return x + y;
        }
    }
}
