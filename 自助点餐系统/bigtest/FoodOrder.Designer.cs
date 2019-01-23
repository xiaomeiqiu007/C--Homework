namespace bigtest
{
    partial class FoodOrder
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FoodPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.foodpricel = new System.Windows.Forms.Label();
            this.sumpricel = new System.Windows.Forms.Label();
            this.SumPrice = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListView();
            this.WechatPay = new System.Windows.Forms.Button();
            this.AliPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FoodName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FoodPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.foodnamel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoodPrice
            // 
            this.FoodPrice.AutoSize = true;
            this.FoodPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FoodPrice.ForeColor = System.Drawing.Color.Black;
            this.FoodPrice.Location = new System.Drawing.Point(472, 332);
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Size = new System.Drawing.Size(0, 20);
            this.FoodPrice.TabIndex = 9;
            this.FoodPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(507, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "元";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(3, 15);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(328, 674);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // foodpricel
            // 
            this.foodpricel.AutoSize = true;
            this.foodpricel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.foodpricel.ForeColor = System.Drawing.Color.Black;
            this.foodpricel.Location = new System.Drawing.Point(337, 332);
            this.foodpricel.Name = "foodpricel";
            this.foodpricel.Size = new System.Drawing.Size(89, 20);
            this.foodpricel.TabIndex = 9;
            this.foodpricel.Text = "菜品单价";
            // 
            // sumpricel
            // 
            this.sumpricel.AutoSize = true;
            this.sumpricel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sumpricel.ForeColor = System.Drawing.Color.Black;
            this.sumpricel.Location = new System.Drawing.Point(20, 289);
            this.sumpricel.Name = "sumpricel";
            this.sumpricel.Size = new System.Drawing.Size(89, 20);
            this.sumpricel.TabIndex = 10;
            this.sumpricel.Text = "订单总价";
            this.sumpricel.Click += new System.EventHandler(this.sumpricel_Click);
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSize = true;
            this.SumPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SumPrice.ForeColor = System.Drawing.Color.Red;
            this.SumPrice.Location = new System.Drawing.Point(114, 289);
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Size = new System.Drawing.Size(0, 20);
            this.SumPrice.TabIndex = 11;
            // 
            // OrderList
            // 
            this.OrderList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderList.GridLines = true;
            this.OrderList.Location = new System.Drawing.Point(18, 23);
            this.OrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(531, 256);
            this.OrderList.TabIndex = 5;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            // 
            // WechatPay
            // 
            this.WechatPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WechatPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WechatPay.Location = new System.Drawing.Point(426, 283);
            this.WechatPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WechatPay.Name = "WechatPay";
            this.WechatPay.Size = new System.Drawing.Size(128, 30);
            this.WechatPay.TabIndex = 12;
            this.WechatPay.Text = "微信支付";
            this.WechatPay.UseVisualStyleBackColor = false;
            this.WechatPay.Click += new System.EventHandler(this.WechatPay_Click);
            // 
            // AliPay
            // 
            this.AliPay.BackColor = System.Drawing.Color.RoyalBlue;
            this.AliPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AliPay.Location = new System.Drawing.Point(262, 283);
            this.AliPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AliPay.Name = "AliPay";
            this.AliPay.Size = new System.Drawing.Size(117, 30);
            this.AliPay.TabIndex = 13;
            this.AliPay.Text = "支付宝支付";
            this.AliPay.UseVisualStyleBackColor = false;
            this.AliPay.Click += new System.EventHandler(this.AliPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(152, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "元";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AliPay);
            this.groupBox1.Controls.Add(this.WechatPay);
            this.groupBox1.Controls.Add(this.OrderList);
            this.groupBox1.Controls.Add(this.SumPrice);
            this.groupBox1.Controls.Add(this.sumpricel);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(365, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 318);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FoodName.ForeColor = System.Drawing.Color.Black;
            this.FoodName.Location = new System.Drawing.Point(244, 332);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(0, 20);
            this.FoodName.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(10, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "减少一份";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "添加至订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoodPicture
            // 
            this.FoodPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FoodPicture.Location = new System.Drawing.Point(124, 10);
            this.FoodPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoodPicture.Name = "FoodPicture";
            this.FoodPicture.Size = new System.Drawing.Size(429, 308);
            this.FoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodPicture.TabIndex = 6;
            this.FoodPicture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.foodnamel);
            this.groupBox2.Controls.Add(this.FoodPicture);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.FoodName);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.foodpricel);
            this.groupBox2.Controls.Add(this.FoodPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Location = new System.Drawing.Point(365, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 361);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "菜品信息";
            // 
            // foodnamel
            // 
            this.foodnamel.AutoSize = true;
            this.foodnamel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.foodnamel.ForeColor = System.Drawing.Color.Black;
            this.foodnamel.Location = new System.Drawing.Point(129, 332);
            this.foodnamel.Name = "foodnamel";
            this.foodnamel.Size = new System.Drawing.Size(89, 20);
            this.foodnamel.TabIndex = 7;
            this.foodnamel.Text = "菜品名称";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Location = new System.Drawing.Point(34, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 688);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "菜单";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(335, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "欢迎来到XXX餐厅";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // FoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 770);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FoodOrder";
            this.Text = "XXX餐厅点餐系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FoodPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label foodpricel;
        public System.Windows.Forms.Label sumpricel;
        public System.Windows.Forms.Label SumPrice;
        private System.Windows.Forms.ListView OrderList;
        private System.Windows.Forms.Button WechatPay;
        private System.Windows.Forms.Button AliPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FoodName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox FoodPicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label foodnamel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;

    }
}

