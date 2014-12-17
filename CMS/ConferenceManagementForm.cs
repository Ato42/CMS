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
    public partial class ConferenceManagementForm : Form
    {
        public EmployeeModel emp;

        public ConferenceManagementForm()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.BindDataToDgv(); 
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            ChooseBoardroomForm choosebdr = new ChooseBoardroomForm();
            this.Hide();
            choosebdr.Show();
            
        }

        /// <summary>
        /// 绑定LIST到datagridview
        /// </summary>
        /// 作者：吴欣哲
        /// 创建时间：20140919
        public void BindDataToDgv()
        {
            dgvReturn.Rows.Clear();
            ConferenceAuditorBLL con = new ConferenceAuditorBLL();
            List<ConferenceModel> conList = new List<ConferenceModel>();
            conList = con.GetConferenceInfo(txtQuery.Text);
            int n = 0;

            foreach (ConferenceModel conference in conList)
            {
                dgvReturn.Rows.Add();
                dgvReturn.Rows[n].Cells["Column1"].Value = conference.ConId;
                if (conference.ConStatus == '0')
                {
                    dgvReturn.Rows[n].Cells["Column2"].Value = "未审核";
                }
                else if (conference.ConStatus == '1')
                {
                    dgvReturn.Rows[n].Cells["Column2"].Value = "审核通过";
                }
                else if (conference.ConStatus == '2')
                {
                    dgvReturn.Rows[n].Cells["Column2"].Value = "不通过";
                }
                dgvReturn.Rows[n].Cells["Column3"].Value = conference.ConName;
                dgvReturn.Rows[n].Cells["Column4"].Value = conference.ConStartTime;
                dgvReturn.Rows[n].Cells["Column5"].Value = conference.ConEndTime;
                UserBLL userbll = new UserBLL();
                List<BoardroomModel> bdrlist = new List<BoardroomModel>();
                bdrlist = userbll.GetBoardroomInfo(conference.ConPlace.ToString ());
                foreach (BoardroomModel bdr in bdrlist)
                {
                    if (bdr.BdrId == conference.ConId)
                    {
                        dgvReturn.Rows[n].Cells["Column6"].Value = bdr.BdrName;
                    }
                
                }

                
                n++;
            }
        }


        private void ConferenceManagementForm_Load(object sender, EventArgs e)
        {
            BindDataToDgv();
        }

        private void btnModCon_Click(object sender, EventArgs e)
        {
            
            string str = dgvReturn.CurrentRow.Cells["Column1"].Value.ToString();
            ConferenceModForm conmod = new ConferenceModForm();
            conmod.selecetedConId = int.Parse (str);
            conmod.userID = emp;
            this.Hide();  
            conmod.Show();
        }

        /// <summary>
        /// 删除会议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelCon_Click(object sender, EventArgs e)
        {
            string str = dgvReturn.CurrentRow.Cells["Column1"].Value.ToString();
            UserBLL userbll = new UserBLL();
            List <ConferenceModel > conlist = new List<ConferenceModel> ();
            conlist = userbll.GetConferenceInfo(str);
            DialogResult result;
            foreach (ConferenceModel con in conlist)
            {
                if (con.ConId == int.Parse (str) )
                {
                    if (con.ConStatus == '0')
                    {
                        result = MessageBox.Show("确定删除吗", "系统消息", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            userbll.DelCon(con);
                        }
                        break;
                    }
                    else if (con.ConStatus == '1')
                    {
                        MessageBox.Show("该会议已经通过审核，若要修改请联系会议管理员！");
                    }
                    break;
                }
            }
            dgvReturn.Rows.Clear();
            BindDataToDgv();   
        }
    }
}
