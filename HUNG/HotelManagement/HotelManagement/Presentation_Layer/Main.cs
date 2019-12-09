using HotelManagement.BS_Layer;
using HotelManagement.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Presentation_Layer
{
    public partial class Main : Form
    {
        int SaveStatus;
        public int? Employee { get; set; }
        public Main(int? EmployeeID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Employee = EmployeeID;
            //BLEmployee temp = new BLEmployee();
            //this.Employee = temp.FindEmployee(EmployeeID).ElementAt(0);
        }

        private void HotelManagement_Load(object sender, EventArgs e)
        {
            panel_Manage.Width = 0;
            LoadData();
        }
        public void LoadData()
        {
            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(tabPage_DefaultScreen);

            BS_Layer.BLRoom blp = new BS_Layer.BLRoom();

            var tbRooms = blp.LoadRoom();

            int floor = 1;
            int row = 0;
            int col = 0;
            Label floorStart = new Label();
            Panel_ListRoom.Controls.Add(floorStart);
            floorStart.Text = "Floor 1";
            floorStart.Width = 45;
            floorStart.Height = 15;
            floorStart.Location = new Point(5, 95);
            foreach (var room in tbRooms)
            {
                if (room.OnFloor != floor)
                {
                    row++;
                    col = 0;
                    floor = room.OnFloor;
                    Label floorNew = new Label();
                    Panel_ListRoom.Controls.Add(floorNew);
                    floorNew.Text = "Floor " + floor.ToString();
                    floorNew.Width = 45;
                    floorNew.Height = 15;
                    floorNew.Location = new Point(5, 90 * row + 85);
                }
                Button A = new Button();
                Panel_ListRoom.Controls.Add(A);
                A.Text = "Room " + room.RoomID.ToString() + "\n " + room.Name.ToString();
                if (room.Status == 0)
                {
                    A.BackColor = Color.White;
                }
                else
                {
                    if (room.Status == 1)
                    {
                        A.BackColor = Color.LightGoldenrodYellow;
                    }
                    else
                    {
                        A.BackColor = Color.LightBlue;
                    }
                }
                A.Size = new Size(90, 90);
                A.Location = new Point(90 * col + 50, 90 * row + 50);
                A.Click += delegate (object sender, EventArgs e) { Click_Detail(sender, e, room.RoomID, this.Employee); };
                col++;
            }
        }
        private void Click_Detail(object sender, EventArgs e, int RoomID, int? EmployeeID)
        {
            Detail Temp = new Detail(RoomID, EmployeeID);
            Temp.ShowDialog();
        }
        #region CellClick DatagridView
        private void dgv_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Room.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_Room.CurrentCell.RowIndex;
                txt_Room_RoomID.Text = dgv_Room.Rows[r].Cells[0].Value.ToString();
                txt_Room_RoomTypeID.Text = dgv_Room.Rows[r].Cells[1].Value.ToString();
                txt_Room_OnFloor.Text = dgv_Room.Rows[r].Cells[2].Value.ToString();
                if (Convert.ToInt32(dgv_Room.Rows[r].Cells[3].Value) == 0)
                {
                    rbtn_Empty.Checked = true;
                }
                if (Convert.ToInt32(dgv_Room.Rows[r].Cells[3].Value) == 1)
                {
                    rbtn_Hired.Checked = true;
                }
                if (Convert.ToInt32(dgv_Room.Rows[r].Cells[3].Value) == 2)
                {
                    rbtn_Reserved.Checked = true;
                }
            }
        }
        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Customer.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_Customer.CurrentCell.RowIndex;
                txt_Customer_CustomerID.Text = dgv_Customer.Rows[r].Cells[0].Value.ToString();
                txt_Customer_CustomerName.Text = dgv_Customer.Rows[r].Cells[1].Value.ToString();
                txt_Customer_IdentityCard.Text = dgv_Customer.Rows[r].Cells[2].Value.ToString();
                txt_Customer_PhoneNumber.Text = dgv_Customer.Rows[r].Cells[3].Value.ToString();
                txt_Customer_CustomerAddress.Text = dgv_Customer.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void dgv_RoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_RoomType.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_RoomType.CurrentCell.RowIndex;
                txt_RoomType_RoomTypeID.Text = dgv_RoomType.Rows[r].Cells[0].Value.ToString();
                txt_RoomType_RoomTypeName.Text = dgv_RoomType.Rows[r].Cells[1].Value.ToString();
                txt_RoomType_Price.Text = dgv_RoomType.Rows[r].Cells[2].Value.ToString();
            }
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Employee.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_Employee.CurrentCell.RowIndex;
                txt_Employee_EmployeeID.Text = dgv_Employee.Rows[r].Cells[0].Value.ToString();
                txt_Employee_EmployeeName.Text = dgv_Employee.Rows[r].Cells[1].Value.ToString();
                txt_Employee_EmployeeTypeID.Text = dgv_Employee.Rows[r].Cells[2].Value.ToString();
                txt_Employee_PhoneNumber.Text = dgv_Employee.Rows[r].Cells[3].Value.ToString();
                txt_Employee_IdentityCard.Text = dgv_Employee.Rows[r].Cells[4].Value.ToString();
                txt_Employee_PassWord.Text = dgv_Employee.Rows[r].Cells[5].Value.ToString();
            }
        }
        private void dgv_Service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Service.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_Service.CurrentCell.RowIndex;
                txt_Service_ServiceID.Text = dgv_Service.Rows[r].Cells[0].Value.ToString();
                txt_Service_ServiceName.Text = dgv_Service.Rows[r].Cells[1].Value.ToString();
                txt_Service_ServiceTypeID.Text = dgv_Service.Rows[r].Cells[2].Value.ToString();
                txt_Service_Price.Text = dgv_Service.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void dgv_ServiceType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ServiceType.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_ServiceType.CurrentCell.RowIndex;
                txt_ServiceType_ServiceTypeID.Text = dgv_ServiceType.Rows[r].Cells[0].Value.ToString();
                txt_ServiceType_ServiceTypeName.Text = dgv_ServiceType.Rows[r].Cells[1].Value.ToString();
            }
        }

        private void dgv_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Invoice.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_Invoice.CurrentCell.RowIndex;
                txt_Invoice_InvoiceID.Text = dgv_Invoice.Rows[r].Cells[0].Value.ToString();
                txt_Invoice_CustomerID.Text = dgv_Invoice.Rows[r].Cells[1].Value.ToString();
                txt_Invoice_RoomID.Text = dgv_Invoice.Rows[r].Cells[2].Value.ToString();
                txt_Invoice_NumberOfDay.Text = dgv_Invoice.Rows[r].Cells[3].Value.ToString();
                txt_Invoice_EmployeeID.Text = dgv_Invoice.Rows[r].Cells[4].Value.ToString();
                txt_Invoice_InvoiceTotal.Text = dgv_Invoice.Rows[r].Cells[5].Value.ToString();
                txt_Invoice_CheckInDate.Text = dgv_Invoice.Rows[r].Cells[6].Value.ToString();
                txt_Invoice_CheckOutDate.Text = dgv_Invoice.Rows[r].Cells[7].Value.ToString();
                if (Convert.ToBoolean(dgv_Invoice.Rows[r].Cells[8].Value) == true)
                {
                    checkBox_CheckInvoice.Checked = true;
                }
                else checkBox_CheckInvoice.Checked = false;
            }
        }

        private void dgv_SalePhase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SalePhase.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_SalePhase.CurrentCell.RowIndex;
                txt_SalePhase_SalePhaseID.Text = dgv_SalePhase.Rows[r].Cells[0].Value.ToString();
                txt_SalePhase_ServiceTypeID.Text = dgv_SalePhase.Rows[r].Cells[1].Value.ToString();
                txt_SalePhase_StartDate.Text = dgv_SalePhase.Rows[r].Cells[2].Value.ToString();
                txt_SalePhase_EndDate.Text = dgv_SalePhase.Rows[r].Cells[3].Value.ToString();
            }
        }
        private void dgv_Booking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Booking.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_Booking.CurrentCell.RowIndex;
                txt_Booking_BookingID.Text = dgv_Booking.Rows[r].Cells[0].Value.ToString();
                txt_Booking_CustomerID.Text = dgv_Booking.Rows[r].Cells[1].Value.ToString();
                txt_Booking_RoomID.Text = dgv_Booking.Rows[r].Cells[2].Value.ToString();
                txt_Booking_AppointmentDate.Text = dgv_Booking.Rows[r].Cells[3].Value.ToString();
            }
        }
        private void dgv_EmployeeType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_EmployeeType.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_EmployeeType.CurrentCell.RowIndex;
                txt_EmployeeType_EmployeeTypeID.Text = dgv_EmployeeType.Rows[r].Cells[0].Value.ToString();
                txt_EmployeeType_EmployeeTypeName.Text = dgv_EmployeeType.Rows[r].Cells[1].Value.ToString();
            }
        }
        private void dgv_InvoiceService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_InvoiceService.Rows[0].Cells[0].Value != null)
            {
                int r = dgv_InvoiceService.CurrentCell.RowIndex;
                txt_InvoiceService_ID.Text = dgv_InvoiceService.Rows[r].Cells[0].Value.ToString();
                txt_InvoiceService_InvoiceID.Text = dgv_InvoiceService.Rows[r].Cells[1].Value.ToString();
                txt_InvoiceService_ServiceID.Text = dgv_InvoiceService.Rows[r].Cells[2].Value.ToString();
                txt_InvoiceService_Times.Text = dgv_InvoiceService.Rows[r].Cells[3].Value.ToString();
            }
        }
        #endregion
        #region Manage Button
        private void btn_Room_Click(object sender, EventArgs e)
        {
            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Room);            
            dgv_Room.AutoResizeColumns();
            BLRoom dbR = new BLRoom();
            var data = dbR.LoadRoom();
            if (data != null)
            {
                dgv_Room.DataSource = data;
            }
            else
            {
                dgv_Room.DataSource = null;
            }
            dgv_Room_CellClick(null, null);
            txt_Room_RoomID.Enabled = false;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Customer);
            dgv_Customer.AutoResizeColumns();
            BLCustomer dbC = new BLCustomer();
            var data = dbC.LoadCustomer();
            if (data != null)
            {
                dgv_Customer.DataSource = data;
            }
            else
            {
                dgv_Customer.DataSource = null;
            }
            dgv_Customer_CellClick(null, null);
            txt_Customer_CustomerID.Enabled = false;

        }

        private void btn_RoomType_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_RoomType);
            dgv_RoomType.AutoResizeColumns();
            BLRoomType dbRT = new BLRoomType();
            var data = dbRT.LoadRoomType();
            if (data != null)
            {
                dgv_RoomType.DataSource = data;
            }
            else
            {
                dgv_RoomType.DataSource = null;
            }
            dgv_RoomType_CellClick(null, null);
            txt_RoomType_RoomTypeID.Enabled = false;
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Employee);
            dgv_Employee.AutoResizeColumns();
            BLEmployee dbE = new BLEmployee();
            var data = dbE.LoadEmployee();
            if (data != null)
            {
                dgv_Employee.DataSource = data ;
            }
            else
            {
                dgv_Employee.DataSource = null;
            }
            dgv_Employee_CellClick(null, null);
            txt_Employee_EmployeeID.Enabled = false;
        }

        private void btn_Service_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Service);
            dgv_Service.AutoResizeColumns();
            BLHotelService dbS = new BLHotelService();
            var data = dbS.LoadHotelService();
            if (data != null)
            {
                dgv_Service.DataSource = data;
            }
            else
            {
                dgv_Service.DataSource = null;
            }
            dgv_Service_CellClick(null, null);
            txt_Service_ServiceID.Enabled = false;
        }

        private void btn_ServiceType_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_ServiceType);
            dgv_ServiceType.AutoResizeColumns();
            BLServiceType dbST = new BLServiceType();
            var data = dbST.LoadServiceType();
            if (data != null)
            {
                dgv_ServiceType.DataSource = data;
            }
            else
            {
                dgv_ServiceType.DataSource = null;
            }
            dgv_ServiceType_CellClick(null, null);
            txt_ServiceType_ServiceTypeID.Enabled = false;
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Invoice);
            dgv_Invoice.AutoResizeColumns();
            BLInvoice dbI = new BLInvoice();
            var data = dbI.LoadInvoice();
            if (data != null)
            {
                dgv_Invoice.DataSource = data;
            }
            else
            {
                dgv_Invoice.DataSource = null;
            }
            dgv_Invoice_CellClick(null, null);
            txt_Invoice_InvoiceID.Enabled = false;
        }

        private void btn_SalePhase_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_SalePhase);
            dgv_SalePhase.AutoResizeColumns();
            BLSalePhase dbSP = new BLSalePhase();
            var data = dbSP.LoadSalePhase();
            if (data != null)
            {
                dgv_SalePhase.DataSource = data;
            }
            else
            {
                dgv_SalePhase.DataSource = null;
            }
            dgv_SalePhase_CellClick(null, null);
            txt_SalePhase_SalePhaseID.Enabled = false;
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Booking);
            dgv_Booking.AutoResizeColumns();
            BLBooking dbB = new BLBooking();
            var data = dbB.LoadBooking();
            if (data != null)
            {
                dgv_Booking.DataSource = data;
            }
            else
            {
                dgv_Booking.DataSource = null;
            }
            dgv_Booking_CellClick(null, null);
            txt_Booking_BookingID.Enabled = false;
        }
    
        private void btn_EmployeeType_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_EmployeeType);
            dgv_EmployeeType.AutoResizeColumns();
            BLEmployeeType dbB = new BLEmployeeType();
            var data = dbB.LoadEmployeeType();
            if (data != null)
            {
                dgv_EmployeeType.DataSource = data;
            }
            else
            {
                dgv_EmployeeType.DataSource = null;
            }
            dgv_EmployeeType_CellClick(null, null);
            txt_EmployeeType_EmployeeTypeID.Enabled = false;
        }

        private void btn_InvoiceService_Click(object sender, EventArgs e)
        {

            TabControl_Main.TabPages.Clear();
            TabControl_Main.TabPages.Add(TabPage_Invoice_Service);
            dgv_InvoiceService.AutoResizeColumns();
            BLInvoice_Service dbB = new BLInvoice_Service();
            var data = dbB.LoadInvoice_Service();
            if (data != null)
            {
                dgv_InvoiceService.DataSource = data;
            }
            else
            {
                dgv_InvoiceService.DataSource = null;
            }
            dgv_InvoiceService_CellClick(null, null);
            txt_InvoiceService_ID.Enabled = false;
        }
        #endregion

        
        #region CRUD Room
        private void btn_Save_Room_Click(object sender, EventArgs e)
        {
            int status = 0;
            BLRoom blR = new BLRoom();
            if (rbtn_Empty.Checked == true)
            {
                status = 0;
            }
            if(rbtn_Hired.Checked == true)
            {
                status = 1;
            }
            if (rbtn_Reserved.Checked == true)
            {
                status = 2;
            }
            if (SaveStatus == 1)
            {
                blR.CreateRoom(txt_Room_RoomTypeID.Text, txt_Room_OnFloor.Text, status);
            }
            else if(SaveStatus == 2)
            {   
                blR.UpdateRoom(Convert.ToInt32(txt_Room_RoomID.Text), txt_Room_RoomTypeID.Text, txt_Room_OnFloor.Text, status);
            }
            SaveStatus = 0;
            dgv_Room.DataSource = blR.LoadRoom();
            dgv_Room_CellClick(null, null);
            btn_Update_Room.Enabled = true;
            btn_Create_Room.Enabled = true;
            btn_Save_Room.Enabled = false;
        }

        private void btn_Create_Room_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_Room.Enabled = true;
            btn_Update_Room.Enabled = false;
            txt_Room_RoomID.Clear();
            txt_Room_RoomTypeID.Clear();
            txt_Room_OnFloor.Clear();
            rbtn_Empty.Checked = rbtn_Hired.Checked = rbtn_Reserved.Checked = false;
        }

        private void btn_Update_Room_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_Room.Enabled = true;
            btn_Create_Room.Enabled = false;
        }
        private void btn_Delete_Room_Click(object sender, EventArgs e)
        {
            BLRoom blR = new BLRoom();
            blR.DeleteRoom(Convert.ToInt32(txt_Room_RoomID.Text));
            dgv_Room.DataSource = blR.LoadRoom();
            dgv_Room_CellClick(null, null);

        }
        private void btn_Cancel_Room_Click(object sender, EventArgs e)
        {
            btn_Save_Room.Enabled = false;
            btn_Create_Room.Enabled = true;
            btn_Update_Room.Enabled = true;
            SaveStatus = 0;
            dgv_Room_CellClick(null, null);
        }
        #endregion
        #region CRUD Customer
        private void btn_Create_Customer_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_Customer.Enabled = true;
            btn_Update_Customer.Enabled = false;
            txt_Customer_CustomerID.Clear();
            txt_Customer_CustomerName.Clear();
            txt_Customer_IdentityCard.Clear();
            txt_Customer_PhoneNumber.Clear();
            txt_Customer_CustomerAddress.Clear();
        }

        private void btn_Save_Customer_Click(object sender, EventArgs e)
        {
            BLCustomer blC = new BLCustomer();
            if (SaveStatus == 1)
            {
                blC.CreateCustomer( txt_Customer_CustomerName.Text,
                                    txt_Customer_IdentityCard.Text,
                                    txt_Customer_PhoneNumber.Text, 
                                    txt_Customer_CustomerAddress.Text);
            }
            else if (SaveStatus == 2)
            {
                blC.UpdateCustomer(txt_Customer_CustomerID.Text, 
                                    txt_Customer_CustomerName.Text,
                                    txt_Customer_IdentityCard.Text,
                                    txt_Customer_PhoneNumber.Text,
                                    txt_Customer_CustomerAddress.Text);
            }
            SaveStatus = 0;
            dgv_Customer.DataSource = blC.LoadCustomer();
            dgv_Customer_CellClick(null, null);
            btn_Update_Customer.Enabled = true;
            btn_Create_Customer.Enabled = true;
            btn_Save_Customer.Enabled = false;
        }

        private void btn_Delete_Customer_Click(object sender, EventArgs e)
        {
            BLCustomer blC = new BLCustomer();
            blC.DeleteCustomer(txt_Customer_CustomerID.Text);
            dgv_Customer.DataSource = blC.LoadCustomer();
            dgv_Customer_CellClick(null, null);
        }

        private void btn_Cancel_Customer_Click(object sender, EventArgs e)
        {
            btn_Save_Customer.Enabled = false;
            btn_Create_Customer.Enabled = true;
            btn_Update_Customer.Enabled = true;
            SaveStatus = 0;
            dgv_Customer_CellClick(null, null);
        }

        private void btn_Update_Customer_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_Customer.Enabled = true;
            btn_Create_Customer.Enabled = false;
        }
        #endregion
        #region CRUD Employee
        private void btn_Create_Employee_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_Employee.Enabled = true;
            btn_Update_Employee.Enabled = false;
            txt_Employee_EmployeeID.Clear();
            txt_Employee_EmployeeName.Clear();
            txt_Employee_EmployeeTypeID.Clear();
            txt_Employee_PhoneNumber.Clear();
            txt_Employee_IdentityCard.Clear();     
            txt_Employee_PassWord.Clear();
        }

        private void btn_Save_Employee_Click(object sender, EventArgs e)
        {
            BLEmployee blE = new BLEmployee();
            if (SaveStatus == 1)
            {
                blE.CreateEmployee(txt_Employee_EmployeeName.Text,
                                    txt_Employee_EmployeeTypeID.Text,
                                    txt_Employee_PhoneNumber.Text,
                                    txt_Employee_IdentityCard.Text,
                                    txt_Employee_PassWord.Text);
            }
            else if (SaveStatus == 2)
            {
                blE.UpdateEmployee(Convert.ToInt32(txt_Employee_EmployeeID.Text),
                                    txt_Employee_EmployeeName.Text,
                                    txt_Employee_EmployeeTypeID.Text,
                                    txt_Employee_PhoneNumber.Text,
                                    txt_Employee_IdentityCard.Text,
                                    txt_Employee_PassWord.Text);
            }
            SaveStatus = 0;
            dgv_Employee.DataSource = blE.LoadEmployee();
            dgv_Employee_CellClick(null, null);
            btn_Update_Employee.Enabled = true;
            btn_Create_Employee.Enabled = true;
            btn_Save_Employee.Enabled = false;
        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_Employee.Enabled = true;
            btn_Create_Employee.Enabled = false;
        }

        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
            BLEmployee blE = new BLEmployee();
            blE.DeleteEmployee(Convert.ToInt32(txt_Employee_EmployeeID.Text));
            dgv_Employee.DataSource = blE.LoadEmployee();
            dgv_Employee_CellClick(null, null);
        }

        private void btn_Cancel_Employee_Click(object sender, EventArgs e)
        {
            btn_Save_Employee.Enabled = false;
            btn_Create_Employee.Enabled = true;
            btn_Update_Employee.Enabled = true;
            SaveStatus = 0;
            dgv_Employee_CellClick(null, null);
        }

        #endregion
        #region CRUD RoomType
        private void btn_Create_RoomType_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_RoomType.Enabled = true;
            btn_Update_RoomType.Enabled = false;
            txt_RoomType_RoomTypeID.Clear();
            txt_RoomType_RoomTypeName.Clear();
            txt_RoomType_Price.Clear();
        }

        private void btn_Save_RoomType_Click(object sender, EventArgs e)
        {
            BLRoomType blRT = new BLRoomType();
            if (SaveStatus == 1)
            {
                blRT.CreateRoomType(txt_RoomType_RoomTypeName.Text, txt_RoomType_Price.Text);
            }
            else if (SaveStatus == 2)
            {
                blRT.UpdateRoomType(Convert.ToInt32(txt_RoomType_RoomTypeID.Text), txt_RoomType_RoomTypeName.Text, txt_RoomType_Price.Text);
            }
            SaveStatus = 0;
            dgv_RoomType.DataSource = blRT.LoadRoomType();
            dgv_RoomType_CellClick(null, null);
            btn_Update_RoomType.Enabled = true;
            btn_Create_RoomType.Enabled = true;
            btn_Save_RoomType.Enabled = false;
        }

        private void btn_Update_RoomType_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_RoomType.Enabled = true;
            btn_Create_RoomType.Enabled = false;
        }

        private void btn_Delete_RoomType_Click(object sender, EventArgs e)
        {
            BLRoomType blRT = new BLRoomType();
            blRT.DeleteRoomType(txt_RoomType_RoomTypeID.Text);
            dgv_RoomType.DataSource = blRT.LoadRoomType();
            dgv_RoomType_CellClick(null, null);
        }

        private void btn_Cancel_RoomType_Click(object sender, EventArgs e)
        {
            btn_Save_RoomType.Enabled = false;
            btn_Create_RoomType.Enabled = true;
            btn_Update_RoomType.Enabled = true;
            SaveStatus = 0;
            dgv_RoomType_CellClick(null, null);
        }

        #endregion
        #region CRUD SalePhase
        private void btn_Create_SalePhase_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_SalePhase.Enabled = true;
            btn_Update_SalePhase.Enabled = false;
            txt_SalePhase_SalePhaseID.Clear();
            txt_SalePhase_ServiceTypeID.Clear();
            txt_SalePhase_StartDate.Clear();
            txt_SalePhase_EndDate.Clear();
        }

        private void btn_Save_SalePhase_Click(object sender, EventArgs e)
        {
            BLSalePhase blSP = new BLSalePhase();
            if (SaveStatus == 1)
            {
                blSP.CreateSalePhase(txt_SalePhase_ServiceTypeID.Text, txt_SalePhase_StartDate.Text, txt_SalePhase_EndDate.Text);
            }
            else if (SaveStatus == 2)
            {
                blSP.UpdateSalePhase(Convert.ToInt32(txt_SalePhase_SalePhaseID.Text), txt_SalePhase_ServiceTypeID.Text, txt_SalePhase_StartDate.Text, txt_SalePhase_EndDate.Text);
            }
            SaveStatus = 0;
            dgv_SalePhase.DataSource = blSP.LoadSalePhase();
            dgv_SalePhase_CellClick(null, null);
            btn_Update_SalePhase.Enabled = true;
            btn_Create_SalePhase.Enabled = true;
            btn_Save_SalePhase.Enabled = false;
        }

        private void btn_Update_SalePhase_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_SalePhase.Enabled = true;
            btn_Create_SalePhase.Enabled = false;
        }

        private void btn_Delete_SalePhase_Click(object sender, EventArgs e)
        {
            BLSalePhase blRT = new BLSalePhase();
            blRT.DeleteSalePhase(Convert.ToInt32(txt_SalePhase_SalePhaseID.Text));
            dgv_SalePhase.DataSource = blRT.LoadSalePhase();
            dgv_SalePhase_CellClick(null, null);
        }

        private void btn_Cancel_SalePhase_Click(object sender, EventArgs e)
        {
            btn_Save_SalePhase.Enabled = false;
            btn_Create_SalePhase.Enabled = true;
            btn_Update_SalePhase.Enabled = true;
            SaveStatus = 0;
            dgv_SalePhase_CellClick(null, null);
        }
        #endregion
        #region CRUD Invoice
        private void btn_Create_Invoice_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_Invoice.Enabled = true;
            btn_Update_Invoice.Enabled = false;
            txt_Invoice_InvoiceID.Clear();
            txt_Invoice_CustomerID.Clear();
            txt_Invoice_RoomID.Clear();
            txt_Invoice_NumberOfDay.Clear();
            txt_Invoice_EmployeeID.Clear();
            txt_Invoice_InvoiceTotal.Clear();
            txt_Invoice_CheckInDate.Clear();
            txt_Invoice_CheckOutDate.Clear();
            checkBox_CheckInvoice.Checked = false;
        }

        private void btn_Save_Invoice_Click(object sender, EventArgs e)
        {
            //BLInvoice blI = new BLInvoice();
            //if (SaveStatus == 1)
            //{
            //    blI.Checkin(txt_Invoice_CustomerID.Text, txt_Invoice_RoomID.Text, txt_Invoice_NumberOfDay.Text, txt_Invoice_EmployeeID.Text, txt_Invoice_InvoiceTotal.Text, txt_Invoice_CheckInDate.Text, txt_Invoice_CheckOutDate.Text, checkBox_CheckInvoice.Checked);
            //}
            //else if (SaveStatus == 2)
            //{
            //    blI.UpdateInvoice(txt_Invoice_InvoiceID.Text, txt_Invoice_CustomerID.Text, txt_Invoice_RoomID.Text, txt_Invoice_NumberOfDay.Text, txt_Invoice_EmployeeID.Text, txt_Invoice_InvoiceTotal.Text, txt_Invoice_CheckInDate.Text, txt_Invoice_CheckOutDate.Text, checkBox_CheckInvoice.Checked);
            //}
            //SaveStatus = 0;
            //dgv_Invoice.DataSource = blI.LoadInvoice();
            //dgv_Invoice_CellClick(null, null);
            //btn_Update_Invoice.Enabled = true;
            //btn_Create_Invoice.Enabled = true;
            //btn_Save_Invoice.Enabled = false;
        }

        private void btn_Update_Invoice_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_Invoice.Enabled = true;
            btn_Create_Invoice.Enabled = false;
        }

        private void btn_Delete_Invoice_Click(object sender, EventArgs e)
        {
            BLInvoice blI = new BLInvoice();
            blI.DeleteInvoice(txt_Invoice_InvoiceID.Text);
            dgv_Invoice.DataSource = blI.LoadInvoice();
            dgv_Invoice_CellClick(null, null);
        }

        private void btn_Cancel_Invoice_Click(object sender, EventArgs e)
        {
            btn_Save_Invoice.Enabled = false;
            btn_Create_Invoice.Enabled = true;
            btn_Update_Invoice.Enabled = true;
            SaveStatus = 0;
            dgv_Invoice_CellClick(null, null);
        }
        #endregion
        #region CRUD Service
        private void btn_Create_Service_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_Service.Enabled = true;
            btn_Update_Service.Enabled = false;
            txt_Service_ServiceID.Clear();
            txt_Service_ServiceName.Clear();
            txt_ServiceType_ServiceTypeID.Clear();
            txt_Service_Price.Clear();
        }

        private void btn_Save_Service_Click(object sender, EventArgs e)
        {
            BLHotelService blS = new BLHotelService();
            if (SaveStatus == 1)
            {
                blS.CreateHotelService(txt_Service_ServiceName.Text, txt_ServiceType_ServiceTypeID.Text, txt_Service_Price.Text);
            }
            else if (SaveStatus == 2)
            {
                blS.UpdateHotelService(txt_Service_ServiceID.Text, txt_Service_ServiceName.Text, txt_ServiceType_ServiceTypeID.Text, txt_Service_Price.Text);
            }
            SaveStatus = 0;
            dgv_Service.DataSource = blS.LoadHotelService();
            dgv_Service_CellClick(null, null);
            btn_Update_Service.Enabled = true;
            btn_Create_Service.Enabled = true;
            btn_Save_Service.Enabled = false;
        }

        private void btn_Delete_Service_Click(object sender, EventArgs e)
        {
            BLHotelService blS = new BLHotelService();
            blS.DeleteHotelService(txt_Service_ServiceID.Text);
            dgv_Service.DataSource = blS.LoadHotelService();
            dgv_Service_CellClick(null, null);
        }

        private void btn_Update_Service_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_Service.Enabled = true;
            btn_Create_Service.Enabled = false;
        }

        private void btn_Cancel_Service_Click(object sender, EventArgs e)
        {
            btn_Save_Service.Enabled = false;
            btn_Create_Service.Enabled = true;
            btn_Update_Service.Enabled = true;
            SaveStatus = 0;
            dgv_Service_CellClick(null, null);
        }
        #endregion
        #region CRUD ServiceType
        private void btn_Save_ServiceType_Click(object sender, EventArgs e)
        {
            BLServiceType blRT = new BLServiceType();
            if (SaveStatus == 1)
            {
                blRT.CreateServiceType(txt_ServiceType_ServiceTypeName.Text);
            }
            else if (SaveStatus == 2)
            {
                blRT.UpdateServiceType(Convert.ToInt32(txt_ServiceType_ServiceTypeID.Text), txt_ServiceType_ServiceTypeName.Text);
            }
            SaveStatus = 0;
            dgv_ServiceType.DataSource = blRT.LoadServiceType();
            dgv_ServiceType_CellClick(null, null);
            btn_Update_ServiceType.Enabled = true;
            btn_Create_ServiceType.Enabled = true;
            btn_Save_ServiceType.Enabled = false;
        }

        private void btn_Create_ServiceType_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_ServiceType.Enabled = true;
            btn_Update_ServiceType.Enabled = false;
            txt_ServiceType_ServiceTypeID.Clear();
            txt_ServiceType_ServiceTypeName.Clear();
        }

        private void btn_Update_ServiceType_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_ServiceType.Enabled = true;
            btn_Create_ServiceType.Enabled = false;
        }

        private void btn_Delete_ServiceType_Click(object sender, EventArgs e)
        {
            BLServiceType blRT = new BLServiceType();
            blRT.DeleteServiceType(txt_ServiceType_ServiceTypeID.Text);
            dgv_ServiceType.DataSource = blRT.LoadServiceType();
            dgv_ServiceType_CellClick(null, null);
        }

        private void btn_Cancel_ServiceType_Click(object sender, EventArgs e)
        {
            btn_Save_ServiceType.Enabled = false;
            btn_Create_ServiceType.Enabled = true;
            btn_Update_ServiceType.Enabled = true;
            SaveStatus = 0;
            dgv_ServiceType_CellClick(null, null);
        }


        #endregion
        #region CRUD EmployeeType
        private void btn_Create_EmployeeType_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_EmployeeType.Enabled = true;
            btn_Update_EmployeeType.Enabled = false;
            txt_EmployeeType_EmployeeTypeID.Clear();
            txt_EmployeeType_EmployeeTypeName.Clear();
        }

        private void btn_Save_EmployeeType_Click(object sender, EventArgs e)
        {
            BLEmployeeType blET = new BLEmployeeType();
            if (SaveStatus == 1)
            {
                blET.CreateEmployeeType(txt_EmployeeType_EmployeeTypeName.Text);
            }
            else if (SaveStatus == 2)
            {
                blET.UpdateEmployeeType(Convert.ToInt32(txt_EmployeeType_EmployeeTypeID.Text), txt_EmployeeType_EmployeeTypeName.Text);
            }
            SaveStatus = 0;
            dgv_EmployeeType.DataSource = blET.LoadEmployeeType();
            dgv_EmployeeType_CellClick(null, null);
            btn_Update_EmployeeType.Enabled = true;
            btn_Create_EmployeeType.Enabled = true;
            btn_Save_EmployeeType.Enabled = false;
        }

        private void btn_Delete_EmployeeType_Click(object sender, EventArgs e)
        {
            BLEmployeeType blET = new BLEmployeeType();
            blET.DeleteEmployeeType(txt_EmployeeType_EmployeeTypeID.Text);
            dgv_EmployeeType.DataSource = blET.LoadEmployeeType();
            dgv_EmployeeType_CellClick(null, null);
        }

        private void btn_Update_EmployeeType_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_EmployeeType.Enabled = true;
            btn_Create_EmployeeType.Enabled = false;
        }

        private void btn_Cancel_EmployeeType_Click(object sender, EventArgs e)
        {
            btn_Save_EmployeeType.Enabled = false;
            btn_Create_EmployeeType.Enabled = true;
            btn_Update_EmployeeType.Enabled = true;
            SaveStatus = 0;
            dgv_EmployeeType_CellClick(null, null);
        }
        #endregion
        #region CRUD Booking
        private void btn_Create_Booking_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_Booking.Enabled = true;
            btn_Update_Booking.Enabled = false;
            txt_Booking_CustomerID.Clear();
            txt_Booking_RoomID.Clear();
            txt_Booking_AppointmentDate.Clear();
        }

        private void btn_Save_Booking_Click(object sender, EventArgs e)
        {
            BLBooking blSP = new BLBooking();
            if (SaveStatus == 1)
            {
                blSP.CreateBooking(txt_Booking_CustomerID.Text, txt_Booking_RoomID.Text, txt_Booking_AppointmentDate.Text);
            }
            else if (SaveStatus == 2)
            {
                blSP.UpdateBooking(txt_Booking_BookingID.Text, txt_Booking_CustomerID.Text, txt_Booking_RoomID.Text, txt_Booking_AppointmentDate.Text);
            }
            SaveStatus = 0;
            dgv_Booking.DataSource = blSP.LoadBooking();
            dgv_Booking_CellClick(null, null);
            btn_Update_Booking.Enabled = true;
            btn_Create_Booking.Enabled = true;
            btn_Save_Booking.Enabled = false;
        }

        private void btn_Delete_Booking_Click(object sender, EventArgs e)
        {
            BLBooking blRT = new BLBooking();
            blRT.DeleteBooking(txt_Booking_BookingID.Text);
            dgv_Booking.DataSource = blRT.LoadBooking();
            dgv_Booking_CellClick(null, null);
        }

        private void btn_Update_Booking_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_Booking.Enabled = true;
            btn_Create_Booking.Enabled = false;
        }

        private void btn_Cancel_Booking_Click(object sender, EventArgs e)
        {
            btn_Save_Booking.Enabled = false;
            btn_Create_Booking.Enabled = true;
            btn_Update_Booking.Enabled = true;
            SaveStatus = 0;
            dgv_Booking_CellClick(null, null);
        }
        #endregion
        #region CRUD Invoice_Service
        private void btn_Create_InvoiceService_Click(object sender, EventArgs e)
        {
            SaveStatus = 1;
            btn_Save_InvoiceService.Enabled = true;
            btn_Update_InvoiceService.Enabled = false;
            txt_InvoiceService_ID.Clear();
            txt_InvoiceService_InvoiceID.Clear();
            txt_InvoiceService_ServiceID.Clear();
            txt_InvoiceService_Times.Clear();
        }

        private void btn_Save_InvoiceService_Click(object sender, EventArgs e)
        {
            BLInvoice_Service blSP = new BLInvoice_Service();
            if (SaveStatus == 1)
            {
                blSP.CreateInvoice_Service(txt_InvoiceService_InvoiceID.Text, txt_InvoiceService_ServiceID.Text, txt_InvoiceService_Times.Text);
            }
            else if (SaveStatus == 2)
            {
                blSP.UpdateInvoice_Service(Convert.ToInt32(txt_InvoiceService_ID.Text), txt_InvoiceService_InvoiceID.Text, txt_InvoiceService_ServiceID.Text, txt_InvoiceService_Times.Text);
            }
            SaveStatus = 0;
            dgv_InvoiceService.DataSource = blSP.LoadInvoice_Service();
            dgv_InvoiceService_CellClick(null, null);
            btn_Update_InvoiceService.Enabled = true;
            btn_Create_InvoiceService.Enabled = true;
            btn_Save_InvoiceService.Enabled = false;
        }

        private void btn_Delete_InvoiceService_Click(object sender, EventArgs e)
        {
            BLInvoice_Service blRT = new BLInvoice_Service();
            blRT.DeleteInvoice_Service(Convert.ToInt32(txt_InvoiceService_ID.Text));
            dgv_InvoiceService.DataSource = blRT.LoadInvoice_Service();
            dgv_InvoiceService_CellClick(null, null);
        }

        private void btn_Update_InvoiceService_Click(object sender, EventArgs e)
        {
            SaveStatus = 2;
            btn_Save_InvoiceService.Enabled = true;
            btn_Create_InvoiceService.Enabled = false;
        }

        private void btn_Cancel_InvoiceService_Click(object sender, EventArgs e)
        {
            btn_Save_InvoiceService.Enabled = false;
            btn_Create_InvoiceService.Enabled = true;
            btn_Update_InvoiceService.Enabled = true;
            SaveStatus = 0;
            dgv_InvoiceService_CellClick(null, null);
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BLRoom db = new BLRoom();
            if(cmb_Room.Text == "OnFloor")
            {
                if (textBox_Room.Text == "")
                {
                    dgv_Room.DataSource = db.LoadRoom();
                }
                else dgv_Room.DataSource = db.SearchRoom(2, textBox_Room.Text);
            }
            if (cmb_Room.Text == "RoomTypeID")
            {
                if (textBox_Room.Text == "")
                {
                    dgv_Room.DataSource = db.LoadRoom();
                }
                else dgv_Room.DataSource = db.SearchRoom(1, textBox_Room.Text);
            }
            if(cmb_Room.Text == "Status")
            {
                if (textBox_Room.Text == "")
                {
                    dgv_Room.DataSource = db.LoadRoom();
                }
                else dgv_Room.DataSource = db.SearchRoom(3, textBox_Room.Text);
            }
            if(textBox_Room.Text == "")
            {
                dgv_Room.DataSource = db.LoadRoom();
            }  
        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            panel_Manage.Width = 260;
        }

        private void Button_Hide_Click(object sender, EventArgs e)
        {
            panel_Manage.Width = 0;
        }
    }
}
