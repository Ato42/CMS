/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ResourceModel.cs
 * 文件功能描述：存放类ResourceModel
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
    /// 资料表类
    /// </summary>        
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class ResourceModel
    {
        private int resourceId;         // 设备ID
        private char resourceStatus;       // 设备状态
        private string resourceClass;      // 资源种类名称

        /// <summary>
        /// 设备ID
        /// </summary>
        public int ResourceId
        {
            get { return resourceId; }
            set { resourceId = value; }
        }


        /// <summary>
        /// 设备状态
        /// </summary>
        public char ResourceStatus
        {
            get { return resourceStatus; }
            set { resourceStatus = value; }
        }


        /// <summary>
        /// 资源种类名称
        /// </summary>
        public string ResourceClass
        {
            get { return resourceClass; }
            set { resourceClass = value; }
        }

    }// class ResourceModel
}// namespace GS.CMS.MODEL
