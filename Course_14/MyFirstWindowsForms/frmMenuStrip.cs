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
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find Client");
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Client");

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Client");

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Client");

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Client");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit Client");

        }
    }
}
