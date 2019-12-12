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
    class BLRoomType
    {
        public System.Data.Linq.Table<RoomType> LoadRoomType()
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.RoomTypes;
        }
        public bool CreateRoomType( string Name, string Price)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateRoomTypes(Name, Convert.ToDecimal(Price));
                db.RoomTypes.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateRoomType(int RoomTypeID, string Name, string Price)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateRoomTypes(Convert.ToByte(RoomTypeID), Name, Convert.ToDecimal(Price));
                db.RoomTypes.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteRoomType(string RoomTypeID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteRoomTypes(Convert.ToByte(RoomTypeID));
                db.RoomTypes.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
