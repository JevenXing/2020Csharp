using System;
using System.Runtime.InteropServices;

namespace 接口与单元测试
{
    public static class 类之间的依赖 {
        public static void Invoke() {
            var eng=new Engine();
            var car=new Car(eng);
            car.Run(99);
            Console.WriteLine(car.Speed);

            Console.Read();
        }
    }

    class Engine {
        /// <summary>
        ///  private set -->只读
        /// </summary>
        public int RPM { get; private set; }
        /// <summary>
        /// 引擎运行
        /// </summary>
        /// <param name="value"></param>
        public void Work(int value) {
            this.RPM = value * 1000;
        }
    }

    class Car {
        private Engine _engine;
        public Car(Engine engine) {
            this._engine = engine;
        }
        public int Speed { get; private set; }
        /// <summary>
        /// 加速汽车
        /// </summary>
        /// <param name="value">油门加多少</param>
        public void Run(int value) {
            _engine.Work(value);//发动机运行
            Speed = _engine.RPM / 100;//将转速转换成速度
        }
    }
}
/*
 * Car 依赖于 engine类 这种紧耦合关系 有一方出问题 就会整体崩溃;
 */