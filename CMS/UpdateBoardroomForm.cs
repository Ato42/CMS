/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：UpdateboardroomForm.cs
 * 文件功能描述：修改会议室信息
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
    /// 修改会议室信息类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-17
    /// 修改时间:2014-09-22
    public partial class UpdateBoardroomForm : Form
    {
        public BoardroomModel bdrid;


        public UpdateBoardroomForm()
        {
            InitializeComponent();
        }




        private void UpdateBoardroomForm_Load(object sender, EventArgs e)
        {
            load();
        }

        /// <summary>
        /// 获取选中的信息显示在控件中
        /// </summary>
        private void load()
        {
            ConferenceAuditorBLL Boardroom = new ConferenceAuditorBLL();
            List<BoardroomModel> BoardroomList = new List<BoardroomModel>();

            BoardroomList = Boardroom.GetBoardroomInfo("");
            foreach (BoardroomModel boardroom in BoardroomList)
            {
                if (boardroom.BdrId == bdrid.BdrId)
                {
                    if (boardroom.BdrStatus == '1')
                    {
                        ComtxtBdrs.Text = "正常";
                    }
                    else
                    {
                        ComtxtBdrs.Text = "损坏";
                    }
                    txtBdrName.Text = boardroom.BdrName;
                    txtBdrContact.Text = boardroom.BdrContactNum.ToString();
                    txtConMan.Text = boardroom.BdrLinkMan;
                    txtConPhone.Text = boardroom.BdrContactPhone;
                    txtConIntro.Text = boardroom.BdrIntro;
                    txtConRemarks.Text = boardroom.BdrRemarks;
                }
            }
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
                ConferenceAuditorBLL Upd = new ConferenceAuditorBLL();
                BoardroomModel boardroom = new BoardroomModel();

                boardroom.BdrId = bdrid.BdrId;
                if (this.ComtxtBdrs.Text == "正常")
                {
                    boardroom.BdrStatus = '1';
                }
                else
                {
                    boardroom.BdrStatus = '0';
                }
                boardroom.BdrName = this.txtBdrName.Text;
                boardroom.BdrContactNum = int.Parse(this.txtBdrContact.Text);
                boardroom.BdrLinkMan = this.txtConMan.Text;
                boardroom.BdrContactPhone = this.txtConPhone.Text;
                boardroom.BdrIntro = this.txtConIntro.Text;
                boardroom.BdrRemarks = this.txtConRemarks.Text;

                if (Upd.UpdateBoardroom(boardroom))
                {
                    MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("该会议室存在会议,不可修改", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
                this.DialogResult = DialogResult.OK;
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
        /// 取消
        /// </summary>
        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
