using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件
{
    class 认识事件2
    {
        public static void Invoke()
        {
            // form 事件拥有者
            Form form = new Form();
            // controller 事件响应者
            Controller controller = new Controller(form);
            form.ShowDialog();
            
        }
    } 
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if (form!=null)
            {
                this.form = form;
                //事件订阅
                this.form.Click+=this.FormClicked;
            }
        }
        /// <summary>
        /// FormClicked 事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
