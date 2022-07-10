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
    public partial class Form1 : Form
    {
        private businesslogic _businesslogic;
        public Form1()
        {
            InitializeComponent();
            _businesslogic = new businesslogic();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            populatecontacts();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DataGridViewLinkCell cell = (DataGridViewLinkCell)data.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                ContactDetails contactDetails = new ContactDetails();
                contactDetails.LoadContact(new Contact
                {
                    id = int.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Firstname = data.Rows[e.RowIndex].Cells[1].ToString(),
                    Lastname = data.Rows[e.RowIndex].Cells[2].ToString(),
                    phone = data.Rows[e.RowIndex].Cells[3].ToString(),
                    Address = data.Rows[e.RowIndex].Cells[4].ToString(),


                });
                contactDetails.ShowDialog(this);



            }
            else if (cell.Value.ToString() == "Delete")
            {
                Deletecontact(int.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()));
                populatecontacts();
           }
             */
        }
       
        #region
        private void OpenContactDetailsDialog()
        {
            ContactDetails frm = new ContactDetails();
            frm.ShowDialog(this);
            ContactDetails contactDetails = new ContactDetails();

            contactDetails.ShowDialog(this);
        }
        #endregion

        private void btnsea_Click(object sender, EventArgs e)
        {
            populatecontacts(txtsearch.Text);
            txtsearch.Text = String.Empty;


        }

       
        public void populatecontacts(string searchtext=null)
        {
          List<Contact> contacts = _businesslogic.GetContacts(searchtext);
            data.DataSource = contacts;
        }

       
            private void  Deletecontact(int id)
            {
                _businesslogic.Deletecontact(id);
            }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           DataGridViewLinkCell cell = (DataGridViewLinkCell)data.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                ContactDetails contactDetails = new ContactDetails();
                contactDetails.LoadContact(new Contact
                {
                    id = int.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Firstname = data.Rows[e.RowIndex].Cells[1].ToString(),
                    Lastname = data.Rows[e.RowIndex].Cells[2].ToString(),
                    phone = data.Rows[e.RowIndex].Cells[3].ToString(),
                    Address = data.Rows[e.RowIndex].Cells[4].ToString(),


                });
                contactDetails.ShowDialog(this);



            }
            else if (cell.Value.ToString() == "Delete")
            {
                Deletecontact(int.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()));
                populatecontacts();
            }
        }
    }
    }
    

