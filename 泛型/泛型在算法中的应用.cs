using System;

namespace 泛型partial类枚举结构体
{
    public class 泛型在算法中的应用
    {
        public static void Invoke()
        {
            int[] a1 = {1, 2, 3, 4, 5};
            int[] a2 = {1, 2, 3, 4, 5,6};
            double[] a3 = {1.1, 2.2, 3.3, 4.4, 5.6};
            double[] a4 = {1.1, 2.2, 3.3, 4.4, 5.5,6.6};
            var res = Px.Zip(a1, a2);
            //串联集合成员并指定字符分割 string的方法
            //泛型方法在调用时类型参数会自动推断 无需显式
            var res2 = Px.Zip2(a3, a4);
            Console.WriteLine(string.Join(",",res));
            Console.WriteLine(string.Join(",",res2));
        }
    }

    public class Px
    {
        public static int[] Zip(int[] a, int[] b)
        {
            int[] zipped = new int[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length)
                {
                    zipped[zi++] = a[ai++];
                }

                if (bi < b.Length)
                {
                    zipped[zi++] = b[bi++];
                }

            } while (ai < a.Length || bi < b.Length);

            return zipped;
        }
        /// <summary>
        /// 1.泛型方法的定义
        ///     修饰符+返回类型+方法名+泛型参数(){}
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] Zip2<T>(T[] a, T[] b)
        {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length)
                {
                    zipped[zi++] = a[ai++];
                }

                if (bi < b.Length)
                {
                    zipped[zi++] = b[bi++];
                }

            } while (ai < a.Length || bi < b.Length);

            return zipped;
        }
    }
}