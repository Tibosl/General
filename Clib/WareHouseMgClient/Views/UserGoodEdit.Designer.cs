namespace WareHouseMgClient.Views
{
    partial class UserGoodEdit
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
            this.button_cancel = new AntdUI.Button();
            this.button_ok = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.input_goodCode = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.input_goodName = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.input_goodTime = new AntdUI.Input();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_goodTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.input_goodName);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.input_goodCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Shadow = 6;
            this.panel1.Size = new System.Drawing.Size(500, 263);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.BorderWidth = 1F;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.button_cancel.Ghost = true;
            this.button_cancel.Location = new System.Drawing.Point(404, 210);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 38);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "取消";
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(325, 210);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 38);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "确定";
            this.button_ok.Type = AntdUI.TTypeMini.Primary;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "货物名称";
            // 
            // input_goodCode
            // 
            this.input_goodCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_goodCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_goodCode.Location = new System.Drawing.Point(18, 42);
            this.input_goodCode.Name = "input_goodCode";
            this.input_goodCode.Radius = 3;
            this.input_goodCode.Size = new System.Drawing.Size(464, 38);
            this.input_goodCode.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "货物编码";
            // 
            // input_goodName
            // 
            this.input_goodName.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_goodName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_goodName.Location = new System.Drawing.Point(18, 104);
            this.input_goodName.Name = "input_goodName";
            this.input_goodName.Radius = 3;
            this.input_goodName.Size = new System.Drawing.Size(464, 38);
            this.input_goodName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "货物入库时间";
            // 
            // input_goodTime
            // 
            this.input_goodTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_goodTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_goodTime.Location = new System.Drawing.Point(18, 166);
            this.input_goodTime.Name = "input_goodTime";
            this.input_goodTime.Radius = 3;
            this.input_goodTime.Size = new System.Drawing.Size(464, 38);
            this.input_goodTime.TabIndex = 22;
            // 
            // UserGoodEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserGoodEdit";
            this.Size = new System.Drawing.Size(500, 263);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Button button_cancel;
        private AntdUI.Button button_ok;
        private AntdUI.Label label1;
        private AntdUI.Input input_goodCode;
        private AntdUI.Label label3;
        private AntdUI.Input input_goodTime;
        private AntdUI.Label label2;
        private AntdUI.Input input_goodName;
    }
}
