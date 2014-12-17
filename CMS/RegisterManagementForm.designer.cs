namespace GS.CMS
{
    partial class RegisterManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterManagementForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOutSave = new System.Windows.Forms.Button();
            this.dgvOutRegister = new System.Windows.Forms.DataGridView();
            this.ColumnConRegister = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnConId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConDuties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInSave = new System.Windows.Forms.Button();
            this.dgvInRegister = new System.Windows.Forms.DataGridView();
            this.ColumnInConRegister = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnConId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmDuties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutRegister)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOutSave);
            this.tabPage1.Controls.Add(this.dgvOutRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(668, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "外部与会人员签到管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOutSave
            // 
            this.btnOutSave.Location = new System.Drawing.Point(577, 385);
            this.btnOutSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutSave.Name = "btnOutSave";
            this.btnOutSave.Size = new System.Drawing.Size(85, 25);
            this.btnOutSave.TabIndex = 21;
            this.btnOutSave.Text = "保存";
            this.btnOutSave.UseVisualStyleBackColor = true;
            this.btnOutSave.Click += new System.EventHandler(this.btnOutSave_Click);
            // 
            // dgvOutRegister
            // 
            this.dgvOutRegister.AllowUserToAddRows = false;
            this.dgvOutRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConRegister,
            this.ColumnConId,
            this.ColumnConName,
            this.ColumnConCompany,
            this.ColumnConDuties,
            this.ColumnConPhone});
            this.dgvOutRegister.Location = new System.Drawing.Point(6, 8);
            this.dgvOutRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOutRegister.Name = "dgvOutRegister";
            this.dgvOutRegister.RowTemplate.Height = 23;
            this.dgvOutRegister.Size = new System.Drawing.Size(656, 369);
            this.dgvOutRegister.TabIndex = 18;
            // 
            // ColumnConRegister
            // 
            this.ColumnConRegister.HeaderText = "签到状态";
            this.ColumnConRegister.Name = "ColumnConRegister";
            this.ColumnConRegister.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnConRegister.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnConRegister.Width = 80;
            // 
            // ColumnConId
            // 
            this.ColumnConId.HeaderText = "会议ID";
            this.ColumnConId.Name = "ColumnConId";
            // 
            // ColumnConName
            // 
            this.ColumnConName.HeaderText = "姓名";
            this.ColumnConName.Name = "ColumnConName";
            // 
            // ColumnConCompany
            // 
            this.ColumnConCompany.HeaderText = "公司";
            this.ColumnConCompany.Name = "ColumnConCompany";
            // 
            // ColumnConDuties
            // 
            this.ColumnConDuties.HeaderText = "职务";
            this.ColumnConDuties.Name = "ColumnConDuties";
            // 
            // ColumnConPhone
            // 
            this.ColumnConPhone.HeaderText = "电话";
            this.ColumnConPhone.Name = "ColumnConPhone";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInSave);
            this.tabPage2.Controls.Add(this.dgvInRegister);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(668, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "内部与会人员签到管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInSave
            // 
            this.btnInSave.Location = new System.Drawing.Point(577, 385);
            this.btnInSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInSave.Name = "btnInSave";
            this.btnInSave.Size = new System.Drawing.Size(85, 25);
            this.btnInSave.TabIndex = 21;
            this.btnInSave.Text = "保存";
            this.btnInSave.UseVisualStyleBackColor = true;
            this.btnInSave.Click += new System.EventHandler(this.btnInSave_Click);
            // 
            // dgvInRegister
            // 
            this.dgvInRegister.AllowUserToAddRows = false;
            this.dgvInRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInConRegister,
            this.ColumnConId2,
            this.ColumnEmId,
            this.ColumnEmName,
            this.ColumnEmDuties,
            this.ColumnEmPhone});
            this.dgvInRegister.Location = new System.Drawing.Point(6, 8);
            this.dgvInRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInRegister.Name = "dgvInRegister";
            this.dgvInRegister.RowTemplate.Height = 23;
            this.dgvInRegister.Size = new System.Drawing.Size(656, 369);
            this.dgvInRegister.TabIndex = 18;
            // 
            // ColumnInConRegister
            // 
            this.ColumnInConRegister.HeaderText = "签到状态";
            this.ColumnInConRegister.Name = "ColumnInConRegister";
            this.ColumnInConRegister.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnInConRegister.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnInConRegister.Width = 80;
            // 
            // ColumnConId2
            // 
            this.ColumnConId2.HeaderText = "会议ID";
            this.ColumnConId2.Name = "ColumnConId2";
            // 
            // ColumnEmId
            // 
            this.ColumnEmId.HeaderText = "员工ID";
            this.ColumnEmId.Name = "ColumnEmId";
            // 
            // ColumnEmName
            // 
            this.ColumnEmName.HeaderText = "姓名";
            this.ColumnEmName.Name = "ColumnEmName";
            // 
            // ColumnEmDuties
            // 
            this.ColumnEmDuties.HeaderText = "职务";
            this.ColumnEmDuties.Name = "ColumnEmDuties";
            // 
            // ColumnEmPhone
            // 
            this.ColumnEmPhone.HeaderText = "电话";
            this.ColumnEmPhone.Name = "ColumnEmPhone";
            // 
            // RegisterManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 485);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(719, 523);
            this.Name = "RegisterManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "签到管理";
            this.Load += new System.EventHandler(this.RegisterManagementForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutRegister)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOutSave;
        private System.Windows.Forms.DataGridView dgvOutRegister;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnConRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConDuties;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConPhone;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInSave;
        private System.Windows.Forms.DataGridView dgvInRegister;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnInConRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmDuties;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmPhone;

    }
}