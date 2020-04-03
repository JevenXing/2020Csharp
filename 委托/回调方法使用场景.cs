using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._1._28委托2
{
    /// <summary>
    /// 回调方法实现记录日志
    /// </summary>
    class 回调方法使用场景
    {
        public static void Invoke()
        {
            //将两个工厂实例化
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Logger logger = new Logger();

            //委托产品工厂生产两个产品;
            //委托的过程可以叫"封装方法"
            Func<Product> func1 = new Func<Product>(productFactory.MakePizaa);
            Func<Product> func2 = new Func<Product>(productFactory.MakeCar);
            Action<Product> log = new Action<Product>(logger.Log);


            //包装产品
            //将两个委托方法传入包装厂
            Box box1 = wrapFactory.WrapProduct(func1,log);
            Box box2 = wrapFactory.WrapProduct(func2,log);
            Box box3 = wrapFactory.WrapProduct(func2,log);
            Box box4 = wrapFactory.WrapProduct(func2,log);
            Box box5 = wrapFactory.WrapProduct(func2,log);
          
            //打印产品名
            Console.WriteLine("模板方法使用场景结果打印:");
            Console.WriteLine("产品名:{0} 价格:{1}",box1.Product.Name,box1.Product.Price);
            Console.WriteLine("产品名:{0} 价格:{1}",box2.Product.Name,box2.Product.Price);
            
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 常用的类 用作记录程序日志
    /// </summary>
    class Logger
    {
        /// <summary>
        /// 销售额
        /// </summary>
        public double Saleroom { get; set; }
        ///// <summary>
        ///// 产品数量
        ///// </summary>
        //public int ProductQuantity { get; set; }
        public void Log(Product product)
        {
            Saleroom += product.Price;
            Console.WriteLine("日志:Product:{0} created at{1}.Price is{2},Sale:{3}",product.Name,DateTime.UtcNow,product.Price,Saleroom);//产品在什么时候创建的价格是多少
        }
    }
    /// <summary>
    /// 产品 
    /// 有 名字属性
    /// </summary>
    class Product
    {
        public string Name { get; set; }
        /// <summary>
        /// Price 价格
        /// </summary>
        public double Price { get; set; }
    }
    /// <summary>
    /// 盒子
    /// 可以装产品
    /// </summary>
    class Box
    {
        public Product Product { get; set; }
    }
    /// <summary>
    /// 包装工厂
    /// 拥有wrap打包功能
    /// 装入不同的产品就能打包生产不同产品
    /// </summary>
    class WrapFactory
    {
        /// <summary>
        /// 模板方法核心:
        ///     一个相对固定的方法流程中需要不断替换不同的方法加入工作时,将"需要填空的地方"用委托带入不同方法,这样做即可做到一套模板的重复利用,也能方便后期扩展新的"产品"
        /// </summary>
        /// <param name="getProduct"></param>
        /// <returns></returns>
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallback)
        {
            Box box = new Box();//生产盒子
            Product product = getProduct.Invoke();//拿到不同的产品
            box.Product = product;//装入产品
            logCallback(product);//将产品交给log记录
            return box;//交付成品
        }
    }
    /// <summary>
    /// 产品工厂
    /// 不同功能生产不同的产品
    /// </summary>
    class ProductFactory
    {
        public Product MakePizaa()
        {
            Product product = new Product();//生产一个产品
            product.Name = "Pizaa";//起名叫披萨
            product.Price = 12;
            return product;//交付
        }
        public Product MakeCar()
        {
            Product product = new Product();//生产一个产品
            product.Name = "car";//起名叫汽车
            product.Price = 100;
            return product;//交付
        }

    }
}
