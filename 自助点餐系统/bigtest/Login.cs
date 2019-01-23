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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login_sql = "";
            int login_flag;
            login_sql = "select count(*) from users where username='" + textBox1.Text + "' and passwd='" + textBox2.Text + "'";
            login_flag = sqlconnet.DBOperation.getReader(login_sql);
            if (login_flag == 0)
            {
                MessageBox.Show("账号或密码错误", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                this.Hide();
                Manger M = new Manger();
                M.ShowDialog();

            }
        }
    }
}
