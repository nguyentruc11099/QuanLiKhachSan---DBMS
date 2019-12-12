using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelManagement.Data_Layer;

namespace HotelManagement.BS_Layer
{
    class BLCustomer
    {
        public System.Data.Linq.Table<Customer> LoadCustomer()
        {
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Customers;
        }
        public void SearchCutomer(string CustomerName, string IdentityCard)
        {
            DBMain db = new DBMain();
            string sql = "Exec sp_SearchCustomers";
            db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool CreateCustomer(string CustomerName, string IdentityCard, string PhoneNumber, string CustomerAddress)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateCustomers(CustomerName, IdentityCard, PhoneNumber, CustomerAddress);
                db.Customers.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(string CustomerID, string CustomerName, string IdentityCard, string PhoneNumber, string CustomerAddress)
        {           
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateCustomers(Convert.ToInt32(CustomerID), CustomerName, IdentityCard, PhoneNumber, CustomerAddress);
                db.Customers.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(string CustomerID)
        {         
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteCustomers(Convert.ToInt32(CustomerID));
                db.Customers.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
