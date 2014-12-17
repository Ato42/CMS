/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：OutconmemberModel.cs
 * 文件功能描述：存放类OutconmemberModel
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
    /// 外部与会人员表类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class OutConMemberModel
    {
        private int conId;       // 会议ID
        private string conName;     // 与会人员姓名
        private string conSex;      // 与会人员性别
        private string conDuties;   // 与会人员职务
        private string conPhone;    // 与会人员电话
        private string conEmail;    // 与会人员Email
        private string conCompany;  // 与会人员公司
        private char conRegister;   // 签到状态


        /// <summary>
        /// 会议ID
        /// </summary>
        public int ConId
        {
            get { return conId; }
            set { conId = value; }
        }


        /// <summary>
        /// 与会人员姓名
        /// </summary>
        public string ConName
        {
            get { return conName; }
            set { conName = value; }
        }


        /// <summary>
        /// 与会人员性别
        /// </summary>
        public string ConSex
        {
            get { return conSex; }
            set { conSex = value; }
        }


        /// <summary>
        /// 与会人员职务
        /// </summary>
        public string ConDuties
        {
            get { return conDuties; }
            set { conDuties = value; }
        }


        /// <summary>
        /// 与会人员电话
        /// </summary>
        public string ConPhone
        {
            get { return conPhone; }
            set { conPhone = value; }
        }


        /// <summary>
        /// 与会人员Email
        /// </summary>
        public string ConEmail
        {
            get { return conEmail; }
            set { conEmail = value; }
        }


        /// <summary>
        /// 与会人员公司
        /// </summary>
        public string ConCompany
        {
            get { return conCompany; }
            set { conCompany = value; }
        }


        /// <summary>
        /// 签到状态
        /// </summary>
        public char ConRegister
        {
            get { return conRegister; }
            set { conRegister = value; }
        }  
    }// class OutconmemberModel
}// namespace GS.CMS.MODEL
