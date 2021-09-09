using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKT1_MaiNguyenXuanKieu_1954052044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai10 bt10 = new Bai10();
            bt10.MdiParent = this;
            bt10.Show();
        }

        private void bai13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai13 bt13 = new Bai13();
            bt13.MdiParent = this;
            bt13.Show();
        }
    }
}
