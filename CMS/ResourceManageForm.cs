/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ResourceManageForm.cs
 * 文件功能描述：资源信管理息
 * 
 * 创建标识：朱健 20140923
 * 
 * 修改标识：朱健 20140923
 * 修改描述：朱健 20140923
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
    /// 资源管理类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-23
    /// 修改时间:2014-09-23
    public partial class ResourceManageForm : Form
    {
        public EmployeeModel emp = new EmployeeModel();
        public ResourceManageForm()
        {
            InitializeComponent();
        }



        private void ResourceManageForm_Load(object sender, EventArgs e)
        {
            load();
        }
        /// <summary>
        /// 读取资源信息
        /// </summary>
        private void load()
        {
            try
            {
                dgvResource.Rows.Clear();
                ConferenceAuditorBLL Resource = new ConferenceAuditorBLL();
                List<ResourceModel> ResourceList = new List<ResourceModel>();
                ResourceList = Resource.GetAllResource();
                int n = 0;
                foreach (ResourceModel resource in ResourceList)
                {
                    dgvResource.Rows.Add();

                    dgvResource.Rows[n].Cells["ColumnResourceId"].Value = resource.ResourceId;
                    dgvResource.Rows[n].Cells["ColumnResourceClass"].Value = resource.ResourceClass;
                    if (resource.ResourceStatus == '0')
                    {
                        dgvResource.Rows[n].Cells["ColumnResourceStatus"].Value = "空闲";
                    }
                    if (resource.ResourceStatus == '1')
                    {
                        dgvResource.Rows[n].Cells["ColumnResourceStatus"].Value = "被预订";
                    }
                    if (resource.ResourceStatus == '2')
                    {
                        dgvResource.Rows[n].Cells["ColumnResourceStatus"].Value = "使用中";
                    }
                    if (resource.ResourceStatus == '3')
                    {
                        dgvResource.Rows[n].Cells["ColumnResourceStatus"].Value = "损坏";
                    }
                    n++;
                }
                txtResId.Text = this.dgvResource.CurrentRow.Cells["ColumnResourceId"].Value.ToString();
                cmbResClass.Text = this.dgvResource.CurrentRow.Cells["ColumnResourceClass"].Value.ToString();
                cmbStatus.Text = this.dgvResource.CurrentRow.Cells["ColumnResourceStatus"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnAddRes_Click(object sender, EventArgs e)
        {
            Add();
            
        }
        /// <summary>
        /// 增加资源
        /// </summary>
        private void Add()
        {
            try
            {
                if (cmbAddResClass.Text == "")
                {
                    if (MessageBox.Show("值不能为空", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("确定添加?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    ConferenceAuditorBLL Add = new ConferenceAuditorBLL();
                    ResourceModel resource = new ResourceModel();

                    resource.ResourceClass = cmbAddResClass.Text;
                    resource.ResourceStatus = '0';

                    Add.AddResouce(resource);

                    MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ResourceManageForm_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 获取选中行显示资源信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>cm
        private void dgvResource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtResId.Text = this.dgvResource.CurrentRow.Cells["ColumnResourceId"].Value.ToString();
            cmbResClass.Text = this.dgvResource.CurrentRow.Cells["ColumnResourceClass"].Value.ToString();
            cmbStatus.Text = this.dgvResource.CurrentRow.Cells["ColumnResourceStatus"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// 保存资源信息
        /// </summary>
        private void Save()
        {
            try
            {
                ConferenceAuditorBLL Save = new ConferenceAuditorBLL();
                ResourceModel resource = new ResourceModel();

                resource.ResourceId = int.Parse(txtResId.Text);
                resource.ResourceClass = cmbResClass.Text;
                if (cmbStatus.Text == "空闲")
                {
                    resource.ResourceStatus = '0';
                }
                else if (cmbStatus.Text == "被预订")
                {
                    resource.ResourceStatus = '1';
                }
                else if (cmbStatus.Text == "使用中")
                {
                    resource.ResourceStatus = '2';
                }
                else if(cmbStatus.Text == "损坏")
                {
                    resource.ResourceStatus = '3';
                }
                else
                {
                    MessageBox.Show("输入错误");
                    return;
                }

                Save.UpdateResouce(resource);

                MessageBox.Show("保存成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.ResourceManageForm_Load(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            Del();
        }


        /// <summary>
        /// 删除资源信息
        /// </summary>
        private void Del()
        {
            if (MessageBox.Show("确定删除该条资源信息?该操作不可恢复!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                ConferenceAuditorBLL Del = new ConferenceAuditorBLL();
                ResourceModel resource = new ResourceModel();

                string resourceid = this.dgvResource.CurrentRow.Cells["ColumnResourceId"].Value.ToString(); ;//获取当前行要修改的资源ID 
                resource.ResourceId = int.Parse(resourceid);
                
                Del.DelAResource(resource);
                MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ResourceManageForm_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
