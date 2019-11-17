using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan.DB_layer
{
    class DBMain
    {
        string ConStr = "Data Source=(local); Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        SqlDataReader dd = null;
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
            catch (SqlException ex)
            {
                f = false;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public bool TestLogin(string strSQl, CommandType ct)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandType = ct;
            comm.CommandText = strSQl;
            dd = comm.ExecuteReader();
            if (dd.Read() == true)
            {
                f = true;
            }
            conn.Close();
            return f;
        }
    }
}
