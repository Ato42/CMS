/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：InconmemberModel.cs
 * 文件功能描述：存放类InconmemberModel
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
    /// 内部与会人员表类
    /// </summary>        
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class InConMemberModel
    {
        private int conId;       // 会议Id
        private int conEmId;     // 与会人ID
        private char conRegister;   // 签到状态

  
        /// <summary>
        /// 会议Id
        /// </summary>
        public int ConId
        {
            get { return conId; }
            set { conId = value; }
        }


        /// <summary>
        /// 与会人ID
        /// </summary>
        public int ConEmId
        {
            get { return conEmId; }
            set { conEmId = value; }
        }


        /// <summary>
        /// 签到状态
        /// </summary>
        public char ConRegister
        {
            get { return conRegister; }
            set { conRegister = value; }
        }
    }// class InconmemberModel
}// namespace GS.CMS.MODEL
