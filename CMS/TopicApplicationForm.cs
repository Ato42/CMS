/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：TopicApplicationForm.cs
 * 文件功能描述：议题申请
 * 
 * 创建标识：朱健 20140923
 * 
 * 修改标识：王宇昊 20140923
 * 修改描述：填充内容
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
    /// 议题申请类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-23
    /// 修改时间:2014-09-23
    public partial class TopicApplicationForm : Form
    {
        public int TopicApplicantId;
        public TopicApplicationForm()
        {
            InitializeComponent();
        }

        private void TopicApplicationForm_Load(object sender, EventArgs e)
        {
            load();
        }
        /// <summary>
        /// 确认提交议题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnsure_Click(object sender, EventArgs e)
        {
            try
            {
                TopicAuditorBLL Topic = new TopicAuditorBLL();
                TopicModel topic = new TopicModel();

                topic.TopicHead = txtTopicHead.Text;
                topic.TopicContent = txtTopicContent.Text;
                topic.TopicStatus = char.Parse("0");
                topic.TopicSubTime = DateTime.Now;
                topic.TopicVerifyTime = Convert.ToDateTime("1-1-1");
                topic.TopicApplicantId = TopicApplicantId;

                Topic.AddTopic(topic);
                
                MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 读取议题信息
        /// </summary>
        private void load()
        {
            try
            {
                dgvTopic.Rows.Clear();
                TopicAuditorBLL Topic = new TopicAuditorBLL();
                List<TopicModel> TopicList = new List<TopicModel>();
                ConferenceAuditorBLL GetAEmployee = new ConferenceAuditorBLL();
                TopicList = Topic.GetTopicInfo("");
                int n = 0;
                foreach (TopicModel topic in TopicList)
                {
                    if (topic.TopicApplicantId == TopicApplicantId)
                    {
                        dgvTopic.Rows.Add();
                        dgvTopic.Rows[n].Cells["dgvTopicSubTime"].Value = topic.TopicSubTime;
                        if (topic.TopicStatus == '0')
                        {
                            dgvTopic.Rows[n].Cells["dgvTopicVerifyTime"].Value = "";
                            dgvTopic.Rows[n].Cells["dgvTopicStatus"].Value = "未审核";
                        }
                        else
                        {
                            dgvTopic.Rows[n].Cells["dgvTopicVerifyTime"].Value = topic.TopicVerifyTime;
                            if (topic.TopicStatus == '1')
                            {
                                dgvTopic.Rows[n].Cells["dgvTopicStatus"].Value = "已审核";
                            }
                            else
                            {
                                dgvTopic.Rows[n].Cells["dgvTopicStatus"].Value = "未通过";
                            }
                        }
                        dgvTopic.Rows[n].Cells["dgvTopicHead"].Value = topic.TopicHead;
                        dgvTopic.Rows[n].Cells["dgvTopicContent"].Value = topic.TopicContent;
                        n++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTopic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
