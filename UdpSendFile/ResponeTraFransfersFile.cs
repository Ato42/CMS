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
    public class ResponeTraFransfersFile
    {
        private string _md5;
        private int _size;
        private int _index;

        public ResponeTraFransfersFile() { }

        public ResponeTraFransfersFile(string md5, int size, int index)
        {
            _md5 = md5;
            _size = size;
            _index = index;
        }

        public string MD5
        {
            get { return _md5; }
            set { _md5 = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
    }
}
