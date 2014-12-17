namespace GS.CMS
{
    partial class TaskManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagementForm));
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.ColumnConferenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBoardroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnsure = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.会议种类 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbConId = new System.Windows.Forms.Label();
            this.lbCon = new System.Windows.Forms.Label();
            this.lbBdr = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbRes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConMen = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnConferenceId,
            this.ColumnConference,
            this.ColumnBoardroom,
            this.ColumnStartTime,
            this.ColumnResource});
            this.dgvTask.Location = new System.Drawing.Point(12, 12);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowTemplate.Height = 23;
            this.dgvTask.Size = new System.Drawing.Size(544, 468);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellContentClick);
            this.dgvTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellContentClick);
            // 
            // ColumnConferenceId
            // 
            this.ColumnConferenceId.HeaderText = "会议ID";
            this.ColumnConferenceId.Name = "ColumnConferenceId";
            this.ColumnConferenceId.ReadOnly = true;
            // 
            // ColumnConference
            // 
            this.ColumnConference.HeaderText = "会议";
            this.ColumnConference.Name = "ColumnConference";
            this.ColumnConference.ReadOnly = true;
            // 
            // ColumnBoardroom
            // 
            this.ColumnBoardroom.HeaderText = "会议室";
            this.ColumnBoardroom.Name = "ColumnBoardroom";
            this.ColumnBoardroom.ReadOnly = true;
            // 
            // ColumnStartTime
            // 
            this.ColumnStartTime.HeaderText = "会议时间";
            this.ColumnStartTime.Name = "ColumnStartTime";
            this.ColumnStartTime.ReadOnly = true;
            // 
            // ColumnResource
            // 
            this.ColumnResource.HeaderText = "会议资源";
            this.ColumnResource.Name = "ColumnResource";
            this.ColumnResource.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "会议ID：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "会议资源：";
            // 
            // btnEnsure
            // 
            this.btnEnsure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnsure.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnsure.Location = new System.Drawing.Point(138, 407);
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.Size = new System.Drawing.Size(75, 25);
            this.btnEnsure.TabIndex = 9;
            this.btnEnsure.Text = "确认完成";
            this.btnEnsure.UseVisualStyleBackColor = true;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "会议时间：";
            // 
            // 会议种类
            // 
            this.会议种类.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.会议种类.AutoSize = true;
            this.会议种类.BackColor = System.Drawing.Color.Transparent;
            this.会议种类.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.会议种类.Location = new System.Drawing.Point(31, 82);
            this.会议种类.Name = "会议种类";
            this.会议种类.Size = new System.Drawing.Size(56, 17);
            this.会议种类.TabIndex = 7;
            this.会议种类.Text = "会议室：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "会议名称：";
            // 
            // lbConId
            // 
            this.lbConId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConId.AutoSize = true;
            this.lbConId.Location = new System.Drawing.Point(93, 28);
            this.lbConId.Name = "lbConId";
            this.lbConId.Size = new System.Drawing.Size(43, 17);
            this.lbConId.TabIndex = 19;
            this.lbConId.Text = "label6";
            // 
            // lbCon
            // 
            this.lbCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCon.AutoSize = true;
            this.lbCon.Location = new System.Drawing.Point(93, 55);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(43, 17);
            this.lbCon.TabIndex = 19;
            this.lbCon.Text = "label6";
            // 
            // lbBdr
            // 
            this.lbBdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBdr.AutoSize = true;
            this.lbBdr.Location = new System.Drawing.Point(93, 82);
            this.lbBdr.Name = "lbBdr";
            this.lbBdr.Size = new System.Drawing.Size(43, 17);
            this.lbBdr.TabIndex = 19;
            this.lbBdr.Text = "label6";
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.Location = new System.Drawing.Point(0, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(117, 46);
            this.lbTime.TabIndex = 19;
            this.lbTime.Text = "label6";
            // 
            // lbRes
            // 
            this.lbRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRes.Location = new System.Drawing.Point(0, 0);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(117, 196);
            this.lbRes.TabIndex = 19;
            this.lbRes.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.btnConMen);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnEnsure);
            this.panel1.Controls.Add(this.会议种类);
            this.panel1.Controls.Add(this.lbBdr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbCon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbConId);
            this.panel1.Location = new System.Drawing.Point(6, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 444);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Location = new System.Drawing.Point(93, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 46);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbRes);
            this.panel2.Location = new System.Drawing.Point(93, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 196);
            this.panel2.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(573, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 468);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会议任务";
            // 
            // btnConMen
            // 
            this.btnConMen.Location = new System.Drawing.Point(96, 376);
            this.btnConMen.Name = "btnConMen";
            this.btnConMen.Size = new System.Drawing.Size(117, 25);
            this.btnConMen.TabIndex = 22;
            this.btnConMen.Text = "录入外部与会人员";
            this.btnConMen.UseVisualStyleBackColor = true;
            this.btnConMen.Click += new System.EventHandler(this.btnConMen_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(15, 376);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 25);
            this.btnReg.TabIndex = 23;
            this.btnReg.Text = "组织签到";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // TaskManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GS.Properties.Resources.dec02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTask);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(854, 448);
            this.Name = "TaskManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的会务单";
            this.Load += new System.EventHandler(this.TaskManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnsure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 会议种类;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConferenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBoardroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConId;
        private System.Windows.Forms.Label lbCon;
        private System.Windows.Forms.Label lbBdr;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnConMen;
    }
}