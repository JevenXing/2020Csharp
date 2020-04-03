using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件
{
    class 事件4
    {
        public static void Invoke()
        {
            
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
    class Form3:Form
    {
        //字段是存储数据的,是属性的低配版
        //字段同样可以存储引用类型数据 ##重要## 防止思维僵化
        private TextBox TextBox;
        private Button Button;
        /// <summary>
        /// 
        /// </summary>
        public Form3()
        {
            this.TextBox = new TextBox();
            this.Button = new Button();
            //获取包含在控件内的控件的集合。->将制定控件添加到控件合集
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextBox);
            Button.Click += Button_Click;
            Button.Top = 200;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            TextBox.Text = DateTime.Now.ToString();
        }
    }
}
