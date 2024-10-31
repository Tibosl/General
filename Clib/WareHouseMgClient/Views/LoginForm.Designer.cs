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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.Input_name = new AntdUI.Input();
            this.Input_pwd = new AntdUI.Input();
            this.cbx_pwd = new AntdUI.Checkbox();
            this.cbx_auto = new AntdUI.Checkbox();
            this.panel1 = new AntdUI.Panel();
            this.titlebar = new AntdUI.WindowBar();
            this.BtnLogin = new AntdUI.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码";
            // 
            // Input_name
            // 
            this.Input_name.Location = new System.Drawing.Point(83, 41);
            this.Input_name.Name = "Input_name";
            this.Input_name.PlaceholderText = "请输入用户名";
            this.Input_name.Size = new System.Drawing.Size(221, 37);
            this.Input_name.TabIndex = 3;
            // 
            // Input_pwd
            // 
            this.Input_pwd.Location = new System.Drawing.Point(83, 86);
            this.Input_pwd.Name = "Input_pwd";
            this.Input_pwd.PasswordChar = '*';
            this.Input_pwd.PlaceholderText = "请输入密码";
            this.Input_pwd.Size = new System.Drawing.Size(221, 37);
            this.Input_pwd.TabIndex = 4;
            // 
            // cbx_pwd
            // 
            this.cbx_pwd.AutoCheck = true;
            this.cbx_pwd.BackColor = System.Drawing.Color.White;
            this.cbx_pwd.Location = new System.Drawing.Point(83, 129);
            this.cbx_pwd.Name = "cbx_pwd";
            this.cbx_pwd.Size = new System.Drawing.Size(75, 23);
            this.cbx_pwd.TabIndex = 5;
            this.cbx_pwd.Text = "记住密码";
            // 
            // cbx_auto
            // 
            this.cbx_auto.AutoCheck = true;
            this.cbx_auto.BackColor = System.Drawing.Color.White;
            this.cbx_auto.Location = new System.Drawing.Point(229, 129);
            this.cbx_auto.Name = "cbx_auto";
            this.cbx_auto.Size = new System.Drawing.Size(75, 23);
            this.cbx_auto.TabIndex = 6;
            this.cbx_auto.Text = "自动登录";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_auto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_pwd);
            this.panel1.Controls.Add(this.Input_name);
            this.panel1.Controls.Add(this.Input_pwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 205);
            this.panel1.TabIndex = 7;
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
            this.titlebar.Size = new System.Drawing.Size(341, 26);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 15;
            this.titlebar.Text = "登录";
            // 
            // BtnLogin
            // 
            this.BtnLogin.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.BtnLogin.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(91)))), ((int)(((byte)(188)))));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLogin.Location = new System.Drawing.Point(83, 158);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(221, 35);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.Type = AntdUI.TTypeMini.Primary;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 205);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.panel1.ResumeLayout(false);
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
        private AntdUI.Button BtnLogin;
        private AntdUI.WindowBar titlebar;
    }
}

