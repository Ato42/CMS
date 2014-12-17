/*--------------------------------------------------------------
 * 口香糖 Gum Studio
 * 
 * 文件名：MailSend.cs
 * 文件功能描述：存放类MailSend.cs
 * 
 * 创建标识：吴若彤 20140918
 * 
 * 修改标识： 
 * 修改描述：
 ---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;

namespace GS.CMS.BLL
{
    /// <summary>
    /// 邮件类
    /// </summary>
    /// 作者:吴若彤
    /// 创建时间:2014-09-18
    /// 修改时间:
    public class MailSendBLL
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="topic">标题</param>
        /// <param name="body">正文</param>
        /// <param name="receive">接受者</param>
        /// 作者:吴若彤
        /// 创建时间:2014-09-18
        /// 修改时间:
        public static void sendMail(string topic, string body, string receive)
        {
            string sendAddress = "kxthyglxt@126.com";
            string sendPassword = "kxt123";
            string receiveAddress = receive;
            string mailTopic = topic;
            string mailBody = body;
            string[] sendeUsername = sendAddress.Split('@');

            SmtpClient client = new SmtpClient("smtp.126.com");
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(sendeUsername[0].ToString(), sendPassword);

            MailMessage mmsg = new MailMessage(new MailAddress(sendAddress), new MailAddress(receiveAddress));
            mmsg.Subject = mailTopic;
            mmsg.SubjectEncoding = Encoding.UTF8;
            mmsg.Body = mailBody;
            mmsg.BodyEncoding = Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.Priority = MailPriority.Normal;
            int I = 0;
            if (InternetGetConnectedState(out I, 0))
            {
                try
                {
                    client.Send(mmsg);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("无法连接到网络！");
            }
        }// function sendMail
    }// class MailSend
} // namespace GS.CMS.DAL