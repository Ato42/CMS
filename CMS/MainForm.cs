using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

using GS.CMS.MODEL;
using GS.CMS.BLL;

using C1.Win.C1Schedule;


namespace GS.CMS
{
    public partial class MainForm : Form
    {
        List<ConferenceModel> list = new List<ConferenceModel>();
        public EmployeeModel employee = new EmployeeModel();
        
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region 界面
            // 在界面显示用户信息
            UserBLL userInfo = new UserBLL();
            EmployeeModel emInfo = userInfo.GetEmInfo(this.employee.EmId);
            string strHello = "欢迎，" + emInfo.EmName[0] + (emInfo.EmSex == "男" ? "先生" : "小姐");
            this.lbHello.Text = strHello;

            // 根据登陆用户的权限显示相应的空间
            if (employee.EmPermission == "OU")//普通用户
            {
                this.tsmiCheckTask.Visible = false;
                this.tsmiApply.Visible = true;
                this.tsmiManage.Visible = false;
                this.tsmiVer.Visible = false;
                this.tsmiUpdateMateria.Visible = true;
                //this.c1scNextCon.Visible = true;

                UserBLL sort = new UserBLL();
                list = sort.GetUserConference(employee);
              //  ConferenceModel con = new ConferenceModel();

                try
                {
                    ConferenceModel con = GetConSort(list);
                    string bdr = sort.GetBoardroomInfo(con.ConPlace.ToString())[0].BdrName;
                    if (con.ConStatus == '1')
                    {
                        this.lbNextCon.Text =
                            String.Format("会议名称：{0}；\n会议地点：{1}；\n会议开始时间：{2}；\n会议结束时间：{3}；\n",
                            con.ConName, bdr, con.ConStartTime.ToShortTimeString(),
                            con.ConEndTime.ToShortTimeString());
                    }
                    else
                    {
                        this.lbNextCon.Text = "接下来并没有会议！";
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    this.lbNextCon.Text = ex.Message;
                }
                


            }
            else if (employee.EmPermission == "TA")//议题审核人
            {
                this.tsmiCheckTask.Visible = false;
                this.tsmiApply.Visible = true;
                this.tsmiManage.Visible = true;
                this.tsmiConManage.Visible = false;
                this.tsmiTopicManage.Visible = true;
                this.tsmiBdrRoomManage.Visible = false;
                this.tsmiResouceManage.Visible = false;
                this.tsmiVer.Visible = false;
                this.tsmiConVer.Visible = false;
                this.tsmiUpdateMateria.Visible = true;
                //this.c1scNextCon.Visible = true;
                UserBLL sort = new UserBLL();
                list = sort.GetUserConference(employee);
                try 
                { 
                    ConferenceModel con = GetConSort(list);
                    string bdr = sort.GetBoardroomInfo(con.ConPlace.ToString())[0].BdrName;
                    if (con.ConStatus == '1')
                    {
                        this.lbNextCon.Text =
                            String.Format("会议名称：{0}；\n会议地点：{1}；\n会议开始时间：{2}；\n会议结束时间：{3}；\n",
                            con.ConName, bdr, con.ConStartTime.ToShortTimeString(),
                            con.ConEndTime.ToShortTimeString());
                    }
                    else
                    {
                        this.lbNextCon.Text = "接下来并没有会议！";
                    }
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    this.lbNextCon.Text = ex.Message;
                }

            }
            else if (employee.EmPermission == "CA")//会议管理员
            {
                this.lbHello.Text = "欢迎，管理员";
                
                this.tsmiTopicManage.Visible = false;
                this.tsmiCheckTask.Visible = false;
                this.tsmiManage.Visible = true;
                this.tsmiConManage.Visible = true;
                this.tsmiBdrRoomManage.Visible = true;
                this.tsmiResouceManage.Visible = false;
                this.tsmiApply.Visible = true;
                this.tsmiVer.Visible = true;
                this.tsmiConVer.Visible = true;
                this.tsmiUpdateMateria.Visible = true;
                //this.c1scNextCon.Visible = true;
                UserBLL sort = new UserBLL();
                list = sort.GetUserConference(employee);
                try
                {
                    ConferenceModel con = GetConSort(list);
                    string bdr = sort.GetBoardroomInfo(con.ConPlace.ToString())[0].BdrName;
                    if (con.ConStatus == '1')
                    {
                        this.lbNextCon.Text =
                            String.Format("会议名称：{0}；\n会议地点：{1}；\n会议开始时间：{2}；\n会议结束时间：{3}；\n",
                            con.ConName, bdr, con.ConStartTime.ToShortTimeString(),
                            con.ConEndTime.ToShortTimeString());
                    }
                    else
                    {
                        this.lbNextCon.Text = "接下来并没有会议！";
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    this.lbNextCon.Text = ex.Message;
                }
            }
            else if (employee.EmPermission == "CE")//会务执行人
            {
                //this.tsmiManage.Visible = true;
                this.tsmiManage.Visible = true;
                this.tsmiResouceManage.Visible = true;
                this.tsmiTopicManage.Visible = false;
                this.tsmiConManage.Visible = false;
                this.tsmiBdrRoomManage.Visible = false;
                this.tsmiCheckTask.Visible = true;
                
                this.tsmiApply.Visible = true;
                this.tsmiVer.Visible = false;
                this.tsmiUpdateMateria.Visible = true;
                this.label1.Visible = false;
                //this.c1scNextCon.Visible = true;

            }
            #endregion

            List<ConferenceModel> ConferenceList = new List<ConferenceModel>();
            UserBLL user = new UserBLL();
            ConferenceList = user.GetConferenceInfo("");
            try
            {
                int n = 0;
                foreach (ConferenceModel con in ConferenceList)
                {
                    if (con.ConStatus == '1')
                    {
                        C1.C1Schedule.Appointment app = new C1.C1Schedule.Appointment();
                        app.Subject = con.ConName;
                        string bdrname = user.GetBoardroomInfo(con.ConPlace.ToString())[0].BdrName;
                        app.Location = bdrname;
                        app.Start = con.ConStartTime;
                        app.End = con.ConEndTime;
                        this.c1sView.DataStorage.AppointmentStorage.Appointments.Add(app);
                        BoardroomModel bdr = new BoardroomModel();
                        bdr.BdrId = con.ConPlace;
                        bdr.BdrName = bdrname;
                        try
                        {
                            this.c1sView.DataStorage.OwnerStorage.Mappings.TextMapping.MappingName = "BdrName";
                            this.c1sView.DataStorage.OwnerStorage.Mappings.IndexMapping.MappingName = "BdrId";
                            bool iscontains = false;
                            foreach (object m in this.c1sView.DataStorage.OwnerStorage.Contacts)
                            {
                                if (m.ToString()==bdr.BdrName)
                                {
                                    iscontains = true;
                                }
                            }
                            if (iscontains == false)
                            {
                                this.c1sView.DataStorage.OwnerStorage.Add(bdr);
                                app.Owner = this.c1sView.DataStorage.OwnerStorage.Contacts[n];
                                n++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region 菜单栏事件
        private void 查看任务单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManagementForm taskManagementForm = new TaskManagementForm();
            taskManagementForm.employee = employee;
            taskManagementForm.ShowDialog();
        }

        private void tsmiTopicManage_Click(object sender, EventArgs e)
        {
            //朱健在做
            TopicManagementForm topicManForm = new TopicManagementForm();
            topicManForm.userId = this.employee.EmId;
            topicManForm.ShowDialog();
        }

        private void tsmiBdrRoomManage_Click(object sender, EventArgs e)
        {
            BoardroomManagementForm boardroommanagementform = new BoardroomManagementForm();
            boardroommanagementform.emp = employee;
            boardroommanagementform.ShowDialog();
        }

        private void tsmiConManage_Click(object sender, EventArgs e)
        {
            ConferenceManagementForm conferencemanagementform = new ConferenceManagementForm();
            conferencemanagementform.emp = employee;
            conferencemanagementform.ShowDialog();
        }

        private void tsmiNewTopic_Click(object sender, EventArgs e)
        {
            //朱健在做
            TopicApplicationForm topicAppForm = new TopicApplicationForm();
            topicAppForm.TopicApplicantId = this.employee.EmId;
            topicAppForm.ShowDialog();
        }

        private void tsmiNewCon_Click(object sender, EventArgs e)
        {
            ChooseBoardroomForm chooseboardroomform = new ChooseBoardroomForm();
            chooseboardroomform.emp = employee;
            chooseboardroomform.ShowDialog();
        }

        private void tsmiResouceManage_Click(object sender, EventArgs e)
        {
            ResourceManageForm resourcemanageform = new ResourceManageForm();
            resourcemanageform.emp = employee;
            resourcemanageform.ShowDialog();

        }


        private void tsbNewCon_Click(object sender, EventArgs e)
        {
            ChooseBoardroomForm chooseboardroomform = new ChooseBoardroomForm();
            chooseboardroomform.emp = employee;
            chooseboardroomform.ShowDialog();
        }
        
        private ConferenceModel GetConSort(List<ConferenceModel> list)
        {
            ConferenceModel Result=new ConferenceModel();
            //排序
            List<ConferenceModel> AfterNow = new List<ConferenceModel>();
            foreach(ConferenceModel con in list)
            {
                if(con.ConEndTime>DateTime.Now)
                {
                    AfterNow.Add(con);
                }
            }
            if (AfterNow.Count != 0)
            {
                for (int i = 0; i < AfterNow.Count; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (AfterNow[j].ConEndTime > AfterNow[j + 1].ConEndTime)
                        {
                            ConferenceModel temp = AfterNow[j];
                            AfterNow[j] = AfterNow[j + 1];
                            AfterNow[j + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                throw new Exception("您接下来没有任何会议");
            }
            Result = AfterNow[0];
                return Result;
        }

        private void tsmiUpdateMateria_Click(object sender, EventArgs e)
        {
            SendFileForm sf = new SendFileForm();
            sf.emp = employee;
            sf.ShowDialog();
        }

        private void tsmiConVer_Click(object sender, EventArgs e)
        {
            ConferenceAuditForm conferenceauditform = new ConferenceAuditForm();
            conferenceauditform.emp = employee;
            conferenceauditform.ShowDialog();

        }

        private void tsbManageCon_Click(object sender, EventArgs e)
        {
            ConferenceManagementForm conferencemanagementform = new ConferenceManagementForm();
            conferencemanagementform.emp = employee;
            conferencemanagementform.ShowDialog();
        }



        private void tsbWeekView_Click(object sender, EventArgs e)
        {
            this.c1sView.ViewType = ScheduleViewEnum.WeekView;
            this.c1sView.GroupBy = "";
        }

        private void tsbMouthView_Click(object sender, EventArgs e)
        {
            this.c1sView.ViewType = ScheduleViewEnum.MonthView;
            this.c1sView.GroupBy = "";
        }
        #endregion

        private void c1sView_BeforeAppointmentCreate(object sender, C1.C1Schedule.CancelAppointmentEventArgs e)
        {
            e.Cancel = true;
            ChooseBoardroomForm chooseboardroomform = new ChooseBoardroomForm();
            chooseboardroomform.emp = employee;
            chooseboardroomform.ShowDialog();
        }

        private void tsbDayView_Click(object sender, EventArgs e)
        {
            this.c1sView.ViewType = ScheduleViewEnum.DayView;
            List<string> i = new List<string>();
            foreach (ConferenceModel con in list)
            {
                i.Add(con.ConId.ToString());
            }
            for (int m = 0; m < i.Count; m++)
            {
                for (int n = 0; n < i.Count; n++)
                {
                    if (m != n)
                    {
                        if (i[m] == i[n])
                            i.Remove(i[n]);
                    }
                }
            }
            this.c1sView.GroupBy = i.ToString();
        }

        private void c1sView_BeforeAppointmentEdit(object sender, C1.C1Schedule.CancelAppointmentEventArgs e)
        {
           string name=e.Appointment.Subject;
           List<ConferenceModel> ConferenceList = new List<ConferenceModel>();
           UserBLL user = new UserBLL();
           ConferenceList = user.GetConferenceInfo(name);
           ConferenceModel conf = new ConferenceModel();
           foreach (ConferenceModel con in ConferenceList)
           {
               if(con.ConName==name&&con.ConStartTime==e.Appointment.Start&&con.ConEndTime==e.Appointment.End&&con.ConPlace.ToString()==e.Appointment.Location)
               {
                   conf = con;
               }
           }
            //会议编辑窗体
        }

        private void tsmiTopicVer_Click(object sender, EventArgs e)
        {

        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否确认离开？", "注销确认", MessageBoxButtons.YesNo))
            {
                this.Close();
                LoginForm lf = new LoginForm();
                lf.Show();
            }
        }

        private void 周视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c1sView.ViewType = ScheduleViewEnum.WeekView;
            this.c1sView.GroupBy = "";
        }

        private void 月视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c1sView.ViewType = ScheduleViewEnum.MonthView;
            this.c1sView.GroupBy = "";
        }

        private void 日视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c1sView.ViewType = ScheduleViewEnum.DayView;
            this.c1sView.GroupBy = "Owner";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }


    }
}
