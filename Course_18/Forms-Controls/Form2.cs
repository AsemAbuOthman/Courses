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
    public partial class Form2 : Form
    {

        public delegate void DataBackEnvenHandler(object sender, int PersonID);

        public event DataBackEnvenHandler DataBack;

        int _PersonID;
        public int PersonID;

        public Form2(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lblResult.Text = _PersonID.ToString();  
        }

        private void btnSendBack_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPersonID.Text, out PersonID))
            {
                DataBack?.Invoke(this, PersonID);

                this.Close();
            }
            else
            {
                MessageBox.Show("Plz try to enter a number !");

            }
        }
    }
}
