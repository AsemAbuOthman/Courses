using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Controls
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        public int PersonID = -1;

        private void btnSendDataToForm2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPersonID.Text, out PersonID))
            {
                Form2 frm = new Form2(PersonID);

                frm.DataBack += Form2_DataBack; // Subscribe

                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Plz try to enter a number !");
                
            }
        }

        private void Form2_DataBack(object sender, int PersonID) 
        {
            txtPersonID.Text = PersonID.ToString();
        }
    }
}
