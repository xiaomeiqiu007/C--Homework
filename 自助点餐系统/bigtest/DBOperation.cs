using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;// Directory
using System.Data.OleDb;


namespace sqlconnet
{
    class DBOperation
    {
        static String constr = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=F:\data.accdb";
        //static String constr = @"Data Source=.\SQLEXPRES;AttachDbFilename=E:\c#shixun\jike.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //绑定DataGridView
        public static void BindDB(DataGridView dg,string strSql, string Tname)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter(strSql, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, Tname);
                dg.DataSource = ds.Tables[Tname];
            }
            catch (Exception ce)
            {
                MessageBox.Show("数据库连接出错，请检查你的数据库相关信息", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //  获取数据表
        public static DataTable  GetDataTable( string strSql)
        {
            DataTable dt2 = new DataTable();
            try
            {
                DataTable dt;
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter(strSql, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "DataTab");
                dt = ds.Tables["DataTab"];
                return dt;
            }
            catch (Exception ce)
            {
                MessageBox.Show("数据库连接出错，请检查你的数据库相关信息", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt2;
            }
        }
       ///添加 删除 修改
        public static int exesql(String strsql)  
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                con.Open();///建立连接
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = strsql;
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception ce)
            {
                MessageBox.Show("数据库语句执行出问题，请检查你的输入", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        //根据select查询sql，返回datareader
        public static int getReader(string sql)
       {
            OleDbConnection con = new OleDbConnection(constr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            //OleDbDataReader reader = cmd.ExecuteReader();
            int num = Convert.ToInt32(cmd.ExecuteScalar());
            return num;
       }
    }
}
