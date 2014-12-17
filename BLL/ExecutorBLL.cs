/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ExecutorBLL.cs
 * 文件功能描述：存放类ExecutorBLL.cs
 * 
 * 创建标识：王宇昊 20140919
 * 
 * 修改标识： 
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GS.CMS.DAL;
using GS.CMS.DB;
using GS.CMS.MODEL;

namespace GS.CMS.BLL
{
    /// <summary>
    /// 会务执行人
    /// </summary>
    /// 作者:王宇昊
    /// 创建时间:2014-09-19
    /// 修改时间:
    public class ExecutorBLL : UserBLL
    {

        /// <summary>
        /// 生成内部与会人员信息
        /// </summary>
        /// <param name="conference">会议的实体类</param>
        /// <returns>一组员工信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public List<EmployeeModel> GetInConMemberInfo(ConferenceModel conference)
        {
            List<EmployeeModel> list = new List<EmployeeModel>();
            InConMemberDAL ICMDAL = new InConMemberDAL();
            list = ICMDAL.GetConRecord(conference.ConId);
            return list;
        }// function GetInConMemberInfo

        /// <summary>
        /// 生成内部与会人员签到表
        /// </summary>
        /// <param name="conference">会议的实体类</param>
        /// <returns>一组内部与会人员状态</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-22
        /// 修改时间:
        public List<InConMemberModel> GetInConMemberRegisterInfo(ConferenceModel conference)
        {
            List<InConMemberModel> list = new List<InConMemberModel>();
            InConMemberDAL ICMDAL = new InConMemberDAL();
            list = ICMDAL.GetInConRecord(conference.ConId);
            return list;
        }// function GetInConMemberRegisterInfo

        /// <summary>
        /// 获取任务单
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public List<TaskModel> GetTask(EmployeeModel employee)
        {
            ConferenceDAL conDal = new ConferenceDAL();
            List<ConferenceModel> conModel = new List<ConferenceModel>();
            List<TaskModel> taskList = new List<TaskModel>();

            conModel = conDal.GetAllRecord(employee.EmId.ToString());

            foreach (ConferenceModel con in conModel)
            {
                if (con.ConStaffMen == employee.EmId)
                {
                    TaskModel task = new TaskModel();
                    task.TaskConference = con; // 获取会议信息
                    //task.TaskConName = con.ConName; //获取会议名称
                    //task.TaskConTime = con.ConStartTime;//获取会议时间

                    BoardroomDAL BdrDAL = new BoardroomDAL();
                    List<BoardroomModel> BoardroomList = new List<BoardroomModel>();
                    BoardroomList = BdrDAL.GetAllRecord(con.ConPlace.ToString());

                    BoardroomModel Boardroom = new BoardroomModel();

                    foreach (BoardroomModel Bdr in BoardroomList)
                    {
                        if (Bdr.BdrId == con.ConPlace)
                        {
                            Boardroom = Bdr;
                        }
                    }

                    task.TaskBdrName = Boardroom.BdrName;//获取会议室名称

                    BoardroomDAL boardroomDal = new BoardroomDAL();
                    BoardroomModel boardroomModel = new BoardroomModel();

                    ConUseResourceDAL conUseRscDal = new ConUseResourceDAL();
                    List<ConUseResourceModel> conUseRscList = new List<ConUseResourceModel> ();
                    task.TaskResource = new ArrayList();
                    conUseRscList = conUseRscDal.GetUseResource(con.ConId);
                    if (conUseRscList.Count != 0)
                    {
                        foreach (ConUseResourceModel conUseRsc in conUseRscList)
                        {
                            task.TaskResource.Add(conUseRsc.DeviceId);//获取资源ID列表
                        } // end foreach
                    }
                    taskList.Add(task);

                } // end if
            } // end foreach

            return taskList;
        }// function GetTask


        /// <summary>
        /// 内部与会人员签到
        /// </summary>
        /// <param name="RegisterMan"></param>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public void InConMemberRegister(InConMemberModel RegisterMan)
        {
            InConMemberDAL ICMDAL = new InConMemberDAL();
            ICMDAL.UpdateARecord(RegisterMan);
        }// function InConMemberRegister


        /// <summary>
        /// 生成外部人员签到表
        /// </summary>
        /// <param name="conference"></param>
        /// <returns></returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public List<OutConMemberModel> GetOutConMemberRegisterInfo(ConferenceModel conference)
        {
            List<OutConMemberModel> list = new List<OutConMemberModel>();
            OutConMemberDAL OCMDAL = new OutConMemberDAL();
            list = OCMDAL.GetConRecord(conference.ConId);
            return list;
        }// function GetOutConMemberRegisterInfo


        /// <summary>
        /// 外部与会人员签到
        /// </summary>
        /// <param name="RegisterMan"></param>
        /// 作者:王宇昊
        /// 创建时间:2014-09-19
        /// 修改时间:
        public void OutConMemberRegister(OutConMemberModel RegisterMan)
        {
            OutConMemberDAL OCMDAL = new OutConMemberDAL();
            OCMDAL.UpdateRegisterRecord(RegisterMan);
        }// function OutConMemberRegister
    }// class ExecutorBLL
} // namespace GS.CMS.DAL
