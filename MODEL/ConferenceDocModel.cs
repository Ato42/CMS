/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConferenceDocModel.cs
 * 文件功能描述：存放类ConferenceDocModel
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
    /// 会议资料存储表类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class ConferenceDocModel
    {
        private int conID;       // 会议ID
        private string conDataRoute;// 文件路径
        

        /// <summary>
        /// 会议ID
        /// </summary>
        public int ConID
        {
            get { return conID; }
            set { conID = value; }
        } 
        

        /// <summary>
        /// 文件路径
        /// </summary>
        public string ConDataRoute
        {
            get { return conDataRoute; }
            set { conDataRoute = value; }
        }
    }// class ConferenceDocModel
}// namespace GS.CMS.MODEL
