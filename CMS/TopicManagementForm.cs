/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：TopicManagementForm.cs
 * 文件功能描述：议题管理
 * 
 * 创建标识：朱健 20140923
 * 
 * 修改标识：王宇昊 20140923
 * 修改描述：修改函数
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
    /// 议题管理类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-23
    /// 修改时间:2014-09-23
    public partial class TopicManagementForm : Form
    {
        public int userId;

        public TopicManagementForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 读取议题信息函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicManagementForm_Load(object sender, EventArgs e)
        {
            load('0', "未审核", dgvTopic, "dgvTopic","");
            load('1', "已审核", dgvTopic2, "dgvTopic2", "");
            load('2', "未通过", dgvTopic3, "dgvTopic3", "");
        }



        /// <summary>
        /// 读取议题信息
        /// </summary>
        /// <param name="statut">状态</param>
        /// <param name="statusDisplay">状态名称</param>
        /// <param name="dgvTopic">填充的表格</param>
        /// <param name="Name">列名前缀</param>
        /// <param name="query">查询的内容</param>
        private void load(char statut, string statusDisplay, DataGridView dgvTopic, string Name, string query)
        {
            try
            {
                dgvTopic.Rows.Clear();
                TopicAuditorBLL Topic = new TopicAuditorBLL();
                List<TopicModel> TopicList = new List<TopicModel>();
                ConferenceAuditorBLL GetAEmployee = new ConferenceAuditorBLL();
                TopicList = Topic.GetTopicInfo(query);
                int n = 0;
                foreach (TopicModel topic in TopicList)
                {

                    if (topic.TopicStatus == statut)
                    {
                        dgvTopic.Rows.Add();
                        dgvTopic.Rows[n].Cells[Name+"Id"].Value = topic.TopicId;
                        dgvTopic.Rows[n].Cells[Name + "ApplicantId"].Value = topic.TopicApplicantId;
                        dgvTopic.Rows[n].Cells[Name + "Applicant"].Value = GetAEmployee.GetAEmployee(topic.TopicApplicantId).EmName;
                        dgvTopic.Rows[n].Cells[Name + "SubTime"].Value = topic.TopicSubTime;
                        if (topic.TopicStatus == '0')
                        {
                            dgvTopic.Rows[n].Cells[Name + "VerifyTime"].Value = "";
                        }
                        else
                        {
                            dgvTopic.Rows[n].Cells[Name + "VerifyTime"].Value = topic.TopicVerifyTime;
                        }
                        dgvTopic.Rows[n].Cells[Name + "Head"].Value = topic.TopicHead;
                        dgvTopic.Rows[n].Cells[Name + "Content"].Value = topic.TopicContent;
                        dgvTopic.Rows[n].Cells[Name + "Status"].Value = statusDisplay;
                        n++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        
        /// <summary>
        /// 通过审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定通过审核?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                UpdateTopic('1');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        /// <summary>
        /// 未通过审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定拒绝通过审核?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                UpdateTopic('2');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        /// <summary>
        /// 更改议题状态
        /// </summary>
        /// <param name="Tag">更改标志</param>
        private void UpdateTopic(char Tag)
        {
            TopicAuditorBLL Topic = new TopicAuditorBLL();
            TopicModel topic = new TopicModel();

            topic.TopicId = int.Parse(this.dgvTopic.CurrentRow.Cells["dgvTopicId"].Value.ToString());
            topic.TopicApplicantId = int.Parse(this.dgvTopic.CurrentRow.Cells["dgvTopicApplicantId"].Value.ToString());
            topic.TopicSubTime = Convert.ToDateTime(this.dgvTopic.CurrentRow.Cells["dgvTopicSubTime"].Value);
            topic.TopicVerifyTime = DateTime.Now;
            topic.TopicHead = this.dgvTopic.CurrentRow.Cells["dgvTopicHead"].Value.ToString();
            topic.TopicContent = this.dgvTopic.CurrentRow.Cells["dgvTopicContent"].Value.ToString();
            string status = this.dgvTopic.CurrentRow.Cells["dgvTopicStatus"].Value.ToString();

            if (Tag == '1')
            {
                if (status != "已审核")
                {
                    topic.TopicStatus = '1';
                    Topic.UpdateTopic(topic);
                    MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
            if (Tag == '2')
            {
                if (status == "未审核")
                {
                    topic.TopicStatus = '2';
                    Topic.UpdateTopic(topic);
                    MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            this.TopicManagementForm_Load(null, null);
        }



        
        /// <summary>
        /// 增加议题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTopicForm Add = new AddTopicForm();
            Add.TopicApplicantId = userId;
            if (Add.ShowDialog() == DialogResult.OK)
            {
                
                this.TopicManagementForm_Load(null, null);
            } 
        }




        /// <summary>
        /// 通过议题ID查询未审核议题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                load('0', "未审核", dgvTopic, "dgvTopic", txtQuery.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            try
            {
                load('1', "已审核", dgvTopic2, "dgvTopic2", txtQuery2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            try
            {
                load('2', "未通过", dgvTopic3, "dgvTopic3", txtQuery3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
