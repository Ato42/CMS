/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：OutConMemberDAL.cs
 * 文件功能描述：存放类OutConMemberDAL
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
using System.Data;
using System.Linq;
using System.Text;
using GS.CMS.DB;
using GS.CMS.IDAL;
using GS.CMS.MODEL;

namespace GS.CMS.DAL
{
    /// <summary>
    /// 外部与会人员类增删改查
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class OutConMemberDAL : IUpdateData
    {
        /// <summary>
        /// 向数据库外部与会人员表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的外部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool AddARecord(object obj)
        {
            try
            {
                OutConMemberModel OutConMember = (OutConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("insert into OutConMember values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                            OutConMember.ConId, OutConMember.ConName, OutConMember.ConSex, OutConMember.ConDuties, 
                                            OutConMember.ConPhone, OutConMember.ConEmail, OutConMember.ConCompany, OutConMember.ConRegister);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function AddARecord


        /// <summary>
        /// 数据库外部与会人员表中删除一条信息
        /// </summary>
        /// <param name="obj">要删除的外部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool DelARecord(object obj)
        {
            try
            {
                OutConMemberModel OutConMember = (OutConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("Delete from OutConMember where ConId ='{0}'", OutConMember.ConId);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function DelARecord


        /// <summary>
        /// 向数据库外部与会人员表中修改信息
        /// </summary>
        /// <param name="obj">要修改的外部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool UpdateARecord(object obj)
        {
            try
            {
                OutConMemberModel OutConMember = (OutConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format(@"update OutConMember set 
                                            ConName='{1}',ConSex='{2}', ConDuties='{3}',ConPhone='{4}',
                                            ConEmail='{5}', ConCompany='{6}', ConRegister='{7}' where ConID='{0}'",
                                            OutConMember.ConId, OutConMember.ConName, OutConMember.ConSex, OutConMember.ConDuties, 
                                            OutConMember.ConPhone, OutConMember.ConEmail, OutConMember.ConCompany, OutConMember.ConRegister);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function UpdateARecord
        /// <summary>
        /// 获取外部参会者的信息
        /// </summary>
        /// <param name="conId">会议ID</param>
        /// <returns>返回外部参会者</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public List<OutConMemberModel> GetConRecord(int conId)
        {
            try
            {
                List<OutConMemberModel> OutConMemberList = new List<OutConMemberModel>();
                
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, "select * from OutConMember where Conid='" + conId + "'", "OutConMember");

                foreach (DataRow row in data.Tables["OutConMember"].Rows)
                {
                    OutConMemberModel ConMember = new OutConMemberModel();
                    ConMember.ConId = Convert.ToInt32(row["ConId"].ToString());
                    ConMember.ConName = row["ConName"].ToString();
                    ConMember.ConSex = row["ConSex"].ToString();
                    ConMember.ConDuties = row["ConDuties"].ToString();
                    ConMember.ConPhone = row["ConPhone"].ToString();
                    ConMember.ConEmail = row["ConEmail"].ToString();
                    ConMember.ConCompany = row["ConCompany"].ToString();
                    ConMember.ConRegister = char.Parse(row["ConRegister"].ToString());
                    OutConMemberList.Add(ConMember);
                    
                }

                return OutConMemberList;
            }
            catch
            {
                throw new Exception();
            }
        }// function GetConRecord


        /// <summary>
        /// 修改外部人员签到信息
        /// </summary>
        /// <param name="obj">要修改的外部与会人员信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool UpdateRegisterRecord(object obj)
        {
            try
            {
                OutConMemberModel OutConMember = (OutConMemberModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format(@"update OutConMember set 
                                            ConRegister='{2}' where ConID='{0}'and ConPhone='{1}'",
                                            OutConMember.ConId, OutConMember.ConPhone, OutConMember.ConRegister);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function UpdateARecord
    }// class OutConMemberDAL
}// namespace GS.CMS.DAL

