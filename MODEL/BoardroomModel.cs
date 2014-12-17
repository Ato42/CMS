/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：BoardroomModel.cs
 * 文件功能描述：存放类BoardroomModel
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
    /// 会议室表类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class BoardroomModel
    {
        private int bdrId;           // 会议室ID
        private string bdrName;         // 会议室名称
        private int bdrContactNum;      // 会议室容纳人数
        private string bdrLinkMan;      // 会议室联系人
        private string bdrContactPhone; // 会议室联系电话
        private string bdrIntro;        // 会议室介绍
        private char bdrStatus;         // 会议室状态
        private string bdrRemarks;      // 会议室备注
      


        /// <summary>
        /// 会议室ID
        /// </summary>
        public int BdrId
        {
            get { return bdrId; }
            set { bdrId = value; }
        }


        /// <summary>
        /// 会议室名称
        /// </summary>
        public string BdrName
        {
            get { return bdrName; }
            set { bdrName = value; }
        }


        /// <summary>
        /// 会议室容纳人数
        /// </summary>
        public int BdrContactNum
        {
            get { return bdrContactNum; }
            set { bdrContactNum = value; }
        }


        /// <summary>
        /// 会议室联系人
        /// </summary>
        public string BdrLinkMan
        {
            get { return bdrLinkMan; }
            set { bdrLinkMan = value; }
        }


        /// <summary>
        /// 会议室联系电话
        /// </summary>
        public string BdrContactPhone
        {
            get { return bdrContactPhone; }
            set { bdrContactPhone = value; }
        }


        /// <summary>
        /// 会议室介绍
        /// </summary>
        public string BdrIntro
        {
            get { return bdrIntro; }
            set { bdrIntro = value; }
        }


        /// <summary>
        /// 会议室状态
        /// </summary>
        public char BdrStatus
        {
            get { return bdrStatus; }
            set { bdrStatus = value; }
        }


        /// <summary>
        /// 会议室备注
        /// </summary>
        public string BdrRemarks
        {
            get { return bdrRemarks; }
            set { bdrRemarks = value; }
        }
    }// class BoardroomModel
}// namespace GS.CMS.MODEL
