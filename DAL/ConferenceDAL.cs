/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConferenceDAL.cs
 * 文件功能描述：存放类ConferenceDAL
 * 
 * 创建标识：朱健 20140917
 * 
 * 修改标识：朱健 20140917
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：朱健 20140918    
 * 修改描述：增加函数GetAllRecord()
 * 
 * 修改标识：王宇昊 20140918    
 * 修改描述：增加函数GetAllRecordReturnId()
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
    /// 会议类增删改查
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class ConferenceDAL:IUpdateData
    {
        /// <summary>
        /// 向数据库会议表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的会议信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool AddARecord(object obj)
        {
            try
            {
                ConferenceModel Conference = (ConferenceModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format(@"insert into Conference values('{0}','{1}','{2}','{3}','{4}',
                                                                          '{5}','{6}','{7}','{8}','{9}',
                                                                          '{10}','{11}','{12}')",
                                            Conference.ConName, Conference.ConPlace, Conference.ConStartTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            Conference.ConEndTime.ToString("yyyy-MM-dd HH:mm:ss"), Conference.ConHost, Conference.ConType, Conference.ConStatus, 
                                            Conference.ConSubMen, Conference.ConRecordMen,Conference.ConStaffMen, Conference.ConRegister, 
                                            Conference.ConIsDone, Conference.ConOthers);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function AddARecord


        /// <summary>
        /// 从数据库会议表中删除新信息
        /// </summary>
        /// <param name="obj">要删除的会议信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool DelARecord(object obj)
        {
            try
            {
                ConferenceModel Conference = (ConferenceModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("Delete from Conference where ConId ='{0}'",Conference.ConId);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // function DelARecord


        /// <summary>
        /// 获取表中所有记录
        /// </summary>
        /// <param name="sqlItem">要获取的记录</param>
        /// <returns>返回ConferenceList</returns>
        /// 作者：朱健
        /// 创建时间:2014-09-18
        /// 修改时间：2014-09-18
        /// 修改时间：2014-09-19
        public List<ConferenceModel> GetAllRecord(string sqlItems)
        {
            try
            {
                List<ConferenceModel> ConferenceList = new List<ConferenceModel>();
                string strSqlCmd = string.Format(@"select * from Conference where Conid like '%{0}%' or ConName like '%{0}%'
                                                                            or ConPlace like '%{0}%' or ConStartTime like '%{0}%'
                                                                            or ConEndTime like '%{0}%' or ConHost like '%{0}%'
                                                                            or ConType like '%{0}%' or ConStatus like '%{0}%'
                                                                            or ConSubMen like '%{0}%' or ConRecordMen like '%{0}%'
                                                                            or ConStaffMen like '%{0}%' or ConRegister like '%{0}%'
                                                                            or ConIsDone like '%{0}%'", sqlItems);
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Conference");

                foreach (DataRow row in data.Tables["Conference"].Rows)
                {
                    ConferenceModel Conference = new ConferenceModel();

                    Conference.ConId = Convert.ToInt32(row["ConId"].ToString());
                    Conference.ConName = row["ConName"].ToString();
                    Conference.ConPlace = Convert.ToInt32(row["ConPlace"].ToString());
                    Conference.ConStartTime = (DateTime)row["ConStartTime"];
                    Conference.ConEndTime = (DateTime)row["ConEndTime"];
                    Conference.ConHost = row["ConHost"].ToString();
                    Conference.ConType = char.Parse(row["ConType"].ToString());
                    Conference.ConStatus = char.Parse(row["ConStatus"].ToString());
                    Conference.ConSubMen = Convert.ToInt32(row["ConSubMen"].ToString());
                    Conference.ConRecordMen = Convert.ToInt32(row["ConRecordMen"].ToString());
                    Conference.ConStaffMen = int.Parse(row["ConStaffMen"].ToString());
                    Conference.ConRegister = char.Parse(row["ConRegister"].ToString());
                    Conference.ConIsDone = char.Parse(row["ConIsDone"].ToString());
                    Conference.ConOthers = row["ConOthers"].ToString();

                    ConferenceList.Add(Conference);
                }

                return ConferenceList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }//function GetAllRecord()


        /// <summary>
        /// 从数据库会议表中修改一条信息
        /// </summary>
        /// <param name="obj">要修改的会议信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool UpdateARecord(object obj)
        {
            try
            {
                ConferenceModel Conference = (ConferenceModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format(@"update Conference set 
                                            ConName='{1}',ConPlace='{2}', ConStartTime='{3}',ConEndTime='{4}',ConHost='{5}', 
                                            ConType='{6}', ConStatus='{7}', ConSubMen='{8}', ConRecordMen='{9}',ConStaffMen='{10}', 
                                            ConRegister='{11}', ConIsDone='{12}', ConOthers='{13}'  where ConId ='{0}'",
                                            Conference.ConId, Conference.ConName, Conference.ConPlace, Conference.ConStartTime.ToString("yyyy-MM-dd HH:mm:ss"), Conference.ConEndTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            Conference.ConHost, Conference.ConType, Conference.ConStatus, Conference.ConSubMen, Conference.ConRecordMen,
                                            Conference.ConStaffMen, Conference.ConRegister, Conference.ConIsDone, Conference.ConOthers);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // function UpdateARecord

        /// <summary>
        /// 向数据库会议表中插入一条新信息，并返回会议ID
        /// </summary>
        /// <param name="obj">一条新的会议信息</param>
        /// <returns>返回会议的编号</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public int AddARecordReturnId(object obj)
        {
            try
            {
                ConferenceModel Conference = (ConferenceModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format(@"insert into Conference values('{0}','{1}','{2}','{3}','{4}',
                                                                          '{5}','{6}','{7}','{8}','{9}',
                                                                          '{10}','{11}','{12}')Select @@Identity",
                                            Conference.ConName, Conference.ConPlace, Conference.ConStartTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            Conference.ConEndTime.ToString("yyyy-MM-dd HH:mm:ss"), Conference.ConHost, Conference.ConType, Conference.ConStatus,
                                            Conference.ConSubMen, Conference.ConRecordMen, Conference.ConStaffMen, Conference.ConRegister,
                                            Conference.ConIsDone, Conference.ConOthers);
                int CId = SqlHelperDB.ExecuteSqlReturnId(SqlHelperDB.ConnectionString, strSqlCmd);//执行并返回会议ID
                return CId;
            }
            catch (Exception)
            {
                return -1;
            }
        } // function AddARecord
     } // class ConferenceDAL
} // namespace GS.CMS.DAL

