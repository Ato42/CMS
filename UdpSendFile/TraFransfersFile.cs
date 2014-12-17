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

    [Serializable]
    public class TraFransfersFile
    {
        private string _md5;
        private int _index;
        private byte[] _buffer;

        public TraFransfersFile(string md5, int index, byte[] buffer)
        {
            _md5 = md5;
            _index = index;
            _buffer = buffer;
        }

        public string MD5
        {
            get { return _md5; }
            set { _md5 = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public byte[] Buffer
        {
            get { return _buffer; }
            set { _buffer = value; }
        }
    }
}
