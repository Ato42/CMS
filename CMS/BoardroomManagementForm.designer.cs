namespace GS.CMS
{
    partial class BoardroomManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardroomManagementForm));
            this.btnDelBdr = new System.Windows.Forms.Button();
            this.btnModBdr = new System.Windows.Forms.Button();
            this.btnAddBdr = new System.Windows.Forms.Button();
            this.dgvBoardroom = new System.Windows.Forms.DataGridView();
            this.ColumnBdrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrContactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrLinkman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrIntro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBdrRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardroom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelBdr
            // 
            this.btnDelBdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelBdr.Location = new System.Drawing.Point(240, 405);
            this.btnDelBdr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelBdr.Name = "btnDelBdr";
            this.btnDelBdr.Size = new System.Drawing.Size(108, 25);
            this.btnDelBdr.TabIndex = 30;
            this.btnDelBdr.Text = "删除会议室";
            this.btnDelBdr.UseVisualStyleBackColor = true;
            this.btnDelBdr.Click += new System.EventHandler(this.btnDelBdr_Click);
            // 
            // btnModBdr
            // 
            this.btnModBdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModBdr.Location = new System.Drawing.Point(126, 405);
            this.btnModBdr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModBdr.Name = "btnModBdr";
            this.btnModBdr.Size = new System.Drawing.Size(108, 25);
            this.btnModBdr.TabIndex = 29;
            this.btnModBdr.Text = "修改会议室";
            this.btnModBdr.UseVisualStyleBackColor = true;
            this.btnModBdr.Click += new System.EventHandler(this.btnModBdr_Click);
            // 
            // btnAddBdr
            // 
            this.btnAddBdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddBdr.Location = new System.Drawing.Point(12, 405);
            this.btnAddBdr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBdr.Name = "btnAddBdr";
            this.btnAddBdr.Size = new System.Drawing.Size(108, 25);
            this.btnAddBdr.TabIndex = 28;
            this.btnAddBdr.Text = "添加会议室";
            this.btnAddBdr.UseVisualStyleBackColor = true;
            this.btnAddBdr.Click += new System.EventHandler(this.btnAddBdr_Click);
            // 
            // dgvBoardroom
            // 
            this.dgvBoardroom.AllowUserToAddRows = false;
            this.dgvBoardroom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBoardroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoardroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBdrId,
            this.ColumnBdrStatus,
            this.ColumnBdrName,
            this.ColumnBdrContactNum,
            this.ColumnBdrLinkman,
            this.ColumnBdrContactPhone,
            this.ColumnBdrIntro,
            this.ColumnBdrRemarks});
            this.dgvBoardroom.Location = new System.Drawing.Point(12, 45);
            this.dgvBoardroom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBoardroom.Name = "dgvBoardroom";
            this.dgvBoardroom.RowTemplate.Height = 23;
            this.dgvBoardroom.Size = new System.Drawing.Size(857, 352);
            this.dgvBoardroom.TabIndex = 27;
            // 
            // ColumnBdrId
            // 
            this.ColumnBdrId.HeaderText = "会议室ID";
            this.ColumnBdrId.Name = "ColumnBdrId";
            // 
            // ColumnBdrStatus
            // 
            this.ColumnBdrStatus.HeaderText = "会议室状态";
            this.ColumnBdrStatus.Name = "ColumnBdrStatus";
            // 
            // ColumnBdrName
            // 
            this.ColumnBdrName.HeaderText = "会议室名称";
            this.ColumnBdrName.Name = "ColumnBdrName";
            // 
            // ColumnBdrContactNum
            // 
            this.ColumnBdrContactNum.HeaderText = "可容纳人数";
            this.ColumnBdrContactNum.Name = "ColumnBdrContactNum";
            // 
            // ColumnBdrLinkman
            // 
            this.ColumnBdrLinkman.HeaderText = "联系人";
            this.ColumnBdrLinkman.Name = "ColumnBdrLinkman";
            // 
            // ColumnBdrContactPhone
            // 
            this.ColumnBdrContactPhone.HeaderText = "联系人电话";
            this.ColumnBdrContactPhone.Name = "ColumnBdrContactPhone";
            // 
            // ColumnBdrIntro
            // 
            this.ColumnBdrIntro.HeaderText = "会议室介绍";
            this.ColumnBdrIntro.Name = "ColumnBdrIntro";
            // 
            // ColumnBdrRemarks
            // 
            this.ColumnBdrRemarks.HeaderText = "备注";
            this.ColumnBdrRemarks.Name = "ColumnBdrRemarks";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuery.Location = new System.Drawing.Point(100, 14);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(672, 23);
            this.txtQuery.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "输入查询条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(778, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 25);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BoardroomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 443);
            this.Controls.Add(this.btnDelBdr);
            this.Controls.Add(this.btnModBdr);
            this.Controls.Add(this.btnAddBdr);
            this.Controls.Add(this.dgvBoardroom);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(897, 481);
            this.Name = "BoardroomManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会议室管理";
            this.Load += new System.EventHandler(this.BoardroomManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelBdr;
        private System.Windows.Forms.Button btnModBdr;
        private System.Windows.Forms.Button btnAddBdr;
        private System.Windows.Forms.DataGridView dgvBoardroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrContactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrLinkman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrIntro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBdrRemarks;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;

    }
}