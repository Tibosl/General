namespace WareHouseMgClient.Views
{
    partial class DlgModifyPwd
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
            this.BtnLogin = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.Input_old_pwd = new AntdUI.Input();
            this.titlebar = new AntdUI.WindowBar();
            this.label1 = new AntdUI.Label();
            this.Input_new_pwd = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.Input_repeat_pwd = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.BtnShowpw1 = new AntdUI.Button();
            this.BtnShowpw2 = new AntdUI.Button();
            this.BtnShowpw3 = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.BtnLogin.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(91)))), ((int)(((byte)(188)))));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLogin.Location = new System.Drawing.Point(74, 162);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(221, 35);
            this.BtnLogin.TabIndex = 15;
            this.BtnLogin.Text = "确定";
            this.BtnLogin.Type = AntdUI.TTypeMini.Primary;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "旧密码";
            // 
            // Input_old_pwd
            // 
            this.Input_old_pwd.Location = new System.Drawing.Point(74, 32);
            this.Input_old_pwd.Name = "Input_old_pwd";
            this.Input_old_pwd.PasswordChar = '*';
            this.Input_old_pwd.PlaceholderText = "请输入旧密码";
            this.Input_old_pwd.Size = new System.Drawing.Size(221, 37);
            this.Input_old_pwd.TabIndex = 12;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.White;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebar.Icon = global::WareHouseMgClient.Properties.Resources.修改密码1;
            this.titlebar.IsMax = false;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.MinimizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(336, 26);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 16;
            this.titlebar.Text = "修改密码";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "新密码";
            // 
            // Input_new_pwd
            // 
            this.Input_new_pwd.Location = new System.Drawing.Point(74, 75);
            this.Input_new_pwd.Name = "Input_new_pwd";
            this.Input_new_pwd.PasswordChar = '*';
            this.Input_new_pwd.PlaceholderText = "请输入新密码";
            this.Input_new_pwd.Size = new System.Drawing.Size(221, 37);
            this.Input_new_pwd.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "重复密码";
            // 
            // Input_repeat_pwd
            // 
            this.Input_repeat_pwd.Location = new System.Drawing.Point(74, 118);
            this.Input_repeat_pwd.Name = "Input_repeat_pwd";
            this.Input_repeat_pwd.PasswordChar = '*';
            this.Input_repeat_pwd.PlaceholderText = "请再次输入新密码";
            this.Input_repeat_pwd.Size = new System.Drawing.Size(221, 37);
            this.Input_repeat_pwd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(22, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(14, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // BtnShowpw1
            // 
            this.BtnShowpw1.Icon = global::WareHouseMgClient.Properties.Resources.显示密码;
            this.BtnShowpw1.Location = new System.Drawing.Point(295, 37);
            this.BtnShowpw1.Name = "BtnShowpw1";
            this.BtnShowpw1.Size = new System.Drawing.Size(30, 30);
            this.BtnShowpw1.TabIndex = 24;
            this.BtnShowpw1.Click += new System.EventHandler(this.BtnShowpw1_Click);
            // 
            // BtnShowpw2
            // 
            this.BtnShowpw2.Icon = global::WareHouseMgClient.Properties.Resources.显示密码;
            this.BtnShowpw2.Location = new System.Drawing.Point(295, 79);
            this.BtnShowpw2.Name = "BtnShowpw2";
            this.BtnShowpw2.Size = new System.Drawing.Size(30, 30);
            this.BtnShowpw2.TabIndex = 25;
            this.BtnShowpw2.Click += new System.EventHandler(this.BtnShowpw2_Click);
            // 
            // BtnShowpw3
            // 
            this.BtnShowpw3.Icon = global::WareHouseMgClient.Properties.Resources.显示密码;
            this.BtnShowpw3.Location = new System.Drawing.Point(295, 121);
            this.BtnShowpw3.Name = "BtnShowpw3";
            this.BtnShowpw3.Size = new System.Drawing.Size(30, 30);
            this.BtnShowpw3.TabIndex = 26;
            this.BtnShowpw3.Click += new System.EventHandler(this.BtnShowpw3_Click);
            // 
            // DlgModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 209);
            this.Controls.Add(this.BtnShowpw3);
            this.Controls.Add(this.BtnShowpw2);
            this.Controls.Add(this.BtnShowpw1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_repeat_pwd);
            this.Controls.Add(this.Input_new_pwd);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.Input_old_pwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DlgModifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Button BtnLogin;
        private AntdUI.Label label2;
        private AntdUI.Input Input_old_pwd;
        private AntdUI.WindowBar titlebar;
        private AntdUI.Label label1;
        private AntdUI.Input Input_new_pwd;
        private AntdUI.Label label3;
        private AntdUI.Input Input_repeat_pwd;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Label label6;
        private AntdUI.Button BtnShowpw1;
        private AntdUI.Button BtnShowpw2;
        private AntdUI.Button BtnShowpw3;
    }
}