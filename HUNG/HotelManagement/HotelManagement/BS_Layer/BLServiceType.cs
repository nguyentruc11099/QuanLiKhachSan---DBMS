using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HotelManagement.BS_Layer
{
    class BLServiceType
    {
        public System.Data.Linq.Table<ServiceType> LoadServiceType()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.ServiceTypes;
        }
        public bool CreateServiceType(string Name)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_CreateServiceTypes(Name);
            db.ServiceTypes.Context.SubmitChanges();
            return true;
        }
        public bool UpdateServiceType(int ServiceTypeID, string Name)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_UpdateServiceTypes(Convert.ToByte(ServiceTypeID), Name);
            db.ServiceTypes.Context.SubmitChanges();
            return true;
        }
        public bool DeleteServiceType(string ServiceTypeID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_DeleteServiceTypes(Convert.ToByte(ServiceTypeID));
            db.ServiceTypes.Context.SubmitChanges();
            return true;
        }
    }
}
