using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.DBL
{
   static  class DBL
    {
        static public SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=User_RoleDB;Integrated Security=True");
        static public DataTable ExcuteQuery(string select_cmd)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(select_cmd, sqlConnection); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        static public int ExcuteNonQuery(string statement)
        {
            int result;
            SqlCommand cmd = new SqlCommand(statement, sqlConnection);
            sqlConnection.Open();
            result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        static public object ExcuteScaler(string statement)
        {
            object result;
            SqlCommand cmd = new SqlCommand(statement, sqlConnection);
            sqlConnection.Open();
            result = cmd.ExecuteScalar();
            sqlConnection.Close();
            return result;
        }
    }
}
