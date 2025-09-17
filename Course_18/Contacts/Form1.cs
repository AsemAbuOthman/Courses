using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBuisnessLayer;

namespace Contacts
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void _RefreshContactList() 
        {
            dgvAllContacts.DataSource = clsContact.GetAllContacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactList();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            fmAddEditContact frm = new fmAddEditContact(-1);

            frm.ShowDialog();

            _RefreshContactList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAddEditContact frm = new fmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshContactList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure want to delete Contact {dgvAllContacts.CurrentRow.Cells[0].Value.ToString()}") == DialogResult.OK) 
            {
                if (clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value)) 
                {
                    MessageBox.Show("Contact Deleted Successfully.");

                    _RefreshContactList();

                }
                else 
                {
                    MessageBox.Show("Contact was not deleted Successfully.");
                }
            }
        }
    }
}
