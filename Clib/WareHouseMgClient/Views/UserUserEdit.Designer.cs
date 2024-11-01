namespace WareHouseMgClient.Views
{
    partial class UserUserEdit
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new AntdUI.Panel();
            this.selectSex = new AntdUI.Select();
            this.label5 = new AntdUI.Label();
            this.input_info = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.button_cancel = new AntdUI.Button();
            this.input_pwd = new AntdUI.Input();
            this.button_ok = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.input_age = new AntdUI.InputNumber();
            this.label1 = new AntdUI.Label();
            this.input_name = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectSex);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.input_info);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.input_pwd);
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.input_age);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.input_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Shadow = 6;
            this.panel1.Size = new System.Drawing.Size(500, 386);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // selectSex
            // 
            this.selectSex.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectSex.Location = new System.Drawing.Point(18, 290);
            this.selectSex.Name = "selectSex";
            this.selectSex.Radius = 2;
            this.selectSex.Size = new System.Drawing.Size(464, 38);
            this.selectSex.TabIndex = 25;
            this.selectSex.Text = "select1";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(18, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(464, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "性别";
            // 
            // input_info
            // 
            this.input_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_info.Location = new System.Drawing.Point(18, 228);
            this.input_info.Name = "input_info";
            this.input_info.Radius = 3;
            this.input_info.Size = new System.Drawing.Size(464, 38);
            this.input_info.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "信息";
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.BorderWidth = 1F;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.button_cancel.Ghost = true;
            this.button_cancel.Location = new System.Drawing.Point(407, 334);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 38);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "取消";
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // input_pwd
            // 
            this.input_pwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_pwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_pwd.Location = new System.Drawing.Point(18, 166);
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.Radius = 3;
            this.input_pwd.Size = new System.Drawing.Size(464, 38);
            this.input_pwd.TabIndex = 20;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(328, 334);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 38);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "确定";
            this.button_ok.Type = AntdUI.TTypeMini.Primary;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "密码";
            // 
            // input_age
            // 
            this.input_age.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_age.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_age.Location = new System.Drawing.Point(18, 104);
            this.input_age.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.input_age.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_age.Name = "input_age";
            this.input_age.Radius = 3;
            this.input_age.Size = new System.Drawing.Size(464, 38);
            this.input_age.TabIndex = 18;
            this.input_age.Text = "0";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "年龄";
            // 
            // input_name
            // 
            this.input_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_name.Location = new System.Drawing.Point(18, 42);
            this.input_name.Name = "input_name";
            this.input_name.Radius = 3;
            this.input_name.Size = new System.Drawing.Size(464, 38);
            this.input_name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "姓名";
            // 
            // DlgUserEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Name = "DlgUserEdit";
            this.Size = new System.Drawing.Size(500, 386);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Input input_pwd;
        private AntdUI.Label label2;
        private AntdUI.InputNumber input_age;
        private AntdUI.Label label1;
        private AntdUI.Input input_name;
        private AntdUI.Label label3;
        private AntdUI.Input input_info;
        private AntdUI.Label label4;
        private AntdUI.Button button_cancel;
        private AntdUI.Button button_ok;
        private AntdUI.Label label5;
        private AntdUI.Select selectSex;
    }
}