using System;

namespace 接口与单元测试
{
    public static class 引入接口
    {
        public static void Invoke()
        {
            var muser=new PhoneUser(new MiPhone());
            muser.UsePhone();
            var nuser=new PhoneUser(new NokiaPhone());
            nuser.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone _phone;

        public PhoneUser(IPhone phone)
        {
            this._phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.Receive();
            _phone.Send();
            _phone.PickUp();
            
        }
    }
    /// <summary>
    /// 实现:只要是手机这个概念,就有要这些功能.
    /// </summary>
    interface IPhone
    {
        /// <summary>
        /// 打电话
        /// </summary>
        void Dail();
        /// <summary>
        /// 接电话
        /// </summary>
        void PickUp();
        /// <summary>
        /// 发短信
        /// </summary>
        void Send();
        /// <summary>
        /// 收短信
        /// </summary>
        void Receive();
    }

    class NokiaPhone:IPhone
    {
        public void Dail()
        {
            Console.WriteLine("诺基亚手机打电话...");
        }

        public void PickUp()
        {
            Console.WriteLine("诺基亚手机接电话...");
        }

        public void Send()
        {
            Console.WriteLine("诺基亚手机发短信...");
        }

        public void Receive()
        {
            Console.WriteLine("诺基亚手机收短信...");
        }
    }

    class MiPhone:IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Mi手机打电话...");
        }

        public void PickUp()
        {
            Console.WriteLine("Mi手机接电话...");
        }

        public void Send()
        {
            Console.WriteLine("Mi手机发短信...");
        }

        public void Receive()
        {
            Console.WriteLine("Mi手机收短信...");
        }
    }
}