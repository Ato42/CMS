/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：BoardroomModel.cs
 * 文件功能描述：存放类BoardroomModel
 * 
 * 创建标识：张衡 20140916
 * 
 * 修改标识：
 * 修改描述：
 * 
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GS.CMS.MODEL
{
    /// <summary>
    /// 任务
    /// </summary>
    public class TaskModel
    {
        private string taskBdrName; // 会议室名称
        //private string taskConName; // 会议名称
        private ConferenceModel taskConference; // 会议信息
        //private DateTime taskConTime; // 会议开始时间
        private ArrayList taskResource; // 会议所需资源


        /// <summary>
        /// 会议信息
        /// </summary>
        /// 作者:张衡
        /// 创建时间:2014-09-24
        /// 修改时间:2014-09-24
        public ConferenceModel TaskConference
        {
            get { return taskConference; }
            set { taskConference = value; }
        }

        /// <summary>
        /// 会议室名称
        /// </summary>
        /// 作者:张衡
        /// 创建时间:2014-09-19
        /// 修改时间:2014-09-19
        public string TaskBdrName
        {
            get { return taskBdrName; }
            set { taskBdrName = value; }
        }

        ///// <summary>
        ///// 会议名称
        ///// </summary>
        ///// 作者:张衡
        ///// 创建时间:2014-09-19
        ///// 修改时间:2014-09-19
        //public string TaskConName
        //{
        //    get { return taskConName; }
        //    set { taskConName = value; }
        //}

        ///// <summary>
        ///// 会议开始时间
        ///// </summary>
        ///// 作者:张衡
        ///// 创建时间:2014-09-19
        ///// 修改时间:2014-09-19
        //public DateTime TaskConTime
        //{
        //    get { return taskConTime; }
        //    set { taskConTime = value; }
        //}

        /// <summary>
        /// 会议所需资源
        /// </summary>
        /// 作者:张衡
        /// 创建时间:2014-09-19
        /// 修改时间:2014-09-19
        public ArrayList TaskResource
        {
            get { return taskResource; }
            set { taskResource = value; }
        }

    }// class TaskModel
}// namespace GS.CMS.MODEL
