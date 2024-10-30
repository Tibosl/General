namespace WareHouseMgClient
{
    partial class LoginForm
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
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.Input_name = new AntdUI.Input();
            this.Input_pwd = new AntdUI.Input();
            this.cbx_pwd = new AntdUI.Checkbox();
            this.cbx_auto = new AntdUI.Checkbox();
            this.panel1 = new AntdUI.Panel();
            this.BtnLogin = new AntdUI.Button();
            this.lb_account = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码";
            // 
            // Input_name
            // 
            this.Input_name.Location = new System.Drawing.Point(83, 13);
            this.Input_name.Name = "Input_name";
            this.Input_name.Size = new System.Drawing.Size(225, 37);
            this.Input_name.TabIndex = 3;
            // 
            // Input_pwd
            // 
            this.Input_pwd.Location = new System.Drawing.Point(83, 58);
            this.Input_pwd.Name = "Input_pwd";
            this.Input_pwd.PasswordChar = '*';
            this.Input_pwd.Size = new System.Drawing.Size(225, 37);
            this.Input_pwd.TabIndex = 4;
            // 
            // cbx_pwd
            // 
            this.cbx_pwd.AutoCheck = true;
            this.cbx_pwd.BackColor = System.Drawing.Color.White;
            this.cbx_pwd.Location = new System.Drawing.Point(83, 101);
            this.cbx_pwd.Name = "cbx_pwd";
            this.cbx_pwd.Size = new System.Drawing.Size(75, 23);
            this.cbx_pwd.TabIndex = 5;
            this.cbx_pwd.Text = "记住密码";
            // 
            // cbx_auto
            // 
            this.cbx_auto.AutoCheck = true;
            this.cbx_auto.BackColor = System.Drawing.Color.White;
            this.cbx_auto.Location = new System.Drawing.Point(164, 101);
            this.cbx_auto.Name = "cbx_auto";
            this.cbx_auto.Size = new System.Drawing.Size(75, 23);
            this.cbx_auto.TabIndex = 6;
            this.cbx_auto.Text = "自动登录";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.lb_account);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_auto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_pwd);
            this.panel1.Controls.Add(this.Input_name);
            this.panel1.Controls.Add(this.Input_pwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 173);
            this.panel1.TabIndex = 7;
            this.panel1.Text = "panel1";
            // 
            // BtnLogin
            // 
            this.BtnLogin.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.BtnLogin.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(91)))), ((int)(((byte)(188)))));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLogin.Location = new System.Drawing.Point(83, 130);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(221, 35);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.BackColor = System.Drawing.Color.White;
            this.lb_account.Location = new System.Drawing.Point(245, 106);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(59, 12);
            this.lb_account.TabIndex = 7;
            this.lb_account.TabStop = true;
            this.lb_account.Text = "没有账号?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 173);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input Input_name;
        private AntdUI.Input Input_pwd;
        private AntdUI.Checkbox cbx_pwd;
        private AntdUI.Checkbox cbx_auto;
        private AntdUI.Panel panel1;
        private System.Windows.Forms.LinkLabel lb_account;
        private AntdUI.Button BtnLogin;
    }
}

