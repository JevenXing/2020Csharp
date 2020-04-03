using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类_数据相关成员
{
    class Property属性
        //属性是一种反映对象或类型特征状态的成员;
        //属性是对字段的功能性的扩展;
        //如扩展字段数据的算法,保护字段不被赋上非法值;

    {
        public void 展现()
        {
            try
            {
                Student2 stu1 = new Student2();
                stu1.Age = 133;
                Console.WriteLine("是否符合打工要求:{0}", stu1.CanWork);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Student2
    {
        private int age;
        public int Age//实例属性(public + 数据类型 + 属性名 + {}属性体)  跟方法体有点像 区别在于方法体需要加()
        {
            get { return this.age; }
            set
            {
                if (value >= 0 && value <= 120)//value 是编译器准备好的 在此处做关键词用
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("年龄不合法");
                }

            }
        }
        public bool CanWork
        {
            get
            {
                if (Age>=16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
    class Student3
    {
        private static  int amount;

        public static  int Amount //静态属性
        {
            get { return amount; }//删除get 会变成只读属性 
            set//get set 可以加访问修饰符 让他不能通过外部访问修改
            {
                if (value>=0&&value<=120)
                {
                    amount = value;

                }
                else
                {
                    throw new Exception(".....");
                }
            }
        }
       

    }
}
