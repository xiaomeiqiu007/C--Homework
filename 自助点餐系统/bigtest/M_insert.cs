using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace bigtest
{
    public partial class M_insert : Form
    {
        Manger M = new Manger();
        
        public M_insert()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //
        //提交信息相关操作,功能：判断是否有值，判断价格是否合法。将菜品信息插入数据库，将文件上传。
        //
        private void button2_Click(object sender, EventArgs e)
        {
            int num = sqlconnet.DBOperation.getReader(M.sql2);
            num = num + 1;
            System.DateTime currentTime=new System.DateTime();
            currentTime = System.DateTime.Now;
            string M_I_sql = "";
            System.Text.RegularExpressions.Regex reg1
          = new System.Text.RegularExpressions.
              Regex(@"^[-]?[1-9]{1}\d*$|^[0]{1}$");
            bool ismatch = reg1.IsMatch(textBox2.Text);
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == ""&& comboBox1.Text == "")
            {
                MessageBox.Show("你的输入不完整！！请检查输入","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
            else if (!ismatch)
            {
                MessageBox.Show("您输入的数字不是整数！请重新输入", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string time=currentTime.ToString("d");
                M_I_sql = "INSERT INTO food_list(ID,food_name,food_price,add_data,node) values("+num+",'" + textBox1.Text + "'," + int.Parse(textBox2.Text) + ",'"+time+"','"+comboBox1.SelectedIndex+"')";
                if (sqlconnet.DBOperation.exesql(M_I_sql) == 1)
                {
                    try
                    {
                        Image img = pictureBox1.Image;
                        img.Save(@"C:\Users\我是好人\Desktop\学习ing\upload" + @"\"+textBox1.Text+".jpg");
                    }
                    catch (Exception ce)
                    {
                        MessageBox.Show("文件保存出错请检查您的文件路径是否包含中文或文件是否存在", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    DialogResult result = MessageBox.Show("菜品添加成功！！请点击OK继续", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlconnet.DBOperation.BindDB(M.dataGridView1, M.sql, "food_list");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";//初始加载路径为C盘；
            openFileDialog1.Filter = " 图片文件 (*.jpg,*.png,*.bmp,*.jpeg)|*.jpg;*.png;*.bmp;*.jpeg";//过滤你想设置的文本文件类型（这是txt型）
            // openFileDialog1.Filter = "文本文件 |All files (*.*)|*.*";（这是全部类型文件）
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = Path.GetFileName(openFileDialog1.FileName);//显示文件的名字
                string s1 = openFileDialog1.FileName.ToString();
                this.pictureBox1.Image=Image.FromFile(s1);
                Path.GetFullPath(openFileDialog1.FileName);
                


            }
        }

        private void M_insert_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("凉菜");
            comboBox1.Items.Add("热菜");
            comboBox1.Items.Add("汤类");
        }
    }
}
