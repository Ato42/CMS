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

    public enum Command
    {
        RequestSendFile = 0x000001,
        ResponeSendFile = 0x100001,

        RequestSendFilePack = 0x000002,
        ResponeSendFilePack = 0x100002,

        RequestCancelSendFile = 0x000003,
        ResponeCancelSendFile = 0x100003,

        RequestCancelReceiveFile = 0x000004,
        ResponeCancelReceiveFile = 0x100004,
    }
}
