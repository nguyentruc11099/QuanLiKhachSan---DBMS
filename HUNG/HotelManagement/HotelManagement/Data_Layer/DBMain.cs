using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data_Layer
{
    class DBMain
    {
        string ConStr = "Data Source=(local); Initial Catalog=HotelDB;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandType = ct;
            comm.CommandText = strSQL;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQUery(string strSQL, CommandType ct)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandType = ct;
            comm.CommandText = strSQL;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch
            {
                f = false;
            }
            finally
            {
                conn.Close();
            }
            return f;

        }
    }
}
