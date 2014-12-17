/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：BoardroomDAL.cs
 * 文件功能描述：存放类BoardroomDAL.cs
 * 
 * 创建标识：吴欣哲 20140916
 * 
 * 修改标识：吴欣哲 20140917    
 * 修改描述：修改代码规范
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
    /// 对会议室进行增删改查的类
    /// </summary>
    /// 作者：吴欣哲
    /// 创建时间:2014-09-16
    /// 修改时间：
    public class BoardroomDAL:IUpdateData
    {
      
      /// <summary>
      /// 向数据库会议室表中插入一条新信息
      /// </summary>
      /// <param name="obj">一条新的会议室信息</param>
      /// <returns>操作成功返回true，失败返回false</returns>
      /// 作者：吴欣哲
      /// 创建时间:2014-09-16
      /// 修改时间：
       public bool AddARecord(object obj) 
        {
            try
            {
                BoardroomModel boardroom = (BoardroomModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("insert into Boardroom values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    boardroom.BdrName, boardroom.BdrContactNum, boardroom.BdrLinkMan, boardroom.BdrContactPhone,
                    boardroom.BdrIntro, boardroom.BdrStatus, boardroom.BdrRemarks);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;  
            } // try
        } // function AddRecord


        /// <summary>
        /// 向数据库会议室表中删除一条信息
        /// </summary>
        /// <param name="obj">要删除的会议室信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-16
        /// 修改时间：
       public bool DelARecord(object obj)
        {
            try
            {
                BoardroomModel boardroom = (BoardroomModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format("delete from boardroom where bdrid = '{0}'", boardroom.BdrId);

                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch
            {
                throw new Exception();
                //return false;  
            } // try
        } //function DelARecord


       /// <summary>
       /// 获取表中所有记录
       /// </summary>
       /// <param name="sqlItems">要获取的记录</param>
       /// <returns>返回BoardroomList</returns>
       /// 作者：朱健
       /// 创建时间:2014-09-18
       /// 修改时间：2014-09-18
       public List<BoardroomModel> GetAllRecord(string sqlItems)
       {
           try
           {
                List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
                string strSqlCmd = string.Format(@"select * from Boardroom where BdrId like '%{0}%' or BdrName like '%{0}%'
                                                                            or BdrContactNum like '%{0}%' or BdrLinkMan like '%{0}%'
                                                                            or BdrContactPhone like '%{0}%' or BdrIntro like '%{0}%'
                                                                            or BdrStatus like '%{0}%' or BdrRemarks like '%{0}%'
                                                                            ", sqlItems);
                DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd , "Boardroom");

                foreach (DataRow row in data.Tables["Boardroom"].Rows)
                {
                    BoardroomModel boardroom =  new BoardroomModel();

                    boardroom.BdrId             = Convert.ToInt32(row["BdrId"].ToString());
                    boardroom.BdrName           = row["BdrName"].ToString();
                    boardroom.BdrContactNum     = int.Parse(row["BdrContactNum"].ToString());
                    boardroom.BdrLinkMan        = row["BdrLinkMan"].ToString();
                    boardroom.BdrContactPhone   = row["BdrContactPhone"].ToString();
                    boardroom.BdrIntro          = row["BdrIntro"].ToString();
                    boardroom.BdrStatus          = char.Parse(row["BdrStatus"].ToString());
                    boardroom.BdrRemarks        = row["BdrRemarks"].ToString();

                    BoardroomList.Add(boardroom); 
                }

                return BoardroomList;
            }
           catch
           {
               throw new Exception();
           }

       }//function GetAllRecord()


        /// <summary>
        /// 向数据库会议室表中修改一条信息
        /// </summary>
        /// <param name="obj">要x修改的会议室信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-16
        /// 修改时间：
       public bool UpdateARecord(object obj)
        {
            try
            {
                BoardroomModel boardroom = (BoardroomModel)obj;
                string strSqlCmd; // sql命令存放语句

                strSqlCmd = string.Format(@"update boardroom set bdrname='{1}',bdrcontactnum='{2}',bdrlinkman='{3}',
                    bdrcontactphone='{4}',bdrintro='{5}',bdrstatus='{6}',bdrremarks='{7}' where bdrid = '{0}'",
                        boardroom.BdrId, boardroom.BdrName, boardroom.BdrContactNum, boardroom.BdrLinkMan, boardroom.BdrContactPhone,
                        boardroom.BdrIntro, boardroom.BdrStatus, boardroom.BdrRemarks);
                SqlHelperDB.ExecuteSql(SqlHelperDB.ConnectionString, strSqlCmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            } // try
        } //function UpdateARecord

       /// <summary>
       /// 判断会议室是否存在会议
       /// </summary>
       /// <param name="bdrId">会议室ID</param>
       /// <returns>操作成功返回true，失败返回false</returns>
       /// 作者：王宇昊
       /// 创建时间:2014-09-19
       /// 修改时间：
       public bool IsConExist(int bdrId)
       {
           try
           {
               string strSqlCmd; // sql命令存放语句
               strSqlCmd = string.Format("select * from Conference where ConPlace='{0}' and ConEndTime > '{1}'", bdrId, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
               DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Conference");

               List<ConferenceModel> ConferenceList = new List<ConferenceModel>();

               foreach (DataRow row in data.Tables["Conference"].Rows)
               {
                   ConferenceModel Conference = new ConferenceModel();
                   ConferenceList.Add(Conference);
               }
               if (ConferenceList.Count > 0)
               {
                   return false;
               }
               else
               {
                   return true;
               }
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
       }//function IsConExist

       /// <summary>
       /// 判断会议室当前时段是否存在会议
       /// </summary>
       /// <param name="bdrId">会议室ID</param>
       /// <param name="bdrId">开始时间</param>
       /// <param name="bdrId">结束时间</param>
       /// <returns>操作成功返回true，失败返回false</returns>
       /// 作者：王宇昊
       /// 创建时间:2014-09-19
       /// 修改时间：
       public bool IsConExist(int bdrId,DateTime start ,DateTime end)
       {
           try
           {
               string strSqlCmd; // sql命令存放语句
               strSqlCmd = string.Format("select * from Conference where ConPlace='{0}' and ConStartTime < '{2}' and ConEndTime > '{1}'", bdrId, start.ToString("yyyy-MM-dd HH:mm:ss"), end.ToString("yyyy-MM-dd HH:mm:ss"));
               DataSet data = SqlHelperDB.GetDataSet(DB.SqlHelperDB.ConnectionString, strSqlCmd, "Conference");

               List<ConferenceModel> ConferenceList = new List<ConferenceModel>();

               foreach (DataRow row in data.Tables["Conference"].Rows)
               {
                   ConferenceModel Conference = new ConferenceModel();
                   ConferenceList.Add(Conference);
               }
               if (ConferenceList.Count > 0)
               {
                   return true ;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
       }//function IsConExist

        /// <summary>
        /// 通过会议ID查找会议室
        /// </summary>
        /// <param name="Conplace"></param>
        /// <returns></returns>
       /// 作者：王宇昊
       /// 创建时间:2014-09-19
       /// 修改时间：
       public BoardroomModel GetBdrFromCon(int Conplace)
       {
           try
           {
               List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
               BoardroomList = GetAllRecord(Conplace.ToString());

               BoardroomModel Boardroom = new BoardroomModel();

               foreach (BoardroomModel Bdr in BoardroomList)
               {
                   if (Bdr.BdrId == Conplace)
                   {
                       Boardroom = Bdr;
                   }
               }
               return Boardroom;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
       }//function GetBdrFromCon

    } // class BoardroomDAL
} // namespace DAL