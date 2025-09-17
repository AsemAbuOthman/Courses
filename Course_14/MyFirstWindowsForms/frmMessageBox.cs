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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            DialogResult wantToExit = MessageBox.Show("Are you sure you want to Exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (wantToExit == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void btnShowMessage2_Click(object sender, EventArgs e)
        {
            DialogResult wantToExit = MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        }

        private void btnShowMessage3_Click(object sender, EventArgs e)
        {
            DialogResult wantToExit = MessageBox.Show("This info will be saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnShowMessage4_Click(object sender, EventArgs e)
        {
            DialogResult wantToExit = MessageBox.Show("Error is blablabla ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            if (wantToExit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
