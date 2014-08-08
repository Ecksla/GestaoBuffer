    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoBuffer
{
    class DataPage
    {
        public int Page { get; set; }
        public char[] Buffer { get; set; }

        public DataPage(int page, char[] buffer)
        {
            // TODO: Complete member initialization
            this.Page = page;
            this.Buffer = buffer;
        }
    }
}
