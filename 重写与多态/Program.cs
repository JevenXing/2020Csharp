using System;
using System.Security.AccessControl;

namespace 重写与多态
{
    /// <summary>
    /// 1.重写的概念:
    ///     #基于继承的更新机制
    ///     #重写关键字: virtual 修饰基类 override 修饰派生类
    ///         继承链中的重写只需要一个顶级基类修饰virtual 之后的派生类全部修饰override
    ///     #基类变量 引用重写修饰的派生类实例,调用的是派生类对象; (更新替代的关系) 
    ///      当没有重写关系的两个同名成员 被实例引用后,调用对应变量的类型(不重写的同名成员,属于隐藏关系,在调用时随变量变化,但这种情况
    ///      在现实中不建议使用 可以忽略)
    /// 1.1.多态的概念:
    ///     #基于重写的父类变量引用子类实例
    ///         多态是强类型语言的表现之一,弱类型语言 舍弃变量类型 或 var代替
    /// 2.哪些类成员可以被重写?
    ///     #函数成员可被继承重写(可以书写多句的成员)
    ///         _methods方法 _Properties属性 _event事件 _indexers索引器 .....
    ///     #可见
    ///         访问级别
    ///     #签名一致
    ///         数据类型\成名名\参数
    /// 
    ///     
    /// </summary>
    internal class Program {
        public static void Main(string[] args)
        {
            Vehicle c=new Car();
            c.Run();
            Console.WriteLine(c.Speed);
        }
    }
    class Vehicle
    {
        private int _speed;
        public virtual int Speed//速度
        {
            get { return _speed;}//获取 
            set { _speed = value; }//value 指代给speed赋值的值;
        }
        public virtual void Run()
        {
            _speed = 100;
            Console.WriteLine("I'm running");
        }
    }

    class Car:Vehicle
    {
        private int _rpm;
        public override int Speed
        {
            get { return _rpm/100;}
            set { Speed = value * 100; }
        }
        public override void Run()
        {
            _rpm = 5000;
            Console.WriteLine("Car is Running");
        }
    }

    class RaseCar:Car
    {
        public override void Run()
        {
            Console.WriteLine("RaseCar is Running");
        }
    }
}