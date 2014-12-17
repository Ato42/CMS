using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace CSharpWin
{
    /* 作者：Starts_2000
     * 日期：2009-07-30
     * 网站：http://www.csharpwin.com CS 程序员之窗。
     * 你可以免费使用或修改以下代码，但请保留版权信息。
     * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
     */

    public delegate void ReceiveDataEventHandler(
        object sender,
        ReceiveDataEventArgs e);

    public class ReceiveDataEventArgs : EventArgs
    {
        private byte[] _buffer;
        private IPEndPoint _remoteIP;

        public ReceiveDataEventArgs() { }

        public ReceiveDataEventArgs(byte[] buffer, IPEndPoint remoteIP)
            : base()
        {
            _buffer = buffer;
            _remoteIP = remoteIP;
        }

        public byte[] Buffer
        {
            get { return _buffer; }
            set { _buffer = value; }
        }

        public IPEndPoint RemoteIP
        {
            get { return _remoteIP; }
            set { _remoteIP = value; }
        }
    }
}
