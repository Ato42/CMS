namespace GS.CMS
{
    partial class SendFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendFileForm));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileTansfersContainer = new CSharpWin.FileTansfersContainer();
            this.labCon = new System.Windows.Forms.Label();
            this.cmbCon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fileTansfersContainer);
            this.panel2.Location = new System.Drawing.Point(6, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 272);
            this.panel2.TabIndex = 16;
            // 
            // fileTansfersContainer
            // 
            this.fileTansfersContainer.AutoScroll = true;
            this.fileTansfersContainer.BackColor = System.Drawing.Color.Transparent;
            this.fileTansfersContainer.BackgroundImage = global::GS.Properties.Resources.dec;
            this.fileTansfersContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileTansfersContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.fileTansfersContainer.Location = new System.Drawing.Point(0, 0);
            this.fileTansfersContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileTansfersContainer.Name = "fileTansfersContainer";
            this.fileTansfersContainer.Size = new System.Drawing.Size(268, 272);
            this.fileTansfersContainer.TabIndex = 0;
            // 
            // labCon
            // 
            this.labCon.AutoSize = true;
            this.labCon.BackColor = System.Drawing.Color.Transparent;
            this.labCon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labCon.Location = new System.Drawing.Point(9, 324);
            this.labCon.Name = "labCon";
            this.labCon.Size = new System.Drawing.Size(32, 17);
            this.labCon.TabIndex = 1;
            this.labCon.Text = "会议";
            // 
            // cmbCon
            // 
            this.cmbCon.FormattingEnabled = true;
            this.cmbCon.Location = new System.Drawing.Point(47, 321);
            this.cmbCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCon.Name = "cmbCon";
            this.cmbCon.Size = new System.Drawing.Size(153, 25);
            this.cmbCon.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 302);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送列表";
            // 
            // SendFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(305, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labCon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCon);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SendFileForm";
            this.Text = "提交文档";
            this.Load += new System.EventHandler(this.SendFileForm_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private CSharpWin.FileTansfersContainer fileTansfersContainer;
        private System.Windows.Forms.Label labCon;
        private System.Windows.Forms.ComboBox cmbCon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

