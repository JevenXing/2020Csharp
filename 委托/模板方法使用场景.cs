
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._1._28委托
{
    class 模板方法使用场景
    {
        public static void Invoke()
        {
            //将两个工厂实例化
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            //委托产品工厂生产两个产品;
            //委托的过程可以叫"封装方法"
            Func<Product> func1 = new Func<Product>(productFactory.MakePizaa);
            Func<Product> func2 = new Func<Product>(productFactory.MakeCar);

            //包装产品
            Box box1 = wrapFactory.WrapProduct(func1);
            Box box2 = wrapFactory.WrapProduct(func2);

            //打印产品名
            Console.WriteLine("模板方法使用场景结果打印:");
            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 产品 
    /// 有 名字属性
    /// </summary>
    class Product
    {
        public string Name { get; set; }
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
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();//生产盒子
            Product product = getProduct.Invoke();//拿到不同的产品
            box.Product = product;//装入产品
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
            return product;//交付
        }
        public Product MakeCar()
        {
            Product product = new Product();//生产一个产品
            product.Name = "car";//起名叫汽车
            return product;//交付
        }

    }
}
