using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 事件进阶
{
    static class Program
    {
        /// <summary>
        /// 概念理解: 事件就是以委托的链接方法效果,通知其他对象
        /// 事件的完整声明 步骤
        ///     1.声明委托:
        ///         参数:事件拥有者,自定义类(传递数据)e;
        ///     2.声明自定义数据类型(类)
        ///     3.为事件拥有者 声明委托属性(使用委托)
        ///     4.为事件拥有者 声明事件:
        ///         声明结构:关键字 event + 数据类型(就是委托名) + 事件名(事件命名){add{},remove{}}
        ///     5.最后编写事件的触发条件(在form控件中的事件是系统调度触发的)
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MyForm());

            Customer customer = new Customer();
            Waiter waiter = new Waiter();

            customer.Order += waiter.Action;//事件订阅

            customer.Action();

            Console.ReadLine();

        }
    }
    /// <summary>
    /// 事件参数类型 传递事件接收的信息 e
    /// 有需要通过订阅来获得的信息才需要传递
    /// </summary>
    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }//菜名
        public string Size { get; set; }//尺寸(分量)

    }
    /// <summary>
    /// 声明一个自定义委托
    /// 1.Eventhandler 后缀方便识别这个委托是给事件使用的
    /// ##为事件准备的委托为什么没有被实例化操作?
    ///     自定义委托作为事件拥有者的属性时,在事件拥有者被实例化后作为其内部成员一同被实例化了
    ///     要理解声明委托本身是静态的即 public 
    ///     事件拥有者通过声明 已创建的委托作为属性 符合 面向对象编程的思想
    ///     等学到继承之后 更多讨论各个成员之间在 创建实例时的规则
    /// 2.在现实使用中,事件委托 一般不需要自己声明,可以使用系统准备好的EventHandler 这个通用委托
    /// </summary>
    /// <param name="custormer"></param>
    /// <param name="e"></param>
    //public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    /// <summary>
    /// 客户Class-拥有的成员
    ///      1.订单事件
    ///      2.买单的方法
    ///      3.一个账本属性
    ///      4.事件字段
    /// </summary>
    public class Customer// 客户 事件拥有者
    {
        /// <summary>
        /// 委托类型的属性 用来储存 实例
        ///  复习理解,字段和方法作为类最重要的成员 一个负责存储数据 一个负责逻辑数据 
        ///  事件类型的字段 存储的就是委托 
        /// </summary>
        //public OrderEventHandler orderEventHandler { get; set; }
        /// <summary>
        /// 以委托为基础 为客户声明 Order 事件 其本质还是委托
        ///     声明结构:关键字 event + 数据类型(就是委托名) + 事件名(事件命名)
        /// 1.事件声明作为类成员 在声明时的实体形态 有点像方法
        /// 2.命名规范:
        ///     带有时态的动词\动词短语
        ///     即将\正在\之后
        /// </summary>
        //public event OrderEventHandler order//事件
        //{
        //    add { this.orderEventHandler += value; }
        //    remove { this.orderEventHandler -= value; }
        //}
        
        public event EventHandler Order;//事件声明语法糖 像字段
        public double Bill { get; set; }//账单
        public void PayBill()//买单
        {
            Console.WriteLine("我需要付:{0}.", this.Bill);
        }
        public void WalkIn()//进店
        {
            Console.WriteLine("就在这家吃吧.");
        }
        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("今天吃什么呢?");
                Thread.Sleep(500);
            }

           this.OnOrder("牛肉拉面", "dafen");
        }
        /// <summary>
        /// //委托事件处理器开始执行 sender参数 必须传入自己本身这个对象 达到"谁叫的服务员谁买单" 这是事件的意义
        /// </summary>
        /// <param name="DishName"></param>
        /// <param name="Size"></param>
        protected void OnOrder(string DishName,string Size)//约定 protected受保护的 On-Name作为触发事件的方法 
        {
            if (Order == null)//为空时,代表事件为未被订阅 这里可以表示店里没人服务
            {
                Console.WriteLine("半天不来人 我走了!");
            }
            else
            {
                OrderEventArgs args = new OrderEventArgs();
                args.DishName = DishName;
                args.Size = Size;

                this.Order.Invoke(this, args);
            }
        }
        public void Action()
        {
            WalkIn();
            Think();
            PayBill();
        }
    }
    class Waiter//服务员 事件响应者
    {
        /// <summary>
        /// //事件处理器
        /// </summary>
        /// <param name="sender"> 是谁触发的 事件拥有者 默认是object 在自定义事件时 可以直接设具体的类</param>
        /// <param name="e"> 传递数据 </param>
        public void Action(object Sender, EventArgs e)//事件处理器
        {
            Customer customer1 = Sender as Customer;
            OrderEventArgs orderInfo = e as OrderEventArgs;

            Console.WriteLine("给你上{1}的{0}.", orderInfo.DishName,orderInfo.Size);//给你上__菜
            double price = 10;
            switch (orderInfo.Size)
            {
                case "xiaofen":
                    price = price * 0.5;
                    break;
                case "zhongfen":
                    price = price * 0.8;
                    break;
                case "dafen":
                    price = price * 1.2;
                    break;
                default:
                    break;
            }
            customer1.Bill += price;//在事件处理器中可以读写实例中的字段
        }
    }
}
