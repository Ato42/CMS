/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：BoardroomManagementForm.cs
 * 文件功能描述：会议室信息管理
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
    /// 会议室管理类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-17
    /// 修改时间:2014-09-20
    public partial class BoardroomManagementForm : Form
    {
        public EmployeeModel emp = new EmployeeModel();
        public BoardroomManagementForm()
        {
            InitializeComponent();
        }

        private void BoardroomManagementForm_Load(object sender, EventArgs e)
        {
            search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        /// <summary>
        /// 查询所有会议室信息
        /// </summary>
        private void search()
        {
            
            try
            {
                dgvBoardroom.Rows.Clear();
                ConferenceAuditorBLL Boardroom = new ConferenceAuditorBLL();
                List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
                BoardroomList = Boardroom.GetBoardroomInfo(txtQuery.Text);
                int n = 0;
                foreach (BoardroomModel boardroom in BoardroomList)
                {
                    dgvBoardroom.Rows.Add();
                    dgvBoardroom.Rows[n].Cells["ColumnBdrId"].Value = boardroom.BdrId;
                    if (boardroom.BdrStatus == '1')
                    {
                        dgvBoardroom.Rows[n].Cells["ColumnBdrStatus"].Value = "正常";
                    }
                    else
                    {
                        dgvBoardroom.Rows[n].Cells["ColumnBdrStatus"].Value = "损坏";
                    }
                    dgvBoardroom.Rows[n].Cells["ColumnBdrName"].Value = boardroom.BdrName;
                    dgvBoardroom.Rows[n].Cells["ColumnBdrContactNum"].Value = boardroom.BdrContactNum;
                    dgvBoardroom.Rows[n].Cells["ColumnBdrLinkMan"].Value = boardroom.BdrLinkMan;
                    dgvBoardroom.Rows[n].Cells["ColumnBdrContactPhone"].Value = boardroom.BdrContactPhone;
                    dgvBoardroom.Rows[n].Cells["ColumnBdrIntro"].Value = boardroom.BdrIntro;
                    dgvBoardroom.Rows[n].Cells["ColumnBdrRemarks"].Value = boardroom.BdrRemarks;
                    n++;
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }


        private void btnAddBdr_Click(object sender, EventArgs e)
        {
            add();
        }
        /// <summary>
        /// 增加会议室信息
        /// </summary>
        private void add()
        {
            AddBoardroomForm Add = new AddBoardroomForm();
            if (Add.ShowDialog() == DialogResult.OK)
            {
                this.btnSearch_Click(null, null);
            } 
        }

        private void btnModBdr_Click(object sender, EventArgs e)
        {
            Mod();
        }

        /// <summary>
        /// 修改会议室信息
        /// </summary>
        private void Mod()
        {
            try
            {
                UpdateBoardroomForm Upd = new UpdateBoardroomForm();
                BoardroomModel boardroom = new BoardroomModel();

                string bdrid = this.dgvBoardroom.CurrentRow.Cells["ColumnBdrId"].Value.ToString();//获取当前行要修改的学号
                boardroom.BdrId = int.Parse(bdrid);//传值到另一个窗口
                Upd.bdrid = boardroom;

                if (Upd.ShowDialog() == DialogResult.OK)
                {
                    this.btnSearch_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnDelBdr_Click(object sender, EventArgs e)
        {
            Del();
        }

        /// <summary>
        /// 删除会议室信息
        /// </summary>
        private void Del()
        {
            if (MessageBox.Show("确定删除该条会议信息?,该操作不可恢复!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                ConferenceAuditorBLL Del = new ConferenceAuditorBLL();
                BoardroomModel boardroom = new BoardroomModel();

                string bdrid = this.dgvBoardroom.CurrentRow.Cells["ColumnBdrId"].Value.ToString();//获取当前行要修改的会议ID 
                boardroom.BdrId = int.Parse(bdrid);
                if (Del.DelBoardroom(boardroom))
                {                   
                    MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);             

                }
                else
                {
                    MessageBox.Show("该会议室存在会议,不可删除", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
                this.btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
