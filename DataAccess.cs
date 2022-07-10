using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlform
{
    public class DataAccess
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=winform;Data Source=MJDEVELOP\\SQLEXPRESS");
        public void InsertContact(Contact contact)
        {
            try
            {

                conn.Open();
                String query = @"
INSERT INTO Contacts (Firstname ,Lastname ,phone, Address) values 
(@Firstname,@Lastname,@phone,@Address)
                ";
                SqlParameter firstname = new SqlParameter();
                firstname.ParameterName = "@Firstname";
                firstname.Value = contact.Firstname;
                firstname.DbType = System.Data.DbType.String;
                SqlParameter lastname = new SqlParameter("@Lastname", contact.Lastname);
                SqlParameter phone = new SqlParameter("@phone", contact.phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstname);
                command.Parameters.Add(lastname);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

                command.ExecuteNonQuery();









            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateContact(Contact contact)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE Contacts SET (Firstname = @Firstname,Lastname=@Lastname,phone=@phone, Address=@Address)  
WHERE id=@id

)";             SqlParameter id = new SqlParameter("@id", contact.id);
                SqlParameter Firstname  = new SqlParameter("@Firstname", contact.Firstname);
                SqlParameter lastname = new SqlParameter("@Lastname", contact.Lastname);
                SqlParameter phone = new SqlParameter("@phone", contact.phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(id);
                command.Parameters.Add(Firstname);
                command.Parameters.Add(lastname);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        finally { conn.Close(); }

        
        }

        public void Deletecontact(int id)
        {
            try
            {
                conn.Open();
                String query = @"DELETE FROM Contacts WHERE id=@id";
                SqlCommand command = new  SqlCommand(query,conn);
                command.Parameters.Add(new SqlParameter("@id",id));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Contact> GetContacts(string search = null)
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                conn.Open();
                string query = @"SELECT id,Firstname,Lastname,phone,Address FROM Contacts";
                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(search))
                {
                    query += @"WHERE Firstname LIKE @Search OR  Lastname LIKE @Search OR phone LIKE @Search OR  Address LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));


                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    contacts.Add(new Contact
                    {
                        id= int.Parse(reader["id"].ToString()),
                        Firstname = reader["Firstname"].ToString(),
                        Lastname = reader["Lastname"].ToString(),
                        phone = reader["phone"].ToString(),
                        Address = reader["Address"].ToString()


                    });

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            return contacts;
        }
    }
}