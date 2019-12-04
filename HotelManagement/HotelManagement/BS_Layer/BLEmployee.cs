using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLEmployee
    {
        public System.Data.Linq.Table<Employee> LoadEmployee()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Employees;
        }
        public bool CreateEmployee(string EmployeeID, string EmployeeName, string EmployeeTypeID, string PhoneNumber, string IdentityCard, string PassWord)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.CreateEmployee(EmployeeID, EmployeeName, Convert.ToByte(EmployeeTypeID), Convert.ToInt32(PhoneNumber), Convert.ToInt32(IdentityCard), PassWord, true);
            db.Employees.Context.SubmitChanges();
            return true;
        }
        public bool UpdateEmployee(string EmployeeID, string EmployeeName, string EmployeeTypeID, string PhoneNumber, string IdentityCard, string PassWord)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.UpdateEmployee(EmployeeID, EmployeeName, Convert.ToByte(EmployeeTypeID), Convert.ToInt32(PhoneNumber), Convert.ToInt32(IdentityCard), PassWord, true);
            db.Employees.Context.SubmitChanges();
            return true;
        }
        public bool DeleteEmployee(string EmployeeID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.DeleteEmployee(EmployeeID);
            db.Employees.Context.SubmitChanges();
            return true;
        }
    }
}
