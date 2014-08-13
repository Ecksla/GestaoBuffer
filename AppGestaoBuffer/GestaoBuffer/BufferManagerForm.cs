using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestaoBuffer
{
    public partial class BufferManagerForm : Form
    {
        BufferManager bm;
        public BufferManagerForm()
        {
            InitializeComponent();
            bm = new BufferManager();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int pageNumber = 0;
            if(int.TryParse(this.txtPageNumber.Text, out pageNumber))
            {
                bm.LoadPage(pageNumber);
            }           
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.txtPageList.Text = this.bm.ListPages();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int pageNumber = 0;
            if(int.TryParse(this.txtPageNumber.Text, out pageNumber))
            {
                bm.ChangePage(pageNumber, this.txtPageData.Text.ToCharArray());
            }   
        }
    }
}
