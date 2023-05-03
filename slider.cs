using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Flower_Management.Models
{

    public class slider
    {


        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS1;Database=Flower_management;User Id=sa;12345678");

        public DataSet get_slider()
        {
            SqlCommand cmd = new SqlCommand("select * from [dbo].[slider]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}
