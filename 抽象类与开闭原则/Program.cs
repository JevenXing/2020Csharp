using System;
using System.Runtime.CompilerServices;

namespace 抽象类与开闭原则
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var car=new Car();
            car.Run();
            // var vh = new Vehicle();  抽象类无法实例化
        }
    }

    // abstract class IVehicle//纯虚类(纯抽象类) 就是接口
    // {
    //     abstract public void Stop();
    //     abstract public void Fill();
    //     abstract public void Run();//共同而变需求就重写 
    // }
    interface IVehicle//纯虚类(纯抽象类) 就是接口
    {
      void Stop();
      void Fill();
      void Run();//共同而变需求就重写 
    }
    
    abstract class Vehicle:IVehicle //有了纯虚函数 类就成了抽象类
    {
        public  void Stop()//共同不变的就直接继承
        {
            Console.WriteLine("Stopped");
        }

        public  void Fill()
        {
            Console.WriteLine("Pay and Fill...");
        }

        abstract public void Run();//部分为实现 继续给子类实现
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is Running");
        }
    }
    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is Running");
        }
    }

    class RaceCar:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is Running");
        }
    }
}
/*
 * 封装思路
 *     1.当发现有两个类有相同的功能成员时,就需要设置一个父类去继承
 *     2.继承链中,同签名方法需要根据不同子类做不同行为时,就需要创建重写基成员virtual
 *         利用重写实现调用此方法的最新版本(当一个封装除了Debug还有可能修改时)
 * 开闭原则（Open Close Principle）
 *     对扩展开放，对修改关闭。在程序需要进行拓展的时候，不能去修改原有的代码，实现一个热插拔的效果。
 *     简言之，是为了使程序的扩展性好，易于维护和升级。想要达到这样的效果，我们需要使用接口和抽象类，
 */
/*
 * 抽象类
 *     #没有被实现的类;一般普通的类--具体类
 *     #关键字 abstract
 *     #抽象类不能实例化
 *     #纯的虚函数(virtual)就是无实现意义的,所以抛弃方法体,就等着来重写,进化为abstract.
 *     #抽象类在派生时,子类必须实现这个纯虚成员;
 *     #当类的所有成员都抽象成员后 这个类就是接口.
 *     #
 */
/*
 * 开闭原则
 *     #封装稳定 固定 确定的成员;不确定 可能改变的成员 声明为抽象成员,留个子类来实现
 * 
 */