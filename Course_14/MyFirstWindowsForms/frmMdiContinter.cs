using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForms
{
    public partial class frmMdiContinter : Form
    {
        public frmMdiContinter()
        {
            InitializeComponent();
        }

        private Form frm = new Form();

        private void btnMakeFormChild_Click(object sender, EventArgs e)
        {
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
