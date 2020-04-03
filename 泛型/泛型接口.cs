using System;
using System.Collections.Generic;
using System.Text;

namespace 泛型partial类枚举结构体
{
    /// <summary>
    /// 使用泛型 就是为了后期确定数据类型 
    /// </summary>
    class 泛型接口
    {
        public static void Invoke()
        {
            Student<int> student = new Student<int>() { ID=007,Name="零零七"};
            Console.WriteLine(student.Name);
            Console.WriteLine(student.ID);
            //在继承时特化泛型接口的类型 创建实例时就不用再给变量类型指定泛型参数了
            Student2 student2=new Student2(){ID = "二十四"};
            Console.WriteLine(student2.ID);
            

        } 
    }

    interface IUnique<T>
    {
       T ID { get; set; }
    }
    class Student<T> : IUnique<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
    }

    class Student2:IUnique<string>
    {
        public string ID { get; set; }
    }
}
