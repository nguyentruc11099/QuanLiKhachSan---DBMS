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
    class BLRoom
    {
        public System.Collections.Generic.List<HotelManagement.sp_LoadRoomResult> LoadRoom()
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.sp_LoadRoom().ToList();
        }
        public System.Collections.Generic.List<HotelManagement.sp_FindRoomResult> FindRoom(int RoomID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.sp_FindRoom(RoomID).ToList();
        }
        public bool CreateRoom (string RoomTypeID, string OnFloor, int Status)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateRooms(Convert.ToByte(RoomTypeID), Convert.ToInt32(OnFloor), Status);
                db.Rooms.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateRoom(int RoomID, string RoomTypeID, string OnFloor, int Status)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateRooms(RoomID, Convert.ToByte(RoomTypeID), Convert.ToInt32(OnFloor), Status);
                db.Rooms.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteRoom(int RoomID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteRooms(RoomID);
                db.Rooms.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SearchRoom(int number, string textSearch)
        {
            //HotelManagementDataContext db = new HotelManagementDataContext();
            //if (number == 1)
            //{
            //    db.SearchRoom(Convert.ToByte(textSearch), default, default);
            //}
            //if (number == 2)
            //{
            //    db.SearchRoom(default, Convert.ToInt32(textSearch), default);
            //}
            //if (number == 3)
            //{
            //    db.SearchRoom(default, default, Convert.ToInt32(textSearch));
            //}
            return true;
        }
    }
}
