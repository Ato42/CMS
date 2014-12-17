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

    public delegate void FileReceiveEventHandler(
        object sender,
        FileReceiveEventArgs e);

    public class FileReceiveEventArgs : EventArgs
    {
        private ReceiveFileManager _receiveFileManager;
        private object _tag;

        public FileReceiveEventArgs() { }

        public FileReceiveEventArgs(
            ReceiveFileManager receiveFileManager)
            : base()
        {
            _receiveFileManager = receiveFileManager;
        }

        public ReceiveFileManager ReceiveFileManager
        {
            get { return _receiveFileManager; }
        }

        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
    }
}
