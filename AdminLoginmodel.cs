﻿using System.Data;
using System.Data.SqlClient;

namespace Admin.Models
{
    public class Loginmodel
    {
        public string email{ get; set; }
        public string password { get; set; }


        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS1;Database=Flower_management;User Id=sa;pwd=cdmi@3420");

        public DataSet Login(string email, string password)
        {
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Admin] where email='" + email + "' and password='" + password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}
