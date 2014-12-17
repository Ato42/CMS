using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpWin
{
    /* 作者：Starts_2000
     * 日期：2009-07-30
     * 网站：http://www.csharpwin.com CS 程序员之窗。
     * 你可以免费使用或修改以下代码，但请保留版权信息。
     * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
     */

    public delegate void TraFransfersFileLogEventHandler(
        object sender,
        TraFransfersFileLogEventArgs e);

    public class TraFransfersFileLogEventArgs : EventArgs
    {
        private string _messgae;

        public TraFransfersFileLogEventArgs(string message)
            : base()
        {
            _messgae = message;
        }

        public string Message
        {
            get { return _messgae; }
        }
    }
}
