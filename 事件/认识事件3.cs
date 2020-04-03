using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 事件
{
    /// <summary>
    /// 两星事件写法
    ///     事件拥有者和事件响应者是同一个类
    ///     以继承控件类的方式达到在同一个类中扩展事件处理器的效果
    /// </summary>
    class 认识事件3
    {
        public static void Invoke()
        {
            MyForm2 form = new MyForm2();
            //用派生类FormClicked方法 订阅 父类的Click事件
            form.Click += form.FormClicked;
            form.ShowDialog();
        }
    }
    class MyForm2 : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
