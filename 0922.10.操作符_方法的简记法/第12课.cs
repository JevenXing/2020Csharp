using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作符
{
    class 第12课
    {
        public void 隐式类型转换()
        {
            //(T)x  类型转换
            int x = int.MaxValue;
            long y = x + 1;
            Console.WriteLine(y);
            //1.无损值类型转换  具体参考帮助文档6.1.2

            老师 老师1 = new 老师();

            //2.类的多态转换

            bool ret = (2 + 2 != 12) ? true : false;
            Console.WriteLine(ret);
            
        }
    }
    class 动物
    {
        public void 吃()
        {
            Console.WriteLine("正在吃东西...");
        }
    }
    class 人类 : 动物
    {
        public void 思考()
        {
            Console.WriteLine("我是谁???");
        }
    }
    class 老师 : 人类
    {
        public void 教学()
        {
            Console.WriteLine("我在上课...");
        }
    }
    class 学生 : 人类
    {
        public void 学生们()
        {
            Console.WriteLine( "没问题呢");
        }
    }
}
