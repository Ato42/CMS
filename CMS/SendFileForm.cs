using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using CSharpWin;
using System.IO;
using System.Diagnostics;
using GS.CMS.MODEL;
using GS.CMS.BLL;


namespace GS.CMS
{
    public partial class SendFileForm : Form
    {
        #region Fields

        private UdpSendFile udpSendFile;
        public EmployeeModel emp=new EmployeeModel();
        private List<int> idlist = new List<int>();
        #endregion

        #region Constructor
        
        public SendFileForm()
        {
            InitializeComponent();
            udpSendFile = new UdpSendFile("127.0.0.1",10003,10002);
            udpSendFile.FileSendBuffer +=
                new FileSendBufferEventHandler(FileSendBuffer);
            udpSendFile.FileSendAccept +=
                new FileSendEventHandler(FileSendAccept);
            udpSendFile.FileSendRefuse +=
                new FileSendEventHandler(FileSendRefuse);
            udpSendFile.FileSendCancel += new FileSendEventHandler(FileSendCancel);
            udpSendFile.FileSendComplete +=
                new FileSendEventHandler(FileSendComplete);
            udpSendFile.Start();
        }

        #endregion

        #region Control Events

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cmbCon.SelectedItem!=null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int t = ofd.FileName.LastIndexOf(".");
                        int m = ofd.FileName.LastIndexOf("\\");
                        string str = ofd.FileName.Replace(ofd.FileName.Substring(m, t - m), "\\"+idlist[this.cmbCon.SelectedIndex]);

                        if (File.Exists(ofd.FileName))
                        {
                            File.Move(ofd.FileName, str);
                            ofd.FileName = str;
                        }
                        SendFileManager sendFileManager = new SendFileManager(
                            ofd.FileName);
                        if (udpSendFile.CanSend(sendFileManager))
                        {
                            FileTransfersItem item = fileTansfersContainer.AddItem(
                                sendFileManager.MD5,
                                "发送文件",
                                sendFileManager.Name,
                                Icon.ExtractAssociatedIcon(ofd.FileName).ToBitmap(),
                                sendFileManager.Length,
                                FileTransfersItemStyle.Send);
                            item.CancelButtonClick += new EventHandler(ItemCancelButtonClick);
                            item.Tag = sendFileManager;
                            sendFileManager.Tag = item;
                            udpSendFile.SendFile(sendFileManager, item.Image);
                        }
                        else
                        {
                            MessageBox.Show("文件正在发送，不能发送重复的文件。");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("您没有作为记录人参加的会议，无法上传资料！");
            }
        }

        private void ItemCancelButtonClick(object sender, EventArgs e)
        {
            FileTransfersItem item =
                sender as FileTransfersItem;
            SendFileManager sendFileManager =
                       item.Tag as SendFileManager;
            udpSendFile.CancelSend(sendFileManager.MD5);

            fileTansfersContainer.RemoveItem(item);
        }
        #endregion

        #region SendFile Events

        private void FileSendCancel(
            object sender, FileSendEventArgs e)
        {
            FileTransfersItem item =
                e.SendFileManager.Tag as FileTransfersItem;
            if (item != null)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    fileTansfersContainer.RemoveItem(item);
                    item.Dispose();
                }));
            }
        }

        private void FileSendComplete(
            object sender, FileSendEventArgs e)
        {
            FileTransfersItem item =
                e.SendFileManager.Tag as FileTransfersItem;
            if (item != null)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    fileTansfersContainer.RemoveItem(item);
                    item.Dispose();
                }));
            }
        }

        private void FileSendRefuse(
            object sender, FileSendEventArgs e)
        {
            FileTransfersItem item =
                e.SendFileManager.Tag as FileTransfersItem;
            if (item != null)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    fileTansfersContainer.RemoveItem(item);
                    item.Dispose();
                }));
            }
        }

        private void FileSendAccept(
            object sender, FileSendEventArgs e)
        {
            FileTransfersItem item =
                e.SendFileManager.Tag as FileTransfersItem;
             if (item != null)
             {
                     item.Start();
             }
        }

        private void FileSendBuffer(
            object sender, FileSendBufferEventArgs e)
        {
            FileTransfersItem item =
                e.SendFileManager.Tag as FileTransfersItem;
            if (item != null)
            {
                BeginInvoke(new MethodInvoker(delegate()
               {
                   item.TotalTransfersSize += e.Size;
               }));
            }
        }

        #endregion

        #region Help Methods


        #endregion

        #region Override Methods

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (udpSendFile != null)
            {
                udpSendFile.Dispose();
            }
        }

        #endregion

        private void AddItem()
        {
            try
            {
                List<ConferenceModel> conList = new List<ConferenceModel>();
                UserBLL user = new UserBLL();
                conList = user.GetConferenceInfo("");
                foreach (ConferenceModel con in conList)
                {
                    if (con.ConRecordMen == emp.EmId)
                    {
                        this.cmbCon.Items.Add(con.ConName);
                        idlist.Add(con.ConId);
                    }
                }
                this.cmbCon.SelectedItem = this.cmbCon.Items[0];
            }
            catch
            { }
        }

        private void SendFileForm_Load(object sender, EventArgs e)
        {
            AddItem();
        }
    }
}