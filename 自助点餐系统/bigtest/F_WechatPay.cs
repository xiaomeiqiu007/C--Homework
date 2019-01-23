using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigtest
{
    public partial class F_WechatPay : Form
    {
        string str1;
        public F_WechatPay()
        {
            InitializeComponent();

        }
        public F_WechatPay(string str)
        {
            this.str1 = str;
            InitializeComponent();
        }

        private void F_WechatPay_Load(object sender, EventArgs e)
        {
            label2.Text = str1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
