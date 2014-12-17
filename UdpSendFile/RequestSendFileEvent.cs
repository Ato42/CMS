using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Net;

namespace CSharpWin
{
    /* 作者：Starts_2000
     * 日期：2009-07-30
     * 网站：http://www.csharpwin.com CS 程序员之窗。
     * 你可以免费使用或修改以下代码，但请保留版权信息。
     * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
     */

    public delegate void RequestSendFileEventHandler(
        object sender,
        RequestSendFileEventArgs e);

    public class RequestSendFileEventArgs : CancelEventArgs
    {
        private TraFransfersFileStart _traFransfersFileStart;
        private IPEndPoint _remoteIP;
        private string _path;

        public RequestSendFileEventArgs()
            : base()
        {
        }

        public RequestSendFileEventArgs(
            TraFransfersFileStart traFransfersFileStart,
            IPEndPoint remoteIP)
            : base()
        {
            _traFransfersFileStart = traFransfersFileStart;
            _remoteIP = remoteIP;
        }

        public RequestSendFileEventArgs(
            TraFransfersFileStart traFransfersFileStart,
            IPEndPoint remoteIP,
            bool cancel)
            : base(cancel)
        {
            _traFransfersFileStart = traFransfersFileStart;
            _remoteIP = remoteIP;
        }

        public IPEndPoint RemoteIP
        {
            get { return _remoteIP; }
            set { _remoteIP = value; }
        }

        public TraFransfersFileStart TraFransfersFileStart
        {
            get { return _traFransfersFileStart; }
            set { _traFransfersFileStart = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
    }
}
