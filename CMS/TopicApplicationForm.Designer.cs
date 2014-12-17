namespace GS.CMS
{
    partial class TopicApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicApplicationForm));
            this.btnEnsure = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTopicContent = new System.Windows.Forms.TextBox();
            this.txtTopicHead = new System.Windows.Forms.TextBox();
            this.dgvTopic = new System.Windows.Forms.DataGridView();
            this.dgvTopicHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicSubTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicVerifyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopicStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnsure
            // 
            this.btnEnsure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnsure.Location = new System.Drawing.Point(655, 401);
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.Size = new System.Drawing.Size(88, 25);
            this.btnEnsure.TabIndex = 17;
            this.btnEnsure.Text = "提交申请";
            this.btnEnsure.UseVisualStyleBackColor = true;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(593, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "议题内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(593, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "议题名称";
            // 
            // txtTopicContent
            // 
            this.txtTopicContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopicContent.Location = new System.Drawing.Point(655, 74);
            this.txtTopicContent.Multiline = true;
            this.txtTopicContent.Name = "txtTopicContent";
            this.txtTopicContent.Size = new System.Drawing.Size(214, 321);
            this.txtTopicContent.TabIndex = 14;
            // 
            // txtTopicHead
            // 
            this.txtTopicHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopicHead.Location = new System.Drawing.Point(655, 44);
            this.txtTopicHead.Name = "txtTopicHead";
            this.txtTopicHead.Size = new System.Drawing.Size(214, 21);
            this.txtTopicHead.TabIndex = 13;
            // 
            // dgvTopic
            // 
            this.dgvTopic.AllowUserToAddRows = false;
            this.dgvTopic.AllowUserToDeleteRows = false;
            this.dgvTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTopicHead,
            this.dgvTopicContent,
            this.dgvTopicSubTime,
            this.dgvTopicVerifyTime,
            this.dgvTopicStatus});
            this.dgvTopic.Location = new System.Drawing.Point(12, 32);
            this.dgvTopic.Name = "dgvTopic";
            this.dgvTopic.ReadOnly = true;
            this.dgvTopic.RowTemplate.Height = 23;
            this.dgvTopic.Size = new System.Drawing.Size(558, 394);
            this.dgvTopic.TabIndex = 19;
            this.dgvTopic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopic_CellContentClick);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "议题申请情况";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(593, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "请填写议题内容";
            // 
            // TopicApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTopicContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnsure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTopic);
            this.Controls.Add(this.txtTopicHead);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(911, 476);
            this.Name = "TopicApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会议议题申请";
            this.Load += new System.EventHandler(this.TopicApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTopicContent;
        private System.Windows.Forms.TextBox txtTopicHead;
        private System.Windows.Forms.DataGridView dgvTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicSubTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicVerifyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTopicStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}