namespace WareHouseMgClient
{
    partial class MainForm
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
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem4 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem6 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main_bar = new AntdUI.WindowBar();
            this.menus = new AntdUI.Menu();
            this.panel = new AntdUI.Panel();
            this.SuspendLayout();
            // 
            // main_bar
            // 
            this.main_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_bar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_bar.IsMax = false;
            this.main_bar.Location = new System.Drawing.Point(0, 0);
            this.main_bar.MaximizeBox = false;
            this.main_bar.Name = "main_bar";
            this.main_bar.Size = new System.Drawing.Size(882, 34);
            this.main_bar.SubText = "";
            this.main_bar.TabIndex = 15;
            this.main_bar.Text = "仓库管理系统";
            // 
            // menus
            // 
            this.menus.AutoCollapse = true;
            this.menus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menus.Dock = System.Windows.Forms.DockStyle.Top;
            this.menus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menus.Indent = true;
            menuItem1.Icon = global::WareHouseMgClient.Properties.Resources.系统设置;
            menuItem1.PARENTITEM = null;
            menuItem2.Icon = global::WareHouseMgClient.Properties.Resources.添加用户1;
            menuItem2.PARENTITEM = null;
            menuItem2.Text = "添加用户";
            menuItem3.Icon = global::WareHouseMgClient.Properties.Resources.修改密码1;
            menuItem3.PARENTITEM = null;
            menuItem3.Text = "修改密码";
            menuItem4.Icon = global::WareHouseMgClient.Properties.Resources.用户管理1;
            menuItem4.PARENTITEM = null;
            menuItem4.Text = "管理用户";
            menuItem5.Icon = global::WareHouseMgClient.Properties.Resources.退出1;
            menuItem5.PARENTITEM = null;
            menuItem5.Text = "退出";
            menuItem1.Sub.Add(menuItem2);
            menuItem1.Sub.Add(menuItem3);
            menuItem1.Sub.Add(menuItem4);
            menuItem1.Sub.Add(menuItem5);
            menuItem1.Text = "系统管理";
            menuItem6.Icon = global::WareHouseMgClient.Properties.Resources.入库管理;
            menuItem6.PARENTITEM = null;
            menuItem6.Text = "入库管理";
            menuItem7.Icon = global::WareHouseMgClient.Properties.Resources.出库管理;
            menuItem7.PARENTITEM = null;
            menuItem7.Text = "出库管理";
            menuItem8.Icon = global::WareHouseMgClient.Properties.Resources.仓库管理;
            menuItem8.PARENTITEM = null;
            menuItem8.Text = "仓库管理";
            menuItem9.Icon = global::WareHouseMgClient.Properties.Resources.帮助;
            menuItem9.PARENTITEM = null;
            menuItem9.Text = "帮助";
            this.menus.Items.Add(menuItem1);
            this.menus.Items.Add(menuItem6);
            this.menus.Items.Add(menuItem7);
            this.menus.Items.Add(menuItem8);
            this.menus.Items.Add(menuItem9);
            this.menus.Location = new System.Drawing.Point(0, 34);
            this.menus.Mode = AntdUI.TMenuMode.Horizontal;
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(882, 46);
            this.menus.TabIndex = 16;
            this.menus.Text = "menu1";
            this.menus.SelectChanged += new AntdUI.SelectEventHandler(this.menus_SelectChanged);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 80);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(882, 406);
            this.panel.TabIndex = 17;
            this.panel.Text = "panel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 486);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menus);
            this.Controls.Add(this.main_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库管理系统";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.WindowBar main_bar;
        private AntdUI.Menu menus;
        private AntdUI.Panel panel;
    }
}