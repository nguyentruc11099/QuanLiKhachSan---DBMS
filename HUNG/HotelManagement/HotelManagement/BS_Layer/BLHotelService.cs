using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLHotelService
    {
        public System.Data.Linq.Table<HotelService> LoadHotelService()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.HotelServices;
        }
        public bool CreateHotelService(string ServiceName, string Price)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateHotelServices(ServiceName, Convert.ToDecimal(Price));
                db.HotelServices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHotelService(string ServiceID, string ServiceName, string Price)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateHotelServices(Convert.ToInt32(ServiceID), ServiceName, Convert.ToDecimal(Price));
                db.HotelServices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteHotelService(string ServiceID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteHotelServices(Convert.ToInt32(ServiceID));
                db.HotelServices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
