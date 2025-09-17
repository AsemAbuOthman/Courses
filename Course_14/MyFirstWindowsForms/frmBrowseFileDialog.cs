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
    public partial class frmBrowseFileDialog : Form
    {
        public frmBrowseFileDialog()
        {
            InitializeComponent();
        }

        private void btnBrowseFolderDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
