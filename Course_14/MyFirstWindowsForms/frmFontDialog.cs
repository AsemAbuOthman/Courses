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
    public partial class frmFontDialog : Form
    {
        public frmFontDialog()
        {
            InitializeComponent();
        }

        Font myFont;
        Color myColor ;

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;

            fontDialog1.Font = textBox1.Font;

             myFont = textBox1.Font;
             myColor = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;

            }
            else 
            {
                textBox1.Font = myFont;
                textBox1.ForeColor = myColor;
            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;

        }
    }
}
