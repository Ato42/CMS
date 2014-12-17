/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名： ConUseResourceDAL.cs
 * 文件功能描述：
 * 
 * 创建标识：吴欣哲 20140917
 * 
 * 修改标识：吴欣哲 20140917
 * 修改描述：修改代码规范
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using GS.CMS.DB;
using GS.CMS.IDAL;
using GS.CMS.MODEL;

namespace GS.CMS.DAL
{
    /// <summary>
    /// 对会议室使用资源进行增删改查的类
    /// </summary>
    /// 作者：吴欣哲
    /// 创建时间:2014-09-17
    /// 修改时间：
    public class ConUseResourceDAL:IUpdateData 
    {
        /// <summary>
        /// 向数据库会议资源表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的会议资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool AddARecord(object obj)
        {
            try
            {
                ConUseResourceModel ConUseResource = (ConUseResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("insert into ConUseResource values('{0}','{1}')",
                 ConUseResource.ConId, ConUseResource.DeviceId);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception(); 
            } // try
        } // function AddRecord


        /// <summary>
        /// 向数据库会议资源表中删除一条新信息
        /// </summary>
        /// <param name="obj">要删除的会议资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool DelARecord(object obj)
        {
            try
            {
                ConUseResourceModel ConUseResource = (ConUseResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("delete from ConUseResource where ConId = '{0}'",
                ConUseResource.ConId);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception();
            } // try
        } // function DelRecord


        /// <summary>
        /// 向数据库会议资源表中修改一条新信息
        /// </summary>
        /// <param name="obj">要修改的会议资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool UpdateARecord(object obj)
        {
            try
            {
                ConUseResourceModel ConUseResource = (ConUseResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("update ConUseResource set deviceid='{1}'where conid = '{0}'",
                 ConUseResource.ConId, ConUseResource.DeviceId);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message );
                
            } // try
        } // function UpdateRecord

        /// <summary>
        /// 向数据库会议资源表中查询与某一会议相关的信息
        /// </summary>
        /// <param name="conId">会议id</param>
        /// <returns>一组资源信息</returns>
        /// 作者：王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间：
        public List<ConUseResourceModel> GetUseResource(int conId)
        {
            try
            {
                
                List<ConUseResourceModel> UseResourceList = new List<ConUseResourceModel> ();
                string strSqlCmd;// 存储数据库命令语句   
                strSqlCmd = string.Format(@"select * from ConUseResource where ConId = '" + conId + "'");
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "ConUseResource");

                foreach (DataRow row in data.Tables["ConUseResource"].Rows)
                {
                    ConUseResourceModel ConUse = new ConUseResourceModel();
                    ConUse.ConId = Convert.ToInt32(row["ConId"].ToString());
                    ConUse.DeviceId =Convert.ToInt32( row["DeViceId"].ToString());

                    UseResourceList.Add(ConUse);
                }
                return UseResourceList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            } // try
        }// function GetUseResource
    } // class ConUseResourceDAL
} // namespace DAL