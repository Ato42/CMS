using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GS.CMS.BLL;
using GS.CMS.MODEL;

namespace GS.CMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text == "" || this.txtPw.Text == "")
            {
                MessageBox.Show("请输入账号和密码！");

            }
            else
            {
                try
                {
                    EmployeeModel employee = new EmployeeModel();
                    UserBLL User = new UserBLL();
                    employee = User.LoginIn(this.txtID.Text, this.txtPw.Text);
                    if (employee.EmPermission != "ER")
                    {
                        MainForm mainform = new MainForm();
                        mainform.employee = employee;
                        this.Hide();
                        mainform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                        this.txtID.Clear();
                        this.txtPw.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }


        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtPw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            } 
        }
    }
}
