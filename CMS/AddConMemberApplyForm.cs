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
    public partial class AddConMemberApplyForm : Form
    {
        public ConferenceApplyForm conapply;
        private TreeNode tnp = new TreeNode();
        //public string ConAdd = "";
        public string ConAdd = "1";
        public int hadclick = 0;
        public DataSet dataset = new DataSet();
        int n = 0;
        

        public AddConMemberApplyForm()
        {
            InitializeComponent();

            dataset.Tables.Add("table");

        }


        /// <summary>
        /// 读取界面读取员工或部门信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 作者：吴欣者
        /// 创建时间：2014-09-23
        private void AddConMemberForm_Load(object sender, EventArgs e)
        {
            if (hadclick == 1)
            {
                this.tvwAll.Nodes.Add(new TreeNode("大帝集团"));
                UserBLL userbll = new UserBLL();
                List<EmployeeModel> emlist = new List<EmployeeModel>();
                emlist = userbll.GetAllEmployee();
                foreach (EmployeeModel em in emlist)
                {
                    string strId = em.EmId.ToString();
                    string strName = em.EmName;
                    string strDep = em.EmDepart.ToString();
                    TreeNode tn = new TreeNode();
                    if (ConAdd == "1")
                    {
                        tn.Name = strId;
                        tn.Text = strName;
                        this.tvwAll.Nodes[0].Nodes.Add(tn);
                        Column1.HeaderText = "员工ID";
                        Column2.HeaderText = "员工姓名";
                    }
                    else if (ConAdd == "2")
                    {
                        
                        tn.Name = strDep;
                        tn.Text = strDep;
                        this.tvwAll.Nodes[0].Nodes.Add(tn);

                        Column1.HeaderText = "部门名称";
                        Column2.HeaderText = "要求参会人数";
                    }
                }
                if (ConAdd == "1")
                {
                    dataset.Tables["table"].Columns.Add("员工ID");
                    dataset.Tables["table"].Columns.Add("员工姓名");
                }
                else
                {
                    dataset.Tables["table"].Columns.Add("部门名称");
                    dataset.Tables["table"].Columns.Add("要求参会人数");
                }
            }
            tvwAll.ExpandAll();
        }


        /// <summary>
        /// 拖动树中的节点，添加到datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwAll_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode tn = (TreeNode)e.Item;
            if (tn == this.tvwAll.Nodes[0])
            {
                return;
            }

            tvwAll.DoDragDrop(tn.Name, DragDropEffects.Move);
        }

        private void dgvAdd_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvAdd_DragDrop(object sender, DragEventArgs e)
        {

            string str = e.Data.GetData(DataFormats.Text).ToString();
            if (ConAdd == "1")
            {
                UserBLL userbll = new UserBLL();
                EmployeeModel emp = new EmployeeModel();
                List<EmployeeModel> emlist = new List<EmployeeModel>();
                emlist = userbll.GetAllEmployee();

                foreach (EmployeeModel em in emlist)
                {
                    if (em.EmId == int.Parse(str))
                    {
                        emp = em;
                        dgvAdd.Rows.Add();
                        dgvAdd.Rows[n].Cells["Column1"].Value = emp.EmId;
                        dgvAdd.Rows[n].Cells["Column2"].Value = emp.EmName;
                        n++;
                        DataRow dr = dataset.Tables["table"].NewRow();
                        dr["员工ID"] = emp.EmId;
                        dr["员工姓名"] = emp.EmName;
                        dataset.Tables["table"].Rows.Add(dr);
                        try
                        {
                            this.tvwAll.Nodes[0].Nodes[emp.EmId.ToString()].Remove();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                UserBLL userbll = new UserBLL();
                EmployeeModel emp = new EmployeeModel();
                List<EmployeeModel> emlist = new List<EmployeeModel>();
                emlist = userbll.GetAllEmployee();
                foreach (EmployeeModel em in emlist)
                {
                    if (em.EmDepart  == str)
                    {
                        emp = em;
                        dgvAdd.Rows.Add();
                        dgvAdd.Rows[n].Cells["Column1"].Value = emp.EmDepart;
                        DataRow dr = dataset.Tables["table"].NewRow();
                        dr["部门名称"] = emp.EmDepart ;
                        dr["要求参会人数"] = dgvAdd .Rows [n].Cells ["Column2"].Value ;
                        dataset.Tables["table"].Rows.Add(dr);
                        n++;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int n = 0;
            //for (n = 0; n < conapply.dgvConMember.Rows.Count; n++)
            //{
            //    string str = this.conapply.dgvConMember.Rows[n].Cells[0].ToString();
            //    this.conapply.cmbRecMan.Items.Add(str);
            //}
            //conapply.Enabled = true;

            // 保存到dataset
            if(dataset.HasChanges())
            {
                this.dataset.AcceptChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Hide ();
        }

        private void dgvAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int clo = e.ColumnIndex;
                if (row >= 0 && clo >= 0 && dgvAdd.Rows[row].Cells[1].Value != null)
                {
                    dataset.Tables["table"].Rows[row][clo] = this.dgvAdd.Rows[row].Cells[clo].Value;
                }
                dataset.AcceptChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Name = tnp.Name;
            node.Text = tnp.Text;
            this.tvwAll.Nodes[0].Nodes.Add(node);
            try
            {
                this.dataset.Tables["table"].Rows.Remove(this.dataset.Tables["table"].Rows[e.RowIndex]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            n--;

        }

        private void dgvAdd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tnp.Name = this.dgvAdd.Rows[e.RowIndex].Cells[0].Value.ToString();
                //MessageBox.Show(tnp.Name);
                tnp.Text = this.dgvAdd.Rows[e.RowIndex].Cells[1].Value.ToString();
               // MessageBox.Show(tnp.Text);
            }
            catch
            {
            }
        }

    }
}
