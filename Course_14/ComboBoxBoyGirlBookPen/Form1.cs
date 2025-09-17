using ComboBoxBoyGirlBookPen.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxBoyGirlBookPen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOptions.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Resources.Boy;
                    break;

                case 1:
                    pictureBox1.Image = Resources.Girl;
                    break;

                case 2:
                    pictureBox1.Image = Resources.Book;
                    break;

                case 3:
                    pictureBox1.Image = Resources.Pen;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOptions.SelectedIndex = 0;
        }
    }
}
