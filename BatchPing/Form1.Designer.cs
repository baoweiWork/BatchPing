namespace BatchPing
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ipStart3 = new System.Windows.Forms.TextBox();
            this.ipStart4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ipEnd4 = new System.Windows.Forms.TextBox();
            this.ipEnd3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ipStart1 = new System.Windows.Forms.TextBox();
            this.ipEnd2 = new System.Windows.Forms.TextBox();
            this.ipEnd1 = new System.Windows.Forms.TextBox();
            this.ipStart2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.rdoGoole = new System.Windows.Forms.RadioButton();
            this.rdoIE = new System.Windows.Forms.RadioButton();
            this.IpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogin = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipStart3
            // 
            this.ipStart3.Location = new System.Drawing.Point(125, 35);
            this.ipStart3.Name = "ipStart3";
            this.ipStart3.Size = new System.Drawing.Size(37, 21);
            this.ipStart3.TabIndex = 3;
            // 
            // ipStart4
            // 
            this.ipStart4.Location = new System.Drawing.Point(184, 35);
            this.ipStart4.Name = "ipStart4";
            this.ipStart4.Size = new System.Drawing.Size(39, 21);
            this.ipStart4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(164, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = ".";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(496, 33);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(407, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = ".";
            // 
            // ipEnd4
            // 
            this.ipEnd4.Location = new System.Drawing.Point(427, 35);
            this.ipEnd4.Name = "ipEnd4";
            this.ipEnd4.Size = new System.Drawing.Size(39, 21);
            this.ipEnd4.TabIndex = 8;
            // 
            // ipEnd3
            // 
            this.ipEnd3.Location = new System.Drawing.Point(368, 35);
            this.ipEnd3.Name = "ipEnd3";
            this.ipEnd3.Size = new System.Drawing.Size(37, 21);
            this.ipEnd3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpAddress,
            this.textMAC,
            this.message,
            this.btnLogin});
            this.dataGridView1.Location = new System.Drawing.Point(1, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(799, 358);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ipStart1
            // 
            this.ipStart1.Location = new System.Drawing.Point(8, 35);
            this.ipStart1.Name = "ipStart1";
            this.ipStart1.Size = new System.Drawing.Size(37, 21);
            this.ipStart1.TabIndex = 1;
            this.ipStart1.Text = "192";
            // 
            // ipEnd2
            // 
            this.ipEnd2.Location = new System.Drawing.Point(306, 35);
            this.ipEnd2.Name = "ipEnd2";
            this.ipEnd2.Size = new System.Drawing.Size(37, 21);
            this.ipEnd2.TabIndex = 6;
            this.ipEnd2.Text = "168";
            // 
            // ipEnd1
            // 
            this.ipEnd1.Location = new System.Drawing.Point(246, 35);
            this.ipEnd1.Name = "ipEnd1";
            this.ipEnd1.Size = new System.Drawing.Size(37, 21);
            this.ipEnd1.TabIndex = 5;
            this.ipEnd1.Text = "192";
            // 
            // ipStart2
            // 
            this.ipStart2.Location = new System.Drawing.Point(66, 35);
            this.ipStart2.Name = "ipStart2";
            this.ipStart2.Size = new System.Drawing.Size(37, 21);
            this.ipStart2.TabIndex = 2;
            this.ipStart2.Text = "168";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(105, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(226, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(287, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(348, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = ".";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(670, 34);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 24;
            this.txtTime.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "请输入起始IP,号段必须一致";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(668, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "验证时间(1000=1s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "用户名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 21);
            this.txtName.TabIndex = 28;
            this.txtName.Text = "admin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(173, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(220, 66);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(108, 21);
            this.txtPwd.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(334, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "网页响应时间(1000=1s)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(486, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 21);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "1000";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.rdoGoole);
            this.grp.Controls.Add(this.rdoIE);
            this.grp.Location = new System.Drawing.Point(529, 55);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(172, 32);
            this.grp.TabIndex = 33;
            this.grp.TabStop = false;
            // 
            // rdoGoole
            // 
            this.rdoGoole.AutoSize = true;
            this.rdoGoole.Checked = true;
            this.rdoGoole.Location = new System.Drawing.Point(83, 11);
            this.rdoGoole.Name = "rdoGoole";
            this.rdoGoole.Size = new System.Drawing.Size(83, 16);
            this.rdoGoole.TabIndex = 1;
            this.rdoGoole.TabStop = true;
            this.rdoGoole.Text = "谷歌浏览器";
            this.rdoGoole.UseVisualStyleBackColor = true;
            // 
            // rdoIE
            // 
            this.rdoIE.AutoSize = true;
            this.rdoIE.Location = new System.Drawing.Point(6, 11);
            this.rdoIE.Name = "rdoIE";
            this.rdoIE.Size = new System.Drawing.Size(71, 16);
            this.rdoIE.TabIndex = 0;
            this.rdoIE.TabStop = true;
            this.rdoIE.Text = "IE浏览器";
            this.rdoIE.UseVisualStyleBackColor = true;
            // 
            // IpAddress
            // 
            this.IpAddress.HeaderText = "地址";
            this.IpAddress.Name = "IpAddress";
            // 
            // textMAC
            // 
            this.textMAC.HeaderText = "MAC地址";
            this.textMAC.Name = "textMAC";
            this.textMAC.Width = 150;
            // 
            // message
            // 
            this.message.HeaderText = "ping结果";
            this.message.Name = "message";
            this.message.Width = 400;
            // 
            // btnLogin
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogin.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.HeaderText = "";
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "登录网页";
            this.btnLogin.UseColumnTextForButtonValue = true;
            this.btnLogin.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipStart2);
            this.Controls.Add(this.ipEnd1);
            this.Controls.Add(this.ipEnd2);
            this.Controls.Add(this.ipStart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ipEnd4);
            this.Controls.Add(this.ipEnd3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipStart4);
            this.Controls.Add(this.ipStart3);
            this.Name = "Form1";
            this.Text = "批量Ping";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ipStart3;
        private System.Windows.Forms.TextBox ipStart4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipEnd4;
        private System.Windows.Forms.TextBox ipEnd3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ipStart1;
        private System.Windows.Forms.TextBox ipEnd2;
        private System.Windows.Forms.TextBox ipEnd1;
        private System.Windows.Forms.TextBox ipStart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton rdoGoole;
        private System.Windows.Forms.RadioButton rdoIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn textMAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewButtonColumn btnLogin;
    }
}

