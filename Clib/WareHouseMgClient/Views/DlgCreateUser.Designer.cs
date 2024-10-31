namespace WareHouseMgClient
{
    partial class DlgCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgCreateUser));
            this.panel1 = new AntdUI.Panel();
            this.titlebar = new AntdUI.WindowBar();
            this.label3 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.Input_repeatName = new AntdUI.Input();
            this.BtnInsert = new AntdUI.Button();
            this.Input_name = new AntdUI.Input();
            this.Input_pwd = new AntdUI.Input();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Input_repeatName);
            this.panel1.Controls.Add(this.BtnInsert);
            this.panel1.Controls.Add(this.Input_name);
            this.panel1.Controls.Add(this.Input_pwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 233);
            this.panel1.TabIndex = 8;
            this.panel1.Text = "panel1";
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.White;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebar.IsMax = false;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.MinimizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(352, 26);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 14;
            this.titlebar.Text = "创建用户";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "重复密码";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(22, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*";
            // 
            // Input_repeatName
            // 
            this.Input_repeatName.Location = new System.Drawing.Point(83, 130);
            this.Input_repeatName.Name = "Input_repeatName";
            this.Input_repeatName.PasswordChar = '*';
            this.Input_repeatName.PlaceholderText = "请再次输入密码";
            this.Input_repeatName.Size = new System.Drawing.Size(225, 37);
            this.Input_repeatName.TabIndex = 10;
            // 
            // BtnInsert
            // 
            this.BtnInsert.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.BtnInsert.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(91)))), ((int)(((byte)(188)))));
            this.BtnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnInsert.Location = new System.Drawing.Point(83, 180);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(225, 40);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "注册";
            this.BtnInsert.Type = AntdUI.TTypeMini.Primary;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // Input_name
            // 
            this.Input_name.Location = new System.Drawing.Point(83, 42);
            this.Input_name.Name = "Input_name";
            this.Input_name.PlaceholderText = "请输入用户名";
            this.Input_name.Size = new System.Drawing.Size(225, 37);
            this.Input_name.TabIndex = 3;
            // 
            // Input_pwd
            // 
            this.Input_pwd.Location = new System.Drawing.Point(83, 87);
            this.Input_pwd.Name = "Input_pwd";
            this.Input_pwd.PasswordChar = '*';
            this.Input_pwd.PlaceholderText = "请输入密码";
            this.Input_pwd.Size = new System.Drawing.Size(225, 37);
            this.Input_pwd.TabIndex = 4;
            // 
            // DlgCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 233);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建用户";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Label label3;
        private AntdUI.Input Input_repeatName;
        private AntdUI.Button BtnInsert;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input Input_name;
        private AntdUI.Input Input_pwd;
        private AntdUI.Label label4;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
        private AntdUI.WindowBar titlebar;
    }
}