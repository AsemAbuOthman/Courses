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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDateTime.Text = dtpDate.Value.ToLongDateString() + Environment.NewLine;
            lblDateTime.Text += dtpDate.Value.ToShortDateString() + Environment.NewLine;
            lblDateTime.Text += dtpDate.Value.ToLongTimeString() + Environment.NewLine;
            lblDateTime.Text += dtpDate.Value.ToShortTimeString() + Environment.NewLine;
            lblDateTime.Text += dtpDate.Value.ToLocalTime() + Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpDate.Value.ToLongDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpDate.Value.ToShortDateString());

        }
    }
}
