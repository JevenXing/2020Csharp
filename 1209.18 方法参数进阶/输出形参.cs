using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法参数进阶
{
    class 输出形参
    {   //输出形参不会创建新副本 类似引用
        public void 展现()
        {
            double x = 0;
            bool a = DoubleParser.TryParse("123", out x);//输出值类型形参
            if (a)
            {
                Console.WriteLine(x+1);
            }
            ////////////////////////////////
            StudentD stu = null; 

            bool stuBoll= StudentFactory.Create("xing", 100, out stu);//输出有引用类型参数
            if (stuBoll)
            {
                Console.WriteLine("生产了学生名字是:{0},年龄是:{1}", stu.Name, stu.Age);

            }
            else
            {
                Console.WriteLine("参数有误");
            }
        }
    }
    class DoubleParser
    {
        public static bool TryParse(string input,out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }
    class StudentD
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
    /// <summary>
    /// 生产Student类
    /// </summary>
    class StudentFactory//学生工厂
    {
        public static bool Create/*创造*/(string stuName,int stuAge,out StudentD result)
        {
            result = null;

            if (string.IsNullOrEmpty(stuName))//如果学生的年龄是空的
            {
                return false;
            }
            if (stuAge<20||stuAge>80)
            {
                return false;
            }
            result = new StudentD() { Name = stuName, Age = stuAge };
            return true;
        }
    }
}
