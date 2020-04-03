using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 操作符
{
    class 第11课
    {
        public string name;
        public void new创建实例操作符()
        {
            // 创建实例操作符  new
            Form form1 = new Form() { Text="cc"};
            form1.Text = "ss";
            //1.在内存中创建类的实例,立刻调用实例构造器
            //如上文,new 将实例地址通过赋值给引用变量 form1进行控制
            //2.同时可调用初始化器,设置属性的值
            string str = "222";
            int[] myintarray = { 1, 2, 3 };
            int[] myintarray2 = new int[] { 1,2,3};
            //3.同样是类 为什么string 不用new就能创建呢? 为了将常用的语法化简,更方便 语法糖衣
            //4.一些数组声明也可以省略 new操作符  直接初始化
            var person = new { name = "张三", age = 33 };
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.GetType().Name);
            //!! 5.为匿名类型创建实例对象 new 配合 var 关键字 person为隐式引用变量 
            
            //6.当new 用作修饰符时,可以在子类中隐藏父类给予子类的方法或字段


        }
        public void 内存溢出检查操作符cheked()
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            try
            {
                uint y = checked(x + 1);
                Console.WriteLine(y);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("算术内存溢出异常");
            }
            //1.制造y的算术溢出,使用checked/unchecked 检查 并捕捉异常
            unchecked
            {
                try
                {
                    uint y = checked(x + 1);
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("算术内存溢出异常");
                }
            }
            //2.当用作关键字使用时,形成语句块 对语句范围作用
        }
        public void 匿名方法链接器delegate()
        {
            Console.WriteLine("已经过时了  懒得学了 哈哈哈 替代的新技术 lamdba 表达式");
        }
        public void 获取基本类型占用字节数sizeof()
        {
            int x = sizeof(long);
            Console.WriteLine(x);
        }
        public void 取址和指针()
        {
            //&x     *x   太难  之后补一下

        }
        public void 取正取反and按位取反()
        {
            // ~    +  -
            int x = int.MinValue;
            int y = -x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            //1.由于数据类型的正负阈值不同 -+ 可能导致内存溢出
            //2.所以编程中常用的数值取反方法是 ~ 按位取反加1
        }
        public void 取非()
        {
            //!
            bool b1 = false;
            bool b2 = !b1;
            Console.WriteLine(b2);
            //很简单不细说了
        }
    }
}
