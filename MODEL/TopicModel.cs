/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：TopicModel.cs
 * 文件功能描述：存放类TopicModel
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
    /// 会议议题表类
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class TopicModel
    {
        private int topicId;         // 议题编号
        private int topicApplicantId;// 议题申请人ID
        private DateTime topicSubTime;    // 议题申请时间
        private DateTime topicVerifyTime; // 议题审核时间
        private string topicHead;       // 议题标题
        private string topicContent;    // 议题正文
        private char topicStatus;        // 议题审核状态


        /// <summary>
        /// 议题编号
        /// </summary>
        public int TopicId
        {
            get { return topicId; }
            set { topicId = value; }
        }


        /// <summary>
        /// 议题申请人ID
        /// </summary>
        public int TopicApplicantId
        {
            get { return topicApplicantId; }
            set { topicApplicantId = value; }
        }


        /// <summary>
        /// 议题申请时间
        /// </summary>
        public DateTime TopicSubTime
        {
            get { return topicSubTime; }
            set { topicSubTime = value; }
        }


        /// <summary>
        /// 议题审核时间
        /// </summary>
        public DateTime TopicVerifyTime
        {
            get { return topicVerifyTime; }
            set { topicVerifyTime = value; }
        }


        /// <summary>
        /// 议题标题
        /// </summary>
        public string TopicHead
        {
            get { return topicHead; }
            set { topicHead = value; }
        }


        /// <summary>
        /// 议题正文
        /// </summary>
        public string TopicContent
        {
            get { return topicContent; }
            set { topicContent = value; }
        }


        /// <summary>
        /// 议题审核状态
        /// </summary>
        public char TopicStatus
        {
            get { return topicStatus; }
            set { topicStatus = value; }
        }
        
    }// class TopicModel
}// namespace GS.CMS.MODEL
