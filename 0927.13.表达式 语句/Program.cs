using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 表达式_语句
{
    class Program
    {
        static void Main(string[] args)//main方法内只能使用静态
        {

            Try语句 C = new Try语句();
            Console.WriteLine("值为:{0}", C.Add("0","0"));
        }
       
        // 整体组织结构的通俗概念//
        //操作数和操作符组成表达式
        //表达式组成语句
        //语句组成语句块
        //语句块组成方法体
        //方法体和字段组成类
        //类体组成名称空间
    }
    class Try语句
    {
        public int Add(string s1,string s2)
        {
            int a = 0, b = 0;
            bool hasError = false;

            try
            {
                 a = int.Parse(s1);
                 b = int.Parse(s2);

            }
            catch(ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                hasError = true;
                
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                hasError = true;

            }
            catch (OverflowException oe)
            {
                throw oe;//抛出异常到调用者处理
                hasError = true;
            }
            finally
            {
                //释放资源
                //执行日志  如,辅助确认是否是正常输出的值
                if (hasError)
                {
                    Console.WriteLine("发生了一次异常");
                }
                else
                {
                    Console.WriteLine("正常运行");
                }
            }

            int result = checked(a+b);//捕捉溢出
         
            return result;
        }
    }
    class 几个选择语句的特殊语法
    {
        public void if语句()
        {
            //if语句 默认将最近一个语句作为嵌入式语句  当我们需要一个分支执行多个语句时 就需要{}块来将多个语句作为一个整体 
            
            if (5 < 3) 
                Console.WriteLine("hello");
            if (5 < 3) 
            {
                Console.WriteLine("hello");
                Console.WriteLine("world");
            }
             if(1<2)
                Console.WriteLine("对的");
             else
                Console.WriteLine("不对的");
             //else 语句 同if语句
            
            //?: 条件运算符 必须要接收分支结果  且分支表达式 或 方法 的返回值不可为空, **引用类型不知道行不行
            //string zhengshu = 3 < 5 ? Console.WriteLine("1") : Console.WriteLine("3");
            string zhengshu = 3 < 5 ? 输出() : 输出();
        }
        public static string 输出()
        {
            return "666";
        }
    }
    class 表达式1//表达式 概念
    {
        public void 表达式有哪些类型()
        {
            /*一个表达式可归类为下列类别之一：
•	值。每个值都有关联的类型。
•	变量。每个变量都有关联的类型，称为该变量的已声明类型。
•	命名空间。归为此类的表达式只能出现在 member-access（第 ‎7.6.4 节）的左侧。在任何其他上下文中，归类为命名空间的表达式将导致编译时错误。
•	类型。归为此类的表达式只能出现在 member-access（第 ‎7.6.4 节）的左侧，或作为 as 运算符（第 ‎7.10.11 节）、is 运算符（第 REF‎7.10.10节）或 typeof 运算符（第 ‎7.6.11 节）的操作数。在任何其他上下文中，归类为类型的表达式将导致编译时错误。
•	方法组。它是一组重载方法，是成员查找（第 ‎7.4 节）的结果。方法组可能具有关联的实例表达式和关联的类型实参列表。当调用实例方法时，实例表达式的计算结果成为由 this（第 ‎7.6.7 节）表示的实例。在 invocation-expression（第 ‎7.6.5 节）和 delegate-creation-expression（第 ‎7.6.10.5 节）中允许使用方法组，且这两种表达式的左边均为运算符，可以隐式转换为兼容的委托类型（第 ‎6.6 节）。在任何其他上下文中，归类为方法组的表达式将导致编译时错误。
•	null 文本。归类为 null 文本的表达式可以隐式转换为引用类型或可以为 null 的类型。
•	匿名函数。归类为匿名函数的表达式可以隐式转换为兼容的委托类型或表达式目录树类型。
•	属性访问。每个属性访问都有关联的类型，即该属性的类型。此外，属性访问可以有关联的实例表达式。当调用实例属性访问的访问器（get 或 set 块）时，实例表达式的计算结果将成为由 this（第 ‎7.6.7 节）表示的实例。
•	事件访问。每个事件访问都有关联的类型，即该事件的类型。此外，事件访问还可以有关联的实例表达式。事件访问可作为 += 和 -= 运算符（第 ‎7.17.3 节）的左操作数出现。在任何其他上下文中，归类为事件访问的表达式将导致编译时错误。
•	索引器访问。每个索引器访问都有关联的类型，即该索引器的元素类型。此外，索引器访问还可以有关联的实例表达式和关联的参数列表。当调用索引器访问的访问器（get 或 set 块）时，实例表达式的计算结果将成为由 this（第 ‎7.6.7 节）表示的实例，而实参列表的计算结果将成为调用的形参列表。
•	Nothing。这出现在当表达式是调用一个具有 void 返回类型的方法时。*/
        }
        private static void 窗口加载完毕(object sender, EventArgs e)
        {

            Form form = (Form)sender;
            form.Text = "加载完毕!";
        }
        public void OutPutConcept()
        {
            long x = 100;
            Console.WriteLine((x <</**/3).GetType().Name);
            var x2 = default(Int16);
            Console.WriteLine(x.GetType().Name);
            Console.WriteLine("Int16的默认值是" + x2);
            //
            int? y = null;
            var yy = y ?? 100;
            Console.WriteLine(yy.GetType().Name);
            //条件操作符 
            var x3 = true == false ? "1" : "0";
            Console.WriteLine(x3.GetType().Name);
            Form form = new Form();
            form.Load += 窗口加载完毕;
            form.ShowDialog();

            List<int> intlist = new List<int>() { 2, 3, 4, 5, 2, 1 };
            intlist.Sort();
            /*
             类别	运算符
////////////基本	x.y  f(x)  a[x]  x++  x--  new
////////////typeof  default  checked  unchecked  delegate
////////////一元	+  -  !  ~  ++x  --x  (T)x
////////////乘法	*  /  %
////////////加减	+  -
////////////移位	<<  >>
////////////关系和类型检测	<  >  <=  >=  is  as
////////////相等	==  !=
////////////逻辑“与”	&
////////////逻辑 XOR	^
////////////逻辑 OR	|
////////////条件 AND	&&
////////////条件 OR	||
////////////null 合并	??
////////////条件	?:
////////////赋值和 lambda 表达式	=  *=  /=  %=  +=  -=  <<=  >>=  &=  ^=  |=
////////////=>
////////////*/
        }
    }
}
