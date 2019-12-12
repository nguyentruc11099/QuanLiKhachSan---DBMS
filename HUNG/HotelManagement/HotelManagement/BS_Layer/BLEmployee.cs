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
        public int? Login(int Account, string Password, int Type)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.sp_LoginEmployee(Account, Password, Convert.ToByte(Type)).ElementAt(0).Column1;
        }
        public System.Collections.Generic.List<HotelManagement.sp_FindEmployeeResult> FindEmployee(int? ID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.sp_FindEmployee(ID).ToList();
        }
        public System.Data.Linq.Table<Employee> LoadEmployee()
        {
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Employees;
        }
        public bool CreateEmployee(string EmployeeName, string EmployeeTypeID, string PhoneNumber, string IdentityCard, string PassWord)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateEmployees(EmployeeName, Convert.ToByte(EmployeeTypeID), PhoneNumber, IdentityCard, PassWord);
                db.Employees.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateEmployee(int EmployeeID, string EmployeeName, string EmployeeTypeID, string PhoneNumber, string IdentityCard, string PassWord)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateEmployees(EmployeeID, EmployeeName, Convert.ToByte(EmployeeTypeID), PhoneNumber, IdentityCard, PassWord);
                db.Employees.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteEmployee(int EmployeeID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteEmployees(EmployeeID);
                db.Employees.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
