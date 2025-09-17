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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text.ToString()) || string.IsNullOrEmpty(txtName.Text.ToString())) 
            {
                return;
            }

            ListViewItem item = new ListViewItem(txtID.Text.ToString().Trim());


            if (rbFemale.Checked)
            {
                item.ImageIndex = 0;

                //item.

            }
            else 
            {
                item.ImageIndex = 1;

                

            }

            item.SubItems.Add(txtName.Text.ToString());
            
            listView1.Items.Add(item);

            txtID.Focus();

        }

        private void frmListView_Load(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else 
            {
                MessageBox.Show("Plz select item(s) to remove");
            }
        }

        private void btnFillRandomly_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++) 
            {

                ListViewItem item = new ListViewItem(i.ToString());

                if (i%2 == 0)
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }

                item.SubItems.Add("Pesron " + i.ToString());

                listView1.Items.Add(item);

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }
    }
}
