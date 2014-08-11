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
    public partial class Form1 : Form
    {
		BufferManager bm;
        public Form1()
        {
            InitializeComponent();
			bm = new BufferManager();
        }

		private void btnLoad_Click(object sender, EventArgs e)
		{

		}
    }
}
