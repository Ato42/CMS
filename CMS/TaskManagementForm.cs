/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：TaskManagementForm.cs
 * 文件功能描述：获取任务单
 * 
 * 创建标识：王宇昊 20140924
 * 
 * 修改标识：
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GS.CMS.MODEL;
using GS.CMS.BLL;


namespace GS.CMS
{
    /// <summary>
    /// 获取任务单
    /// </summary>
    /// 作者:王宇昊
    /// 创建时间:2014-09-24
    /// 修改时间:2014-09-24
    public partial class TaskManagementForm : Form
    {
        public EmployeeModel employee = new EmployeeModel();
       
        public TaskManagementForm()
        {
            InitializeComponent();
        }

        private void TaskManagementForm_Load(object sender, EventArgs e)
        {
            GetTask();
        }

        /// <summary>
        /// 获取任务单
        /// </summary>
        /// 作者:王宇昊
        /// 创建时间:2014-09-24
        /// 修改时间:2014-09-24
        private void GetTask()
        {
            try
            {
                dgvTask.Rows.Clear();
                ExecutorBLL Task = new ExecutorBLL();
                List<TaskModel> TaskList = new List<TaskModel>();
                ConferenceAuditorBLL ResourceName = new ConferenceAuditorBLL();
                List<ResourceModel> Resource = new List<ResourceModel>();
                TaskList = Task.GetTask(employee);
                int n = 0;
                foreach (TaskModel task in TaskList)
                {
                    if (task.TaskConference.ConIsDone == '0')
                    {
                        dgvTask.Rows.Add();
                        dgvTask.Rows[n].Cells["ColumnConferenceId"].Value = task.TaskConference.ConId;
                        dgvTask.Rows[n].Cells["ColumnConference"].Value = task.TaskBdrName;
                        dgvTask.Rows[n].Cells["ColumnBoardroom"].Value = task.TaskConference.ConName;
                        dgvTask.Rows[n].Cells["ColumnStartTime"].Value = task.TaskConference.ConStartTime;
                        dgvTask.Rows[n].Cells["ColumnResource"].Value = "";
                        for (int i = 0; i < task.TaskResource.Count; i++)
                        {
                            Resource = ResourceName.GetAllResource();
                            foreach (ResourceModel Res in Resource)
                            {
                                if (Res.ResourceId == Convert.ToInt32(task.TaskResource[i]))
                                {
                                    dgvTask.Rows[n].Cells["ColumnResource"].Value += task.TaskResource[i].ToString() + Res.ResourceClass + "\r\n";
                                }
                            }

                        }
                        n++;
                    }
                }

                //txtResId.Text = this.dgvTask.CurrentRow.Cells["ColumnResourceId"].Value.ToString();
                dgvTask_CellContentClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 选中任务单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 作者:王宇昊
        /// 创建时间:2014-09-24
        /// 修改时间:2014-09-24
        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtConId.Text = this.dgvTask.CurrentRow.Cells["ColumnConferenceId"].Value.ToString();
            //txtCon.Text = this.dgvTask.CurrentRow.Cells["ColumnConference"].Value.ToString();
            //txtBdr.Text = this.dgvTask.CurrentRow.Cells["ColumnBoardroom"].Value.ToString();
            //txtTime.Text = this.dgvTask.CurrentRow.Cells["ColumnStartTime"].Value.ToString();
            //txtRes.Text = this.dgvTask.CurrentRow.Cells["ColumnResource"].Value.ToString();

            lbConId.Text = this.dgvTask.CurrentRow.Cells["ColumnConferenceId"].Value.ToString();
            lbCon.Text = this.dgvTask.CurrentRow.Cells["ColumnConference"].Value.ToString();
            lbBdr.Text = this.dgvTask.CurrentRow.Cells["ColumnBoardroom"].Value.ToString();
            lbTime.Text = this.dgvTask.CurrentRow.Cells["ColumnStartTime"].Value.ToString();
            lbRes.Text = this.dgvTask.CurrentRow.Cells["ColumnResource"].Value.ToString();
        }

        /// <summary>
        /// 确认任务单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 作者:王宇昊
        /// 创建时间:2014-09-24
        /// 修改时间:2014-09-24
        private void btnEnsure_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTask.RowCount != 0)
                {
                    ConferenceAuditorBLL Save = new ConferenceAuditorBLL();
                    ExecutorBLL Get = new ExecutorBLL();
                    List<ConferenceModel> Conference = new List<ConferenceModel>();
                    Conference = Get.GetConferenceInfo("");
                    foreach (ConferenceModel con in Conference)
                    {
                        if (con.ConId.ToString() == this.dgvTask.CurrentRow.Cells["ColumnConferenceId"].Value.ToString())
                        {
                            con.ConIsDone = '1';
                            Save.UpdateConference(con);
                            MessageBox.Show("确认成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    GetTask();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConMen_Click(object sender, EventArgs e)
        {
            ConMemberForm cmf = new ConMemberForm();
            cmf.Conid = int.Parse(this.lbConId.Text);
            cmf.ShowDialog();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegisterManagementForm rmf = new RegisterManagementForm();
            rmf.conid = int.Parse(this.lbConId.Text);
            rmf.ShowDialog();
        }
    }
}
