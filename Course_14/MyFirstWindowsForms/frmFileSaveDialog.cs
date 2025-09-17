using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyFirstWindowsForms
{
    public partial class frmFileSaveDialog : Form
    {
        public frmFileSaveDialog()
        {
            InitializeComponent();
        }

        private void btnSaveDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "My Save Dialog";
            saveFileDialog1.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";

            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }

            
        }
    }
}
