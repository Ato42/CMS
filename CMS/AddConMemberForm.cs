/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：AddConMemberForm.cs
 * 文件功能描述：添加外部与会人员信息
 * 
 * 创建标识：朱健 20140917
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
    /// 添加外部与会人员信息类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-17
    /// 修改时间:2014-09-20
    public partial class AddConMemberForm : Form
    {
        public AddConMemberForm()
        {
            InitializeComponent();
        }
        ConMemberForm conid = new ConMemberForm();//实体化会议管理窗口中的会议ID

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            Ensure();
        }


        /// <summary>
        /// 确认提交
        /// </summary>
        private void Ensure()
        {
            try
            {
                ExecutorBLL Add = new ExecutorBLL();
                OutConMemberModel OutConMember = new OutConMemberModel();

                OutConMember.ConId = conid.Conid;
                OutConMember.ConName = this.txtConName.Text;
                OutConMember.ConSex = this.cmbConSex.Text;
                OutConMember.ConDuties = this.txtConDuties.Text;
                OutConMember.ConPhone = this.txtConPhone.Text;
                OutConMember.ConEmail = this.txtConEmail.Text;
                OutConMember.ConCompany = this.txtConCompany.Text;
                OutConMember.ConRegister = '0';

                Add.AddConMenRecord(OutConMember);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// 传值会议ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddConMemberForm_Load(object sender, EventArgs e)
        {
            int i = conid.Conid;
            txtConId.Text = i.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
        }



    }
}
