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
    
    public partial class FoodOrder : Form
    {
        string F_sql = "select node,food_name,food_price from food_list";
        DataTable dt = new DataTable("food_list");
        DataTable dt2 = new DataTable("food_list");
        string food_name="";
        public string sumpay="";
        public FoodOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderList.Columns.Add("菜品名称",100,HorizontalAlignment.Left);
            OrderList.Columns.Add("菜品单价", 100, HorizontalAlignment.Left);
            OrderList.Columns.Add("数量", 100, HorizontalAlignment.Left);
            TreeNode node_root1 = new TreeNode("凉菜");
            node_root1.Text = "凉菜";
            TreeNode node_root2 = new TreeNode("热菜");
            node_root2.Text = "热菜";
            TreeNode node_root3 = new TreeNode("汤类");
            node_root3.Text = "汤类";
            treeView1.Nodes.Add(node_root1);
            treeView1.Nodes.Add(node_root2);
            treeView1.Nodes.Add(node_root3);
            dt = sqlconnet.DBOperation.GetDataTable(F_sql);
            string  a = Convert.ToString(dt.Rows[0].ItemArray[1]);
            string b = Convert.ToString(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++){
                TreeNode node = new TreeNode(Convert.ToString(dt.Rows[i].ItemArray[1]));
                node.Text = Convert.ToString(dt.Rows[i].ItemArray[1]);
                if (Convert.ToInt32(dt.Rows[i].ItemArray[0]) == 0) {
                    node_root1.Nodes.Add(node);
                }
                else if (Convert.ToInt32(dt.Rows[i].ItemArray[0]) == 1) {
                    node_root2.Nodes.Add(node);
                }
                else if(Convert.ToInt32(dt.Rows[i].ItemArray[0]) == 2){
                    node_root3.Nodes.Add(node);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sumpricel_Click(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            food_name = e.Node.Text;
            if (food_name != "热菜" && food_name != "凉菜" && food_name != "汤类")
            {
                string F_sql2 = this.F_sql + " where food_name = '" + e.Node.Text+"'";
                this.FoodPicture.Image = Image.FromFile(@"C:\Users\我是好人\Desktop\学习ing\upload\" + food_name + ".jpg");
                dt2 = sqlconnet.DBOperation.GetDataTable(F_sql2);
                FoodName.Text = food_name;
                FoodPrice.Text = Convert.ToString(dt2.Rows[0].ItemArray[2]);
            }

        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
        //
        //添加菜品相关操作
        //
        private void button1_Click(object sender, EventArgs e)
        {

            int a = 0,a1=0;
            int flag=1;
            int i = 0,sum=0;
            string  name= FoodName.Text;
            a=OrderList.Items.Count;
            ListViewItem lvi = new ListViewItem();
            if (food_name != "凉菜" && food_name != "热菜" && food_name != "汤类")
            {
                if (FoodName.Text != "")
                {
                    if (a == 0)
                    {
                        lvi.Text = FoodName.Text;
                        lvi.SubItems.Add(FoodPrice.Text);
                        lvi.SubItems.Add("1");
                        OrderList.Items.Add(lvi);
                    }
                    else
                    {
                        for (i = 0; i < a; i++)
                        {
                            if (OrderList.Items[i].SubItems[0].Text == name)
                            {
                                flag = Convert.ToInt32(OrderList.Items[i].SubItems[2].Text);
                                flag = flag + 1;
                                OrderList.Items[i].SubItems[2].Text = Convert.ToString(flag);
                                break;
                            }
                        }
                        if (i == a)
                        {
                            lvi.Text = FoodName.Text;
                            lvi.SubItems.Add(FoodPrice.Text);
                            lvi.SubItems.Add("1");
                            OrderList.Items.Add(lvi);
                        }
                    }
                }
                a1 = OrderList.Items.Count;
            for (i = 0; i < a1; i++)
            {
                sum = sum + Convert.ToInt32(OrderList.Items[i].SubItems[1].Text) * Convert.ToInt32(OrderList.Items[i].SubItems[2].Text);
                SumPrice.Text = Convert.ToString(sum);
            }
            }
            sumpay = Convert.ToString(sum);
        }
        //
        //减少菜品相关操作
        //
        private void button2_Click(object sender, EventArgs e)
        {
            int a,i,flag=0,sum=0,a1;
            string name = FoodName.Text;
            if (food_name != "凉菜" && food_name != "热菜" && food_name != "汤类")
            {
                a = OrderList.Items.Count;
                if (a == 0)
                {
                    MessageBox.Show("您还没有添加菜品哦，请先添加菜品", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (i = 0; i < a; i++)
                    {
                        if (OrderList.Items[i].SubItems[0].Text == name)
                        {
                            flag = Convert.ToInt32(OrderList.Items[i].SubItems[2].Text);
                            if (flag == 1)
                            {
                                OrderList.Items[i].Remove();
                                break;
                            }
                            else
                            {
                                flag = flag - 1;
                                OrderList.Items[i].SubItems[2].Text = Convert.ToString(flag);
                                break;
                            }
                        }
                    }
                    if (i == a)
                    { 
                            MessageBox.Show("您的订单不存在当前菜品哦", "错误提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                a1 = OrderList.Items.Count;
                for (i = 0; i < a1; i++)
                {
                    sum = sum + Convert.ToInt32(OrderList.Items[i].SubItems[1].Text) * Convert.ToInt32(OrderList.Items[i].SubItems[2].Text);
                    SumPrice.Text = Convert.ToString(sum);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        public void get_sumprice()
        {
            sumpay = SumPrice.Text;
        }
        private void AliPay_Click(object sender, EventArgs e)
        {
            int a, num,sale_num;
            string F_sql = "";
            string F_sql1 = "";
            string F_sql2 = "";
            string F_up = "";
            num = sqlconnet.DBOperation.getReader("select count(*) from food_order");
            System.DateTime currentTime=new System.DateTime();
            currentTime = System.DateTime.Now;
            string time = currentTime.ToString("d");
            a = OrderList.Items.Count;
            if (a == 0 && FoodName.Text == "")
            {
;            MessageBox.Show("您还没有添加菜品哦，请先添加菜品", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else {
              for (int i = 0; i < a; i++)
                {
                    F_sql1 = "select count(*) from food_order where O_food_name='" + OrderList.Items[i].SubItems[0].Text + "' and O_food_data='" + time + "'";
                    if (sqlconnet.DBOperation.getReader(F_sql1) == 0)
                    {
                        num = num + 1;
                        F_sql = "INSERT INTO food_order(ID,O_food_name,O_food_sale_num,O_food_data,O_price) values(" + num + ",'" + OrderList.Items[i].SubItems[0].Text + "',1,'" + time + "'," + FoodPrice.Text + ")";
                        sqlconnet.DBOperation.exesql(F_sql);
                    }
                    else
                    {
                        F_sql2 = "select O_food_sale_num from food_order where O_food_name='" + OrderList.Items[i].SubItems[0].Text + "' and O_food_data='" + time + "'";
                        sale_num = sqlconnet.DBOperation.getReader(F_sql2);
                        sale_num = sale_num + Convert.ToInt32(OrderList.Items[i].SubItems[2].Text);
                        F_up = "update food_order set O_food_sale_num=" + sale_num + " where O_food_name='" + OrderList.Items[i].SubItems[0].Text + "' and O_food_data='" + time + "'";
                        sqlconnet.DBOperation.exesql(F_up);
                    }
                }
                F_AliPay F_A = new F_AliPay(SumPrice.Text);
                F_A.ShowDialog();
            }
        }

        private void WechatPay_Click(object sender, EventArgs e)
        {
            int a, num, sale_num;
            string F_sql = "";
            string F_sql1 = "";
            string F_sql2 = "";
            string F_up = "";
            num = sqlconnet.DBOperation.getReader("select count(*) from food_order");
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string time = currentTime.ToString("d");
            a = OrderList.Items.Count;
            if (a == 0 && FoodName.Text == "")
            {
                ; MessageBox.Show("您还没有添加菜品哦，请先添加菜品", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                for (int i = 0; i < a; i++)
                {
                    F_sql1 = "select count(*) from food_order where O_food_name='" + OrderList.Items[i].SubItems[0].Text + "' and O_food_data='" + time + "'";
                    if (sqlconnet.DBOperation.getReader(F_sql1) == 0)
                    {
                        num = num + 1;
                        F_sql = "INSERT INTO food_order(ID,O_food_name,O_food_sale_num,O_food_data,O_price) values(" + num + ",'" + OrderList.Items[i].SubItems[0].Text + "',1,'" + time + "'," + FoodPrice.Text + ")";
                        sqlconnet.DBOperation.exesql(F_sql);
                    }
                    else
                    {
                        F_sql2 = "select O_food_sale_num from food_order where O_food_name='" + OrderList.Items[i].SubItems[0].Text + "' and O_food_data='" + time + "'";
                        sale_num = sqlconnet.DBOperation.getReader(F_sql2);
                        sale_num = sale_num + Convert.ToInt32(OrderList.Items[i].SubItems[2].Text);
                        F_up = "update food_order set O_food_sale_num=" + sale_num + " where O_food_name='" + OrderList.Items[i].SubItems[0].Text + "' and O_food_data='" + time + "'";
                        sqlconnet.DBOperation.exesql(F_up);
                    }

                }
                F_WechatPay F_W = new F_WechatPay(SumPrice.Text);
                F_W.ShowDialog();
            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
