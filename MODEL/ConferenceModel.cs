/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConferenceModel.cs
 * 文件功能描述：存放类ConferenceModel
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
    /// 会议表类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class ConferenceModel
    {
        private int conId;       // 会议ID
        private string conName;     // 会议名称
        private int conPlace;    // 会议地点
        private DateTime conStartTime;// 会议开始时间
        private DateTime conEndTime;  // 会议结束时间
        private string conHost;     // 会议主办单位
        private char conType;       // 会议类型
        private char conStatus;     // 会议状态
        private int conSubMen;   // 会议申请人ID
        private int conRecordMen;// 会议记录人ID
        private int conStaffMen;    // 会务执行人ID
        private char conRegister;   // 是否签到
        private char conIsDone;     // 是否执行
        private string conOthers;   // 备注
  
        
        /// <summary>
        /// 会议ID
        /// </summary>
        public int ConId
        {
            get { return conId; }
            set { conId = value; }
        }

        
        /// <summary>
        /// 会议名称
        /// </summary>
        public string ConName
        {
            get { return conName; }
            set { conName = value; }
        }
        
        /// <summary>
        /// 会议地点
        /// </summary>
        public int ConPlace
        {
            get { return conPlace; }
            set { conPlace = value; }
        }
        
        /// <summary>
        /// 会议开始时间
        /// </summary>
        public DateTime ConStartTime
        {
            get { return conStartTime; }
            set { conStartTime = value; }
        }


        /// <summary>
        /// 会议结束时间
        /// </summary>
        public DateTime ConEndTime
        {
            get { return conEndTime; }
            set { conEndTime = value; }
        }


        /// <summary>
        /// 会议主办单位
        /// </summary>
        public string ConHost
        {
            get { return conHost; }
            set { conHost = value; }
        }


        /// <summary>
        /// 会议类型
        /// </summary>
        public char ConType
        {
            get { return conType; }
            set { conType = value; }
        }


        /// <summary>
        /// 会议状态
        /// </summary>
        public char ConStatus
        {
            get { return conStatus; }
            set { conStatus = value; }
        }


        /// <summary>
        /// 会议申请人ID
        /// </summary>
        public int ConSubMen
        {
            get { return conSubMen; }
            set { conSubMen = value; }
        }


        /// <summary>
        /// 会议记录人ID
        /// </summary>
        public int ConRecordMen
        {
            get { return conRecordMen; }
            set { conRecordMen = value; }
        }


        /// <summary>
        /// 会务执行人ID
        /// </summary>
        public int ConStaffMen
        {
            get { return conStaffMen; }
            set { conStaffMen = value; }
        }


        /// <summary>
        /// 是否签到
        /// </summary>
        public char ConRegister
        {
            get { return conRegister; }
            set { conRegister = value; }
        }


        /// <summary>
        /// 是否执行
        /// </summary>
        public char ConIsDone
        {
            get { return conIsDone; }
            set { conIsDone = value; }
        }


        /// <summary>
        /// 备注
        /// </summary>
        public string ConOthers
        {
            get { return conOthers; }
            set { conOthers = value; }
        }  
    }// class ConferenceModel
}// namespace GS.CMS.MODEL