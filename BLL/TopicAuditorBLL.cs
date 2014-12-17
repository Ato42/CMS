/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：ConferenceAuditorBLL.cs
 * 文件功能描述：存放类ConferenceAuditorBLL.cs
 * 
 * 创建标识：吴若彤 20140919
 * 
 * 修改标识： 
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GS.CMS.DAL;
using GS.CMS.MODEL;

namespace GS.CMS.BLL
{
    /// <summary>
    /// 议题审核人
    /// </summary>
    /// 作者:吴若彤
    /// 创建时间:2014-09-18
    /// 修改时间:
    public class TopicAuditorBLL
    {
        /// <summary>
        /// 查询议题
        /// </summary>
        /// <returns></returns>
        /// 作者：吴若彤
        /// 创建时间：2014-09-19
        /// 修改时间：2014-09-19
        public List<TopicModel> GetTopicInfo(string sqlItems)
        {
            try
            {
                List<TopicModel> list = new List<TopicModel>();
                TopicDAL topicdal = new TopicDAL();
                list = topicdal.GetAllRecord(sqlItems);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//function  GetTopicInfo
        /// <summary>
        /// 审核议题
        /// </summary>
        /// <param name="status"></param>
        /// <param name="topic"></param>
        /// <returns></returns>
        /// 作者：吴若彤
        /// 创建时间：2014-09-19
        /// 修改时间：2014-09-19
        public bool VerifyTopic(char status, TopicModel topic)
        {
            try
            {
                topic.TopicStatus = status;
                TopicDAL topicdal = new TopicDAL();
                topicdal.UpdateARecord(topic);
                
                EmployeeDAL ed = new EmployeeDAL ();
                EmployeeModel em = ed.GetARecord(topic.TopicApplicantId);

                MailSendBLL.sendMail("议题审核通过", "您的议题“" + topic.TopicHead + "”已经通过审核，可以申请会议。", em.EmEmail);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//function VerifyTopic

        
        /// <summary>
        /// 添加议题
        /// </summary>
        /// <param name="topic"></param>
        /// 作者：吴若彤
        /// 创建时间：2014-09-19
        /// 修改时间：2014-09-19
        public bool AddTopic(TopicModel topic)
        {
            try
            {
                TopicDAL topicdal = new TopicDAL();
                topicdal.AddARecord(topic);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//function AddTopic

        /// <summary>
        /// 修改议题
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        /// 作者：吴若彤
        /// 创建时间：2014-09-19
        /// 修改时间：2014-09-19
        public bool UpdateTopic(TopicModel topic)
        {
            try
            {
                TopicDAL topicdal = new TopicDAL();
                if (topicdal.UpdateARecord(topic))
                {
                    EmployeeDAL ed = new EmployeeDAL();
                    EmployeeModel em = ed.GetARecord(topic.TopicApplicantId);
                    MailSendBLL.sendMail("议题审核通过", "您的议题“" + topic.TopicHead + "”已经通过审核，可以申请会议。", em.EmEmail);
                    return true;
                }
                else 
                {
                    throw new Exception("议题修改失败");
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//function UpdateTopic
    }// class TopicAuditorBLL
} // namespace GS.CMS.DAL

