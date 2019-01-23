namespace bigtest
{
    partial class Manger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Function = new System.Windows.Forms.GroupBox();
            this.Analysis = new System.Windows.Forms.Button();
            this.FoodMange = new System.Windows.Forms.Button();
            this.Display1 = new System.Windows.Forms.GroupBox();
            this.M_SelectUpdate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FDelete = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FInsert = new System.Windows.Forms.Button();
            this.M_FPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.M_FSelect = new System.Windows.Forms.Button();
            this.M_FUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.M_Display2 = new System.Windows.Forms.GroupBox();
            this.M_l_yearnum = new System.Windows.Forms.Label();
            this.M_l_yearsum = new System.Windows.Forms.Label();
            this.M_l_mouthnum = new System.Windows.Forms.Label();
            this.M_l_todaynum = new System.Windows.Forms.Label();
            this.M_l_mouthsum = new System.Windows.Forms.Label();
            this.M_l_todaysum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Function.SuspendLayout();
            this.Display1.SuspendLayout();
            this.M_SelectUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.M_Display2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Function
            // 
            this.Function.Controls.Add(this.Analysis);
            this.Function.Controls.Add(this.FoodMange);
            this.Function.Location = new System.Drawing.Point(33, 39);
            this.Function.Margin = new System.Windows.Forms.Padding(4);
            this.Function.Name = "Function";
            this.Function.Padding = new System.Windows.Forms.Padding(4);
            this.Function.Size = new System.Drawing.Size(163, 479);
            this.Function.TabIndex = 0;
            this.Function.TabStop = false;
            this.Function.Text = "功能区";
            // 
            // Analysis
            // 
            this.Analysis.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Analysis.Location = new System.Drawing.Point(24, 118);
            this.Analysis.Margin = new System.Windows.Forms.Padding(4);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(131, 37);
            this.Analysis.TabIndex = 1;
            this.Analysis.Text = "数据分析";
            this.Analysis.UseVisualStyleBackColor = true;
            this.Analysis.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // FoodMange
            // 
            this.FoodMange.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FoodMange.Location = new System.Drawing.Point(24, 40);
            this.FoodMange.Margin = new System.Windows.Forms.Padding(4);
            this.FoodMange.Name = "FoodMange";
            this.FoodMange.Size = new System.Drawing.Size(131, 38);
            this.FoodMange.TabIndex = 0;
            this.FoodMange.Text = "菜品管理";
            this.FoodMange.UseVisualStyleBackColor = true;
            this.FoodMange.Click += new System.EventHandler(this.FoodMange_Click);
            // 
            // Display1
            // 
            this.Display1.Controls.Add(this.M_SelectUpdate);
            this.Display1.Controls.Add(this.dataGridView1);
            this.Display1.Location = new System.Drawing.Point(203, 39);
            this.Display1.Name = "Display1";
            this.Display1.Size = new System.Drawing.Size(497, 479);
            this.Display1.TabIndex = 1;
            this.Display1.TabStop = false;
            this.Display1.Text = "菜品管理显示区";
            // 
            // M_SelectUpdate
            // 
            this.M_SelectUpdate.Controls.Add(this.label1);
            this.M_SelectUpdate.Controls.Add(this.FDelete);
            this.M_SelectUpdate.Controls.Add(this.textBox2);
            this.M_SelectUpdate.Controls.Add(this.FInsert);
            this.M_SelectUpdate.Controls.Add(this.M_FPrice);
            this.M_SelectUpdate.Controls.Add(this.textBox1);
            this.M_SelectUpdate.Controls.Add(this.M_FSelect);
            this.M_SelectUpdate.Controls.Add(this.M_FUpdate);
            this.M_SelectUpdate.Location = new System.Drawing.Point(23, 251);
            this.M_SelectUpdate.Name = "M_SelectUpdate";
            this.M_SelectUpdate.Size = new System.Drawing.Size(454, 214);
            this.M_SelectUpdate.TabIndex = 6;
            this.M_SelectUpdate.TabStop = false;
            this.M_SelectUpdate.Text = "更新查询相关信息";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "更新/查询菜品名称";
            // 
            // FDelete
            // 
            this.FDelete.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FDelete.Location = new System.Drawing.Point(281, 176);
            this.FDelete.Name = "FDelete";
            this.FDelete.Size = new System.Drawing.Size(118, 31);
            this.FDelete.TabIndex = 2;
            this.FDelete.Text = "删除菜品";
            this.FDelete.UseVisualStyleBackColor = true;
            this.FDelete.Click += new System.EventHandler(this.FDelete_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 25);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FInsert
            // 
            this.FInsert.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FInsert.Location = new System.Drawing.Point(16, 176);
            this.FInsert.Name = "FInsert";
            this.FInsert.Size = new System.Drawing.Size(121, 31);
            this.FInsert.TabIndex = 1;
            this.FInsert.Text = "添加菜品";
            this.FInsert.UseVisualStyleBackColor = true;
            this.FInsert.Click += new System.EventHandler(this.FInsert_Click);
            // 
            // M_FPrice
            // 
            this.M_FPrice.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.M_FPrice.Location = new System.Drawing.Point(19, 62);
            this.M_FPrice.Name = "M_FPrice";
            this.M_FPrice.Size = new System.Drawing.Size(169, 26);
            this.M_FPrice.TabIndex = 5;
            this.M_FPrice.Text = "更新/查询价格";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 25);
            this.textBox1.TabIndex = 4;
            // 
            // M_FSelect
            // 
            this.M_FSelect.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.M_FSelect.Location = new System.Drawing.Point(281, 117);
            this.M_FSelect.Name = "M_FSelect";
            this.M_FSelect.Size = new System.Drawing.Size(118, 34);
            this.M_FSelect.TabIndex = 1;
            this.M_FSelect.Text = "查询菜品";
            this.M_FSelect.UseVisualStyleBackColor = true;
            this.M_FSelect.Click += new System.EventHandler(this.M_FSelect_Click);
            // 
            // M_FUpdate
            // 
            this.M_FUpdate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.M_FUpdate.Location = new System.Drawing.Point(16, 117);
            this.M_FUpdate.Name = "M_FUpdate";
            this.M_FUpdate.Size = new System.Drawing.Size(121, 33);
            this.M_FUpdate.TabIndex = 0;
            this.M_FUpdate.Text = "更新菜品";
            this.M_FUpdate.UseVisualStyleBackColor = true;
            this.M_FUpdate.Click += new System.EventHandler(this.M_FUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(454, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // M_Display2
            // 
            this.M_Display2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M_Display2.Controls.Add(this.M_l_yearnum);
            this.M_Display2.Controls.Add(this.M_l_yearsum);
            this.M_Display2.Controls.Add(this.M_l_mouthnum);
            this.M_Display2.Controls.Add(this.M_l_todaynum);
            this.M_Display2.Controls.Add(this.M_l_mouthsum);
            this.M_Display2.Controls.Add(this.M_l_todaysum);
            this.M_Display2.Controls.Add(this.label7);
            this.M_Display2.Controls.Add(this.label6);
            this.M_Display2.Controls.Add(this.label5);
            this.M_Display2.Controls.Add(this.label4);
            this.M_Display2.Controls.Add(this.label3);
            this.M_Display2.Controls.Add(this.label2);
            this.M_Display2.Controls.Add(this.dataGridView2);
            this.M_Display2.Location = new System.Drawing.Point(204, 39);
            this.M_Display2.Margin = new System.Windows.Forms.Padding(4);
            this.M_Display2.Name = "M_Display2";
            this.M_Display2.Padding = new System.Windows.Forms.Padding(4);
            this.M_Display2.Size = new System.Drawing.Size(475, 479);
            this.M_Display2.TabIndex = 1;
            this.M_Display2.TabStop = false;
            this.M_Display2.Text = "数据分析显示区";
            this.M_Display2.Enter += new System.EventHandler(this.M_Display2_Enter);
            // 
            // M_l_yearnum
            // 
            this.M_l_yearnum.AutoSize = true;
            this.M_l_yearnum.Location = new System.Drawing.Point(343, 376);
            this.M_l_yearnum.Name = "M_l_yearnum";
            this.M_l_yearnum.Size = new System.Drawing.Size(0, 15);
            this.M_l_yearnum.TabIndex = 7;
            // 
            // M_l_yearsum
            // 
            this.M_l_yearsum.AutoSize = true;
            this.M_l_yearsum.Location = new System.Drawing.Point(152, 375);
            this.M_l_yearsum.Name = "M_l_yearsum";
            this.M_l_yearsum.Size = new System.Drawing.Size(0, 15);
            this.M_l_yearsum.TabIndex = 7;
            // 
            // M_l_mouthnum
            // 
            this.M_l_mouthnum.AutoSize = true;
            this.M_l_mouthnum.Location = new System.Drawing.Point(343, 339);
            this.M_l_mouthnum.Name = "M_l_mouthnum";
            this.M_l_mouthnum.Size = new System.Drawing.Size(0, 15);
            this.M_l_mouthnum.TabIndex = 5;
            // 
            // M_l_todaynum
            // 
            this.M_l_todaynum.AutoSize = true;
            this.M_l_todaynum.Location = new System.Drawing.Point(343, 302);
            this.M_l_todaynum.Name = "M_l_todaynum";
            this.M_l_todaynum.Size = new System.Drawing.Size(0, 15);
            this.M_l_todaynum.TabIndex = 5;
            // 
            // M_l_mouthsum
            // 
            this.M_l_mouthsum.AutoSize = true;
            this.M_l_mouthsum.Location = new System.Drawing.Point(150, 338);
            this.M_l_mouthsum.Name = "M_l_mouthsum";
            this.M_l_mouthsum.Size = new System.Drawing.Size(0, 15);
            this.M_l_mouthsum.TabIndex = 6;
            // 
            // M_l_todaysum
            // 
            this.M_l_todaysum.AutoSize = true;
            this.M_l_todaysum.Location = new System.Drawing.Point(150, 302);
            this.M_l_todaysum.Name = "M_l_todaysum";
            this.M_l_todaysum.Size = new System.Drawing.Size(0, 15);
            this.M_l_todaysum.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "本年销售量最多为";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "本月销售量最多为";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "今日销售量最多为";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "本年销售额为：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "本月销售额为：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "今日销售额为：";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(416, 235);
            this.dataGridView2.TabIndex = 0;
            // 
            // Manger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 554);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.Display1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Manger";
            this.Text = "XXX餐厅管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manger_FormClosing);
            this.Load += new System.EventHandler(this.Manger_Load);
            this.Function.ResumeLayout(false);
            this.Display1.ResumeLayout(false);
            this.M_SelectUpdate.ResumeLayout(false);
            this.M_SelectUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.M_Display2.ResumeLayout(false);
            this.M_Display2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Function;
        private System.Windows.Forms.Button Analysis;
        private System.Windows.Forms.Button FoodMange;
        private System.Windows.Forms.GroupBox Display1;
        private System.Windows.Forms.Button FDelete;
        private System.Windows.Forms.Button FInsert;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox M_SelectUpdate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label M_FPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button M_FSelect;
        private System.Windows.Forms.Button M_FUpdate;
        private System.Windows.Forms.GroupBox M_Display2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label M_l_yearnum;
        private System.Windows.Forms.Label M_l_yearsum;
        private System.Windows.Forms.Label M_l_mouthnum;
        private System.Windows.Forms.Label M_l_todaynum;
        private System.Windows.Forms.Label M_l_mouthsum;
        private System.Windows.Forms.Label M_l_todaysum;

    }
}