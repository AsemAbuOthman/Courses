using BoyGirlBookPen.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoyGirlBookPen
{
    public partial class frmImages : Form
    {
        public frmImages()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBoy.Checked)
                pbImages.Image = Resources.Boy;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPen.Checked)
                pbImages.Image = Resources.Girl;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();


        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {

            if (rbBook.Checked)
                pbImages.Image = Resources.Book;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();


        }

        private void rdGirl_CheckedChanged(object sender, EventArgs e)
        {

            if (rdGirl.Checked)
                pbImages.Image = Resources.Pen;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();


        }

        private void frmImages_Load(object sender, EventArgs e)
        {
            rbBoy.Checked = false;

        }

    }
}
