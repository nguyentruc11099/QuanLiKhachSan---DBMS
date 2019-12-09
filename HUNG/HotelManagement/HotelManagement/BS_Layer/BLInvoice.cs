using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLInvoice
    {
        public System.Data.Linq.Table<Invoice> LoadInvoice()
        {
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Invoices;
        }
        public System.Collections.Generic.List<sp_FindInvoiceRoomPriceResult> LoadCheckoutInvoiceRoomPrice(int RoomID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.sp_FindInvoiceRoomPrice(RoomID).ToList();
        }
        public bool Checkin(string CustomerID, string RoomID,string EmployeeID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CheckIn(Convert.ToInt32(CustomerID), Convert.ToInt32(RoomID),Convert.ToInt32(EmployeeID));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public decimal? CalInvoiceRoomPrice(int RoomID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.fn_RoomPrice(RoomID);
        }
        public decimal? CalInvoiceServicePrice(int RoomID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            return db.fn_ServicePrice(RoomID);
        }
        public bool Checkout(int RoomID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CheckOut(RoomID);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateInvoice(string InvoiceID, string CustomerID, string RoomID, string EmployeeID, string InvoiceTotal, string CheckInDate, string CheckOutDate, bool HasPaid)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateInvoices(Convert.ToInt32(InvoiceID), Convert.ToInt32(CustomerID), Convert.ToInt32(RoomID), Convert.ToInt32(EmployeeID), Convert.ToDecimal(InvoiceTotal), Convert.ToDateTime(CheckInDate), Convert.ToDateTime(CheckOutDate), HasPaid);
                db.Invoices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteInvoice( string InvoiceID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteInvoices(Convert.ToInt32(InvoiceID));
                db.Invoices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public decimal CalculateRevenue(string month, string year)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();

            return Convert.ToDecimal(db.Revenue(month, year));
        }
    }
}
