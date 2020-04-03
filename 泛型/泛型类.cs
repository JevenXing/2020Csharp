using System;
using System.Collections.Generic;
using System.Text;

namespace 泛型partial类枚举结构体
{
    class 泛型类
    {
        public static void Invoke()
        {
            //在使用时 替换类型参数 达到特指
            Box<Apple> box = new Box<Apple>() { Cargo = new Apple() { Color = "Red" } };
            Box<Book> box2 = new Box<Book>() { Cargo = new Book() { Name = "wwww" } };
            Console.WriteLine(box.Cargo);
            Console.WriteLine(box2.Cargo);
        }
    }
    class Apple
    {
        public string Color { get; set; }

    }
    class Book
    {
        public String Name { get; set; }
    }
    /// <summary>
    /// 为类添加类型参数 << 类型参数名>>2
    /// 使用时替换就是泛型的作用
    /// </summary>
    /// <typeparam name="TCargo"></typeparam>
    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }//货物  __货物  什么货物
    }
}
