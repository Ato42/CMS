/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：SqlHelperDB.cs
 * 文件功能描述：存放类SqlHelper
 * 
 * 创建标识：zhangheng 20140911
 * 
 * 修改标识：zhangheng 20140914
 * 修改描述：修改类名以符合规范
 * 
 * 修改标识：王宇昊 20140918
 * 修改描述：添加方法ExecuteSqlReturnId
 ---------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// using GS.CMS....本解决方案的引用与其他引用空行隔开


namespace GS.CMS.DB
{
    /// <summary>
    /// 提供数据库基本操作的类
    /// </summary>
    /// <author>张衡</author >
    /// <create date>2014/9/12</create date>
    /// <update time>2014/9/12</update time>
    public static class SqlHelperDB
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string connectionString =
            @"Data Source=LANCE-PC;Initial Catalog=CMS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";


        public static string ConnectionString
        {
            get { return SqlHelperDB.connectionString; }
        }


        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConn = new SqlConnection(connectionString); // 数据库连接对象
            return sqlConn;
        }



        /// <summary>
        /// 执行一条SQL语句，不返回数据
        /// </summary>
        /// <param name="strConnection">数据库连接字符串</param>
        /// <param name="strSqlCmd">SQL命令语句</param>
        /// <author>张衡</author >
        /// <create date>2014/9/12</create date>
        /// <update time>2014/9/12</update time>
        public static void ExecuteSql(string strConnection, string strSqlCmd)
        {

            SqlConnection sqlConn = new SqlConnection(strConnection); // 数据库连接对象
            SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn); // 数据库命令对象

            sqlConn.Open();
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        } // function ExecuteSql

        /// <summary>
        /// 执行一条SQL语句，返回ID
        /// </summary>
        /// <param name="strConnection">数据库连接字符串</param>
        /// <param name="strSqlCmd">SQL命令语句</param>
        public static int ExecuteSqlReturnId(string strConnection, string strSqlCmd)
        {

            SqlConnection sqlConn = new SqlConnection(strConnection); // 数据库连接对象
            SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn); // 数据库命令对象

            sqlConn.Open();
            int Id = Convert.ToInt32(sqlCmd.ExecuteScalar());
            sqlConn.Close();
            return Id;
        } // function ExecuteSql

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="strConnection">数据库连接字符串</param>
        /// <param name="strSqlCmd">SQL命令语句</param>
        /// <param name="tableName">填充的表名</param>
        /// <returns>返回指定的数据集</returns>
        /// <author>张衡</author >
        /// <create date>2014/9/12</create date>
        /// <update time>2014/9/12</update time>
        public static DataSet GetDataSet(string strConnection, string strSqlCmd, string strTableName)
        {
            SqlConnection sqlConn = new SqlConnection(strConnection); // 数据库连接对象
            SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn); // 数据库命令对象

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd); // 
            DataSet dataSet = new DataSet();
            sqlAdapter.Fill(dataSet, strTableName);

            return dataSet;
        } // function GetDataSet


        /// <summary>
        /// 更新数据集
        /// </summary>
        /// <param name="strConnection">数据库连接字符串</param>
        /// <param name="strSqlCmd">SQL命令语句</param>
        /// <param name="dataSet">要更新的数据集</param>
        /// <param name="strTableName">填充的表名</param>
        /// <author>张衡</author >
        /// <create date>2014/9/12</create date>
        /// <update time>2014/9/12</update time>
        public static void UpdateDataSet(string strConnection, string strSqlCmd, DataSet dataSet, string strTableName)
        {
            SqlConnection sqlConn = new SqlConnection(strConnection); // 数据库连接对象
            SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn); // 数据库命令对象

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd); // 
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(sqlAdapter); // 

            sqlAdapter.Update(dataSet, strTableName);
        } // function UpdateDataSet
    } // class SqlHelperDB
} // namespace GS.CMS.DB
