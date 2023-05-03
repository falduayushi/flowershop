using System.Data.SqlClient;
using System.Data;

namespace Admin.Models
{
    public class category_model
    {
        public string category_name { get; set; }
        public string c_image { get; set; }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS1;Database=flower_management;User Id=sa;pwd=12345678");

        public int add_cat(string cat_name , string c_image)
        {

            SqlCommand cmd = new SqlCommand("insert into [dbo].[category](cat_name , c_image)values('" + cat_name + "' , '"+  c_image +"')", con);
            con.Open();

            return cmd.ExecuteNonQuery();
        }

        public DataSet get_category()
        {
            SqlCommand cmd = new SqlCommand("SELECT category.cat_name ,category.c_image, COUNT(product.p_category) AS total_data  from category left join product on category.cat_name = product.p_category group by category.cat_name , category.c_image ORDER BY  COUNT(product.p_category) ", con);
          //  SqlCommand cmd = new SqlCommand("select * from category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}
