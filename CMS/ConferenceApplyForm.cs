using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GS.CMS.MODEL;
using GS.CMS.BLL;
using GS.CMS.DB;

namespace GS.CMS
{
    

    public partial class ConferenceApplyForm : Form
    {
        public EmployeeModel emp = new EmployeeModel();
        public DataSet dataset = new DataSet();
        public int bdrPlace;
        public DateTime constart ;
        public DateTime conend ;
        
        

        AddConMemberApplyForm addconmem;
        ConferenceModel con = new ConferenceModel();
        EmployeeModel em = new EmployeeModel();
        UserBLL userbll = new UserBLL();
        List<ResourceModel> reslist = new List<ResourceModel>();

        public ConferenceApplyForm()
        {
            InitializeComponent();
            addconmem = new AddConMemberApplyForm();
            cmbRecMan.Enabled = false;
        }

        /// <summary>
        /// 申请，将数据添加到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnsure_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定申请?", "系统消息", MessageBoxButtons.OKCancel);
            if (cmbHost.Text != ""  && cmbTopic.Text != "")
            {
                if (result == DialogResult.OK)
                {
                    con.ConHost = cmbHost.Text;
                    con.ConSubMen = emp.EmId;
                    con.ConOthers = rtxRemarks.Text;
                    con.ConPlace = bdrPlace;
                    con.ConStartTime = constart;
                    con.ConEndTime = conend;
                    con.ConStatus = '0';
                    con.ConIsDone = '0';
                    con.ConName = cmbTopic.Text;
                    con.ConRecordMen = Convert.ToInt32(cmbRecMan.SelectedValue);

                    // 随机选择会务执行人

                    List<EmployeeModel> emlist = new List<EmployeeModel>();
                    List<EmployeeModel> onelist = new List<EmployeeModel>();
                    emlist = userbll.GetAllEmployee();
                    foreach (EmployeeModel em2 in emlist)
                    {
                        if (em2.EmPermission == "CE")
                        {
                            onelist.Add(em2);
                        }
                    }

                    Random r = new Random();
                    int ecId = r.Next(0, onelist.Count - 1);

                    con.ConStaffMen = onelist[ecId].EmId;


                    // 会议使用资源表中添加条目
                    List<string> rscList = new List<string>();
                    IEnumerator myEnumerator = cklStaff.CheckedIndices.GetEnumerator();
                    int index;
                    string[] rsc;
                    while (myEnumerator.MoveNext())
                    {
                        index = (int)myEnumerator.Current;
                        cklStaff.SelectedItem = cklStaff.Items[index];
                        rsc = cklStaff.Text.Split(' ');
                        rscList.Add(rsc[0]);
                        //MessageBox.Show(rsc[0]);
                    }
                    int ConId = userbll.ConApply(con, rscList);

                    for (int i = 0; i < addconmem.dataset.Tables["table"].Rows.Count; i++)
                    {
                        InConMemberModel ICMM = new InConMemberModel();
                        ICMM.ConId = ConId;
                        DataRow dr;
                        dr = addconmem.dataset.Tables["table"].Rows[i];
                        ICMM.ConEmId = Convert.ToInt32(dr["员工ID"]);
                        ICMM.ConRegister = '0';
                        userbll.AddConMenRecord(ICMM);
                    }

                    // 申请会议
                    MessageBox.Show("申请成功，请耐心等待管理员审核通知");
                    this.Close();
                }  
            } // end if
            else
            {
                MessageBox.Show("请填写完整信息");
            }
        }

        /// <summary>
        /// 列出所有可以使用的资源
        /// </summary>
        private void GetStaff()
        {
            reslist = userbll.GetCanUseResource(constart, conend);
            foreach (ResourceModel res in reslist)
            {
                cklStaff.Items.Add(res.ResourceId + " " + res.ResourceClass);
                
            }
;
        }

        /// <summary>
        /// 添加参会人员或参会部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEm_Click(object sender, EventArgs e)
        {
            if (rdoEm.Checked == false && rdoDep.Checked == false)
            {
                MessageBox.Show("请选择参会类型！");
            }
            else
            {
                addconmem.hadclick++;
                addconmem.Owner = this;
                addconmem.ShowDialog();
                if (addconmem.DialogResult == DialogResult.OK)
                {
                    dgvConMember.DataSource = addconmem.dataset.Tables["table"];


                    if (addconmem.dataset.Tables["table"].Rows.Count != 0)
                    {
                        // cmb
                        this.cmbRecMan.Enabled = true;
                        cmbRecMan.DataSource = addconmem.dataset.Tables["table"];
                        cmbRecMan.DisplayMember = "员工姓名";
                        cmbRecMan.ValueMember = "员工ID";
                    }
                    else
                    {
                        this.cmbRecMan.Items.Clear();
                        this.cmbRecMan.Enabled = false;
                    }

                    //foreach (DataRow row in addconmem.dataset.Tables["table"].Rows)
                    //{
                    //    if (em.EmPermission == "CE")
                    //    {
                    //        cmbStaff.Items.Add(em.EmName);
                    //    }
                    //}
                }
                rdoEm.Enabled = false;
                rdoDep.Enabled = false;
            }
            
        }

        /// <summary>
        /// 选中则为人员参会
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoEm_Click(object sender, EventArgs e)
        {
            addconmem.ConAdd = "1";
        }

        /// <summary>
        /// 选中则为部门参会
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoDep_CheckedChanged(object sender, EventArgs e)
        {
            addconmem.ConAdd = "2";
        }
        /// <summary>
        /// 选中则为需要签到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoReg_Click(object sender, EventArgs e)
        {
            con.ConRegister = '1';
        }

        /// <summary>
        /// 选中则为不需要签到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoRegNo_Click(object sender, EventArgs e)
        {
            con.ConRegister = '2';
        }

        /// <summary>
        /// 内部会议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoInCon_Click(object sender, EventArgs e)
        {
            con.ConType = '0';
            //rdoInCon.Enabled = false;
            rdoDep.Enabled = true;
            rdoEm.Enabled = true;
            btnAddEm.Enabled = true;
            
        }

        /// <summary>
        /// 外部会议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoOutCon_Click(object sender, EventArgs e)
        {
            con.ConType = '1';
            //rdoOutCon.Enabled = false;
            rdoDep.Enabled = false;
            rdoEm.Enabled = false;
            btnAddEm.Enabled  = false;
        }

        /// <summary>
        /// 读取界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConferenceApplyForm_Load(object sender, EventArgs e)
        {
            GetStaff();
            dgvConMember.DataSource = dataset;
            List<TopicModel >  toplist = new List<TopicModel> ();
            toplist = userbll.GetUserTopic(emp);
            foreach (TopicModel top in toplist)
            {
                cmbTopic.Items.Add(top.TopicHead);  
            }
            ConferenceAuditorBLL conabll = new ConferenceAuditorBLL();
            cmbHost.Text = conabll.GetAEmployee(emp.EmId).EmDepart;
            rdoInCon.Checked = true;
            rdoInCon_Click(null,null);
            rdoReg.Checked = true;
            rdoReg_Click(null,null);
        }

        /// <summary>
        /// 绑定到CMBSTAFF
        /// </summary>
        public void bingCmb()
        {
            //List<EmployeeModel> perlist = new List<EmployeeModel>();
            //perlist = userbll.GetAllEmployee();
            //foreach (EmployeeModel em in perlist)
            //{
            //    if (em.EmPermission == "CE")
            //    {
            //        cmbStaff.Items.Add(em.EmName );
            //    }
            //}
        }

        private void getrecordman()
        {
            int n = 0;
            for (n=0; n < dgvConMember.Rows.Count; n++)
            {
                string str=this.dgvConMember.Rows[n].Cells[0].ToString();
                this.cmbRecMan.Items.Add(str);
            }
        }
        

        /// <summary>
        /// 返回上一界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void cmbRecMan_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void rdoInCon_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}
