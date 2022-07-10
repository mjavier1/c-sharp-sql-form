using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace sqlform
{
    public class businesslogic
    {
        private DataAccess _dataAccess;





        public businesslogic()
        {
            _dataAccess = new DataAccess();
        }

        public Contact saveContact(Contact contact)

        {
            if (contact.id == 0)
            {
                _dataAccess.InsertContact(contact);
            }
            else
                _dataAccess.UpdateContact(contact);
            return contact;

        }
        public  List<Contact> GetContacts(string searchtext= null)
        {
          return   _dataAccess.GetContacts(searchtext);

        }
        public void Deletecontact(int id)
        {
            _dataAccess.Deletecontact(id);


        }


    }
}
