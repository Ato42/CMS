namespace GS.CMS
{
    partial class ConferenceApplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceApplyForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnsure = new System.Windows.Forms.Button();
            this.dgvConMember = new System.Windows.Forms.DataGridView();
            this.btnAddEm = new System.Windows.Forms.Button();
            this.rdoEm = new System.Windows.Forms.RadioButton();
            this.rdoDep = new System.Windows.Forms.RadioButton();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.rdoReg = new System.Windows.Forms.RadioButton();
            this.rdoRegNo = new System.Windows.Forms.RadioButton();
            this.rdoOutCon = new System.Windows.Forms.RadioButton();
            this.rdoInCon = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cklStaff = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxRemarks = new System.Windows.Forms.RichTextBox();
            this.cmbHost = new System.Windows.Forms.ComboBox();
            this.cmbRecMan = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConMember)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(591, 469);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 25);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "取消并退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnsure
            // 
            this.btnEnsure.Location = new System.Drawing.Point(475, 469);
            this.btnEnsure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.Size = new System.Drawing.Size(110, 25);
            this.btnEnsure.TabIndex = 46;
            this.btnEnsure.Text = "确定申请";
            this.btnEnsure.UseVisualStyleBackColor = true;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // dgvConMember
            // 
            this.dgvConMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConMember.Location = new System.Drawing.Point(26, 55);
            this.dgvConMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvConMember.Name = "dgvConMember";
            this.dgvConMember.RowTemplate.Height = 23;
            this.dgvConMember.Size = new System.Drawing.Size(404, 213);
            this.dgvConMember.TabIndex = 45;
            // 
            // btnAddEm
            // 
            this.btnAddEm.Location = new System.Drawing.Point(26, 24);
            this.btnAddEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEm.Name = "btnAddEm";
            this.btnAddEm.Size = new System.Drawing.Size(101, 25);
            this.btnAddEm.TabIndex = 42;
            this.btnAddEm.Text = "添加";
            this.btnAddEm.UseVisualStyleBackColor = true;
            this.btnAddEm.Click += new System.EventHandler(this.btnAddEm_Click);
            // 
            // rdoEm
            // 
            this.rdoEm.AutoSize = true;
            this.rdoEm.Checked = true;
            this.rdoEm.Location = new System.Drawing.Point(246, 26);
            this.rdoEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoEm.Name = "rdoEm";
            this.rdoEm.Size = new System.Drawing.Size(74, 21);
            this.rdoEm.TabIndex = 40;
            this.rdoEm.TabStop = true;
            this.rdoEm.Text = "人员参会";
            this.rdoEm.UseVisualStyleBackColor = true;
            this.rdoEm.Visible = false;
            this.rdoEm.Click += new System.EventHandler(this.rdoEm_Click);
            // 
            // rdoDep
            // 
            this.rdoDep.AutoSize = true;
            this.rdoDep.Location = new System.Drawing.Point(326, 26);
            this.rdoDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoDep.Name = "rdoDep";
            this.rdoDep.Size = new System.Drawing.Size(74, 21);
            this.rdoDep.TabIndex = 41;
            this.rdoDep.Text = "部门参会";
            this.rdoDep.UseVisualStyleBackColor = true;
            this.rdoDep.Visible = false;
            this.rdoDep.CheckedChanged += new System.EventHandler(this.rdoDep_CheckedChanged);
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(104, 35);
            this.cmbTopic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(326, 25);
            this.cmbTopic.TabIndex = 26;
            // 
            // rdoReg
            // 
            this.rdoReg.AutoSize = true;
            this.rdoReg.Location = new System.Drawing.Point(3, 9);
            this.rdoReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoReg.Name = "rdoReg";
            this.rdoReg.Size = new System.Drawing.Size(50, 21);
            this.rdoReg.TabIndex = 39;
            this.rdoReg.TabStop = true;
            this.rdoReg.Text = "签到";
            this.rdoReg.UseVisualStyleBackColor = true;
            this.rdoReg.Click += new System.EventHandler(this.rdoReg_Click);
            // 
            // rdoRegNo
            // 
            this.rdoRegNo.AutoSize = true;
            this.rdoRegNo.Location = new System.Drawing.Point(106, 9);
            this.rdoRegNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoRegNo.Name = "rdoRegNo";
            this.rdoRegNo.Size = new System.Drawing.Size(62, 21);
            this.rdoRegNo.TabIndex = 38;
            this.rdoRegNo.TabStop = true;
            this.rdoRegNo.Text = "不签到";
            this.rdoRegNo.UseVisualStyleBackColor = true;
            this.rdoRegNo.Click += new System.EventHandler(this.rdoRegNo_Click);
            // 
            // rdoOutCon
            // 
            this.rdoOutCon.AutoSize = true;
            this.rdoOutCon.Location = new System.Drawing.Point(106, 9);
            this.rdoOutCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoOutCon.Name = "rdoOutCon";
            this.rdoOutCon.Size = new System.Drawing.Size(74, 21);
            this.rdoOutCon.TabIndex = 37;
            this.rdoOutCon.TabStop = true;
            this.rdoOutCon.Text = "外部会议";
            this.rdoOutCon.UseVisualStyleBackColor = true;
            this.rdoOutCon.Click += new System.EventHandler(this.rdoOutCon_Click);
            // 
            // rdoInCon
            // 
            this.rdoInCon.AutoSize = true;
            this.rdoInCon.Location = new System.Drawing.Point(3, 9);
            this.rdoInCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoInCon.Name = "rdoInCon";
            this.rdoInCon.Size = new System.Drawing.Size(74, 21);
            this.rdoInCon.TabIndex = 36;
            this.rdoInCon.TabStop = true;
            this.rdoInCon.Text = "内部会议";
            this.rdoInCon.UseVisualStyleBackColor = true;
            this.rdoInCon.CheckedChanged += new System.EventHandler(this.rdoInCon_CheckedChanged);
            this.rdoInCon.Click += new System.EventHandler(this.rdoInCon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "会议记录人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "主办单位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "会议议题";
            // 
            // cklStaff
            // 
            this.cklStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cklStaff.CheckOnClick = true;
            this.cklStaff.FormattingEnabled = true;
            this.cklStaff.Location = new System.Drawing.Point(21, 25);
            this.cklStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cklStaff.Name = "cklStaff";
            this.cklStaff.Size = new System.Drawing.Size(407, 184);
            this.cklStaff.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cklStaff);
            this.groupBox1.Location = new System.Drawing.Point(475, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(448, 232);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会议使用资源";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rdoEm);
            this.groupBox4.Controls.Add(this.dgvConMember);
            this.groupBox4.Controls.Add(this.rdoDep);
            this.groupBox4.Controls.Add(this.btnAddEm);
            this.groupBox4.Location = new System.Drawing.Point(12, 252);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(457, 276);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加与会人员";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "请选择参会类型：";
            this.label4.Visible = false;
            // 
            // rtxRemarks
            // 
            this.rtxRemarks.Location = new System.Drawing.Point(21, 23);
            this.rtxRemarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxRemarks.Name = "rtxRemarks";
            this.rtxRemarks.Size = new System.Drawing.Size(407, 180);
            this.rtxRemarks.TabIndex = 52;
            this.rtxRemarks.Text = "";
            // 
            // cmbHost
            // 
            this.cmbHost.FormattingEnabled = true;
            this.cmbHost.Location = new System.Drawing.Point(104, 68);
            this.cmbHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHost.Name = "cmbHost";
            this.cmbHost.Size = new System.Drawing.Size(156, 25);
            this.cmbHost.TabIndex = 55;
            // 
            // cmbRecMan
            // 
            this.cmbRecMan.FormattingEnabled = true;
            this.cmbRecMan.Location = new System.Drawing.Point(104, 101);
            this.cmbRecMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRecMan.Name = "cmbRecMan";
            this.cmbRecMan.Size = new System.Drawing.Size(156, 25);
            this.cmbRecMan.TabIndex = 57;
            this.cmbRecMan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbRecMan_MouseClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.rtxRemarks);
            this.groupBox5.Location = new System.Drawing.Point(475, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 210);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "备注";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbTopic);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbHost);
            this.groupBox2.Controls.Add(this.cmbRecMan);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 233);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本信息";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoReg);
            this.panel2.Controls.Add(this.rdoRegNo);
            this.panel2.Location = new System.Drawing.Point(140, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 34);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoOutCon);
            this.panel1.Controls.Add(this.rdoInCon);
            this.panel1.Location = new System.Drawing.Point(140, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "请选择是否签到：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "请选择会议类型：";
            // 
            // ConferenceApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnsure);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConferenceApplyForm";
            this.Text = "申请会议";
            this.Load += new System.EventHandler(this.ConferenceApplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConMember)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnsure;
        private System.Windows.Forms.DataGridView dgvConMember;
        private System.Windows.Forms.Button btnAddEm;
        private System.Windows.Forms.RadioButton rdoEm;
        private System.Windows.Forms.RadioButton rdoDep;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.RadioButton rdoReg;
        private System.Windows.Forms.RadioButton rdoRegNo;
        private System.Windows.Forms.RadioButton rdoOutCon;
        private System.Windows.Forms.RadioButton rdoInCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cklStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtxRemarks;
        private System.Windows.Forms.ComboBox cmbHost;
        private System.Windows.Forms.ComboBox cmbRecMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

    }
}