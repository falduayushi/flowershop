using System.Data.SqlClient;

namespace Admin.Models
{
    public class contact
    {
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }


        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS1;Database=flower_management;User Id=sa;pwd=12345678");

        public int add_contact(string name, string email, string subject, string message,int user_id)
        {
            SqlCommand cmd = new SqlCommand("insert into [dbo].[contact](name,email,subject,message,user_id)values('" + name + "','" + email + "','" + subject+ "','" + message + "','" + user_id + "')", con);
            con.Open();

            return cmd.ExecuteNonQuery();
        }

    }
}
