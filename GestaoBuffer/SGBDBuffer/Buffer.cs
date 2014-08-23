using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBDBuffer
{
    public class Buffer
    {
        internal Memory BufferMemory { get; private set; }

        public int ChangeIndex { get; private set; }

        public Buffer()
        {
            BufferMemory = new Memory();
            ChangeIndex = -1;
        }

        public void ChangeAlgorithm(string selected)
        {
            switch (selected.ToUpper())
            {
                case "LRU":
                    BufferMemory.ChooserPage = new LRU();
                    break;
                case "MRU":
                    BufferMemory.ChooserPage = new MRU();
                    break;
            }
        }

        #region buffer automático
        public void LoadPageInMemory()
        {
            ChangeIndex = new Random().Next(0, 19);
            BufferMemory.LoadPage(ChangeIndex);
        }


        public void ChangePageInMemory()
        {
            if (ChangeIndex == -1)
                ChangeIndex = new Random().Next(0, 19);

            BufferMemory.ChangePage(ChangeIndex, BuildNewLine());
        }

        public void ReleasePageInMemory()
        {
            if (ChangeIndex == -1)
                ChangeIndex = new Random().Next(0, 19);

            BufferMemory.ReleasePage(ChangeIndex);
        }

        public string PrintData()
        {
            var data = new StringBuilder();

            foreach (var pages in BufferMemory.ListPages())
            {
                if (pages != null)
                    data.AppendLine(pages.ToString());
            }

            return data.ToString();
        }

        private char[] BuildNewLine()
        {
            char[] c = new char[128];
            int caracterCode = new Random().Next(97, 122);

            for (int i = 0; i < c.Length; i++)
                c[i] = (char)caracterCode;

            return c;
        }
        #endregion

        #region buffer registros
        public void LoadPageInMemory(int changeIndex)
        {
            BufferMemory.LoadPage(changeIndex);
        }
        #endregion
    }
}
