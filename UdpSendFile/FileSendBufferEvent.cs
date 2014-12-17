using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpWin
{
    /* 作者：Starts_2000
     * 日期：2009-08-02
     * 网站：http://www.csharpwin.com CS 程序员之窗。
     * 你可以免费使用或修改以下代码，但请保留版权信息。
     * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
     */

    public delegate void FileSendBufferEventHandler(
        object sender,
        FileSendBufferEventArgs e);

    public class FileSendBufferEventArgs : EventArgs
    {
        private SendFileManager _sendFileManager;
        private int _size;

        public FileSendBufferEventArgs(
            SendFileManager sendFileManager,
            int size)
            : base()
        {
            _sendFileManager = sendFileManager;
            _size = size;
        }

        public SendFileManager SendFileManager
        {
            get { return _sendFileManager; }
        }

        public int Size
        {
            get { return _size; }
        }
    }
}
