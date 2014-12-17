/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：RegisterManagementForm.cs
 * 文件功能描述：与会人员签到管理
 * 
 * 创建标识：朱健 20140922
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
    /// 签到管理类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-22
    /// 修改时间:2014-09-22
    public partial class RegisterManagementForm : Form
    {
        public RegisterManagementForm()
        {
            InitializeComponent();
        }

        public int conid = 10006;//来自会议界面传过来的会议ID参数

        private void RegisterManagementForm_Load(object sender, EventArgs e)
        {
            OutQuery();
            InQuery();
        }

        /// <summary>
        /// 查询外部与会人员签到信息
        /// </summary>
        private void OutQuery()
        {
            try
            {
                dgvOutRegister.Rows.Clear();
                ExecutorBLL OutConMember = new ExecutorBLL();
                List<OutConMemberModel> OutConMemberList = new List<OutConMemberModel>();
                ConferenceModel Conid = new ConferenceModel();
                Conid.ConId = Convert.ToInt32(conid);
                OutConMemberList = OutConMember.GetOutConMemberRegisterInfo(Conid);
                int n = 0;
                foreach (OutConMemberModel outConMember in OutConMemberList)
                {
                    dgvOutRegister.Rows.Add();

                    dgvOutRegister.Rows[n].Cells["ColumnConDuties"].Value = outConMember.ConDuties;
                    dgvOutRegister.Rows[n].Cells["ColumnConName"].Value = outConMember.ConName;
                    dgvOutRegister.Rows[n].Cells["ColumnConCompany"].Value = outConMember.ConCompany;
                    dgvOutRegister.Rows[n].Cells["ColumnConId"].Value = outConMember.ConId;
                    dgvOutRegister.Rows[n].Cells["ColumnConPhone"].Value = outConMember.ConPhone;

                    if (outConMember.ConRegister == '1')
                    {
                        ((DataGridViewCheckBoxCell)dgvOutRegister.Rows[n].Cells["ColumnConRegister"]).Value = true;
                    }
                    if (outConMember.ConRegister == '0')
                    {
                        ((DataGridViewCheckBoxCell)dgvOutRegister.Rows[n].Cells["ColumnConRegister"]).Value = false;
                    }
                    n++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnOutSave_Click(object sender, EventArgs e)
        {
            OutSave();
        }


        /// <summary>
        /// 保存外部与会人员签到信息
        /// </summary>
        private void OutSave()
        {
            try
            {
                ExecutorBLL Execu = new ExecutorBLL();
                OutConMemberModel OutCon = new OutConMemberModel();
                for (int n = 0; n < dgvOutRegister.Rows.Count; n++)
                {
                    string selectValue = dgvOutRegister.Rows[n].Cells["ColumnConRegister"].EditedFormattedValue.ToString();
                    if (selectValue == "True")
                    {
                        OutCon.ConId = Convert.ToInt32(conid);
                        OutCon.ConRegister = '1';
                        OutCon.ConPhone = dgvOutRegister.Rows[n].Cells["ColumnConPhone"].Value.ToString();
                        Execu.OutConMemberRegister(OutCon);
                    }
                    else
                    {
                        OutCon.ConId = Convert.ToInt32(conid);
                        OutCon.ConRegister = '0';
                        OutCon.ConPhone = dgvOutRegister.Rows[n].Cells["ColumnConPhone"].Value.ToString();
                        Execu.OutConMemberRegister(OutCon);
                    }
                }
                MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OutQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// 查询内部与会人员签到信息
        /// </summary>
        private void InQuery()
        {
            try
            {
                dgvInRegister.Rows.Clear();
                ExecutorBLL InConMember = new ExecutorBLL();
                List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
                List<InConMemberModel> inconList = new List<InConMemberModel>();
                ConferenceModel Conid = new ConferenceModel();
                ConferenceModel Con = new ConferenceModel();

                Conid.ConId = Convert.ToInt32(conid);
                EmployeeList = InConMember.GetInConMemberInfo(Conid);
                int n = 0;
                foreach (EmployeeModel employee in EmployeeList)
                {
                    dgvInRegister.Rows.Add();
                    dgvInRegister.Rows[n].Cells["ColumnEmId"].Value = employee.EmId;
                    dgvInRegister.Rows[n].Cells["ColumnEmName"].Value = employee.EmName;
                    dgvInRegister.Rows[n].Cells["ColumnEmPhone"].Value = employee.EmPhone;
                    dgvInRegister.Rows[n].Cells["ColumnEmDuties"].Value = employee.EmDuties;
                    Con.ConId = Conid.ConId;
                    inconList = InConMember.GetInConMemberRegisterInfo(Con);
                    foreach (InConMemberModel incon in inconList)
                    {
                        if (incon.ConEmId == employee.EmId)
                        {
                            if (incon.ConRegister == '1')
                            {
                                ((DataGridViewCheckBoxCell)dgvInRegister.Rows[n].Cells["ColumnInConRegister"]).Value = true;
                            }
                            if (incon.ConRegister == '0')
                            {
                                ((DataGridViewCheckBoxCell)dgvInRegister.Rows[n].Cells["ColumnInConRegister"]).Value = false;
                            }
                        }
                        dgvInRegister.Rows[n].Cells["ColumnConId2"].Value = incon.ConId;
                    }
                    n++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnInSave_Click(object sender, EventArgs e)
        {
            InSave();
        }



        /// <summary>
        /// 保存内部与会人员签到信息
        /// </summary>
        private void InSave()
        {
            try
            {
                ExecutorBLL Execu = new ExecutorBLL();
                InConMemberModel InCon = new InConMemberModel();
                for (int n = 0; n < dgvInRegister.Rows.Count; n++)
                {
                    string selectValue = dgvInRegister.Rows[n].Cells["ColumnInConRegister"].EditedFormattedValue.ToString();
                    if (selectValue == "True")
                    {
                        InCon.ConId = Convert.ToInt32(conid);
                        InCon.ConRegister = '1';
                        InCon.ConEmId = int.Parse(dgvInRegister.Rows[n].Cells["ColumnEmId"].Value.ToString());
                        Execu.InConMemberRegister(InCon);
                    }
                    else
                    {
                        InCon.ConId = Convert.ToInt32(conid);
                        InCon.ConRegister = '0';
                        InCon.ConEmId = int.Parse(dgvInRegister.Rows[n].Cells["ColumnEmId"].Value.ToString());
                        Execu.InConMemberRegister(InCon);
                    }
                }
                MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



       

    }
}
