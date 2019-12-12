using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLInvoice_Service
    {
        public System.Data.Linq.Table<Invoices_Service> LoadInvoice_Service()
        {
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Invoices_Services;
        }
        public bool CreateInvoice_Service(string InvoiceID, string ServiceID, string Times)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CreateInvoices_Services(Convert.ToInt32(InvoiceID), Convert.ToInt32(ServiceID), Convert.ToInt32(Times));
                db.Invoices_Services.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateInvoice_Service(int Invoices_Services_ID, string InvoiceID, string ServiceID, string Times)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_UpdateInvoices_Services(Invoices_Services_ID, Convert.ToInt32(InvoiceID), Convert.ToInt32(ServiceID), Convert.ToInt32(Times));
                db.Invoices_Services.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteInvoice_Service(int Invoices_Services_ID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteInvoices_Services(Invoices_Services_ID);
                db.Invoices_Services.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
