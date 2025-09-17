using MyFirstWindowsForms.Properties;
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
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnLightOff_Click(object sender, EventArgs e)
        {
            pbLight.Image = Resources.lightOff;
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            pbLight.Image = Image.FromFile(@"C:\Users\asimw\OneDrive\Desktop\Courses\Course_14 in progress\MyFirstWindowsForms\light.png");
        }

        private void btnLightOn_Click(object sender, EventArgs e)
        {
            pbLight.Image = Resources.lightOn;

        }
    }
}
