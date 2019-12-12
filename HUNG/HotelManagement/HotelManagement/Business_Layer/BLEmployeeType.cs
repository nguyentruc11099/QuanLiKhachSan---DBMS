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
    class BLEmployeeType
    {
        public System.Data.Linq.Table<EmployeeType> LoadEmployeeType()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.EmployeeTypes;
        }
        public bool CreateEmployeeType(string Name)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateEmployeeTypes(Name);
                db.EmployeeTypes.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateEmployeeType(int EmployeeTypeID, string Name)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateEmployeeTypes(Convert.ToByte(EmployeeTypeID), Name);
                db.EmployeeTypes.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteEmployeeType(string EmployeeTypeID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteEmployeeTypes(Convert.ToByte(EmployeeTypeID));
                db.EmployeeTypes.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
