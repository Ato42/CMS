using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GS.CMS.BLL;
using GS.CMS.MODEL;

namespace GS.CMS
{
    public partial class ConferenceModForm : Form
    {
        public int selecetedConId;
        public DataSet dataset;
        public EmployeeModel userID;



        public ConferenceModForm()
        {
            InitializeComponent();

        }

        private void ConferenceModForm_Load(object sender, EventArgs e)
        {
            bindtopic();
            bindhost();
            bindPlace();
            UserBLL userbll = new UserBLL();
            ExecutorBLL exebll = new ExecutorBLL();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            conlist = userbll.GetConferenceInfo(selecetedConId.ToString());
            foreach (ConferenceModel con in conlist)
            {
                if (con.ConId == selecetedConId)
                {
                    cmbTopic.Text = con.ConName;
                    cmbHost.Text = con.ConHost;
                    List<BoardroomModel> bdrlist = new List<BoardroomModel>();
                    bdrlist = userbll.GetBoardroomInfo(con.ConPlace.ToString());
                    foreach (BoardroomModel bdr in bdrlist)
                    {
                        cmbPlace.Text = bdr.BdrName;
                    }
                    dtpEnd.Value = con.ConEndTime;
                    dtpStart.Value = con.ConStartTime;
                    List<ResourceModel> reslist = new List<ResourceModel>();
                    reslist = userbll.GetConUseResourceInfo(con.ConId);
                    foreach (ResourceModel res in reslist)
                    {
                        cklStaff.Items.Add(res.ResourceId + "  " + res.ResourceClass);
                    }
                    con.ConOthers = rtxRemarks.Text;
                    cklStaff.Enabled = false;

                }
            }

        }

        /// <summary>
        /// 绑定议题到cmbTopic(需要申请人ID)
        /// </summary>
        /// 未完
        
        private void bindtopic()
        {
            UserBLL userbll = new UserBLL();
            List <TopicModel > toplist = new List<TopicModel> ();
            toplist = userbll.GetUserTopic(userID);
            foreach (TopicModel top in toplist)
            {
                cmbTopic.Items.Add(top.TopicHead);     
            }
        }
        

        /// <summary>
        /// 绑定主办部门
        /// </summary>
        private void bindhost()
        {
            UserBLL userbll = new UserBLL();
            List<EmployeeModel> emlist = new List<EmployeeModel>();
            emlist = userbll.GetAllEmployee();
            foreach (EmployeeModel em in emlist)
            {
                cmbHost.Items.Add(em.EmDepart);
            }
            for (int i = 0; i < cmbHost.Items.Count; i++)
            {
                for (int j = 0; j < cmbHost.Items.Count; j++)
                {
                    if (i != j)
                    {
                        if (cmbHost.Items[i].Equals(cmbHost.Items[j]))

                            cmbHost.Items.Remove(this.cmbHost.Items[i]);
                    }
                }
            }
        }

        /// <summary>
        /// 绑定会议室
        /// </summary>
        private void bindPlace()
        {
            ConferenceAuditorBLL conabll = new ConferenceAuditorBLL();
            List<BoardroomModel> bdrlist = new List<BoardroomModel>();
            bdrlist = conabll.GetBoardroomInfo("");
            foreach (BoardroomModel bdr in bdrlist)
            {
                cmbPlace.Items.Add(bdr.BdrName);
            }
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定修改吗", "系统消息", MessageBoxButtons.OKCancel))
            {
                ConferenceAuditorBLL auditbll = new ConferenceAuditorBLL();
                List<ConferenceModel> conlist = new List<ConferenceModel>();
                conlist = auditbll.GetConferenceInfo(selecetedConId.ToString());
                foreach (ConferenceModel con in conlist)
                {
                    if (con.ConId == this.selecetedConId)
                    {
                        con.ConHost = cmbHost.Text;
                        List<BoardroomModel> bdrlist = new List<BoardroomModel>();
                        bdrlist = auditbll.GetBoardroomInfo(cmbPlace.Text);
                        foreach (BoardroomModel bdr in bdrlist)
                        {
                            con.ConPlace = bdr.BdrId;
                        }
                        con.ConStartTime = dtpStart.Value;
                        con.ConEndTime = dtpEnd.Value;

                        auditbll.UpdateCon(con);
                        MessageBox.Show("修改成功！");
                    }
                }
            }
        }

        private void cklStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cklStaff_Click(object sender, EventArgs e)
        {
            //if (this.cklStaff.GetItemChecked(this.cklStaff.SelectedIndex) == true)
            //{
            //    // 删除一条资源
            //    MessageBox.Show("已提交申请的资源无法删除！");
            //}
            //else
            //{
            //    // 添加一条资源
            //    ConUseResourceModel addUseRsc = new ConUseResourceModel();
            //    addUseRsc.ConId = selecetedConId;
            //    this.cklStaff.SelectedItem= this.cklStaff.Items[this.cklStaff.SelectedIndex];
            //    string[] rsc = this.cklStaff.Text.Split(' ');
            //    addUseRsc.DeviceId = int.Parse(rsc[0]);

            //    ConferenceAuditorBLL cabll = new ConferenceAuditorBLL();
            //    if (cabll.AddConUseResource(addUseRsc))
            //    {
            //        MessageBox.Show("添加成功！");
            //    }
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ConferenceManagementForm conmaga = new ConferenceManagementForm();
            this.Close();
            conmaga.Show();
        }



    }
}
