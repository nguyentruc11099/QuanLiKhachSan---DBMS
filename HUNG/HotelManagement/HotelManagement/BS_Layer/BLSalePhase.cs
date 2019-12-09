using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLSalePhase
    {
        public System.Data.Linq.Table<SalePhase> LoadSalePhase()
        {
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.SalePhases;
        }
        public bool CreateSalePhase(string ServiceTypeID, string StartDate, string EndDate)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_CreateSalePhases(Convert.ToByte(ServiceTypeID), Convert.ToDateTime(StartDate), Convert.ToDateTime(EndDate));
            db.SalePhases.Context.SubmitChanges();
            return true;
        }
        public bool UpdateSalePhase(int SalePhaseID, string ServiceTypeID, string StartDate, string EndDate)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_UpdateSalePhases(SalePhaseID, Convert.ToByte(ServiceTypeID), Convert.ToDateTime(StartDate), Convert.ToDateTime(EndDate));
            db.SalePhases.Context.SubmitChanges();
            return true;
        }
        public bool DeleteSalePhase(int SalePhaseID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_DeleteSalePhases(SalePhaseID);
            db.SalePhases.Context.SubmitChanges();
            return true;
        }
    }
}
