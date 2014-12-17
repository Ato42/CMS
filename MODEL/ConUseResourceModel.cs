/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConuseresourceModel.cs
 * 文件功能描述：存放类ConuseresourceModel
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
    /// 会议使用资源表类
    /// </summary>        
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class ConUseResourceModel
    {

        private int conId;   // 会议ID
        private int deviceId; // 设备ID


        /// <summary>
        /// 会议ID
        /// </summary>
        public int ConId
        {
            get { return conId; }
            set { conId = value; }
        }


        /// <summary>
        /// 设备ID
        /// </summary>
        public int DeviceId
        {
            get { return deviceId; }
            set { deviceId = value; }
        }
    }// class ConuseresourceModel
}// namespace GS.CMS.MODEL
