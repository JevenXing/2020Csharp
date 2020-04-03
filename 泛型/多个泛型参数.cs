using System;
using System.Collections.Generic;

namespace 泛型partial类枚举结构体
{
    public class 多个泛型参数
    {
        public static void Invoke()
        {
            IDictionary<int,string> dict=new Dictionary<int, string>();
            dict[1] = "xingwenjie";
            dict[2] = "xingwenjie2";
            Console.WriteLine($"{dict[1]}{dict[2]}");
        }
    }
}