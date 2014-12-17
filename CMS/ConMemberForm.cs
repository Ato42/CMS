/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConMemberForm.cs
 * 文件功能描述：参会人员信息管理
 * 
 * 创建标识：朱健 20140920
 * 
 * 修改标识：朱健 20140922
 * 修改描述：完善功能
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
using GS.CMS.DAL;

namespace GS.CMS
{
    /// <summary>
    /// 与会人员信息管理类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-20
    /// 修改时间:2014-09-22
    public partial class ConMemberForm : Form
    {
        public ConMemberForm()
        {
            InitializeComponent();
        }
        private int conid = 10006; // 来自会议界面传过来的会议ID参数

        public int Conid
        {
            get { return conid; }
            set { conid = value; }
        }


        /// <summary>
        /// 窗口打开读取所有与会人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConMemberForm_Load(object sender, EventArgs e)
        {
            OutQuery();
            InQuery();
        }

        /// <summary>
        /// 查询外部与会人员信息
        /// </summary>
        private void OutQuery()
        {
            try
            {
                dgvOutConMember.Rows.Clear();
                ExecutorBLL OutConMember = new ExecutorBLL();
                List<OutConMemberModel> OutConMemberList = new List<OutConMemberModel>();
                ConferenceModel Conid = new ConferenceModel();
                Conid.ConId = Convert.ToInt32(conid);
                OutConMemberList = OutConMember.GetOutConMemberRegisterInfo(Conid);
                int n = 0;
                foreach (OutConMemberModel outConMember in OutConMemberList)
                {
                    dgvOutConMember.Rows.Add();

                    dgvOutConMember.Rows[n].Cells["ColumnConId"].Value = outConMember.ConId;
                    dgvOutConMember.Rows[n].Cells["ColumnConName"].Value = outConMember.ConName;
                    dgvOutConMember.Rows[n].Cells["ColumnConSex"].Value = outConMember.ConSex;
                    dgvOutConMember.Rows[n].Cells["ColumnConDuties"].Value = outConMember.ConDuties;
                    dgvOutConMember.Rows[n].Cells["ColumnConPhone"].Value = outConMember.ConPhone;
                    dgvOutConMember.Rows[n].Cells["ColumnConEmail"].Value = outConMember.ConEmail;
                    dgvOutConMember.Rows[n].Cells["ColumnConCompany"].Value = outConMember.ConCompany;
                    if (outConMember.ConRegister == '1')
                    {
                        dgvOutConMember.Rows[n].Cells["ColumnConRegister"].Value = "已签到";
                    }
                    else
                    {
                        dgvOutConMember.Rows[n].Cells["ColumnConRegister"].Value = "未签到";
                    } 
                    n++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 查询内部与会人员信息
        /// </summary>
        private void InQuery()
        {
            try
            {
                dgvInConMember.Rows.Clear();
                ExecutorBLL InConMember = new ExecutorBLL();
                List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
                ConferenceModel Conid = new ConferenceModel();
                Conid.ConId = Convert.ToInt32(conid);
                EmployeeList = InConMember.GetInConMemberInfo(Conid);
                int n = 0;
                foreach (EmployeeModel employee in EmployeeList)
                {
                    dgvInConMember.Rows.Add();

                    dgvInConMember.Rows[n].Cells["ColumnEmId"].Value = employee.EmId;
                    dgvInConMember.Rows[n].Cells["ColumnEmName"].Value = employee.EmName;
                    dgvInConMember.Rows[n].Cells["ColumnEmPermission"].Value = employee.EmPermission;
                    dgvInConMember.Rows[n].Cells["ColumnEmSex"].Value = employee.EmSex;
                    dgvInConMember.Rows[n].Cells["ColumnEmDepart"].Value = employee.EmDepart;
                    dgvInConMember.Rows[n].Cells["ColumnEmPhone"].Value = employee.EmPhone;
                    dgvInConMember.Rows[n].Cells["ColumnEmEmail"].Value = employee.EmEmail;
                    dgvInConMember.Rows[n].Cells["ColumnEmCompany"].Value = employee.EmCompany;
                    dgvInConMember.Rows[n].Cells["ColumnEmDuties"].Value = employee.EmDuties;

                    n++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddConMember_Click(object sender, EventArgs e)
        {
            Add();
        }


        /// <summary>
        /// 弹出添加外部与会人员窗口
        /// </summary>
        private void Add()
        {
            AddConMemberForm Add = new AddConMemberForm();
            if (Add.ShowDialog() == DialogResult.OK)
            {
                OutQuery();
            } 
        }





        private void btnAddConInEXCEL_Click(object sender, EventArgs e)
        {
            ExcelToSqlBLL Ex = new ExcelToSqlBLL();
            Ex.OutExcel(Conid);
            OutQuery();
        }
        /// <summary>
        /// 从EXceld导入与会人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInConInEXCEL_Click(object sender, EventArgs e)
        {
            ExcelToSqlBLL Ex = new ExcelToSqlBLL();
            Ex.InExcel(Conid);
            InQuery();
        }

    }
}
