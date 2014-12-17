using System;
using System.Collections.Generic;
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
    public partial class ConferenceAuditForm : Form
    {
        public EmployeeModel emp = new EmployeeModel();
        public ConferenceAuditForm()
        {
            InitializeComponent();
        }

        ConferenceAuditorBLL auditbll = new ConferenceAuditorBLL();
        ExecutorBLL exebll = new ExecutorBLL();

        /// <summary>
        /// 绑定数据到dgv，cmb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConferenceAudit_Load(object sender, EventArgs e)
        {
            bingdgv();
            dgvNotAudit_CellContentClick_1(null,null);
            //dgvAudit_CellContentClick(null, null);
            #region 绑定cmb
            //绑定CmbPlace
            List<BoardroomModel> bdrlist = new List<BoardroomModel>();
            bdrlist = auditbll.GetBoardroomInfo("");
            foreach (BoardroomModel bdr in bdrlist)
            {
                cmbPlace.Items.Add(bdr.BdrName);
            }
            //CmbStaffMan
            List<EmployeeModel> perlist = new List<EmployeeModel>();
            perlist = auditbll.GetAllEmployee();
            foreach (EmployeeModel em in perlist)
            {
                if (em.EmPermission == "CE")
                {
                    cmbStaffMan.Items.Add(em.EmName );
                }
            }
            //绑定部门到下拉控件
            List<EmployeeModel> hostlist = new List<EmployeeModel>();
            hostlist = auditbll.GetAllEmployee();
            foreach (EmployeeModel em in hostlist)
            {
                cmbHost.Items.Add(em.EmDepart);
            }
            for (int i = 0; i < cmbHost.Items.Count; i++)
            {
                for(int j=0;j<cmbHost.Items.Count;j++)
                {
                    if (i != j)
                    {
                        if (cmbHost.Items[i].Equals(cmbHost.Items[j]))

                            cmbHost.Items.Remove(this.cmbHost.Items[i]);
                    }
                }
            }
            
            //绑定议题到下拉控件
            //List<TopicModel> toplist = new List<TopicModel>();
            //toplist = auditbll.GetUserTopic();
            #endregion
        }

        /// <summary>
        /// 在dgvAudit选中单元格时显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strConName = dgvAudit.CurrentRow.Cells["ColumnConId2"].Value.ToString();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            List<EmployeeModel> inclist = new List<EmployeeModel >();
            
            conlist = auditbll.GetConferenceInfo(strConName);
            foreach (ConferenceModel con in conlist)
            {
                if (int.Parse(strConName) == con.ConId)
                {
                    inclist = exebll.GetInConMemberInfo(con);
                    cmbRecMan.Items.Clear();
                    foreach (EmployeeModel em in inclist)
                    {
                        cmbRecMan.Items.Add(em.EmName);
                    }
                    cmbRecMan.Text = auditbll.GetAEmployee(con.ConRecordMen).EmName;
                    cmbRecMan.Enabled = false;
                    cmbStaffMan.Text = auditbll.GetAEmployee(con.ConStaffMen).EmName;
                    cmbStaffMan.Enabled = false;

                    txtConId.Text = con.ConId.ToString();
                    txtConId.Enabled = false;
                    cmbHost.SelectedItem = con.ConHost;
                    cmbTopic.Text = con.ConName;
                    cmbTopic.Enabled = false;
                    rtxRemarks2.Text = con.ConOthers;
                    if (con.ConRegister == '0')
                    {
                        txtReg.Text = "不用签到";
                    }
                    else
                    {
                        txtReg.Text = "需要签到";
                    }
                    txtReg.Enabled = false;
                    if (con.ConType == '0')
                    {
                        txtType.Text = "内部会议";
                    }
                    else
                    {
                        txtType.Text = "外部会议";
                    }
                    txtType.Enabled = false;
                    List<BoardroomModel> bdrlist = new List<BoardroomModel>();
                    bdrlist = auditbll.GetBoardroomInfo(con.ConPlace.ToString());
                    foreach (BoardroomModel bdr in bdrlist)
                    {
                        cmbPlace.Text = bdr.BdrName;
                    }
                    List<ResourceModel> reslist = new List<ResourceModel>();
                    reslist = auditbll.GetConUseResourceInfo(con.ConId);
                    lstStaff2.Items.Clear();
                    foreach (ResourceModel res in reslist)
                    {
                        lstStaff2.Items.Add(res.ResourceId + "  " + res.ResourceClass);
                    }
                }
            }  
        }

        /// <summary>
        /// 在dgvNotAudit选中单元格时显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNotAudit_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string strConName = dgvNotAudit.CurrentRow.Cells["ColumnConId1"].Value.ToString();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            conlist = auditbll.GetConferenceInfo(strConName);
            foreach (ConferenceModel con in conlist)
            {
                if (int.Parse(strConName) == con.ConId)
                {
                    lblConHost.Text = con.ConHost;
                    lblConId.Text = con.ConId.ToString();
                    lblRecMan.Text = auditbll.GetAEmployee(con.ConRecordMen).EmName;
                    lblStaffMan.Text = auditbll.GetAEmployee(con.ConStaffMen).EmName;
                    lblType.Text = con.ConType.ToString();
                    rtxRemarks1.Text = con.ConOthers;
                    if (con.ConRegister == '0')
                    {
                        lblReg.Text = "不用签到";
                    }
                    else
                    {
                        lblReg.Text = "需要签到";
                    }
                    if (con.ConType == '0')
                    {
                        lblType.Text = "内部会议";
                    }
                    else
                    {
                        lblType.Text = "外部会议";
                    }
                    List<BoardroomModel> bdrlist = new List<BoardroomModel>();
                    bdrlist = auditbll.GetBoardroomInfo(con.ConPlace.ToString());
                    foreach (BoardroomModel bdr in bdrlist)
                    {
                        lblConPlace.Text = bdr.BdrName;
                    }
                    List<ResourceModel> reslist = new List<ResourceModel>();
                    reslist = auditbll.GetConUseResourceInfo(con.ConId);
                    lstStaff1.Items.Clear();
                    foreach (ResourceModel res in reslist)
                    {
                        lstStaff1.Items.Add(res.ResourceId + "  " + res.ResourceClass);
                    }
                }
            } 
        }


        /// <summary>
        /// 修改已审核的会议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMod_Click(object sender, EventArgs e)
        {
            string strConName = dgvAudit.CurrentRow.Cells["ColumnConId2"].Value.ToString();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            List<BoardroomModel> bdrlist = new List<BoardroomModel>();
            List <EmployeeModel > emlist =new List<EmployeeModel> ();
            List <EmployeeModel >emlist2 = new List<EmployeeModel> ();

            conlist = auditbll.GetConferenceInfo(strConName);
            foreach (ConferenceModel con in conlist)
            {
                if (int.Parse(strConName) == con.ConId)
                {
                    bdrlist = auditbll.GetBoardroomInfo(cmbPlace.Text);
                    foreach (BoardroomModel bdr in bdrlist)
                    {
                        con.ConPlace = bdr.BdrId;
                    }
                    MessageBox.Show(con.ConPlace.ToString());

                    con.ConStartTime = dtpStart.Value;

                    con.ConEndTime = dtpEnd.Value;

                    con.ConHost = cmbHost.Text;

                    auditbll.UpdateConference(con);
                }
            }
            dgvAudit.Rows.Clear();
            bingdgv();    
        }

        /// <summary>
        /// 删除已审核的会议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            string strConName = dgvAudit.CurrentRow.Cells["ColumnConId2"].Value.ToString();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            conlist = auditbll.GetConferenceInfo(strConName);
            foreach (ConferenceModel con in conlist)
            {
                if (int.Parse(strConName) == con.ConId)
                {
                    auditbll.DelConference(con);
                }
            }
            dgvAudit.Rows.Clear();
            bingdgv();
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPass_Click(object sender, EventArgs e)
        {
            string strConId = dgvNotAudit.CurrentRow.Cells["ColumnConId1"].Value.ToString();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            conlist = auditbll.GetConferenceInfo(strConId);
            foreach (ConferenceModel con in conlist)
            {
                if (con.ConId == int.Parse(strConId))
                {
                    con.ConStatus = '1';
                    auditbll.VerifyConference(con);
                    MessageBox.Show("审核成功！");
                }
            }
            dgvNotAudit.Rows.Clear();
            dgvAudit.Rows.Clear();
            bingdgv();
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNotPass_Click(object sender, EventArgs e)
        {
            string strConId = dgvNotAudit.CurrentRow.Cells["ColumnConId1"].Value.ToString();
            List<ConferenceModel> conlist = new List<ConferenceModel>();
            conlist = auditbll.GetConferenceInfo(strConId);
            foreach (ConferenceModel con in conlist)
            {
                if (con.ConId == int.Parse(strConId))
                {
                    con.ConStatus = '2';
                    auditbll.VerifyConference(con);
                    MessageBox.Show("已驳回申请");
                }
            }
            dgvNotAudit.Rows.Clear();
            bingdgv();
        }

 
        /// <summary>
        /// 绑定dgv
        /// </summary>
        public void bingdgv()
        {
            List<ConferenceModel> conlist = auditbll.GetConferenceInfo("0");
            List<ConferenceModel> conresult1 = new List<ConferenceModel>();
            List<ConferenceModel> conresult2 = new List<ConferenceModel>();
            int n = 0;
            int m = 0;
            foreach (ConferenceModel co1 in conlist)
            {
                if (co1.ConStatus == '0')
                {
                    conresult1.Add(co1);
                }
                else if (co1.ConStatus =='1')
                {
                    conresult2.Add(co1);
                }
            }
            foreach (ConferenceModel co2 in conresult1)
            {
                dgvNotAudit.Rows.Add();
                dgvNotAudit.Rows[n].Cells["ColumnConId1"].Value = co2.ConId;
                dgvNotAudit.Rows[n].Cells["Column1"].Value = co2.ConName;
                dgvNotAudit.Rows[n].Cells["Column2"].Value = co2.ConStartTime;
                string s = auditbll.GetAEmployee(co2.ConId).EmName;
                dgvNotAudit.Rows[n].Cells["Column3"].Value = auditbll.GetAEmployee(co2.ConSubMen).EmName;
                n++;
            }
            foreach (ConferenceModel co3 in conresult2)
            {
                dgvAudit.Rows.Add();
                dgvAudit.Rows[m].Cells["ColumnConId2"].Value = co3.ConId;
                dgvAudit.Rows[m].Cells["Column4"].Value = co3.ConName;
                dgvAudit.Rows[m].Cells["Column5"].Value = co3.ConStartTime;
                dgvAudit.Rows[m].Cells["Column6"].Value = auditbll.GetAEmployee(co3.ConSubMen).EmName;
                m++;
            }
        }


    }
}
