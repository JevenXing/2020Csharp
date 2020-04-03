using System;
using System.Collections.Generic;
using System.Text;

namespace 泛型partial类枚举结构体
{
    /// <summary>
    /// 1.人为限定取值范围的整数
    /// 2.整数值的对应
    /// 3.比特位式用法
    ///     枚举值通过比特位方式组合,可实现结果判断
    /// </summary>
    class 枚举类型
    {
        public static void invoke()
        {
            
            Person person = new Person();
            
            person.skill = Skill.喝酒|Skill.读书;
            var zj = (person.skill & Skill.写字) == Skill.写字;
            Console.WriteLine(zj);
        }
    }
    enum Level
    {
        Employee,
        Manager,
        boss,
        bigboss
    }
    enum Skill
    {
        读书=1,
        写字=2,
        游戏=4,
        喝酒=8
    }
    class Person
    {
        public Level Level { get; set; }
        public Skill skill { get; set; }
    }
}
