namespace GS.CMS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiApply = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewCon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTopicManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBdrRoomManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResouceManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.周视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1sView = new C1.Win.C1Schedule.C1Schedule();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNextCon = new System.Windows.Forms.Label();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApply,
            this.tsmiCheckTask,
            this.tsmiManage,
            this.tsmiVer,
            this.tsmiUpdateMateria,
            this.视图ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiApply
            // 
            this.tsmiApply.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewTopic,
            this.tsmiNewCon});
            this.tsmiApply.Name = "tsmiApply";
            this.tsmiApply.Size = new System.Drawing.Size(44, 21);
            this.tsmiApply.Text = "申请";
            // 
            // tsmiNewTopic
            // 
            this.tsmiNewTopic.Name = "tsmiNewTopic";
            this.tsmiNewTopic.Size = new System.Drawing.Size(124, 22);
            this.tsmiNewTopic.Text = "议题申请";
            this.tsmiNewTopic.Click += new System.EventHandler(this.tsmiNewTopic_Click);
            // 
            // tsmiNewCon
            // 
            this.tsmiNewCon.Name = "tsmiNewCon";
            this.tsmiNewCon.Size = new System.Drawing.Size(124, 22);
            this.tsmiNewCon.Text = "会议申请";
            this.tsmiNewCon.Click += new System.EventHandler(this.tsmiNewCon_Click);
            // 
            // tsmiCheckTask
            // 
            this.tsmiCheckTask.Name = "tsmiCheckTask";
            this.tsmiCheckTask.Size = new System.Drawing.Size(80, 21);
            this.tsmiCheckTask.Text = "查看任务单";
            this.tsmiCheckTask.Click += new System.EventHandler(this.查看任务单ToolStripMenuItem_Click);
            // 
            // tsmiManage
            // 
            this.tsmiManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopicManage,
            this.tsmiConManage,
            this.tsmiBdrRoomManage,
            this.tsmiResouceManage});
            this.tsmiManage.Name = "tsmiManage";
            this.tsmiManage.Size = new System.Drawing.Size(44, 21);
            this.tsmiManage.Text = "管理";
            // 
            // tsmiTopicManage
            // 
            this.tsmiTopicManage.Name = "tsmiTopicManage";
            this.tsmiTopicManage.Size = new System.Drawing.Size(136, 22);
            this.tsmiTopicManage.Text = "议题管理";
            this.tsmiTopicManage.Click += new System.EventHandler(this.tsmiTopicManage_Click);
            // 
            // tsmiConManage
            // 
            this.tsmiConManage.Name = "tsmiConManage";
            this.tsmiConManage.Size = new System.Drawing.Size(136, 22);
            this.tsmiConManage.Text = "会议管理";
            this.tsmiConManage.Click += new System.EventHandler(this.tsmiConManage_Click);
            // 
            // tsmiBdrRoomManage
            // 
            this.tsmiBdrRoomManage.Name = "tsmiBdrRoomManage";
            this.tsmiBdrRoomManage.Size = new System.Drawing.Size(136, 22);
            this.tsmiBdrRoomManage.Text = "会议室管理";
            this.tsmiBdrRoomManage.Click += new System.EventHandler(this.tsmiBdrRoomManage_Click);
            // 
            // tsmiResouceManage
            // 
            this.tsmiResouceManage.Name = "tsmiResouceManage";
            this.tsmiResouceManage.Size = new System.Drawing.Size(136, 22);
            this.tsmiResouceManage.Text = "资源管理";
            this.tsmiResouceManage.Click += new System.EventHandler(this.tsmiResouceManage_Click);
            // 
            // tsmiVer
            // 
            this.tsmiVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConVer});
            this.tsmiVer.Name = "tsmiVer";
            this.tsmiVer.Size = new System.Drawing.Size(44, 21);
            this.tsmiVer.Text = "审核";
            // 
            // tsmiConVer
            // 
            this.tsmiConVer.Name = "tsmiConVer";
            this.tsmiConVer.Size = new System.Drawing.Size(124, 22);
            this.tsmiConVer.Text = "会议审核";
            this.tsmiConVer.Click += new System.EventHandler(this.tsmiConVer_Click);
            // 
            // tsmiUpdateMateria
            // 
            this.tsmiUpdateMateria.Name = "tsmiUpdateMateria";
            this.tsmiUpdateMateria.Size = new System.Drawing.Size(68, 21);
            this.tsmiUpdateMateria.Text = "资料上传";
            this.tsmiUpdateMateria.Click += new System.EventHandler(this.tsmiUpdateMateria_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日视图ToolStripMenuItem,
            this.周视图ToolStripMenuItem,
            this.月视图ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 日视图ToolStripMenuItem
            // 
            this.日视图ToolStripMenuItem.Name = "日视图ToolStripMenuItem";
            this.日视图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.日视图ToolStripMenuItem.Text = "日视图";
            this.日视图ToolStripMenuItem.Click += new System.EventHandler(this.日视图ToolStripMenuItem_Click);
            // 
            // 周视图ToolStripMenuItem
            // 
            this.周视图ToolStripMenuItem.Name = "周视图ToolStripMenuItem";
            this.周视图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.周视图ToolStripMenuItem.Text = "周视图";
            this.周视图ToolStripMenuItem.Click += new System.EventHandler(this.周视图ToolStripMenuItem_Click);
            // 
            // 月视图ToolStripMenuItem
            // 
            this.月视图ToolStripMenuItem.Name = "月视图ToolStripMenuItem";
            this.月视图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.月视图ToolStripMenuItem.Text = "月视图";
            this.月视图ToolStripMenuItem.Click += new System.EventHandler(this.月视图ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // c1sView
            // 
            this.c1sView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.c1sView.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("zh-CN");
            this.c1sView.CalendarInfo.DateFormatString = "yyyy/M/d";
            this.c1sView.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1sView.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1sView.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1sView.CalendarInfo.WeekStart = System.DayOfWeek.Monday;
            this.c1sView.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            // 
            // 
            // 
            this.c1sView.EditOptions = C1.Win.C1Schedule.EditOptions.None;
            this.c1sView.GroupPageSize = 2;
            this.c1sView.Location = new System.Drawing.Point(12, 46);
            this.c1sView.Name = "c1sView";
            this.c1sView.PrintInfo.IsPrintingEnabled = false;
            printStyle1.Description = "Daily Style";
            printStyle1.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle1.PreviewImage")));
            printStyle1.StyleName = "Daily";
            printStyle1.StyleSource = "day.c1d";
            printStyle2.Description = "Weekly Style";
            printStyle2.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle2.PreviewImage")));
            printStyle2.StyleName = "Week";
            printStyle2.StyleSource = "week.c1d";
            printStyle3.Description = "Monthly Style";
            printStyle3.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle3.PreviewImage")));
            printStyle3.StyleName = "Month";
            printStyle3.StyleSource = "month.c1d";
            printStyle4.Description = "Details Style";
            printStyle4.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle4.PreviewImage")));
            printStyle4.StyleName = "Details";
            printStyle4.StyleSource = "details.c1d";
            printStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle5.PreviewImage")));
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            this.c1sView.PrintInfo.PrintStyles.AddRange(new C1.C1Schedule.Printing.PrintStyle[] {
            printStyle1,
            printStyle2,
            printStyle3,
            printStyle4,
            printStyle5});
            this.c1sView.Size = new System.Drawing.Size(829, 496);
            this.c1sView.TabIndex = 0;
            this.c1sView.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WeekView;
            this.c1sView.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2010Black;
            this.c1sView.BeforeAppointmentCreate += new C1.C1Schedule.CancelAppointmentEventHandler(this.c1sView_BeforeAppointmentCreate);
            this.c1sView.BeforeAppointmentEdit += new C1.C1Schedule.CancelAppointmentEventHandler(this.c1sView_BeforeAppointmentEdit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GS.Properties.Resources.userimg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(874, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbHello
            // 
            this.lbHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHello.AutoSize = true;
            this.lbHello.BackColor = System.Drawing.Color.Transparent;
            this.lbHello.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHello.Location = new System.Drawing.Point(847, 190);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(51, 20);
            this.lbHello.TabIndex = 5;
            this.lbHello.Text = "欢迎！";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(848, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "以下是您下一个会议的\r\n简要信息：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbNextCon);
            this.panel1.Location = new System.Drawing.Point(847, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 266);
            this.panel1.TabIndex = 6;
            // 
            // lbNextCon
            // 
            this.lbNextCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNextCon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNextCon.Location = new System.Drawing.Point(0, 0);
            this.lbNextCon.Name = "lbNextCon";
            this.lbNextCon.Size = new System.Drawing.Size(176, 266);
            this.lbNextCon.TabIndex = 0;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GS.Properties.Resources.dec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1sView);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1051, 610);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会议管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1sView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiTopicManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiConManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiApply;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTopic;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewCon;
        private System.Windows.Forms.ToolStripMenuItem tsmiVer;
        private System.Windows.Forms.ToolStripMenuItem tsmiConVer;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmiBdrRoomManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiResouceManage;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private C1.Win.C1Schedule.C1Schedule c1sView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckTask;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 周视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月视图ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNextCon;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}