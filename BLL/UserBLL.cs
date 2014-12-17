/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：UserBLL.cs
 * 文件功能描述：存放类UserBLL.cs
 * 
 * 创建标识：王宇昊 20140918
 * 
 * 修改标识：zhangheng 20140926
 * 修改描述：添加会议使用资源时修改状态标识
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GS.CMS.DAL;
using GS.CMS.DB;
using GS.CMS.MODEL;

namespace GS.CMS.BLL
{
    /// <summary>
    /// 用户类
    /// </summary>
    /// 作者:王宇昊
    /// 创建时间:2014-09-18
    /// 修改时间:
    public  class UserBLL
    {
        protected  EmployeeModel user;// 员工类


        /// <summary>
        /// 员工类保存员工信息
        /// </summary>
        public EmployeeModel User
        {
            get { return user; }
            set { user = value; }
        }


        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="userPwd">用户密码</param>
        /// <returns>返回用户类</returns>
        //  作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public EmployeeModel LoginIn(string userId, string userPwd)
        {
            EmployeeModel Employee = new EmployeeModel();
            GS.CMS.DAL.EmployeeDAL Emp = new GS.CMS.DAL.EmployeeDAL();
            Employee = Emp.IsExist(userId,userPwd);
            return Employee; 
        } // function LoginIn

        /// <summary>
        /// 查询所有会议
        /// </summary>
        /// <param name="sqlItems">查询的内容</param>
        /// <returns>一组会议信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public List<ConferenceModel> GetConferenceInfo(string sqlItems)
        {
            List<ConferenceModel> ConM = new List<ConferenceModel>();
            ConferenceDAL ConDAL = new ConferenceDAL();
            ConM = ConDAL.GetAllRecord(sqlItems);
            return ConM;
        }// function GetConferenceInfo

        /// <summary>
        /// 查看会议室
        /// </summary>
        /// <param name="sqlItems">查询会议信息</param>
        /// <returns>一组会议室信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public List<BoardroomModel> GetBoardroomInfo(string sqlItems)
        {
            List<BoardroomModel> LBM = new List<BoardroomModel>();
            BoardroomDAL LBMDAL = new BoardroomDAL();
            LBM = LBMDAL.GetAllRecord(sqlItems);
            return LBM;
        }// function GetBoardroomInfo

        /// <summary>
        /// 申请会议
        /// </summary>
        /// <param name="conferenceInfo">会议信息</param>
        /// <param name="resource">资源设备编号信息</param>
        /// <returns>是否成功申请</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        /// 
        ///

        public int ConApply(ConferenceModel conferenceInfo,List<string> resource)
        {
            try
            {
                ConferenceDAL ConDAL = new ConferenceDAL();
                ConUseResourceDAL CURDAL = new ConUseResourceDAL();
                ConUseResourceModel CURM = new ConUseResourceModel();
                //
                ResourceDAL RDAL = new ResourceDAL();
                ResourceModel RMODEL = new ResourceModel();

                int CId = ConDAL.AddARecordReturnId(conferenceInfo);//返回会议的ID
                if (CId != -1)
                {
                    foreach (string DeviceId in resource)
                    {
                        CURM.ConId = CId;
                        CURM.DeviceId = Convert.ToInt32(DeviceId);
                        CURDAL.AddARecord(CURM);

                        // 将资源表中的状态标志改为1，被预订
                        RMODEL.ResourceId = Convert.ToInt32(DeviceId);
                        RMODEL.ResourceStatus = '1';
                        RDAL.UpdateAStatus(RMODEL);
                    }
                    return CId;
                }
                else
                {
                    return -1;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }// function ConApply

        /// <summary>
        /// 对已提交申请但未审核的会议进行删除
        /// </summary>
        /// <param name="conference">会议表实体类</param>
        /// <returns>true：申请提交成功；false：申请提交失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool DelCon(ConferenceModel conference)
        {
            try
            {
                ConferenceDAL ConDAL = new ConferenceDAL();
                if (conference.ConStatus == '0')
                {
                    ConDAL.DelARecord(conference);
                    return true;
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
        }// function DelCon

        /// <summary>
        /// 对已提交申请但未审核的会议进行更改
        /// </summary>
        /// <param name="conference">会议表实体类</param>
        /// <returns>true：申请提交成功；false：申请提交失败</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool UpdateCon(ConferenceModel conference)
        {
            try
            {
                ConferenceDAL ConDAL = new ConferenceDAL();
                if (conference.ConStatus == '0')
                {
                    ConDAL.UpdateARecord(conference);
                    return true;
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
        }// function UpdateCon

        /// <summary>
        /// 申请议题
        /// </summary>
        /// <param name="topic">议题实体类</param>
        /// <returns>操作成功返回true，失败返回false</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-18
        /// 修改时间:
        public bool TopicApply(TopicModel topic)
        {
            try
            {
                TopicDAL TDAL = new TopicDAL();
                TDAL.AddARecord(topic);
                return true;
            }
            catch
            {
                return false;
            }
        }// function TopicApply

        

        /// <summary>
        /// 判断选择时间内是否有会议
        /// </summary>
        /// <param name="boardroom">会议室实体类</param>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns>有会议返回true，无会议返回false</returns>
        public bool IsExistCon(BoardroomModel boardroom,DateTime start,DateTime end)
        {
            try
            {
                //判断会议结束时间>当前时间并且会议室ID=boardroom.BrdId 是否存在
                BoardroomDAL BdrDAL = new BoardroomDAL();
                if (BdrDAL.IsConExist(boardroom.BdrId, start, end))
                {
                    return true;
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
        }//function  IsExistCon

        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <returns>返回所有员工信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间:
        public List<EmployeeModel> GetAllEmployee()
        {
            List<EmployeeModel> Employeelist = new List<EmployeeModel>();
            EmployeeDAL EmpDAL = new EmployeeDAL();
            Employeelist = EmpDAL.GetAllRecord();
            return Employeelist;
        } // function GetAllEmployee

        /// <summary>
        /// 获取指定员工的信息
        /// </summary>
        /// <param name="userId">员工ID</param>
        /// <returns>员工实体类对象</returns>
        public EmployeeModel GetEmInfo(int userId)
        {
            EmployeeModel emModel = new EmployeeModel();
            EmployeeDAL emDal = new EmployeeDAL();
            emModel = emDal.GetARecord(userId);

            return emModel;
        }

        /// <summary>
        /// 获取所有部门信息
        /// </summary>
        /// <returns>返回所有部门信息</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间:
        public List<EmployeeModel> GetAllDepart()
        {
            List<EmployeeModel> Employeelist = new List<EmployeeModel>();
            EmployeeDAL EmpDAL = new EmployeeDAL();
            Employeelist = EmpDAL.GetAllDepart();
            return Employeelist;
        } // function GetAllEmployee

        /// <summary>
        /// 查询用户申请的通过议题
        /// </summary>
        /// <returns>一组议题信息</returns>
        /// 作者：王宇昊
        /// 创建时间：2014-09-20
        /// 修改时间：
        public List<TopicModel> GetUserTopic(EmployeeModel employee)
        {
            try
            {
                List<TopicModel> list = new List<TopicModel>();
                List<TopicModel> topiclist = new List<TopicModel>();
                TopicModel topic = new TopicModel();
                TopicDAL topicdal = new TopicDAL();
                list = topicdal.GetAllRecord(employee.EmId.ToString());
                foreach (TopicModel TM in list)
                {
                    if (TM.TopicApplicantId == employee.EmId && TM.TopicStatus == '1')
                    {
                        topic = TM;
                        topiclist.Add(TM);
                    }

                }
                return topiclist;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//function  GetUserTopic

        /// <summary>
        /// 查询与用户有关的会议信息
        /// </summary>
        /// <returns>会议列表</returns>
        /// 作者：张衡
        /// 创建时间：2014-09-20
        /// 修改时间：
        public List<ConferenceModel> GetUserConference(EmployeeModel employee)
        {
            List<ConferenceModel> list = new List<ConferenceModel>();

            InConMemberDAL inConMember = new InConMemberDAL();

            list = inConMember.GetConferenceByUserId(employee);

            return list;

        } // function  GetUserTopic

        /// <summary>
        /// 添加外部与会人员
        /// </summary>
        /// <returns> 添加外部与会人员</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间:
        public void AddConMenRecord(OutConMemberModel outConMen)
        {
            try
            {
                OutConMemberDAL OCMDAL = new OutConMemberDAL();
                OCMDAL.AddARecord(outConMen);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // function AddConMenRecord

        /// <summary>
        /// 添加内部与会人员
        /// </summary>
        /// <returns> 添加内部与会人员</returns>
        /// 作者:王宇昊
        /// 创建时间:2014-09-20
        /// 修改时间:
        public void AddConMenRecord(InConMemberModel inConMen)
        {
            try
            {
                InConMemberDAL ICMDAL = new InConMemberDAL();
                ICMDAL.AddARecord(inConMen);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // function AddConMenRecord

        /// <summary>
        /// 获取指定时段内可以使用的资源
        /// </summary>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns>可用资源列表</returns>
        /// 作者:张衡
        /// 创建时间:2014-09-20
        /// 修改时间:
        public List<ResourceModel> GetCanUseResource(DateTime startTime, DateTime endTime)
        {
            List<ResourceModel> rscList = new List<ResourceModel>();
            ResourceDAL rscDal = new ResourceDAL();

            rscList = rscDal.GetCanUseRecord(startTime, endTime);

            return rscList;

        } // function GetCanUseResource

        /// <summary>
        /// 向数据库会议资源表中查询与某一会议相关资源的信息
        /// </summary>
        /// <param name="conId">会议id</param>
        /// <returns>一组资源信息</returns>
        /// 作者：王宇昊
        /// 创建时间:2014-09-22
        /// 修改时间：
        public List<ResourceModel> GetConUseResourceInfo(int conId)
        {
            try
            {
                ConUseResourceDAL CUR = new ConUseResourceDAL();
                ResourceDAL R = new ResourceDAL();
                List<ConUseResourceModel> UseResourceList = new List<ConUseResourceModel>();
                List<ResourceModel> ResourceList = new List<ResourceModel>();
                List<ResourceModel> ResourceReList = new List<ResourceModel>();//要返回的列表
                UseResourceList = CUR.GetUseResource(conId);
                foreach (ConUseResourceModel conuse in UseResourceList)
                {

                    ResourceList = R.GetAllRecord();
                    foreach (ResourceModel RM in ResourceList)
                    {
                        if (conuse.DeviceId == RM.ResourceId)
                        {
                            ResourceReList.Add(RM);
                        }
                    }    
                }
                return ResourceReList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            } // try
        }// function GetConUseResource
    }// class UserBLL
} // namespace GS.CMS.DAL
