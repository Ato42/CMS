/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：EmployeeModel.cs
 * 文件功能描述：存放类EmployeeModel
 * 
 * 创建标识：朱健 20140916
 * 
 * 修改标识：朱健 20140916
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.CMS.MODEL
{
    /// <summary>
    /// 员工表类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class EmployeeModel
    {
        private int emId;        // 员工ID
        private string emName;      // 员工名字
        private string emSex;       // 员工性别
        private string emDepart;  // 员工部门
        private string emPhone;     // 员工电话
        private string emEmail;     // Email
        private string emCompany;   // 员工公司
        private string emDuties;    // 员工职务
        private string emPassword;  // 员工密码
        private string emPermission;// 员工权限
 

        /// <summary>
        /// 员工ID
        /// </summary>
        public int EmId
        {
            get { return emId; }
            set { emId = value; }
        }


        /// <summary>
        /// 员工名字
        /// </summary>
        public string EmName
        {
            get { return emName; }
            set { emName = value; }
        }


        /// <summary>
        /// 员工部门ID
        /// </summary>
        public string EmDepart
        {
            get { return emDepart; }
            set { emDepart = value; }
        }


        /// <summary>
        /// 员工性别
        /// </summary>
        public string EmSex
        {
            get { return emSex; }
            set { emSex = value; }
        }


        /// <summary>
        /// 员工电话
        /// </summary>
        public string EmPhone
        {
            get { return emPhone; }
            set { emPhone = value; }
        }


        /// <summary>
        /// Email
        /// </summary>
        public string EmEmail
        {
            get { return emEmail; }
            set { emEmail = value; }
        }


        /// <summary>
        /// 员工公司
        /// </summary>
        public string EmCompany
        {
            get { return emCompany; }
            set { emCompany = value; }
        }


        /// <summary>
        /// 员工职务
        /// </summary>
        public string EmDuties
        {
            get { return emDuties; }
            set { emDuties = value; }
        }


        /// <summary>
        /// 员工密码
        /// </summary>
        public string EmPassword
        {
            get { return emPassword; }
            set { emPassword = value; }
        }


        /// <summary>
        /// 员工权限
        /// </summary>
        public string EmPermission
        {
            get { return emPermission; }
            set { emPermission = value; }
        }
    }// class EmployeeModel
}// namespace GS.CMS.MODEL
