/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名： ResourceDAL.cs
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
    /// 对资源进行增删改查的类
    /// </summary>
    /// 作者：吴欣哲
    /// 创建时间:2014-09-16
    /// 修改时间：
    public class ResourceDAL : IUpdateData
    {
        /// <summary>
        /// 向数据库资源表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool AddARecord(object obj)
        {
            try
            {
                ResourceModel resource = (ResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("insert into resource values('{0}','{1}')",
                resource .ResourceStatus,resource.ResourceClass);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message );
                // return false;  
            } // try
        } // function AddRecord



        /// <summary>
        /// 向数据库资源表中删除一条新信息
        /// </summary>
        /// <param name="obj">要删除的资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool DelARecord(object obj)
        {
            try
            {
                ResourceModel resource = (ResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("delete from resource where resourceId = '{0}'",
                resource.ResourceId);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception();
                // return false;  
            } // try
        } // function AddRecord


        /// <summary>
        /// 向数据库资源表中修改一条新信息
        /// </summary>
        /// <param name="obj">要修改的资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool UpdateARecord(object obj)
        {
            try
            {
                ResourceModel resource = (ResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("update resource set resourcestatus = '{1}',resourceclass='{2}'where resourceid = '{0}'"
                ,resource .ResourceId ,resource .ResourceStatus ,resource .ResourceClass  );

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception();
                // return false;  
            } // try
        } // function AddRecord

        /// <summary>
        /// 修改一个资源的状态信息
        /// </summary>
        /// <param name="obj">要修改的资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool UpdateAStatus(object obj)
        {
            try
            {
                ResourceModel resource = (ResourceModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("update resource set resourcestatus = '{1}' where resourceid = '{0}'"
                , resource.ResourceId, resource.ResourceStatus);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception();
                // return false;  
            } // try
        } // function AddRecord


        /// <summary>
        /// 获取所有资源信息
        /// </summary>
        /// <returns>一组资源信息</returns>
        /// 作者：王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间：
        public List<ResourceModel> GetAllRecord()
        {
            try
            {
                List<ResourceModel> Resourcelist = new List<ResourceModel>();
                string strSqlCmd;// 存储数据库命令语句   
                strSqlCmd = string.Format(@"select * from Resource");
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Resource");

                foreach (DataRow row in data.Tables["Resource"].Rows)
                {
                    ResourceModel Resource = new ResourceModel();
                    Resource.ResourceId = Convert.ToInt32(row["ResourceId"].ToString());
                    Resource.ResourceStatus = char.Parse(row["ResourceStatus"].ToString());
                    Resource.ResourceClass = row["ResourceClass"].ToString();
                    Resourcelist.Add(Resource);
                }
                return Resourcelist;
            }
            catch
            {
                throw new Exception();
                // return false;  
            } // try
        }

        /// <summary>
        /// 获取指定时段内可以使用资源信息
        /// </summary>
        /// <returns>一组资源信息</returns>
        /// 作者：张衡
        /// 创建时间:2014-09-20
        /// 修改时间：
        public List<ResourceModel> GetCanUseRecord(DateTime startTime, DateTime endTime)
        {
            List<ResourceModel> rscList = new List<ResourceModel>();
            string strSqlCmd = string.Format("select * from Resource where ResourceStatus = '{0}'", 0);
            DataSet rsc = SqlHelperDB.GetDataSet(SqlHelperDB.ConnectionString, strSqlCmd, "Resource");

            foreach (DataRow rscRow in rsc.Tables["Resource"].Rows)
            {
                ResourceModel Resource = new ResourceModel();

                Resource.ResourceId = Convert.ToInt32(rscRow["ResourceId"].ToString());
                Resource.ResourceStatus = char.Parse(rscRow["ResourceStatus"].ToString());
                Resource.ResourceClass = rscRow["ResourceClass"].ToString();

                rscList.Add(Resource);
            } // end foreach

            return rscList;

            //// 查询 会议表 找到不在该时段的会议ID
            //string strSqlCmd = string.Format("select * from Conference where ConStartTime > '{0}' or ConEndTime < '{1}'", 
            //    endTime.ToString("yyyy/MM/dd HH:mm:ss"), startTime.ToString("yyyy/MM/dd HH:mm:ss"));
            //DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Conference");

            //if (data.Tables["Conference"].Rows.Count == 0) // 该时段外没有会议（在一个可用时段外没有会议）
            //{
            //    rscList = GetAllRecord();
            //}
            //else
            //{
            //    // 用不在该时段的会议id，找到不在该时段使用的资源的id
            //    foreach (DataRow row in data.Tables["Conference"].Rows)
            //    {

            //        strSqlCmd = string.Format("select * from ConUseResource where ConId = '{0}'", row["ConId"].ToString());
            //        DataSet rscData = SqlHelperDB.GetDataSet(SqlHelperDB.ConnectionString, strSqlCmd, "ConUseResource");

            //        // 根据找到的id在资源表里查询相应的资源
            //        foreach (DataRow useRscRow in rscData.Tables["ConUseResource"].Rows)
            //        {
            //            strSqlCmd = string.Format("select * from Resource where ResourceId = '{0}'", int.Parse(useRscRow["DeviceId"].ToString()));
            //            DataSet rsc = SqlHelperDB.GetDataSet(SqlHelperDB.ConnectionString, strSqlCmd, "Resource");

            //            foreach (DataRow rscRow in rsc.Tables["Resource"].Rows)
            //            {
            //                ResourceModel Resource = new ResourceModel();

            //                Resource.ResourceId = Convert.ToInt32(rscRow["ResourceId"].ToString());
            //                Resource.ResourceStatus = char.Parse(rscRow["ResourceStatus"].ToString());
            //                Resource.ResourceClass = rscRow["ResourceClass"].ToString();

            //                rscList.Add(Resource);
            //            } // end foreach
            //        } // end foreach
            //    } // end foreach
            //} // end if

            //return rscList;
        } // function GetCanUseRecord
    } // class ResourceDAL
} // namespace