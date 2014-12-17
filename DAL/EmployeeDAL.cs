/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：EmployeeDAL.cs
 * 文件功能描述：存放类EmployeeDAL
 * 
 * 创建标识：朱健 20140917
 * 
 * 修改标识：朱健 20140917
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：朱健 20140918    
 * 修改描述：增加函数IsExist()
 * 
 * 修改标识：王宇昊 20140918    
 * 修改描述：删除增删改的功能，修改IsExist()
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using GS.CMS.DB;
using GS.CMS.IDAL;
using GS.CMS.MODEL;

namespace GS.CMS.DAL
{
    /// <summary>
    /// 员工类增删改查
    /// </summary>
    /// 作者:朱健
    /// 创建时间:2014-09-16
    /// 修改时间:2014-09-17
    public class EmployeeDAL : IUpdateData 
    {
        /// <summary>
        /// 向数据库员工表中插入一条新信息
        /// </summary>
        /// <param name="obj">一条新的员工信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool AddARecord(object obj)
        {
            try
            {
                EmployeeModel Employee = (EmployeeModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("insert into Employee values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                       Employee.EmId, Employee.EmName, Employee.EmSex, Employee.EmDepart, 
                                                       Employee.EmPhone, Employee.EmEmail, Employee.EmCompany, Employee.EmDuties);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function AddARecord


        /// <summary>
        /// 从数据库员工表中删除一条信息
        /// </summary>
        /// <param name="obj">要删除的员工信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool DelARecord(object obj)
        {
            try
            {
                EmployeeModel Employee = (EmployeeModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format("Delete from Employee where EmId ='{0}'", Employee.EmId);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } // function DelARecord


        /// <summary>
        /// 从数据库员工表中修改一条信息
        /// </summary>
        /// <param name="obj">要修改员工信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:朱健
        /// 创建时间:2014-09-16
        /// 修改时间:2014-09-17
        public bool UpdateARecord(object obj)
        {
            try
            {
                EmployeeModel Employee = (EmployeeModel)obj;
                string strSqlCmd;// 存储数据库命令语句
                strSqlCmd = string.Format(@"update Employee set EmName='{1}',EmSex='{2}', EmDepart='{3}',EmPhone='{4}',
                                                                EmEmail='{5}', EmCompany='{6}', EmDuties='{7}' where EmId='{0}'",
                                                                Employee.EmId, Employee.EmName, Employee.EmSex, Employee.EmDepart, 
                                                                Employee.EmPhone, Employee.EmEmail, Employee.EmCompany, Employee.EmDuties);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
         } // function UpdateARecord


        /// <summary>
        /// 判断登陆用户是否存在
        /// </summary>
        /// <param name="id">用户账号</param>
        /// <param name="pwd">用户密码</param>
        /// <returns>用户信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:2014-09-18
        public EmployeeModel IsExist(string id,string pwd)
        {
            EmployeeModel Employee = new EmployeeModel();//返回值

            string strSqlCmd;// 存储数据库命令语句
            strSqlCmd = string.Format("select * from Employee where EmId ='{0}'and EmPassword = '{1}'", id , pwd);

            SqlConnection sqlConn = SqlHelperDB.GetConnection();
            SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn);
            sqlConn.Open();
            
            SqlDataReader sqlDR = sqlCmd.ExecuteReader();
          
            if (sqlDR.Read())
            {
                Employee.EmId = Convert.ToInt32(sqlDR[0].ToString());
                Employee.EmName = sqlDR[1].ToString();
                Employee.EmPermission = sqlDR[2].ToString();
                Employee.EmSex = sqlDR[3].ToString();
                Employee.EmDepart = sqlDR[4].ToString();
                Employee.EmPhone = sqlDR[5].ToString();
                Employee.EmEmail = sqlDR[6].ToString();
                Employee.EmCompany = sqlDR[7].ToString();
                Employee.EmDuties = sqlDR[8].ToString();
                Employee.EmPassword = sqlDR[9].ToString();
                sqlDR.Close();
                sqlConn.Close();
                return Employee;
            }
            else
            {
                Employee.EmPermission = "ER";
                return Employee;
            }
        }// function IsExist()

        /// <summary>
        /// 从数据库员工表中获取一条信息
        /// </summary>
        /// <param name="obj">员工ID</param>
        /// <returns>返回员工信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public EmployeeModel GetARecord(int id)
        {     
            EmployeeModel Employee = new EmployeeModel();   
            string strSqlCmd;// 存储数据库命令语句   
            strSqlCmd = string.Format(@"select * from Employee where EmId = '" + id + "'");
            DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Employee");

            foreach (DataRow row in data.Tables["Employee"].Rows)
             {   
                 Employee.EmId = Convert.ToInt32(row["EmId"].ToString());
                 Employee.EmName = row["EmName"].ToString();
                 Employee.EmSex = row["EmSex"].ToString();
                 Employee.EmDepart = row["EmDepart"].ToString();
                 Employee.EmPhone = row["EmPhone"].ToString();
                 Employee.EmEmail = row["EmEmail"].ToString();
                 Employee.EmCompany = row["EmCompany"].ToString();
                 Employee.EmDuties = row["EmDuties"].ToString();
                 Employee.EmPassword = row["EmPassword"].ToString();
                 Employee.EmPermission = row["EmPermission"].ToString();
             }
             return Employee;
        } // function GetARecord

        /// <summary>
        /// 从数据库员工表中获取所有信息
        /// </summary>
        /// <returns>返回员所有工信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间:
        public List<EmployeeModel> GetAllRecord()
        {
            List<EmployeeModel> Employeelist = new List<EmployeeModel>();
            string strSqlCmd;// 存储数据库命令语句   
            strSqlCmd = string.Format(@"select * from Employee");
            DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Employee");

            foreach (DataRow row in data.Tables["Employee"].Rows)
            {
                EmployeeModel Employee = new EmployeeModel();
                Employee.EmId = Convert.ToInt32(row["EmId"].ToString());
                Employee.EmName = row["EmName"].ToString();
                Employee.EmSex = row["EmSex"].ToString();
                Employee.EmDepart = row["EmDepart"].ToString();
                Employee.EmPhone = row["EmPhone"].ToString();
                Employee.EmEmail = row["EmEmail"].ToString();
                Employee.EmCompany = row["EmCompany"].ToString();
                Employee.EmDuties = row["EmDuties"].ToString();
                Employee.EmPassword = row["EmPassword"].ToString();
                Employee.EmPermission = row["EmPermission"].ToString();
                Employeelist.Add(Employee);
            }
            return Employeelist;
        } // function GetAllRecord


        /// <summary>
        /// 从数据库员工表中获取所有部门信息
        /// </summary>
        /// <returns>返回员所有工信息</returns>
        /// 作者:张衡
        /// 创建时间:2014-09-20
        /// 修改时间:
        public List<EmployeeModel> GetAllDepart()
        {
            List<EmployeeModel> Employeelist = new List<EmployeeModel>();
            string strSqlCmd;// 存储数据库命令语句   
            strSqlCmd = string.Format(@"select distinct emdepart from Employee");
            DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Employee");

            foreach (DataRow row in data.Tables["Employee"].Rows)
            {
                EmployeeModel Employee = new EmployeeModel();
                Employee.EmDepart = row["EmDepart"].ToString();
                Employeelist.Add(Employee);
            }
            return Employeelist;
        } // function GetAllDepart
    }// class EmployeeDAL
}// namespace GS.CMS.DAL

