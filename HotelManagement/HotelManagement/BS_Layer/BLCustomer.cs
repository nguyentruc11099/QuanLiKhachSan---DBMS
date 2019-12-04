using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HotelManagement.BS_Layer
{
    class BLCustomer
    {
        public System.Data.Linq.Table<Customer> LoadCustomer()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Customers;
        }
        public bool CreateCustomer(string CustomerID, string CustomerName, string IdentityCard, string PhoneNumber, string CustomerAddress)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.CreateCustomer(Convert.ToInt32(CustomerID), CustomerName, Convert.ToInt32(IdentityCard), PhoneNumber, CustomerAddress, true);
            db.Customers.Context.SubmitChanges();
            return true;
        }
        public bool UpdateCustomer(string CustomerID, string CustomerName, string IdentityCard, string PhoneNumber, string CustomerAddress)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.UpdateCustomer(Convert.ToInt32(CustomerID), CustomerName, Convert.ToInt32(IdentityCard), PhoneNumber, CustomerAddress, true);
            db.Customers.Context.SubmitChanges();
            return true;
        }
        public bool DeleteCustomer(string CustomerID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.DeleteCustomer(Convert.ToInt32(CustomerID));
            db.Customers.Context.SubmitChanges();
            return true;
        }
    }
}
