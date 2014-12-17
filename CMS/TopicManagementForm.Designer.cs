namespace GS.CMS
{
    partial class TopicManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicManagementForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTopic = new System.Windows.Forms.DataGridView();
            this.dgvTopicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicApplicantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicApplicant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicSubTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicVerifyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.txtQuery2 = new System.Windows.Forms.TextBox();
            this.dgvTopic2 = new System.Windows.Forms.DataGridView();
            this.dgvTopic2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2ApplicantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2Applicant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2SubTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2VerifyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic2Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.txtQuery3 = new System.Windows.Forms.TextBox();
            this.dgvTopic3 = new System.Windows.Forms.DataGridView();
            this.dgvTopic3Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3ApplicantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3Applicant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3SubTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3VerifyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopic3Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Controls.Add(this.txtQuery);
            this.tabPage1.Controls.Add(this.btnReject);
            this.tabPage1.Controls.Add(this.btnVerify);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dgvTopic);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未审核议题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "按会议ID查询";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(777, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 25);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuery.Location = new System.Drawing.Point(93, 9);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(678, 23);
            this.txtQuery.TabIndex = 14;
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReject.Location = new System.Drawing.Point(596, 410);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(125, 25);
            this.btnReject.TabIndex = 13;
            this.btnReject.Text = "未通过审核";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVerify.Location = new System.Drawing.Point(465, 410);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(125, 25);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "通过审核";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(727, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增议题";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTopic
            // 
            this.dgvTopic.AllowUserToAddRows = false;
            this.dgvTopic.AllowUserToDeleteRows = false;
            this.dgvTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTopicId,
            this.dgvTopicHead,
            this.dgvTopicContent,
            this.dgvTopicApplicantId,
            this.dgvTopicApplicant,
            this.dgvTopicSubTime,
            this.dgvTopicVerifyTime,
            this.dgvTopicStatus});
            this.dgvTopic.Location = new System.Drawing.Point(9, 39);
            this.dgvTopic.Name = "dgvTopic";
            this.dgvTopic.ReadOnly = true;
            this.dgvTopic.RowTemplate.Height = 23;
            this.dgvTopic.Size = new System.Drawing.Size(843, 365);
            this.dgvTopic.TabIndex = 9;
            // 
            // dgvTopicId
            // 
            this.dgvTopicId.HeaderText = "会议议题ID";
            this.dgvTopicId.Name = "dgvTopicId";
            this.dgvTopicId.ReadOnly = true;
            // 
            // dgvTopicHead
            // 
            this.dgvTopicHead.HeaderText = "议题名称";
            this.dgvTopicHead.Name = "dgvTopicHead";
            this.dgvTopicHead.ReadOnly = true;
            // 
            // dgvTopicContent
            // 
            this.dgvTopicContent.HeaderText = "议题内容";
            this.dgvTopicContent.Name = "dgvTopicContent";
            this.dgvTopicContent.ReadOnly = true;
            // 
            // dgvTopicApplicantId
            // 
            this.dgvTopicApplicantId.HeaderText = "议题申请人ID";
            this.dgvTopicApplicantId.Name = "dgvTopicApplicantId";
            this.dgvTopicApplicantId.ReadOnly = true;
            // 
            // dgvTopicApplicant
            // 
            this.dgvTopicApplicant.HeaderText = "议题申请人";
            this.dgvTopicApplicant.Name = "dgvTopicApplicant";
            this.dgvTopicApplicant.ReadOnly = true;
            // 
            // dgvTopicSubTime
            // 
            this.dgvTopicSubTime.HeaderText = "申请时间";
            this.dgvTopicSubTime.Name = "dgvTopicSubTime";
            this.dgvTopicSubTime.ReadOnly = true;
            // 
            // dgvTopicVerifyTime
            // 
            this.dgvTopicVerifyTime.HeaderText = "审核时间";
            this.dgvTopicVerifyTime.Name = "dgvTopicVerifyTime";
            this.dgvTopicVerifyTime.ReadOnly = true;
            this.dgvTopicVerifyTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTopicStatus
            // 
            this.dgvTopicStatus.HeaderText = "议题状态";
            this.dgvTopicStatus.Name = "dgvTopicStatus";
            this.dgvTopicStatus.ReadOnly = true;
            this.dgvTopicStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopicStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnQuery2);
            this.tabPage2.Controls.Add(this.txtQuery2);
            this.tabPage2.Controls.Add(this.dgvTopic2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已审核议题";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "按会议ID查询";
            // 
            // btnQuery2
            // 
            this.btnQuery2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery2.Location = new System.Drawing.Point(777, 8);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(75, 25);
            this.btnQuery2.TabIndex = 18;
            this.btnQuery2.Text = "查询";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // txtQuery2
            // 
            this.txtQuery2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuery2.Location = new System.Drawing.Point(93, 9);
            this.txtQuery2.Name = "txtQuery2";
            this.txtQuery2.Size = new System.Drawing.Size(678, 23);
            this.txtQuery2.TabIndex = 17;
            // 
            // dgvTopic2
            // 
            this.dgvTopic2.AllowUserToAddRows = false;
            this.dgvTopic2.AllowUserToDeleteRows = false;
            this.dgvTopic2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTopic2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTopic2Id,
            this.dgvTopic2Head,
            this.dgvTopic2Content,
            this.dgvTopic2ApplicantId,
            this.dgvTopic2Applicant,
            this.dgvTopic2SubTime,
            this.dgvTopic2VerifyTime,
            this.dgvTopic2Status});
            this.dgvTopic2.Location = new System.Drawing.Point(9, 39);
            this.dgvTopic2.Name = "dgvTopic2";
            this.dgvTopic2.ReadOnly = true;
            this.dgvTopic2.RowTemplate.Height = 23;
            this.dgvTopic2.Size = new System.Drawing.Size(843, 396);
            this.dgvTopic2.TabIndex = 10;
            // 
            // dgvTopic2Id
            // 
            this.dgvTopic2Id.HeaderText = "会议议题ID";
            this.dgvTopic2Id.Name = "dgvTopic2Id";
            this.dgvTopic2Id.ReadOnly = true;
            // 
            // dgvTopic2Head
            // 
            this.dgvTopic2Head.HeaderText = "议题名称";
            this.dgvTopic2Head.Name = "dgvTopic2Head";
            this.dgvTopic2Head.ReadOnly = true;
            // 
            // dgvTopic2Content
            // 
            this.dgvTopic2Content.HeaderText = "议题内容";
            this.dgvTopic2Content.Name = "dgvTopic2Content";
            this.dgvTopic2Content.ReadOnly = true;
            // 
            // dgvTopic2ApplicantId
            // 
            this.dgvTopic2ApplicantId.HeaderText = "议题申请人ID";
            this.dgvTopic2ApplicantId.Name = "dgvTopic2ApplicantId";
            this.dgvTopic2ApplicantId.ReadOnly = true;
            // 
            // dgvTopic2Applicant
            // 
            this.dgvTopic2Applicant.HeaderText = "议题申请人";
            this.dgvTopic2Applicant.Name = "dgvTopic2Applicant";
            this.dgvTopic2Applicant.ReadOnly = true;
            // 
            // dgvTopic2SubTime
            // 
            this.dgvTopic2SubTime.HeaderText = "申请时间";
            this.dgvTopic2SubTime.Name = "dgvTopic2SubTime";
            this.dgvTopic2SubTime.ReadOnly = true;
            // 
            // dgvTopic2VerifyTime
            // 
            this.dgvTopic2VerifyTime.HeaderText = "审核时间";
            this.dgvTopic2VerifyTime.Name = "dgvTopic2VerifyTime";
            this.dgvTopic2VerifyTime.ReadOnly = true;
            // 
            // dgvTopic2Status
            // 
            this.dgvTopic2Status.HeaderText = "议题状态";
            this.dgvTopic2Status.Name = "dgvTopic2Status";
            this.dgvTopic2Status.ReadOnly = true;
            this.dgvTopic2Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopic2Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnQuery3);
            this.tabPage3.Controls.Add(this.txtQuery3);
            this.tabPage3.Controls.Add(this.dgvTopic3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(858, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "未通过议题";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "按会议ID查询";
            // 
            // btnQuery3
            // 
            this.btnQuery3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery3.Location = new System.Drawing.Point(777, 8);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(75, 25);
            this.btnQuery3.TabIndex = 18;
            this.btnQuery3.Text = "查询";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // txtQuery3
            // 
            this.txtQuery3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuery3.Location = new System.Drawing.Point(93, 9);
            this.txtQuery3.Name = "txtQuery3";
            this.txtQuery3.Size = new System.Drawing.Size(678, 23);
            this.txtQuery3.TabIndex = 17;
            // 
            // dgvTopic3
            // 
            this.dgvTopic3.AllowUserToAddRows = false;
            this.dgvTopic3.AllowUserToDeleteRows = false;
            this.dgvTopic3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTopic3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTopic3Id,
            this.dgvTopic3Head,
            this.dgvTopic3Content,
            this.dgvTopic3ApplicantId,
            this.dgvTopic3Applicant,
            this.dgvTopic3SubTime,
            this.dgvTopic3VerifyTime,
            this.dgvTopic3Status});
            this.dgvTopic3.Location = new System.Drawing.Point(9, 39);
            this.dgvTopic3.Name = "dgvTopic3";
            this.dgvTopic3.ReadOnly = true;
            this.dgvTopic3.RowTemplate.Height = 23;
            this.dgvTopic3.Size = new System.Drawing.Size(843, 396);
            this.dgvTopic3.TabIndex = 11;
            // 
            // dgvTopic3Id
            // 
            this.dgvTopic3Id.HeaderText = "会议议题ID";
            this.dgvTopic3Id.Name = "dgvTopic3Id";
            this.dgvTopic3Id.ReadOnly = true;
            // 
            // dgvTopic3Head
            // 
            this.dgvTopic3Head.HeaderText = "议题名称";
            this.dgvTopic3Head.Name = "dgvTopic3Head";
            this.dgvTopic3Head.ReadOnly = true;
            // 
            // dgvTopic3Content
            // 
            this.dgvTopic3Content.HeaderText = "议题内容";
            this.dgvTopic3Content.Name = "dgvTopic3Content";
            this.dgvTopic3Content.ReadOnly = true;
            // 
            // dgvTopic3ApplicantId
            // 
            this.dgvTopic3ApplicantId.HeaderText = "议题申请人ID";
            this.dgvTopic3ApplicantId.Name = "dgvTopic3ApplicantId";
            this.dgvTopic3ApplicantId.ReadOnly = true;
            // 
            // dgvTopic3Applicant
            // 
            this.dgvTopic3Applicant.HeaderText = "议题申请人";
            this.dgvTopic3Applicant.Name = "dgvTopic3Applicant";
            this.dgvTopic3Applicant.ReadOnly = true;
            // 
            // dgvTopic3SubTime
            // 
            this.dgvTopic3SubTime.HeaderText = "申请时间";
            this.dgvTopic3SubTime.Name = "dgvTopic3SubTime";
            this.dgvTopic3SubTime.ReadOnly = true;
            // 
            // dgvTopic3VerifyTime
            // 
            this.dgvTopic3VerifyTime.HeaderText = "审核时间";
            this.dgvTopic3VerifyTime.Name = "dgvTopic3VerifyTime";
            this.dgvTopic3VerifyTime.ReadOnly = true;
            // 
            // dgvTopic3Status
            // 
            this.dgvTopic3Status.HeaderText = "议题状态";
            this.dgvTopic3Status.Name = "dgvTopic3Status";
            this.dgvTopic3Status.ReadOnly = true;
            this.dgvTopic3Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopic3Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TopicManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 491);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(906, 529);
            this.Name = "TopicManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "议题管理";
            this.Load += new System.EventHandler(this.TopicManagementForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTopic;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTopic2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTopic3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2Head;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2ApplicantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2Applicant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2SubTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2VerifyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic2Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicApplicantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicApplicant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicSubTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicVerifyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3Head;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3ApplicantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3Applicant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3SubTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3VerifyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopic3Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.TextBox txtQuery2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.TextBox txtQuery3;

    }
}