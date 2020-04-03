using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法参数进阶
{
    class 数组参数
    {
        /// <summary>
        /// params 关键字 可以将数组构造器直接在参数中表示
        /// 如果有多个参数其中包含params 参数 params 需要后置;
        /// </summary>
        public static void zanXian()
        {
            int a = QiuHe(3,5);
            Console.WriteLine("和是:{0}",a);
        }
        /// <summary>
        /// 将一组数据给方法去计算 返回结果 也可返回数组
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public static int QiuHe(params int[] intArray)
        {
            int Sum = 0;
            foreach (var item in intArray)
            {
                Sum += item;
            }
            return Sum;
        }
        public static void StrSplit()//sp li t
        {
            string str = "xing,wen;jie.";
            string[] outSplit = str.Split(',', ';', '.');
            Console.WriteLine(outSplit);
        }
    }

}
