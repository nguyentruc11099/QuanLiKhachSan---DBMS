using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLBooking
    {
        public System.Data.Linq.Table<Booking> LoadBooking()
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.Bookings;
        }
        public System.Collections.Generic.List<fn_FindBookingResult> FindBooking(int roomid)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.fn_FindBooking(roomid).ToList();
        }
        public bool CreateBooking(string CustomerID, string RoomID, string AppointmentDate)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_Booking(Convert.ToInt32(CustomerID), Convert.ToByte(RoomID), Convert.ToDateTime(AppointmentDate));
                db.Bookings.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateBooking(string BookingID, string CustomerID, string RoomID, string AppointmentDate)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateBooking(Convert.ToInt32(BookingID), Convert.ToInt32(CustomerID), Convert.ToByte(RoomID), Convert.ToDateTime(AppointmentDate));
                db.Bookings.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteBooking(string BookingID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteBooking(Convert.ToInt32(BookingID));
                db.Bookings.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
