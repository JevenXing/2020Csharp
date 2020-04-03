using System;
using System.Collections.Generic;
using System.Text;

namespace 泛型partial类枚举结构体
{
    /// <summary>
    /// 1.值类型 可装/拆箱
    ///     值类型的特点:
    ///         1.值类型变量相关联的栈内存里存储的就是这个值类型的实例
    ///         2.栈内存在被另个变量引用时 会被拷贝备份 内存中会生成一个相同的数据 这就是堆栈的明显区别
    /// 2.可实现接口,不能派生自类/接口体
    /// 3.不能有显式无参构造器
    /// </summary>
    class 结构体struct
    {
        public static void main()
        {
            Student student = new Student() { ID = 12312, Name = "xing" };
            //装箱
            object obj = student;
            //拆箱
            var student2 = (Student)obj;
        }
       
    }
    interface ISpeak
    {
        void Speak();
    }
    struct Student:ISpeak
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Speak()
        {
            throw new NotImplementedException();
        }
        //不可以显式无参  但可以显式有参
        public Student(int a ,string name)
        {
            ID = a;
            Name = name;
        }
    }
}
