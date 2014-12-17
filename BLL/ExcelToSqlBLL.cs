/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ExcelToSqlBLL.cs
 * 文件功能描述：存放类ExcelToSqlBLL.cs
 * 
 * 创建标识：王宇昊 20140918
 * 
 * 修改标识： 
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using GS.CMS.DAL;
using GS.CMS.DB;
using GS.CMS.MODEL;

namespace GS.CMS.BLL
{
    /// <summary>
    /// 调用将Excel文件导入SQL
    /// </summary>
    /// 作者：王宇昊
    /// 创建时间：2014-9-22
    /// 修改时间
    public class ExcelToSqlBLL
    {
        /// <summary>
        /// 调用将Excel文件导入外部与会人员表
        /// </summary>
        /// 作者：王宇昊
        /// 创建时间：2014-9-22
        /// 修改时间
        public void OutExcel(int conid)
        {
            ExcelToSqlDAL EX = new ExcelToSqlDAL();
            EX.ExcelToSqlFill(conid);
        }//function OutExcelToSqlFill

        /// <summary>
        /// 调用将Excel文件导入内部与会人员表
        /// </summary>
        /// 作者：王宇昊
        /// 创建时间：2014-9-22
        /// 修改时间
        public void InExcel(int conid)
        {
            ExcelToSqlDAL EX = new ExcelToSqlDAL();
            EX.ExcelToSqlFill(conid);
        }//function OutExcelToSqlFill

    }//Class ExcelToSql
}// namespace GS.CMS.BLL
