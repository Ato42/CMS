/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：IUpdateData.cs
 * 文件功能描述：存放接口类IUpdateData
 * 
 * 创建标识：朱健 20140916
 * 
 * 修改标识：朱健 20140917
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：朱健 20140917
 * 修改描述：删除GetARecord接口
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GS.CMS.IDAL
{
    /// <summary>
    /// 接口类的增删改查操作函数
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-18
    public interface IUpdateData
    {
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>成功返回true,失败返回false</returns>
        bool AddARecord(object obj);


        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>成功返回true,失败返回false</returns>
        bool DelARecord(object obj);


        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns>成功返回true,失败返回false</returns>
        bool UpdateARecord(object obj);
    }
}
