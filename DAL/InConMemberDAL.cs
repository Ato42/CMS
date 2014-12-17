/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：InConMemberDAL.cs
 * 文件功能描述：存放类InConMemberDAL
 * 
 * 创建标识：朱健 20140917
 * 
 * 修改标识：朱健 20140917
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：王宇昊 20140918
 * 修改描述：添加方法GetConRecord
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
    /// 内部与会人员类增删改查
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class InConMemberDAL : IUpdateData
    {
        /// <summary>
        /// 向数据库内部与会人员表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的内部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool AddARecord(object obj)
        {
            try
            {
                InConMemberModel InConMember = (InConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("insert into InconMember values('{0}','{1}','{2}')", 
                                           InConMember.ConId, InConMember.ConEmId, InConMember.ConRegister);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function AddARecord


        /// <summary>
        /// 从数据库内部与会人员表中删除一条信息
        /// </summary>
        /// <param name="obj">要删除的内部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool DelARecord(object obj)
        {
            try
            {
                InConMemberModel InConMember = (InConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("Delete from InconMember where ConId ='{0}'and ConEmId='{1}'", 
                                           InConMember.ConId, InConMember.ConEmId);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function DelARecord


        /// <summary>
        /// 向数据库内部与会人员表中修改信息
        /// </summary>
        /// <param name="obj">要修改的内部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool UpdateARecord(object obj) 
        {
            try
            {
                InConMemberModel InConMember = (InConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("update InConMember set ConRegister='{2}' where ConId ='{0}'and ConEmId='{1}'", 
                                           InConMember.ConId, InConMember.ConEmId,InConMember.ConRegister);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        } // function UpdateARecord

        /// <summary>
        /// 获取内部参会者的状态
        /// </summary>
        /// <param name="conId">会议ID</param>
        /// <returns>返回内部参会者</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-22
        /// 修改时间:
        public List<InConMemberModel> GetInConRecord(int conId)
        {
            try
            {
                List<InConMemberModel> InConMemberList = new List<InConMemberModel>();
                InConMemberModel InConMember = new InConMemberModel();
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, "select * from InConMember where Conid='" + conId + "'", "InConMember");

                foreach (DataRow row in data.Tables["InConMember"].Rows)
                {
                    InConMember.ConId = Convert.ToInt32(row["ConId"]);
                    InConMember.ConEmId = Convert.ToInt32(row["EmId"]);
                    InConMember.ConRegister = char.Parse(row["ConRegister"].ToString());
                    InConMemberList.Add(InConMember);
                }

                return InConMemberList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }// function GetInConRecord


        /// <summary>
        /// 获取内部参会者的员工信息
        /// </summary>
        /// <param name="conId">会议ID</param>
        /// <returns>返回内部参会者</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public List<EmployeeModel> GetConRecord(int conId)
        {
            try
            {
                List<InConMemberModel> InConMemberList = new List<InConMemberModel>();
                List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, "select * from InConMember where Conid='" + conId + "'", "InConMember");

                foreach (DataRow row in data.Tables["InConMember"].Rows)
                {
                    data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, "select * from Employee where Emid='" + Convert.ToInt32(row["ConEmid"].ToString()) + "'", "Employee");
                    EmployeeModel Employee = new EmployeeModel();
                    foreach (DataRow rowem in data.Tables["Employee"].Rows)
                    {
                        Employee.EmId = Convert.ToInt32(rowem["EmId"].ToString());
                        Employee.EmName = rowem["EmName"].ToString();
                        Employee.EmSex = rowem["EmSex"].ToString();
                        Employee.EmDepart = rowem["EmDepart"].ToString();
                        Employee.EmPhone = rowem["EmPhone"].ToString();
                        Employee.EmEmail = rowem["EmEmail"].ToString();
                        Employee.EmCompany = rowem["EmCompany"].ToString();
                        Employee.EmDuties = rowem["EmDuties"].ToString();
                        Employee.EmPassword = rowem["EmPassword"].ToString();
                        Employee.EmPermission = rowem["EmPermission"].ToString();
                        EmployeeList.Add(Employee);
                    } // 
                }

                return EmployeeList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }// function GetConRecord

        /// <summary>
        /// 按照用户ID查找会议信息
        /// </summary>
        /// <param name="employee">用户实体类对象</param>
        /// <returns>会议列表</returns>
        /// 作者：张衡
        /// 创建时间:2014-09-18
        /// 修改时间:
        public List<ConferenceModel> GetConferenceByUserId(EmployeeModel employee)
        {
            try
            {
                List<ConferenceModel> list = new List<ConferenceModel>(); // 存放用于返回的会议信息列表

                // 查找与指定用户相关的会议id
                string strSqlCmd = string.Format("select * from InConMember where ConEmId = '{0}'", employee.EmId);
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "InConMember");

                foreach (DataRow row in data.Tables["InConMember"].Rows)
                {
                    // 根据会议id获取会议信息
                    strSqlCmd = string.Format("select * from Conference where ConId = '{0}'", row["ConId"]);
                    DataSet conData = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Conference");

                    foreach (DataRow conRow in conData.Tables["Conference"].Rows)
                    {
                        ConferenceModel Conference = new ConferenceModel();

                        Conference.ConId = Convert.ToInt32(conRow["ConId"].ToString());
                        Conference.ConName = conRow["ConName"].ToString();
                        Conference.ConPlace = Convert.ToInt32(conRow["ConPlace"].ToString());
                        Conference.ConStartTime = (DateTime)conRow["ConStartTime"];
                        Conference.ConEndTime = (DateTime)conRow["ConEndTime"];
                        Conference.ConHost = conRow["ConHost"].ToString();
                        Conference.ConType = char.Parse(conRow["ConType"].ToString());
                        Conference.ConStatus = char.Parse(conRow["ConStatus"].ToString());
                        Conference.ConSubMen = Convert.ToInt32(conRow["ConSubMen"].ToString());
                        Conference.ConRecordMen = Convert.ToInt32(conRow["ConRecordMen"].ToString());
                        Conference.ConStaffMen = int.Parse(conRow["ConStaffMen"].ToString());
                        Conference.ConRegister = char.Parse(conRow["ConRegister"].ToString());
                        Conference.ConIsDone = char.Parse(conRow["ConIsDone"].ToString());
                        Conference.ConOthers = conRow["ConOthers"].ToString();

                        list.Add(Conference);
                    } // end foreach
                } // end foreach
                
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // function GetConferenceByUserId

    }// class InConMemberDAL
}// namespace GS.CMS.DAL

