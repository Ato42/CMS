/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ExcelToSqlDAL.cs
 * 文件功能描述：存放类ExcelToSqlDAL
 * 
 * 创建标识：吴若彤 20140922
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GS.CMS.DB;
using GS.CMS.IDAL;
using GS.CMS.MODEL;

namespace GS.CMS.DAL
{
    /// <summary>
    /// 将Excel文件导入Sql中
    /// </summary>
    /// 作者：吴若彤
    /// 创建时间：2014-9-22
    /// 修改时间
    public class ExcelToSqlDAL
    {
        /// <summary>
        /// 将Excel文件内容填充入DataSet
        /// </summary>
        /// <returns>填充的DataSet内容</returns>
        /// 作者：吴若彤
        /// 创建时间：2014-9-22
        /// 修改时间：2014-9-22
        public DataSet ExcelTsql()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Excel files(*.xls)|*.xls";
            if(fd.ShowDialog()==DialogResult.OK)
            {
                string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + fd.FileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                OleDbConnection myConn = new OleDbConnection(strCon);
                string strCom = " SELECT * FROM [Sheet1$] ";
                myConn.Open();
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
                DataSet ds = new DataSet();
                myCommand.Fill(ds,"Table");
                myConn.Close();
                return ds;
            }
            else
            {
                throw new Exception("未打开文件！");
            }
            
        }//function ExcelTsql
        
        /// <summary>
        /// 将填充的DataSet写入Sql中
        /// </summary>
        /// <param name="ConID">会议ID</param>
        /// 作者：吴若彤
        /// 创建时间：2014-9-22
        /// 修改时间：2014-9-22
        public void ExcelToSqlFill(int ConID)
        {
            DataSet ds =ExcelTsql();

            SqlConnection sqlConn = SqlHelperDB.GetConnection();
            for(int i=0;i<ds.Tables["table"].Rows.Count;i++)
            {
                string sqlcmdstring = String.Format("Insert into OutConMember values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ConID, ds.Tables["table"].Rows[i][1], ds.Tables["table"].Rows[i][2], ds.Tables["table"].Rows[i][3], ds.Tables["table"].Rows[i][4], ds.Tables["table"].Rows[i][5], ds.Tables["table"].Rows[i][0], '0');
                SqlCommand cmd = new SqlCommand(sqlcmdstring,sqlConn);
                DB.SqlHelperDB.ExecuteSql(DB.SqlHelperDB.ConnectionString, sqlcmdstring);
            }
            sqlConn.Close();

        }//function ExcelToSqlFill
        
    }//Class ExcelToSql
}
