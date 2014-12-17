using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpWin
{
    /* 作者：Starts_2000
     * 日期：2009-08-01
     * 网站：http://www.csharpwin.com CS 程序员之窗。
     * 你可以免费使用或修改以下代码，但请保留版权信息。
     * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
     */

    public delegate void FileReceiveCompleteEventHandler(
        object sender,
        FileReceiveCompleteEventArgs e);

    public class FileReceiveCompleteEventArgs : EventArgs
    {
        private bool _success;

        public FileReceiveCompleteEventArgs() { }

        public FileReceiveCompleteEventArgs(bool success)
            : base()
        {
            _success = success;
        }

        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }
    }
}
