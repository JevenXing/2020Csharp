using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    /// <summary>
    /// 1.访问级别(汇总)
    ///     #   internal(程序集内可访问)  
    ///         public(程序集外可访问)  
    ///         private(类体内可访问) 
    ///         protected(继承链可访问,程序集外可访问)
    ///     #类成员的访问级别 以 类的访问级别 为上限;
    ///     #static 是 静态修饰符 不是访问级别修饰符
    ///  且静态类中所有的成员必须也是静态的
    ///     #private 字段通常配合 属性实现核心数据的保护
    ///     #protected 修饰 仅派生类可访问
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// 转速
        /// </summary>
        protected int _rpm;
        /// <summary>
        /// 油量
        /// </summary>
        protected int _fuel;
        /// <summary>
        /// 加油
        /// </summary>
        public void Refuel()
        {
            _fuel = 100;
        }
        /// <summary>
        /// 加速
        /// </summary>
        public void Accelerate()
        {
            _rpm += 1000;
            Burn(1);
        }
        /// <summary>
        /// 油量消耗 不需要随意调用,仅允许派生类使用 可以使用protected 修饰
        /// </summary>
        protected void Burn(int value)
        {
            _fuel=_fuel-value;
        }
        /// <summary>
        /// 刹车
        /// </summary>
        public void Draking()
        {
            _rpm = 0;
        }
        /// <summary>
        /// 速度
        /// </summary>
        public int Speed { get { return _rpm / 100; } }
    }
    /// <summary>
    /// 跑车:交通工具
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// 显示码表
        /// </summary>
        public void ShowSpeed()
        {
            Console.WriteLine(Speed);
        }
        /// <summary>
        /// 超级加速
        /// </summary>
        public void TruboAccelerate()
        {
            Burn(2);
            _rpm += 3000;
        }
        /// <summary>
        /// 显示油量
        /// </summary>
        public void ShowFuel()
        {
            Console.WriteLine(_fuel);
        }
    }
}
