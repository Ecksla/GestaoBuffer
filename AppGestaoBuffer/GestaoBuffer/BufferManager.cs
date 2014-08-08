using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GestaoBuffer
{
    class BufferManager
    {
        private int pageLength = 128;
        private int bufferLength = 10;
        private string discPath = @"c:\temp\dbFile.txt";
        private IList<DataPage> buffer;

        public BufferManager()
        {
            this.buffer = new List<DataPage>(this.bufferLength);
        }

        // TODO: Popular arquivo se o mesmo não existir
        private FileStream OpenDbFile()
        {
            return File.Open(this.discPath, FileMode.OpenOrCreate);
        }

        internal void LoadPage(int page)
        {
            char[] buffer = new char[pageLength];

            var dbFile = new StreamReader(this.OpenDbFile());
            dbFile.ReadBlock(buffer, this.pageLength * (page - 1), this.pageLength);

            var dataPage = new DataPage(page, buffer);

        }

        internal void SavePage(int page, DataPage dataPage)
        {
            var dbFile = new StreamWriter(this.OpenDbFile());
            dbFile.Write(dataPage.Buffer, this.pageLength * (page - 1), this.pageLength);
        }


        internal void ChangePage(int page, DataPage dataPage)
        {
            buffer[page - 1].Buffer = dataPage.Buffer;
        }

        internal void ListPages()
        {
            
        }
    }
}
