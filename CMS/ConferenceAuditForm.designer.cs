namespace GS.CMS
{
    partial class ConferenceAuditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceAuditForm));
            this.tabAudit = new System.Windows.Forms.TabControl();
            this.PageNotAudit = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtxRemarks1 = new System.Windows.Forms.RichTextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnNotPass = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstStaff1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblStaffMan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRecMan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConHost = new System.Windows.Forms.Label();
            this.lblConPlace = new System.Windows.Forms.Label();
            this.lblConId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotAudit = new System.Windows.Forms.DataGridView();
            this.ColumnConId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageAudit = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rtxRemarks2 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstStaff2 = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbHost = new System.Windows.Forms.ComboBox();
            this.cmbStaffMan = new System.Windows.Forms.ComboBox();
            this.cmbRecMan = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtConId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            this.ColumnConId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAudit.SuspendLayout();
            this.PageNotAudit.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotAudit)).BeginInit();
            this.PageAudit.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAudit
            // 
            this.tabAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAudit.Controls.Add(this.PageNotAudit);
            this.tabAudit.Controls.Add(this.PageAudit);
            this.tabAudit.Location = new System.Drawing.Point(12, 13);
            this.tabAudit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAudit.Name = "tabAudit";
            this.tabAudit.SelectedIndex = 0;
            this.tabAudit.Size = new System.Drawing.Size(1116, 545);
            this.tabAudit.TabIndex = 0;
            // 
            // PageNotAudit
            // 
            this.PageNotAudit.Controls.Add(this.groupBox5);
            this.PageNotAudit.Controls.Add(this.btnPass);
            this.PageNotAudit.Controls.Add(this.btnNotPass);
            this.PageNotAudit.Controls.Add(this.groupBox2);
            this.PageNotAudit.Controls.Add(this.groupBox1);
            this.PageNotAudit.Controls.Add(this.dgvNotAudit);
            this.PageNotAudit.Location = new System.Drawing.Point(4, 26);
            this.PageNotAudit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageNotAudit.Name = "PageNotAudit";
            this.PageNotAudit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageNotAudit.Size = new System.Drawing.Size(1108, 515);
            this.PageNotAudit.TabIndex = 0;
            this.PageNotAudit.Text = "待审核会议";
            this.PageNotAudit.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.rtxRemarks1);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(493, 278);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(374, 229);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "备注";
            // 
            // rtxRemarks1
            // 
            this.rtxRemarks1.Location = new System.Drawing.Point(6, 24);
            this.rtxRemarks1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxRemarks1.Name = "rtxRemarks1";
            this.rtxRemarks1.Size = new System.Drawing.Size(362, 192);
            this.rtxRemarks1.TabIndex = 2;
            this.rtxRemarks1.Text = "";
            // 
            // btnPass
            // 
            this.btnPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPass.Location = new System.Drawing.Point(671, 245);
            this.btnPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(87, 25);
            this.btnPass.TabIndex = 4;
            this.btnPass.Text = "通过";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnNotPass
            // 
            this.btnNotPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotPass.Location = new System.Drawing.Point(764, 245);
            this.btnNotPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotPass.Name = "btnNotPass";
            this.btnNotPass.Size = new System.Drawing.Size(103, 25);
            this.btnNotPass.TabIndex = 3;
            this.btnNotPass.Text = "不予通过";
            this.btnNotPass.UseVisualStyleBackColor = true;
            this.btnNotPass.Click += new System.EventHandler(this.btnNotPass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstStaff1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(873, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(229, 499);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "资源使用清单";
            // 
            // lstStaff1
            // 
            this.lstStaff1.FormattingEnabled = true;
            this.lstStaff1.ItemHeight = 17;
            this.lstStaff1.Location = new System.Drawing.Point(6, 23);
            this.lstStaff1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstStaff1.Name = "lstStaff1";
            this.lstStaff1.Size = new System.Drawing.Size(217, 463);
            this.lstStaff1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lblStaffMan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblRecMan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblReg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblConHost);
            this.groupBox1.Controls.Add(this.lblConPlace);
            this.groupBox1.Controls.Add(this.lblConId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(493, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(374, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会议详细信息";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(102, 174);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 17);
            this.lblType.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "会议类型：";
            // 
            // lblStaffMan
            // 
            this.lblStaffMan.AutoSize = true;
            this.lblStaffMan.Location = new System.Drawing.Point(268, 132);
            this.lblStaffMan.Name = "lblStaffMan";
            this.lblStaffMan.Size = new System.Drawing.Size(0, 17);
            this.lblStaffMan.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "执行人：";
            // 
            // lblRecMan
            // 
            this.lblRecMan.AutoSize = true;
            this.lblRecMan.Location = new System.Drawing.Point(265, 91);
            this.lblRecMan.Name = "lblRecMan";
            this.lblRecMan.Size = new System.Drawing.Size(0, 17);
            this.lblRecMan.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "记录人：";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(279, 44);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(0, 17);
            this.lblReg.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "是否签到：";
            // 
            // lblConHost
            // 
            this.lblConHost.AutoSize = true;
            this.lblConHost.Location = new System.Drawing.Point(102, 132);
            this.lblConHost.Name = "lblConHost";
            this.lblConHost.Size = new System.Drawing.Size(0, 17);
            this.lblConHost.TabIndex = 1;
            // 
            // lblConPlace
            // 
            this.lblConPlace.AutoSize = true;
            this.lblConPlace.Location = new System.Drawing.Point(102, 91);
            this.lblConPlace.Name = "lblConPlace";
            this.lblConPlace.Size = new System.Drawing.Size(0, 17);
            this.lblConPlace.TabIndex = 1;
            // 
            // lblConId
            // 
            this.lblConId.AutoSize = true;
            this.lblConId.Location = new System.Drawing.Point(102, 44);
            this.lblConId.Name = "lblConId";
            this.lblConId.Size = new System.Drawing.Size(0, 17);
            this.lblConId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "主办单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "会议地点：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "会议编号：";
            // 
            // dgvNotAudit
            // 
            this.dgvNotAudit.AllowUserToAddRows = false;
            this.dgvNotAudit.AllowUserToDeleteRows = false;
            this.dgvNotAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConId1,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNotAudit.Location = new System.Drawing.Point(7, 8);
            this.dgvNotAudit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNotAudit.Name = "dgvNotAudit";
            this.dgvNotAudit.ReadOnly = true;
            this.dgvNotAudit.RowTemplate.Height = 23;
            this.dgvNotAudit.Size = new System.Drawing.Size(480, 499);
            this.dgvNotAudit.TabIndex = 0;
            this.dgvNotAudit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotAudit_CellContentClick_1);
            this.dgvNotAudit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotAudit_CellContentClick_1);
            // 
            // ColumnConId1
            // 
            this.ColumnConId1.HeaderText = "会议编号";
            this.ColumnConId1.Name = "ColumnConId1";
            this.ColumnConId1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ConName";
            this.Column1.HeaderText = "会议议题";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ConStartTime";
            this.Column2.HeaderText = "会议开始时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ConSubMen";
            this.Column3.HeaderText = "申请人";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // PageAudit
            // 
            this.PageAudit.Controls.Add(this.groupBox6);
            this.PageAudit.Controls.Add(this.groupBox4);
            this.PageAudit.Controls.Add(this.btnDel);
            this.PageAudit.Controls.Add(this.btnMod);
            this.PageAudit.Controls.Add(this.groupBox3);
            this.PageAudit.Controls.Add(this.dgvAudit);
            this.PageAudit.Location = new System.Drawing.Point(4, 26);
            this.PageAudit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageAudit.Name = "PageAudit";
            this.PageAudit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageAudit.Size = new System.Drawing.Size(1108, 515);
            this.PageAudit.TabIndex = 1;
            this.PageAudit.Text = "已审核会议";
            this.PageAudit.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.rtxRemarks2);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(462, 353);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(473, 154);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "备注";
            // 
            // rtxRemarks2
            // 
            this.rtxRemarks2.Location = new System.Drawing.Point(6, 24);
            this.rtxRemarks2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxRemarks2.Name = "rtxRemarks2";
            this.rtxRemarks2.Size = new System.Drawing.Size(461, 118);
            this.rtxRemarks2.TabIndex = 13;
            this.rtxRemarks2.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lstStaff2);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(941, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(161, 499);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "资源使用清单";
            // 
            // lstStaff2
            // 
            this.lstStaff2.FormattingEnabled = true;
            this.lstStaff2.ItemHeight = 17;
            this.lstStaff2.Location = new System.Drawing.Point(6, 24);
            this.lstStaff2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstStaff2.Name = "lstStaff2";
            this.lstStaff2.Size = new System.Drawing.Size(149, 463);
            this.lstStaff2.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(818, 320);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(117, 25);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除会议";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMod.Location = new System.Drawing.Point(695, 320);
            this.btnMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(117, 25);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "保存修改";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.cmbHost);
            this.groupBox3.Controls.Add(this.cmbStaffMan);
            this.groupBox3.Controls.Add(this.cmbRecMan);
            this.groupBox3.Controls.Add(this.dtpEnd);
            this.groupBox3.Controls.Add(this.dtpStart);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbTopic);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbPlace);
            this.groupBox3.Controls.Add(this.txtReg);
            this.groupBox3.Controls.Add(this.txtConId);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(462, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(473, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "会议详细信息";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(88, 135);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(142, 23);
            this.txtType.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "会议类型";
            // 
            // cmbHost
            // 
            this.cmbHost.FormattingEnabled = true;
            this.cmbHost.Location = new System.Drawing.Point(88, 102);
            this.cmbHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHost.Name = "cmbHost";
            this.cmbHost.Size = new System.Drawing.Size(142, 25);
            this.cmbHost.TabIndex = 21;
            // 
            // cmbStaffMan
            // 
            this.cmbStaffMan.FormattingEnabled = true;
            this.cmbStaffMan.Location = new System.Drawing.Point(319, 99);
            this.cmbStaffMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStaffMan.Name = "cmbStaffMan";
            this.cmbStaffMan.Size = new System.Drawing.Size(132, 25);
            this.cmbStaffMan.TabIndex = 20;
            // 
            // cmbRecMan
            // 
            this.cmbRecMan.FormattingEnabled = true;
            this.cmbRecMan.Location = new System.Drawing.Point(319, 66);
            this.cmbRecMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRecMan.Name = "cmbRecMan";
            this.cmbRecMan.Size = new System.Drawing.Size(132, 25);
            this.cmbRecMan.TabIndex = 19;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(112, 249);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(287, 23);
            this.dtpEnd.TabIndex = 18;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(112, 218);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(287, 23);
            this.dtpStart.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "会议结束时间";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "会议开始时间";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(88, 181);
            this.cmbTopic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(311, 25);
            this.cmbTopic.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "会议议题";
            // 
            // cmbPlace
            // 
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(88, 69);
            this.cmbPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(142, 25);
            this.cmbPlace.TabIndex = 14;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(319, 35);
            this.txtReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(132, 23);
            this.txtReg.TabIndex = 11;
            // 
            // txtConId
            // 
            this.txtConId.Location = new System.Drawing.Point(88, 38);
            this.txtConId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConId.Name = "txtConId";
            this.txtConId.Size = new System.Drawing.Size(142, 23);
            this.txtConId.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "执行人";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "记录人";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(257, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "是否签到";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "主办单位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "会议地点";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "会议编号";
            // 
            // dgvAudit
            // 
            this.dgvAudit.AllowUserToAddRows = false;
            this.dgvAudit.AllowUserToDeleteRows = false;
            this.dgvAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConId2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvAudit.Location = new System.Drawing.Point(6, 8);
            this.dgvAudit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.ReadOnly = true;
            this.dgvAudit.RowTemplate.Height = 23;
            this.dgvAudit.Size = new System.Drawing.Size(450, 499);
            this.dgvAudit.TabIndex = 1;
            this.dgvAudit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudit_CellContentClick);
            this.dgvAudit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudit_CellContentClick);
            // 
            // ColumnConId2
            // 
            this.ColumnConId2.HeaderText = "会议编号";
            this.ColumnConId2.Name = "ColumnConId2";
            this.ColumnConId2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "会议议题";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "会议开始时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "申请人";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 85;
            // 
            // ConferenceAuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 580);
            this.Controls.Add(this.tabAudit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1156, 618);
            this.Name = "ConferenceAuditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会议审核";
            this.Load += new System.EventHandler(this.ConferenceAudit_Load);
            this.tabAudit.ResumeLayout(false);
            this.PageNotAudit.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotAudit)).EndInit();
            this.PageAudit.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAudit;
        private System.Windows.Forms.TabPage PageNotAudit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNotAudit;
        private System.Windows.Forms.TabPage PageAudit;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnNotPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConHost;
        private System.Windows.Forms.Label lblConPlace;
        private System.Windows.Forms.Label lblConId;
        private System.Windows.Forms.Label lblStaffMan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRecMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxRemarks1;
        private System.Windows.Forms.ListBox lstStaff1;
        private System.Windows.Forms.DataGridView dgvAudit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtConId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxRemarks2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.ListBox lstStaff2;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStaffMan;
        private System.Windows.Forms.ComboBox cmbRecMan;
        private System.Windows.Forms.ComboBox cmbHost;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;


    }
}