using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLRoom
    {
        public System.Data.Linq.Table<Room> LoadRoom()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Rooms;
        }
        public bool CreateRoom (string RoomID, string RoomTypeID, string OnFloor)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.CreateRoom(RoomID, Convert.ToByte(RoomTypeID), Convert.ToInt32(OnFloor), true);
            db.Rooms.Context.SubmitChanges();
            return true;
        }
        public bool UpdateRoom(string RoomID, string RoomTypeID, string OnFloor)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.UpdateRoom(RoomID, Convert.ToByte(RoomTypeID), Convert.ToInt32(OnFloor), true);
            db.Rooms.Context.SubmitChanges();
            return true;
        }
        public bool DeleteRoom(string RoomID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.DeleteRoom(RoomID);
            db.Rooms.Context.SubmitChanges();
            return true;
        }
        public bool UndoRoom ()
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.UndoRooms();
            db.Rooms.Context.SubmitChanges();
            return true;
        }
        public bool RedoRoom()
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.RedoRooms();
            db.Rooms.Context.SubmitChanges();
            return true;
        }
    }
}
