using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoBuffer
{
    public class DataPage
    {
        public int Page { get; set; }
        public char[] Buffer { get; set; }
        public bool Dirt { get; set; }
        public int PinCount { get; set; }
        public DateTime LastAccess { get; private set; }

        public DataPage(int page, char[] buffer)
        {
            // TODO: Complete member initialization
            Page = page;
            Buffer = buffer;
            Dirt = false;
            PinCount = 0;
            LastAccess = DateTime.Now;
        }
    }
}
