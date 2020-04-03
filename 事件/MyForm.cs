using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            //设计器InitializeComponent 方法自动写好组件需要的实例和字段,所以在可以直接使用拖拽的控件
            InitializeComponent();

            this.MyButton.Click += ButtonClicked;
            //delegate 匿名方法 可以用作一次性事件处理器
            button2.Click += delegate (object sender, EventArgs e)
            {
                this.textBox1.Text = "匿名方法用作处理器";
            };
            //lameda表达式 做事件处理器
            button3.Click += (object sender, EventArgs e) =>
            {
                this.textBox1.Text = "lamda表达式用作处理器";
            };

        }


        /// <summary>
        /// 1.同一个事件处理器可以被多个事件重用,前提是这个处理器符合特定参数上的约束
        /// 2.sender 参数传递是事件对象,所以是object
        /// </summary>
        /// <param name="sender"> sender 参数传递了事件对象信息;可以用来分辨事件对象从而分别相应.</param>
        /// <param name="e"></param>
        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender == this.button1)
            {
                this.textBox1.Text = "是由按钮2传递的";
            }
            if (sender == this.MyButton)
            {
                this.textBox1.Text = "是由按钮1传递的";
            }


        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.Text = "阿伟死了";
        }
    }

}
