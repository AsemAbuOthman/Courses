using ContactsBuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class fmAddEditContact : Form
    {
        public enum enMode 
        {
            AddNew,
            Update
        }
        private enMode _Mode;

        int _ContactID;
        clsContact _Contact;

        public fmAddEditContact(int ContactID)
        {
            InitializeComponent();

            _ContactID = ContactID;

            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else 
            {
                _Mode = enMode.Update;
            }

        }

        private void _FillCountriesInComboBox() 
        {
            DataTable dt = clsCountry.GetAllCountry();

            foreach (DataRow row in dt.Rows) 
            {
                cmbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void LoadData() 
        {
            _FillCountriesInComboBox();
            cmbCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew) 
            {
                lblAddNewContact.Text = "Add New Contact";
                _Contact = new clsContact();
                return;
            }

            _Contact = clsContact.Find(_ContactID);

            if (_Contact == null) 
            {
                MessageBox.Show("This form will close because Contact was not Here!");
                this.Close();

                return;
            }

            lblAddNewContact.Text = "Edit Contact ID = " + _ContactID;
            txtContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName; 
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "") 
            {
                pbImage.Load(_Contact.ImagePath);
            }

            lnkRemove.Visible = (_Contact.ImagePath != "");

            cmbCountry.SelectedIndex = cmbCountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);
        }

        private void fmAddEditContact_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.Find(cmbCountry.Text).CountryID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.CountryID = CountryID;

            if (pbImage.ImageLocation != null)
            {
                _Contact.ImagePath = pbImage.ImageLocation.ToString();
            }
            else 
            {
                _Contact.ImagePath = "";
            }

            if (_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully .");
            }
            else 
            {
                MessageBox.Show("Error : Data is not Saved Successfully .");
            }

            _Mode = enMode.Update;

            lblAddNewContact.Text = "Edit Contact ID = " + _Contact.ID;
            txtContactID.Text = _ContactID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
