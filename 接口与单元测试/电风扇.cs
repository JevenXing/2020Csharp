using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口与单元测试
{
    public class 电风扇
    {
        public static void Invoke(){
            var fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());

        }
    }
    public interface IPowerSupply
    {
        int GetPower();
    }
    public class PowerSupply:IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }
    public class DeskFan
    {
        public IPowerSupply _powerSupply { get; set; }
        public DeskFan(IPowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power<=0)
            {
                return "不工作";
            }
            else if (power<100)
            {
                return "电量低";
            }
            else if (power<200)
            {
                return "正常工作";
            }
            else
            {
                return "Boon!";
            }

        }
    }
    
}
