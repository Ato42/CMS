/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：AddBoardroomForm.cs
 * 文件功能描述：添加会议室信息
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
    /// 增加会议室信息类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-17
    /// 修改时间:2014-09-20
    public partial class AddBoardroomForm : Form
    {
        public AddBoardroomForm()
        {
            InitializeComponent();
        }

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
                ConferenceAuditorBLL Add = new ConferenceAuditorBLL();
                BoardroomModel boardroom = new BoardroomModel();

                boardroom.BdrStatus = '1';
                boardroom.BdrName = this.txtBdrName.Text;
                boardroom.BdrContactNum = int.Parse(this.txtBdrContact.Text);
                boardroom.BdrLinkMan = this.txtConMan.Text;
                boardroom.BdrContactPhone = this.txtConPhone.Text;
                boardroom.BdrIntro = this.txtConIntro.Text;
                boardroom.BdrRemarks = this.txtConRemarks.Text;

                Add.AddBoardroom(boardroom);

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
