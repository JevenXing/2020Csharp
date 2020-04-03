using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类_数据相关成员
{
    class indexer索引器
    {
        public void 展现()
        { Student4 stu4 = new Student4();
            stu4["Xing"] = 66;
            var mathScore = stu4["Xing"];
            Console.WriteLine(mathScore);
        }
    }
    class Student4 
    {
        private Dictionary<string, int> scoreD = new Dictionary<string, int>();
        public int? this[string subject]
        {
            get {
                if (this.scoreD.ContainsKey(subject))
                {
                    return this.scoreD[subject];
                }
                else
                {
                    return null;
                }
            }
            set {
                if (value.HasValue==false)
                {
                    throw new Exception("数值不合法");
                }
                if (this.scoreD.ContainsKey(subject))
                {
                    this.scoreD[subject] = value.Value;
                }
                else
                {
                    this.scoreD.Add(subject, value.Value);
                }
            }
        }
    }
}
