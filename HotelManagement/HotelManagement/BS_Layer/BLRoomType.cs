using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HotelManagement.BS_Layer
{
    class BLRoomType
    {
        public System.Data.Linq.Table<RoomType> LoadRoomType()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.RoomTypes;
        }
        public bool CreateRoomType( string Name, string Price)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.CreateRoomType(Name, Convert.ToDecimal(Price), true);
            db.RoomTypes.Context.SubmitChanges();
            return true;
        }
        public bool UpdateRoomType(string RoomTypeID, string Name, string Price)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.UpdateRoomType(Convert.ToInt32(RoomTypeID), Name, Convert.ToDecimal(Price), true); 
            db.RoomTypes.Context.SubmitChanges();
            return true;
        }
        public bool DeleteRoomType(string RoomTypeID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.DeleteRoomType(Convert.ToInt32(RoomTypeID));
            db.RoomTypes.Context.SubmitChanges();
            return true;
        }
    }
}
