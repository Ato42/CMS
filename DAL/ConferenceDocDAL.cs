/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConferenceDocDAL.cs
 * 文件功能描述：存放类ConferenceDocDAL
 * 
 * 创建标识：朱健 20140917
 * 
 * 修改标识：朱健 20140917
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GS.CMS.DB;
using GS.CMS.IDAL;
using GS.CMS.MODEL;

namespace GS.CMS.DAL
{
    /// <summary>
    /// 会议资料存储类增删改查
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class ConferenceDocDAL : IUpdateData
    {
        /// <summary>
        /// 向数据库会议资料存储表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的会议资料存储信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool AddARecord(object obj)
        {
            try
            {
                ConferenceDocModel ConferenceDoc = (ConferenceDocModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("insert into ConferenceDoc values('{0}','{1}')",ConferenceDoc.ConID, ConferenceDoc.ConDataRoute);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function AddARecord


        /// <summary>
        /// 从数据库会议资料存储表中删除一条信息
        /// </summary>
        /// <param name="obj">要删除的会议资料存储信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool DelARecord(object obj)
        {
            try
            {
                ConferenceDocModel ConferenceDoc = (ConferenceDocModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("Delete from ConferenceDoc where ConId ='{0}'", ConferenceDoc.ConID);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function DelARecord


        /// <summary>
        /// 从数据库会议资料存储表中修改一条信息
        /// </summary>
        /// <param name="obj">要修改的会议资料存储信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool UpdateARecord(object obj)
        {
            try
            {
                ConferenceDocModel ConferenceDoc = (ConferenceDocModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("update ConferenceDoc set ConDataRoute='{1}' where ConID='{0}'", 
                                                                    ConferenceDoc.ConID, ConferenceDoc.ConDataRoute);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function UpdateARecord
    } // class ConferenceDocDAL
} // namespace GS.CMS.DAL
