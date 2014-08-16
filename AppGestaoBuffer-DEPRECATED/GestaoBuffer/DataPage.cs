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
		public DateTime LastAccess { get; set; }

		public DataPage(int page, char[] buffer)
		{
			// TODO: Complete member initialization
			Page = page;
			Buffer = buffer;
			Dirt = false;
			PinCount = 0;
			LastAccess = DateTime.Now;
		}

        public DataPage()
        {            
        }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(string.Format("Page: {0}", this.Page));
			sb.AppendLine(string.Format("Buffer: {0}", new string(this.Buffer)));
			sb.AppendLine(string.Format("Dirt: {0}", this.Dirt));
			sb.AppendLine(string.Format("PinCount: {0}", this.PinCount));

            return sb.ToString();
		}
	}
}
