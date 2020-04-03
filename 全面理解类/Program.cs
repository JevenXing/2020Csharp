using System;

namespace 全面理解类
{
    /// <summary>
    /// 类的概念:
    ///     1.对现实对象的封装 抽象成数据结构 
    ///         以类的成员抽象现实对象的信息和行为
    ///     2.非静态成员一般为每一个实例都可以拥有的属性特征
    ///         可以作为模板实例化;
    ///         可以使用类的构造器差异化\初始化不同的实例成员;
    ///         析构器释放内存
    ///     3.类的静态成员 作为实例的特征不合理 适合"这类群体"共同的属性特征
    ///         静态构造器可以初始化 静态成员
    ///         例如:总量\平均\
    ///         更贴近数学概念
    ///         
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(ID: 111, Name: "zhang");
            Student student2 = new Student(ID: 111, Name: "xing");

            Console.ReadKey();
        }
    }
    class Student
    {
        public static int Amount { get; set; }
        static Student()
        {
            Amount = 100;
        }
        public Student(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            Amount++;//每一次创建一次实例 静态属性Amount就会被记录
            Console.WriteLine("实例ID:{0}创建完毕.",Amount);
        }
        ~Student()
        {
            Amount--;
            Console.WriteLine("ID:{0}实例被回收了",Amount+1);
        }
        public int ID { get; set; }
        public String Name { get; set; }
        public void Report()//成绩
        {
            Console.WriteLine($"我是{ID}号学生,我的名字是{Name}.");
        }
    }
}
