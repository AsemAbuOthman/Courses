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
    public partial class frmMoreAboutTextBox : Form
    {
        public frmMoreAboutTextBox()
        {
            InitializeComponent();
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            textBox5.Focus();
        }
    }
}
