using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBDBuffer
{
    internal class Page
    {
        public char[] Data { get; set; }
        public bool Dirt { get; set; }
        public int PinCount { get; set; }
        public int PageNumber { get; set; }
        public DateTime LastAccess { get; set; }

        public override string ToString()
        {
            return string.Format("Page: {0}, Pin-Count: {1}, Dirt: {2}", PageNumber, PinCount, Dirt);
        }
    }
}
