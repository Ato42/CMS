/* 口香糖 Gum Studio
* 
* 文件名：AddTopicForm.cs
* 文件功能描述：增加议题
* 
* 创建标识：朱健 20140923
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
    /// 增加议题类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-23
    /// 修改时间:2014-09-23
    public partial class AddTopicForm : Form
    {
        public int TopicApplicantId ;
        public AddTopicForm()
        {
            InitializeComponent();
            
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
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
