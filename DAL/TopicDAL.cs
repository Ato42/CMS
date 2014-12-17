/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：TopicDAL.cs
 * 文件功能描述：存放类TopicDAL.cs
 * 
 * 创建标识：吴欣哲 20140916
 * 
 * 修改标识：朱健 20140918    
 * 修改描述：增加函数GetAllRecord()
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
    /// 对议题进行增删改查的类
    /// </summary>
    /// 作者：吴欣哲
    /// 创建时间:2014-09-16
    /// 修改时间：
    public class TopicDAL : IUpdateData
    {
        /// <summary>
        /// 向数据库议题表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的议题信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-16
        /// 修改时间：
        public bool AddARecord(object obj)
        {
            try
            {
                TopicModel topic = (TopicModel )obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("insert into topic values('{0}','{1}','{2}','{3}','{4}','{5}')",
                   topic.TopicApplicantId,
                   topic.TopicSubTime.ToString("yyyy-MM-dd HH:mm:ss"),
                   topic.TopicVerifyTime.ToString("yyyy-MM-dd HH:mm:ss"), 
                   topic.TopicHead, topic.TopicContent, topic .TopicStatus);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message );
                // return false;  
            } // try
        } // function AddRecord


        /// <summary>
        /// 向数据库会议议题室表中删除一条信息
        /// </summary>
        /// <param name="obj">要删除的议题信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-16
        /// 修改时间：
        public bool DelARecord(object obj)
        {
            try
            {
                TopicModel topic = (TopicModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("delete from topic where topicid = '{0}'", topic .TopicId );

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception();
                // return false;  
            } // try
        } //function DelARecord


        /// <summary>
        /// 获取表中所有记录
        /// </summary>
        /// <param name="sqlItems">要获取的记录</param>
        /// <returns>返回TopicList</returns>
        /// 作者：朱健
        /// 创建时间:2014-09-18
        /// 修改时间：2014-09-18
        /// 修改时间：2014-09-19
        public List<TopicModel> GetAllRecord(string sqlItems)
        {
            try
            {
                List<TopicModel> TopicList = new List<TopicModel>();
                string strSqlCmd = string.Format(@"select * from Topic where TopicId like '%{0}%' or TopicApplicantId like '%{0}%'
                                                                            or TopicSubTime like '%{0}%' or TopicVerifyTime like '%{0}%'
                                                                            or TopicHead like '%{0}%' or TopicContent like '%{0}%'
                                                                            or TopicStatus like '%{0}%'", sqlItems);
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Topic");

                foreach (DataRow row in data.Tables["Topic"].Rows)
                {
                    TopicModel Topic = new TopicModel();

                    Topic.TopicId = Convert.ToInt32(row["TopicId"].ToString());
                    Topic.TopicApplicantId = Convert.ToInt32(row["TopicApplicantId"].ToString());
                    Topic.TopicSubTime = (DateTime)row["TopicSubTime"];

                    if((Object)row["TopicVerifyTime"] != null)
                    {
                        Topic.TopicVerifyTime = (DateTime)row["TopicVerifyTime"];
                    }
                    
                    Topic.TopicHead = row["TopicHead"].ToString();
                    Topic.TopicContent = row["TopicContent"].ToString();
                    Topic.TopicStatus = char.Parse(row["TopicStatus"].ToString());

                    TopicList.Add(Topic);
                }

                return TopicList;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }//function GetAllRecord()
        /// <summary>
        /// 向数据库会议议题室表中修改一条信息
        /// </summary>
        /// <param name="obj">要修改的议题信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-16
        /// 修改时间：
        public bool UpdateARecord(object obj)
        {
            try
            {
                TopicModel topic = (TopicModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format(@"update topic set TopicApplicantId='{1}', TopicSubTime='{2}', TopicVerifyTime='{3}',
                TopicHead='{4}', TopicContent='{5}', TopicStatus= '{6}' where TopicId = '{0}'",
                topic.TopicId, topic.TopicApplicantId,
                topic.TopicSubTime.ToString("yyyy-MM-dd HH:mm:ss"),
                topic.TopicVerifyTime.ToString("yyyy-MM-dd HH:mm:ss"),
                topic.TopicHead, topic.TopicContent, topic.TopicStatus);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                // return false;  
            } // try
        } //function DelARecord
    } // class TopicDAL
} // namespace DAL
