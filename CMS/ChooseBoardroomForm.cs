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
using GS.CMS.DB;

namespace GS.CMS
{
    public partial class ChooseBoardroomForm : Form
    {
        public EmployeeModel emp = new EmployeeModel();
        
        public ChooseBoardroomForm()
        {
            InitializeComponent();
           
        }


        private void ChooseBoardroomForm_Load(object sender, EventArgs e)
        {
            ConferenceAuditorBLL conabll = new ConferenceAuditorBLL();
            List <BoardroomModel > bdrlist = new List<BoardroomModel> ();
            bdrlist = conabll.GetBoardroomInfo("");
            foreach (BoardroomModel bdr in bdrlist)
            {
                cmbSelect.Items.Add(bdr.BdrName);
            }

        }

        private void cmbSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<BoardroomModel> bdrlist = new List<BoardroomModel>();
            ConferenceAuditorBLL conabll = new ConferenceAuditorBLL();
            bdrlist = conabll.GetBoardroomInfo("");
            foreach (BoardroomModel bdr in bdrlist)
            {
                if (bdr.BdrName.ToString() == cmbSelect.SelectedItem .ToString ())
                {
                    lblId.Text = bdr.BdrId.ToString();
                    lblName.Text = bdr.BdrName;
                    lblContactNum.Text = bdr.BdrContactNum.ToString ();
                    lblIntro.Text = bdr.BdrIntro;
                    lblRemarks.Text = bdr.BdrRemarks;
                    lblStatus.Text = bdr.BdrStatus.ToString ();
                    lblConMan.Text = bdr.BdrLinkMan;
                    lblConPhone.Text = bdr.BdrContactPhone;

                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            { 
                ConferenceApplyForm conapply = new ConferenceApplyForm();
                conapply.emp = emp;

                try
                {
                    conapply.bdrPlace = int.Parse(this.lblId.Text);
                    //MessageBox.Show(conapply.bdrPlace.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception("请正确选择会议室");
                }

                if ((DateTime)this.dtpStart.Value < (DateTime)this.dtpEnd.Value)
                {
                    DateTime ds = (DateTime)this.dtpStart.Value;
                    DateTime de = (DateTime)this.dtpEnd.Value;

                    // 判断该时间段内已选会议室是否有会议
                    UserBLL userbll = new UserBLL();
                    BoardroomModel bdr = new BoardroomModel ();
                    bdr.BdrId = conapply.bdrPlace;
                    if (userbll.IsExistCon(bdr, ds, de))
                    {
                        throw new Exception("该时段会议室有会议，请重新选择");
                    }

                    conapply.constart = (DateTime)this.dtpStart.Value;
                    conapply.conend = (DateTime)this.dtpEnd.Value;
                    this.Hide();
                    conapply.ShowDialog();
                }
                else
                {
                    throw new Exception("请正确选择时间");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("请正确选择会议室");
            }
            
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
