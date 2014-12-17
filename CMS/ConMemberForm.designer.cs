namespace GS.CMS
{
    partial class ConMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConMemberForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddConInEXCEL = new System.Windows.Forms.Button();
            this.btnAddConMember = new System.Windows.Forms.Button();
            this.dgvOutConMember = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddInConInEXCEL = new System.Windows.Forms.Button();
            this.dgvInConMember = new System.Windows.Forms.DataGridView();
            this.ColumnEmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmPermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmDuties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConDuties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConRegister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutConMember)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInConMember)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddConInEXCEL);
            this.tabPage1.Controls.Add(this.btnAddConMember);
            this.tabPage1.Controls.Add(this.dgvOutConMember);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(929, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "外部人员";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddConInEXCEL
            // 
            this.btnAddConInEXCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddConInEXCEL.Location = new System.Drawing.Point(823, 8);
            this.btnAddConInEXCEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddConInEXCEL.Name = "btnAddConInEXCEL";
            this.btnAddConInEXCEL.Size = new System.Drawing.Size(100, 25);
            this.btnAddConInEXCEL.TabIndex = 35;
            this.btnAddConInEXCEL.Text = "EXCEL导入";
            this.btnAddConInEXCEL.UseVisualStyleBackColor = true;
            this.btnAddConInEXCEL.Click += new System.EventHandler(this.btnAddConInEXCEL_Click);
            // 
            // btnAddConMember
            // 
            this.btnAddConMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddConMember.Location = new System.Drawing.Point(717, 8);
            this.btnAddConMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddConMember.Name = "btnAddConMember";
            this.btnAddConMember.Size = new System.Drawing.Size(100, 25);
            this.btnAddConMember.TabIndex = 34;
            this.btnAddConMember.Text = "手动添加";
            this.btnAddConMember.UseVisualStyleBackColor = true;
            this.btnAddConMember.Click += new System.EventHandler(this.btnAddConMember_Click);
            // 
            // dgvOutConMember
            // 
            this.dgvOutConMember.AllowUserToAddRows = false;
            this.dgvOutConMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutConMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutConMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConId,
            this.ColumnConName,
            this.ColumnConSex,
            this.ColumnConDuties,
            this.ColumnConPhone,
            this.ColumnConEmail,
            this.ColumnConCompany,
            this.ColumnConRegister});
            this.dgvOutConMember.Location = new System.Drawing.Point(6, 41);
            this.dgvOutConMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOutConMember.Name = "dgvOutConMember";
            this.dgvOutConMember.RowTemplate.Height = 23;
            this.dgvOutConMember.Size = new System.Drawing.Size(917, 354);
            this.dgvOutConMember.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddInConInEXCEL);
            this.tabPage2.Controls.Add(this.dgvInConMember);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(929, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "内部人员";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddInConInEXCEL
            // 
            this.btnAddInConInEXCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInConInEXCEL.Location = new System.Drawing.Point(830, -156);
            this.btnAddInConInEXCEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddInConInEXCEL.Name = "btnAddInConInEXCEL";
            this.btnAddInConInEXCEL.Size = new System.Drawing.Size(100, 33);
            this.btnAddInConInEXCEL.TabIndex = 36;
            this.btnAddInConInEXCEL.Text = "EXCEL导入";
            this.btnAddInConInEXCEL.UseVisualStyleBackColor = true;
            this.btnAddInConInEXCEL.Click += new System.EventHandler(this.btnAddInConInEXCEL_Click);
            // 
            // dgvInConMember
            // 
            this.dgvInConMember.AllowUserToAddRows = false;
            this.dgvInConMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInConMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInConMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmID,
            this.ColumnEmName,
            this.ColumnEmPermission,
            this.ColumnEmSex,
            this.ColumnEmDepart,
            this.ColumnEmPhone,
            this.ColumnEmEmail,
            this.ColumnEmCompany,
            this.ColumnEmDuties});
            this.dgvInConMember.Location = new System.Drawing.Point(6, 8);
            this.dgvInConMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInConMember.Name = "dgvInConMember";
            this.dgvInConMember.RowTemplate.Height = 23;
            this.dgvInConMember.Size = new System.Drawing.Size(917, 412);
            this.dgvInConMember.TabIndex = 34;
            // 
            // ColumnEmID
            // 
            this.ColumnEmID.HeaderText = "员工ID";
            this.ColumnEmID.Name = "ColumnEmID";
            this.ColumnEmID.Width = 90;
            // 
            // ColumnEmName
            // 
            this.ColumnEmName.HeaderText = "员工姓名";
            this.ColumnEmName.Name = "ColumnEmName";
            this.ColumnEmName.Width = 90;
            // 
            // ColumnEmPermission
            // 
            this.ColumnEmPermission.HeaderText = "员工权限";
            this.ColumnEmPermission.Name = "ColumnEmPermission";
            this.ColumnEmPermission.Width = 90;
            // 
            // ColumnEmSex
            // 
            this.ColumnEmSex.HeaderText = "员工性别";
            this.ColumnEmSex.Name = "ColumnEmSex";
            this.ColumnEmSex.Width = 90;
            // 
            // ColumnEmDepart
            // 
            this.ColumnEmDepart.HeaderText = "员工部门";
            this.ColumnEmDepart.Name = "ColumnEmDepart";
            // 
            // ColumnEmPhone
            // 
            this.ColumnEmPhone.HeaderText = "员工电话";
            this.ColumnEmPhone.Name = "ColumnEmPhone";
            this.ColumnEmPhone.Width = 90;
            // 
            // ColumnEmEmail
            // 
            this.ColumnEmEmail.HeaderText = "员工Email";
            this.ColumnEmEmail.Name = "ColumnEmEmail";
            this.ColumnEmEmail.Width = 90;
            // 
            // ColumnEmCompany
            // 
            this.ColumnEmCompany.HeaderText = "员工公司";
            this.ColumnEmCompany.Name = "ColumnEmCompany";
            this.ColumnEmCompany.Width = 90;
            // 
            // ColumnEmDuties
            // 
            this.ColumnEmDuties.HeaderText = "员工职务";
            this.ColumnEmDuties.Name = "ColumnEmDuties";
            this.ColumnEmDuties.Width = 90;
            // 
            // ColumnConId
            // 
            this.ColumnConId.HeaderText = "会议ID";
            this.ColumnConId.Name = "ColumnConId";
            // 
            // ColumnConName
            // 
            this.ColumnConName.HeaderText = "外部人员姓名";
            this.ColumnConName.Name = "ColumnConName";
            this.ColumnConName.Width = 110;
            // 
            // ColumnConSex
            // 
            this.ColumnConSex.HeaderText = "外部人员性别";
            this.ColumnConSex.Name = "ColumnConSex";
            this.ColumnConSex.Width = 110;
            // 
            // ColumnConDuties
            // 
            this.ColumnConDuties.HeaderText = "外部人员职务";
            this.ColumnConDuties.Name = "ColumnConDuties";
            this.ColumnConDuties.Width = 110;
            // 
            // ColumnConPhone
            // 
            this.ColumnConPhone.HeaderText = "外部人员电话";
            this.ColumnConPhone.Name = "ColumnConPhone";
            this.ColumnConPhone.Width = 110;
            // 
            // ColumnConEmail
            // 
            this.ColumnConEmail.HeaderText = "外部人员Email";
            this.ColumnConEmail.Name = "ColumnConEmail";
            this.ColumnConEmail.Width = 110;
            // 
            // ColumnConCompany
            // 
            this.ColumnConCompany.HeaderText = "外部人员公司";
            this.ColumnConCompany.Name = "ColumnConCompany";
            this.ColumnConCompany.Width = 110;
            // 
            // ColumnConRegister
            // 
            this.ColumnConRegister.HeaderText = "签到状态";
            this.ColumnConRegister.Name = "ColumnConRegister";
            // 
            // ConMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 484);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(974, 522);
            this.Name = "ConMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "与会人员";
            this.Load += new System.EventHandler(this.ConMemberForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutConMember)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInConMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddConMember;
        private System.Windows.Forms.DataGridView dgvOutConMember;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvInConMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmDuties;
        private System.Windows.Forms.Button btnAddConInEXCEL;
        private System.Windows.Forms.Button btnAddInConInEXCEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConDuties;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConRegister;

    }
}