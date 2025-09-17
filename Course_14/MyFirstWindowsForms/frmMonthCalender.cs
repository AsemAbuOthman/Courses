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
    public partial class frmMonthCalender : Form
    {
        public frmMonthCalender()
        {
            InitializeComponent();
        }

        private void btnStrat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToLongDateString());
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToLongDateString());

        }

        private void btnSelectedRange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());

        }
    }
}
