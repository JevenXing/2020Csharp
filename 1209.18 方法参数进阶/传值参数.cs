using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法参数进阶
{
    class 值参数
    {   //传值会创建副本;
        public void 展示()
        {
            StudentA stu1 = new StudentA();
            int y = 99;
            stu1.Add(y);
            Console.WriteLine("传入方法后,y的值:{0}",y);
            //传值的 值类型参数 是将外部变量值或显示值创建一个给方法使用的副本;
            //传入的值类型参数 属于方法体的局部变量,所以不会影响外部变量;

            StudentB stuC = new StudentB() { Name = "Xin" };
            SM(stuC);

            StudentB sb = new StudentB() { Name = "xing1" };
            Lan(sb);
            Console.WriteLine("原来的引用变量:{0},{1}", sb.Name, sb.GetHashCode());
        }
        static void Lan(StudentB sb)
        {
            sb.Name = sb.Name + "1";
            Console.WriteLine("传入引用参数后:{0},{1}", sb.Name,sb.GetHashCode());
        }
        //引用对象参数是方法的副作用,side-effect 少用
       //可得知,引用变量传入后修改的是同一个对象,方法运行完毕后可在基础上继续使用;
        static void SM(StudentB stu2)//引用类型参数
        {
            stu2 = new StudentB() { Name = "Xing" };
            stu2.Name = "zhang";
            Console.WriteLine(stu2.Name);
        }
        //引用类型参数 传入的是stu2引用的"xin"地址实例,方法内将stu2引用了"Xing"的地址实例;
        //对于后者引用的对象做修改,不会影响前者对象;
    }
    class StudentA
    {
      
        public void Add(int value)//值类型参数
        {
            int x = value+1;
            Console.WriteLine("方法运行:{0}",x);
        }
    }
    class StudentB
    {
        public string Name { get; set; }
    }
}
