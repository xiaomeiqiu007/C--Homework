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
    public partial class F_AliPay : Form
    {
        string str1;
        public F_AliPay()
        {
            InitializeComponent();
        }
        public F_AliPay(string str)
        {
            this.str1 = str;
            InitializeComponent();
        }

        private void F_AliPay_Load(object sender, EventArgs e)
        {
            label3.Text = str1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
