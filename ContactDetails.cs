using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlform
{
    public partial class ContactDetails : Form
    {
        private businesslogic _businesslogic;
        private Contact _contact;
        public ContactDetails()
        {
            InitializeComponent();
            _businesslogic = new businesslogic();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            saveContact();
            this.Close();
            ((Form1)this.Owner).populatecontacts();
        }
        public void saveContact()
        {
            //DataGridViewTextBoxCell { ColumnIndex=, RowIndex=0 }
            Contact contact = new Contact();
            contact.Firstname = txtname.Text;
            contact.Lastname = txtlast.Text;
            contact.phone = txtphone.Text;
            contact.Address = txtaddress.Text;
          contact.id = _contact != null ? _contact.id : 0;
            _businesslogic.saveContact(contact);

        }
        public void LoadContact(Contact contact)
        {
            _contact = contact;

            if (contact != null)
            {
               ClearForm();
                txtname.Text = contact.Firstname;
                txtlast.Text = contact.Lastname;
                txtphone.Text = contact.phone;
                txtaddress.Text = contact.Address;



            }
        }
        private void ClearForm()
        {

            txtname.Text = String.Empty;
            txtlast.Text = String.Empty;
            txtphone.Text = String.Empty;
            txtaddress.Text = String.Empty;
        }


        private void Carcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    

    }
}