/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConferenceAuditorBLL.cs
 * 文件功能描述：存放类ConferenceAuditorBLL.cs
 * 
 * 创建标识：王宇昊 20140918
 * 
 * 修改标识： 
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GS.CMS.DAL;
using GS.CMS.DB;
using GS.CMS.MODEL;

namespace GS.CMS.BLL
{
    /// <summary>
    /// 会议管理员类
    /// </summary>
    /// 作者:王宇昊
    /// 创建时间:2014-09-18
    /// 修改时间:
    public class ConferenceAuditorBLL : UserBLL
    {
        /// <summary>
        /// 会议管理员删除会议
        /// </summary>
        /// <param name="conference">会议表实体类</param>
        /// <returns>true：申请提交成功；false：申请提交失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool DelConference(ConferenceModel conference)
        {
            try
            {
                ConferenceDAL ConDAL = new ConferenceDAL();
                if (conference.ConStatus == '0')
                {
                    ConDAL.DelARecord(conference);
                }
                else
                {
                   
                    ConDAL.DelARecord(conference);

                    BoardroomDAL BdrDAL = new BoardroomDAL();
                    List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
                    BoardroomList = BdrDAL.GetAllRecord(conference.ConPlace.ToString());

                    BoardroomModel Boardroom = new BoardroomModel();

                    foreach (BoardroomModel Bdr in BoardroomList)
                    {
                        if (Bdr.BdrId == conference.ConPlace)
                        {
                            Boardroom = Bdr;
                        }
                    }

                    ConDAL.UpdateARecord(conference);
                    string Topic = string.Format("{0}会议取消通知", conference.ConName);
                    string Body = string.Format("会议名称：{0}<br />会议地点：{1}<br />主办单位：{2}<br />会议时间：{3}<br />会议由于特殊原因取消，请诸位告知", conference.ConName, Boardroom.BdrName, conference.ConHost, conference.ConStartTime);
                    SendTask(conference.ConSubMen, Topic, Body);//向会议申请人发送会议取消的消息
                    SendNotice(conference, Topic, Body);//查找与会人员通过邮件发布会议取消的信息
                    SendTask(conference.ConStaffMen, Topic, Body);//发送新任务单信息给会务人员
                }
                return true;
            }
            catch
            {
                return false;
            }
        }// function DelConference
        
        /// <summary>
        /// 会议管理员修改会议
        /// </summary>
        /// <param name="conference">会议实体类的实例化对象</param>
        /// <returns>：true：修改成功；false：修改失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool UpdateConference(ConferenceModel conference)
        {
            try
            {
                ConferenceDAL ConDAL = new ConferenceDAL();
                if (conference.ConStatus == '0')
                {
                    ConDAL.UpdateARecord(conference);
                }
                else
                {
                    ConDAL.UpdateARecord(conference);

                    BoardroomDAL BdrDAL = new BoardroomDAL();
                    List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
                    BoardroomList = BdrDAL.GetAllRecord(conference.ConPlace.ToString());

                    BoardroomModel Boardroom = new BoardroomModel();

                    foreach (BoardroomModel Bdr in BoardroomList)
                    {
                        if (Bdr.BdrId == conference.ConPlace)
                        {
                            Boardroom = Bdr;
                        }
                    }

                    string Topic = string.Format("{0}会议更改通知",conference.ConName);
                    string Body = string.Format("会议名称：{0}<br />会议地点：{1}<br />主办单位：{2}<br />会议时间：{3}", conference.ConName, Boardroom.BdrName, conference.ConHost, conference.ConStartTime);
                    SendNotice(conference, Topic, Body);//查找与会人员通过邮件发布会议修改的信息
                    List<ConUseResourceModel> ConUse = new List<ConUseResourceModel>();
                    ConUseResourceDAL CURDAL = new ConUseResourceDAL();
                    Body = Body + "<br />会议资源：";

                    ConUse = CURDAL.GetUseResource(conference.ConId);

                    foreach (ConUseResourceModel CU in ConUse)
                    {
                        Body = Body + CU.DeviceId.ToString()+",";
                    }
                    SendTask(conference.ConStaffMen, Topic, Body);//发送新任务单信息给会务人员
                }
                return true;
            }
            catch
            {
                return false;
            }
        }// function UpdateConference

        /// <summary>
        /// 会议管理员对会议申请进行审核
        /// </summary>
        /// <param name="conference">会议实体类的实例化对象</param>
        /// <returns>true：审核成功；false：审核失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool VerifyConference(ConferenceModel conference)
        {
            try
            {
                ConferenceDAL ConDAL = new ConferenceDAL();
                if (conference.ConStatus == '1')
                {
                    ConDAL.UpdateARecord(conference);

                    SendTask(conference.ConSubMen, conference.ConName + "会议审核成功", "已通知各参会人员");//发送回执单信息给申请人员

                    BoardroomDAL BdrDAL = new BoardroomDAL();
                    List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
                    BoardroomList = BdrDAL.GetAllRecord(conference.ConPlace.ToString());

                    BoardroomModel Boardroom = new BoardroomModel();

                    foreach (BoardroomModel Bdr in BoardroomList)
                    {
                        if (Bdr.BdrId == conference.ConPlace)
                        {
                            Boardroom = Bdr;
                        }
                    }

                    string Topic = string.Format("{0}会议通知", conference.ConName);
                    string Body = string.Format("会议名称：{0}<br />会议地点：{1}<br />主办单位：{2}<br />会议时间：{3}", conference.ConName, Boardroom.BdrName, conference.ConHost, conference.ConStartTime);
                    SendNotice(conference, Topic, Body);//查找与会人员通过邮件发布会议修改的信息
                    List<ConUseResourceModel> ConUse = new List<ConUseResourceModel>();
                    ConUseResourceDAL CURDAL = new ConUseResourceDAL();
                    Body = Body + "<br />会议资源：";

                    ConUse = CURDAL.GetUseResource(conference.ConId);

                    foreach (ConUseResourceModel CU in ConUse)
                    {
                        Body = Body + CU.DeviceId.ToString() + ",";
                    }
                    SendTask(conference.ConStaffMen, Topic, Body);//发送新任务单信息给会务人员
                    
                }
                else
                {
                    ConDAL.UpdateARecord(conference);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }// function VerifyConference


        /// <summary>
        /// 会议管理员添加会议室
        /// </summary>
        /// <param name="boardroom">会议室实体类的实例化对象</param>
        /// <returns>true：添加成功；false：添加失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool AddBoardroom(BoardroomModel  boardroom)
        {
            try
            {
                BoardroomDAL BdrDAL = new BoardroomDAL();
                BdrDAL.AddARecord(boardroom);
                return true;
            }
            catch
            {
                return false;
            }
        }// function AddBoardroom

        /// <summary>
        /// 会议管理员删除会议室
        /// </summary>
        /// <param name="boardroom">会议室实体类的实例化对象</param>
        /// <returns>：true：删除成功；false：删除失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool DelBoardroom(BoardroomModel boardroom)
        {
            try
            {
                //判断会议结束时间>当前时间并且会议室ID=boardroom.BrdId 是否存在
                BoardroomDAL BdrDAL = new BoardroomDAL();
                if (BdrDAL.IsConExist(boardroom.BdrId))
                {
                    BdrDAL.DelARecord(boardroom);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }// function DelBoardroom


        /// <summary>
        /// 会议管理员修改会议室
        /// </summary>
        /// <param name="boardroom">会议实体类的实例化对象</param>
        /// <returns>true：修改成功；false：修改失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool UpdateBoardroom(BoardroomModel boardroom)
        {
            try
            {
                //判断会议结束时间>当前时间并且会议室ID=boardroom.BrdId 是否存在
                BoardroomDAL BdrDAL = new BoardroomDAL();
                if (BdrDAL.IsConExist(boardroom.BdrId))
                {
                    BdrDAL.UpdateARecord(boardroom);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }// function UpdateBoardroom


        /// <summary>
        /// 会议管理员添加资源
        /// </summary>
        /// <param name="resource">资源实体类的实例化对象</param>
        /// <returns>true：添加成功；false：添加失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool AddResouce(ResourceModel  resource)
        {
            try
            {
                ResourceDAL RDAL = new ResourceDAL();
                RDAL.AddARecord(resource);
                return true;
            }
            catch
            {
                return false;
            }
        }// function AddResouce


        /// <summary>
        /// 会议管理员修改资源
        /// </summary>
        /// <param name="resource">资源实体类的实例化对象</param>
        /// <returns>true：修改成功；false：修改失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool UpdateResouce(ResourceModel resource)
        {
            try
            {
                ResourceDAL RDAL = new ResourceDAL();
                RDAL.UpdateARecord(resource);
                return true;
            }
            catch
            {
                return false;
            }
        }// function UpdateResouce


        /// <summary>
        /// 会议管理员发布会议通知
        /// </summary>
        /// <param name="conference">会议实体类的实例化对象</param>
        /// <param name="topic">邮件标题</param>
        /// <param name="body">邮件正文</param>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public void SendNotice(ConferenceModel conference,string topic,string body)
        {
            InConMemberDAL ICMBDAL = new InConMemberDAL();
            OutConMemberDAL OCMBDAL = new OutConMemberDAL();

            List<EmployeeModel> Employee = new List<EmployeeModel>();
            List<OutConMemberModel> OutCon = new List<OutConMemberModel>();

            Employee = ICMBDAL.GetConRecord(conference.ConId);
            foreach (EmployeeModel Emp in Employee)
            {
                string receive =Emp.EmEmail;
                MailSendBLL.sendMail(topic, body, receive);
                Thread.Sleep(1000);
                
            }

            OutCon = OCMBDAL.GetConRecord(conference.ConId);
            foreach (OutConMemberModel Oot in OutCon)
            {
                string receive = Oot.ConEmail;
                MailSendBLL.sendMail(topic, body, receive);
                Thread.Sleep(1000);
            }

        }// function SendNotice


        /// <summary>
        /// 会议管理员下达任务单或回执
        /// </summary>
        /// <param name="UId">查询的用户ID</param>
        /// <param name="topic">邮件标题</param>
        /// <param name="body">邮件正文</param>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public void SendTask(int UId, string topic, string body)
        {
            EmployeeModel Emp = new EmployeeModel();
            EmployeeDAL EDAL = new EmployeeDAL();
            Emp = EDAL.GetARecord(UId);
            string receive = Emp.EmEmail;
            MailSendBLL.sendMail(topic, body, receive);
        }// function SendTask


        /// <summary>
        /// 获取一个员工信息
        /// </summary>
        /// <param name="id">员工ID</param>
        /// <returns>返回一个员工信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-22
        /// 修改时间:
        public EmployeeModel GetAEmployee(int id)
        {
            EmployeeModel Employee = new EmployeeModel();
            EmployeeDAL EmpDAL = new EmployeeDAL();
            Employee = EmpDAL.GetARecord(id);
            return Employee;
        } // function GetAllEmployee


        /// <summary>
        /// 获取所有资源信息
        /// </summary>
        /// <returns>一组资源信息</returns>
        /// 作者：王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间：
        public List<ResourceModel> GetAllResource()
        {
            try
            {
                List<ResourceModel> Resourcelist = new List<ResourceModel>();
                ResourceDAL RDAL = new ResourceDAL();
                Resourcelist=RDAL.GetAllRecord();
                return Resourcelist;
            }
            catch
            {
                throw new Exception();
            } // try
        }// function GetAllResource

        //// <summary>
        /// 向数据库资源表中删除一条新信息
        /// </summary>
        /// <param name="obj">要删除的资源信息</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者：吴欣哲
        /// 创建时间:2014-09-17
        /// 修改时间：
        public bool DelAResource(ResourceModel resource)
        {
            try
            {
                ResourceDAL RDAL = new ResourceDAL();
                RDAL.DelARecord(resource);
                return true;
            }
            catch
            {
                throw new Exception();
                // return false;  
            } // try
        } // function DelARecord

        /// <summary>
        /// 会议管理员向会议使用资源表添加一条记录
        /// </summary>
        /// <param name="useRsc">使用资源实体类的实例化对象</param>
        /// <returns>true：添加成功；false：添加失败</returns>
        public bool AddConUseResource(ConUseResourceModel useRsc)
        {
            try
            {
                ConUseResourceDAL CURD = new ConUseResourceDAL();
                CURD.AddARecord(useRsc);
                return true;
            }
            catch
            {
                return false;
            }
        } // function AddConUseResource


    }// class ConferenceAuditorBLL
} // namespace GS.CMS.BLL
