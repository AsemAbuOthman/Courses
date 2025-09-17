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
    public partial class frmOpenFileDialog : Form
    {
        public frmOpenFileDialog()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Title = "My Open File Dialog";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt | All Files (*.*)|*.*";

            openFileDialog1.FilterIndex = 0;
            
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                foreach (string file in openFileDialog1.FileNames) 
                {
                
                    MessageBox.Show(openFileDialog1.FileName);

                }

            }
        }
    }
}
