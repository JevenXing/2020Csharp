using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 操作符
{
    class Program
    {
        static void Main(string[] args)
        {
            第10课 _10 = new 第10课() { name= "成员访问       x.y 方法调用        f(x) 元素访问      a[x]  自增 自减    x++     x--   类型信息查询   typeof   类型默认值     default" };
            //_10.index();
            第11课 _11 = new 第11课() ;
            _11.获取基本类型占用字节数sizeof();

        }
    }
    class 第10课
    {
        public string name { get; set; }
        public  void index()
        {
            int x;
            x = 2 + 3 + 4;
            Console.WriteLine(x);
            System.IO.File.Create("C:/hello.txt");
            Form form1 = new Form();
            form1.Text = "操作符的详解";
            //成员访问       x.y
            //1.访问子级名称空间
            //2.访问名称空间的类
            //3.访问类中的静态方法  static
            //4. 访问对象的实例成员/方法
            //5. 访问枚举成员

            //方法调用        f(x)
            //1.方法的调用必须加(),无论是否有参数
            int[] MyArray = new int[] { 1, 2, 3 };

            //元素访问      a[x]
            //1.访问数组元素
            //2.访问字典元素
            //3.元素索引不一定都是整数
            x = 100;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //自增 自减    x++     x--  
            //1.x++  同 x=x+1
            //2.后置++,-- 优先级特殊 先赋值 后++,--

            Type type1 = typeof(int);
            Console.WriteLine(type1.Namespace);
            Console.WriteLine(type1.FullName);
            //类型信息查询   typeof
            //
            x = default(int);
            Console.WriteLine("int的默认值是:" + x);
            level level = default(level);
            Console.WriteLine(level);
            //类型默认值     default
            //1.值类型按设定  
            //2.引用类型 为null 
            //3.枚举类型  对应声明时的顺序 如果声明初始化没有0元素 会出错
            //#4.结合经验,default可以拿来快速获取枚举的首元素
        }
    }
    enum level
    {
        low,
        mid,
        high
    }
    
}
