using System;
namespace 泛型partial类枚举结构体
{
    public class partial类
    {
        public static void Invoke()
        {
            par类 partial = new par类() { ID = "xxx" };
            Console.WriteLine(partial.Report());
        }
    }
    public partial class par类
    {
       
        public string ID="333";
    }
   

}
namespace 泛型partial类枚举结构体
{
    /// <summary>
    /// 1.减少类的派生
    ///     划分功能分块编写,可是实现类的部分派生
    ///     
    /// 2.partial类必须写在同一个名称空间中
    ///  
    /// </summary>
    public partial class par类
    {
        public string Report()
        {
            return ID;
        }
    }

}