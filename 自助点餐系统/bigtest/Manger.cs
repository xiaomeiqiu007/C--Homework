using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlconnet;
namespace bigtest
{
    public partial class Manger : Form
    {
        public string sql = "select * from food_list order by 1";
        public string sql2 = "select count(*) from food_list";
        
        
        public Manger()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FoodMange_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.M_Display2);
            this.Controls.Add(this.Display1);
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.Display1);
            this.Controls.Add(this.M_Display2);
            
        }

        private void FInsert_Click(object sender, EventArgs e)
        {
            M_insert M_I = new M_insert();
            M_I.ShowDialog();
            DBOperation.BindDB(dataGridView1, sql, "food_list");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_FUpdate_Click(object sender, EventArgs e)
        {
            int num = sqlconnet.DBOperation.getReader(sql2);
            string M_Updata = "";
            int flag = 0;
            int M_U_Num = dataGridView1.CurrentRow.Index + 1;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                M_Updata = "UPDATE  food_list  SET food_name='" + textBox1.Text + "' , food_price=" + int.Parse(textBox2.Text)+" WHERE ID="+M_U_Num;
                flag = 1;
            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                M_Updata = "UPDATE  food_list SET food_name='" + textBox1.Text + "' WHERE ID=" + M_U_Num;
                flag = 1;
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                M_Updata = "UPDATE  food_list WHERE food_price=" + int.Parse(textBox2.Text) + "WHERE ID=" + M_U_Num;
                flag = 1;
            }
            else
            {
                MessageBox.Show("请输入要更新的价格或者菜品名称", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (flag == 1)
            {
                DialogResult result = MessageBox.Show("确认要更新第" + M_U_Num + "列的信息吗？", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlconnet.DBOperation.exesql(M_Updata);
                sqlconnet.DBOperation.BindDB(dataGridView1, this.sql, "food_liat");

            }
        }

        public void Manger_Load(object sender, EventArgs e)
        {
            int a = 0;
            DataTable dt = new DataTable();
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string tody_time = currentTime.ToString("d");
            string moth_time = currentTime.ToString("yyyy/M");
            string year_time = currentTime.ToString("yy");
            moth_time = moth_time + "%";
            year_time = "20" + year_time + "/%";
            string G_d_sql1 = "select sum(O_food_sale_num*O_price) from food_order where O_food_data='" + tody_time + "'", G_d_sql2 = "select O_food_name from food_order where O_food_sale_num=(SELECT Max(O_food_sale_num)  FROM food_order where O_food_data='" + tody_time + "') and  O_food_data='" + tody_time + "'";
            string G_m_sql1 = "select sum(O_food_sale_num*O_price) from food_order where O_food_data LIKE '" + moth_time + "'", G_m_sql2 = "select O_food_name from food_order where O_food_sale_num=(SELECT Max(O_food_sale_num)  FROM food_order where O_food_data LIKE'" + moth_time + "') and  O_food_data LIKE '" + moth_time + "'";
            string G_y_sql1 = "select sum(O_food_sale_num*O_price) from food_order where O_food_data LIKE '" + year_time + "'", G_y_sql2 = "select O_food_name from food_order where O_food_sale_num=(SELECT Max(O_food_sale_num)  FROM food_order where O_food_data LIKE'" + year_time + "') and O_food_data  LIKE '" + year_time + "'";
            DBOperation.BindDB(dataGridView1, sql, "food_list");
            DBOperation.BindDB(dataGridView2, "select * from food_order", "food_order");
            M_l_todaysum.Text = print(G_d_sql1);
            M_l_todaynum.Text = print(G_d_sql2);
            M_l_mouthsum.Text = print(G_m_sql1);
            M_l_mouthnum.Text = print(G_m_sql2);
            M_l_yearsum.Text = print(G_y_sql1);
            M_l_yearnum.Text = print(G_y_sql2);
        }
        public string  print( string sql)
        {
            int a = 0;
            string str2 = "";
            DataTable dt =new DataTable();
            dt=sqlconnet.DBOperation.GetDataTable(sql);
            a = dt.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                str2 = str2 + Convert.ToString(dt.Rows[i].ItemArray[0]) + " ";
            }
            return str2;
        }

        private void M_FSelect_Click(object sender, EventArgs e)
        {
            string M_Select="";
            int flag = 0;
            if(textBox1.Text!= "" && textBox2.Text!="")
            {
                M_Select = "SELECT * FROM food_list WHERE food_name='" + textBox1.Text + "' and food_price=" + int.Parse(textBox2.Text);
                flag = 1;
            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                M_Select = "SELECT * FROM food_list WHERE food_name='" + textBox1.Text + "'";
                flag = 1;
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                M_Select = "SELECT * FROM food_list WHERE food_price=" + int.Parse(textBox2.Text);
                flag = 1;
            }
            else
            {
                MessageBox.Show("请输入要查询的价格或者菜品名称", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (flag==1)
            {
                sqlconnet.DBOperation.BindDB(dataGridView1,M_Select,"food_liat");

            }
        }

        private void FDelete_Click(object sender, EventArgs e)
        {
            int num = sqlconnet.DBOperation.getReader(sql2);
            int M_U_Num = dataGridView1.CurrentRow.Index + 1;
            int tmp = M_U_Num;
            string M_Delete="";
            M_Delete = "DELETE FROM food_list where ID="+M_U_Num;
            DialogResult result = MessageBox.Show("确认要删除第" + M_U_Num + "列的信息吗？", "提示信息",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                sqlconnet.DBOperation.exesql(M_Delete);
                for (int i = tmp; i <= num - 1; i++)
                {
                    int j = i + 1;
                    string M_D_update = "update food_list set ID=" + i + " where ID =" + j;
                    sqlconnet.DBOperation.exesql(M_D_update);
                }
                sqlconnet.DBOperation.BindDB(dataGridView1, this.sql, "food_liat");
            }
            

        }

        private void M_Display2_Enter(object sender, EventArgs e)
        {



        }

        private void Manger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
