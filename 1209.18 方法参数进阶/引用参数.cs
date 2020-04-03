using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法参数进阶
{
    class 引用参数
    {
        //使用ref 修饰声明的形参  不创建副本
        //变量在作为ref参数调用时,必须事先赋值;
        public void 展示()
        {
            int Y = 99;
            IWantSideEffect(ref Y);//值类型引用参数
            //显式申明IW方法处理的是Y所指向的同一个地址;

            StudentC outterStu = new StudentC() { Name = "Xin" };
            Console.WriteLine("引用类型引用参数的方法处理前:{0},{1}",outterStu.Name,outterStu.GetHashCode());
            Console.WriteLine("___________");
            IWantSideEffect2(ref outterStu);
            Console.WriteLine("引用类型引用参数的方法处理后:{0},{1}", outterStu.Name, outterStu.GetHashCode());
        }
        //+++++++++++++++++ 机理理解*** 非常重要+++++++++++++++++++
        // 引用类型的引用参数与值类型的引用参数
        //前者 参数就是引用地址本身   后者 参数就是变量地址本身
        // 传值参数
        static void IWantSideEffect(ref int x)
        {
            x += 1;
        } 
        static void IWantSideEffect2(ref StudentC stuc)
        {
            stuc = new StudentC() { Name = "Xing" };//如果方法内不创建新的对象,在使用效果上 与传值参数效果相同,只是机理不同
            Console.WriteLine("引用类型引用参数的方法:{0},{1}", stuc.Name,stuc.GetHashCode());

        }

    }
    class StudentC
    {
        public string Name { get; set; }
    }
}
