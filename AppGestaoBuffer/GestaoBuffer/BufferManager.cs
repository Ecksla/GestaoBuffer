using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

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
			// Check whether already exists
			if (!this.PageInBuffer(page))
			{
				DataPage slotPage = null;

				// is there space to load a page?
				if (!this.buffer.Any(x => x == null))
				{
					// Choose a page to kick out
					slotPage = this.ChoosePage(GestaoBuffer.Enum.ReplacementPolicyEnum.LRU);
										
					if(slotPage.Dirt)
					{
						// flush page to hard disc
						this.SavePage(page, slotPage);
					}
				}
				else
				{
					// Pick a free page
					slotPage = this.GetFreeSlot();
				}	

				this.Read(page, slotPage);
			}
		}

		internal void SavePage(int page, DataPage dataPage)
		{
			var dbFile = new StreamWriter(this.OpenDbFile());
			dbFile.Write(dataPage.Buffer, this.pageLength * (page - 1), this.pageLength);
		}


		internal void ChangePage(int page, char[] data)
		{
			buffer[page - 1].Buffer = data;
			buffer[page - 1].Dirt = true;
		}

		internal void ListPages()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var page in this.buffer)
			{
				sb.AppendLine("----------------------------------------------------------------------");
				sb.AppendLine(page.ToString());
				sb.AppendLine("----------------------------------------------------------------------");
			}

			MessageBox.Show(sb.ToString());
		}

		private bool PageInBuffer(int page)
		{
			return this.buffer.Any(x => x.Page == page);
		}

		private DataPage ChoosePage(GestaoBuffer.Enum.ReplacementPolicyEnum ra)
		{
			DataPage chosenPage;

			switch (ra)
			{
				case GestaoBuffer.Enum.ReplacementPolicyEnum.LRU:
					chosenPage = this.buffer.Where(x => x.PinCount == 0).OrderBy(x => x.LastAccess).First();
					break;
				case GestaoBuffer.Enum.ReplacementPolicyEnum.MRU:
					chosenPage = this.buffer.Where(x => x.PinCount == 0).OrderByDescending(x => x.LastAccess).First();
					break;
				default:
					chosenPage = this.buffer.Where(x => x.PinCount == 0).OrderBy(x => x.LastAccess).First();
					break;
			}
			return chosenPage;
		}

		private DataPage GetFreeSlot()
		{
			return this.buffer.First(); 
		}

		private void Read(int page, DataPage memoryPage)
		{
			char[] buffer = new char[pageLength];

			var dbFile = new StreamReader(this.OpenDbFile());
			dbFile.ReadBlock(buffer, this.pageLength * (page - 1), this.pageLength);

			memoryPage.Page = page;
			memoryPage.Buffer = buffer;
			memoryPage.PinCount++;
			memoryPage.LastAccess = DateTime.Now;
		}
	}
}






















