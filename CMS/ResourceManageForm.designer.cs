namespace GS.CMS
{
    partial class ResourceManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceManageForm));
            this.dgvResource = new System.Windows.Forms.DataGridView();
            this.ColumnResourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResourceClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResourceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbResClass = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAddResClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResource
            // 
            this.dgvResource.AllowUserToAddRows = false;
            this.dgvResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResourceId,
            this.ColumnResourceClass,
            this.ColumnResourceStatus});
            this.dgvResource.Location = new System.Drawing.Point(12, 13);
            this.dgvResource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvResource.Name = "dgvResource";
            this.dgvResource.RowTemplate.Height = 23;
            this.dgvResource.Size = new System.Drawing.Size(360, 384);
            this.dgvResource.TabIndex = 0;
            this.dgvResource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResource_CellContentClick);
            // 
            // ColumnResourceId
            // 
            this.ColumnResourceId.HeaderText = "资源ID";
            this.ColumnResourceId.Name = "ColumnResourceId";
            // 
            // ColumnResourceClass
            // 
            this.ColumnResourceClass.HeaderText = "资源种类";
            this.ColumnResourceClass.Name = "ColumnResourceClass";
            // 
            // ColumnResourceStatus
            // 
            this.ColumnResourceStatus.HeaderText = "可用状态";
            this.ColumnResourceStatus.Name = "ColumnResourceStatus";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbResClass);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtResId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(378, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "资源信息:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(183, 151);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(87, 25);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除资源";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "空闲",
            "被预定",
            "使用中",
            "损坏"});
            this.cmbStatus.Location = new System.Drawing.Point(90, 107);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(210, 25);
            this.cmbStatus.TabIndex = 5;
            // 
            // cmbResClass
            // 
            this.cmbResClass.FormattingEnabled = true;
            this.cmbResClass.Items.AddRange(new object[] {
            "麦克风",
            "投影仪",
            "电脑",
            "新麦克风",
            "扩音器",
            "椅子"});
            this.cmbResClass.Location = new System.Drawing.Point(90, 74);
            this.cmbResClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbResClass.Name = "cmbResClass";
            this.cmbResClass.Size = new System.Drawing.Size(210, 25);
            this.cmbResClass.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 151);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtResId
            // 
            this.txtResId.Enabled = false;
            this.txtResId.Location = new System.Drawing.Point(90, 43);
            this.txtResId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(210, 23);
            this.txtResId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "资源状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "资源种类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "资源ID";
            // 
            // btnAddRes
            // 
            this.btnAddRes.Location = new System.Drawing.Point(90, 86);
            this.btnAddRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(87, 25);
            this.btnAddRes.TabIndex = 2;
            this.btnAddRes.Text = "新增资源";
            this.btnAddRes.UseVisualStyleBackColor = true;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbAddResClass);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAddRes);
            this.groupBox2.Location = new System.Drawing.Point(378, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(339, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新增资源信息:";
            // 
            // cmbAddResClass
            // 
            this.cmbAddResClass.FormattingEnabled = true;
            this.cmbAddResClass.Items.AddRange(new object[] {
            "麦克风",
            "投影仪",
            "电脑",
            "新麦克风",
            "扩音器",
            "椅子"});
            this.cmbAddResClass.Location = new System.Drawing.Point(90, 44);
            this.cmbAddResClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAddResClass.Name = "cmbAddResClass";
            this.cmbAddResClass.Size = new System.Drawing.Size(210, 25);
            this.cmbAddResClass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "资源种类";
            // 
            // ResourceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResource);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(745, 448);
            this.Name = "ResourceManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "资源管理";
            this.Load += new System.EventHandler(this.ResourceManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourceClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourceStatus;
        private System.Windows.Forms.ComboBox cmbResClass;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAddResClass;
        private System.Windows.Forms.Label label5;
    }
}