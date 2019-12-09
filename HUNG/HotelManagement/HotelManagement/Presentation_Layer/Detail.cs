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
    public partial class Detail : Form
    {
        public int Room_ID { get; set; }
        public int? EmployeeID { get; set; }
        public Detail(int roomID, int? employeeID)
        {
            InitializeComponent();
            this.Room_ID = roomID;
            this.EmployeeID = employeeID;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            BS_Layer.BLRoom bl = new BS_Layer.BLRoom();
            var Room = bl.FindRoom(Room_ID).ElementAt(0);
            switch (Room.Status)
            {
                case 0:
                    {
                        Button_Checkout.Enabled = false;
                        tabControl_Main.TabPages.Clear();
                        tabControl_Main.TabPages.Add(tabPage_Booking);
                        InitializerBooking();
                        break;
                    }
                case 1:
                    {
                        Button_Booking.Enabled = false;
                        Button_Checkin.Enabled = false;
                        tabControl_Main.TabPages.Clear();
                        tabControl_Main.TabPages.Add(tabPage_CheckOut);
                        break;
                    }
                case 2:
                    {
                        Button_Booking.Enabled = false;
                        Button_Checkout.Enabled = false;
                        InitializerCheckin();
                        tabControl_Main.TabPages.Clear();
                        tabControl_Main.TabPages.Add(tabPage_Checkin);
                        break;
                    }
            }
        }



        #region  Booking 
        private void Button_Booking_Click(object sender, EventArgs e)
        {
            InitializerBooking();
            tabControl_Main.TabPages.Clear();
            tabControl_Main.TabPages.Add(tabPage_Booking);
            Booking_Panel_NewCustomer.Enabled = false;
            Booking_Panel_SelectingCustomer.Enabled = true;
        }
        private void Booking_Button_AddNewCustomer_Click(object sender, EventArgs e)
        {
            BS_Layer.BLCustomer bl = new BS_Layer.BLCustomer();
            if (bl.CreateCustomer(Booking_TextBox_CustomerName.Text, Booking_TextBox_IdentityCard.Text, Booking_TextBox_PhoneNumber.Text, Booking_TextBox_Address.Text) == true)
            {
                MessageBox.Show(" Add a new customer successfully ");
                LoadCustomerDataBookingTable();
            }
            else
            {
                MessageBox.Show(" Adding failed ");
            }
        }
        private void Booking_Button_ChooseCustomer_Click(object sender, EventArgs e)
        {
            int r = Booking_DGV_ListOfCustomer.CurrentCell.RowIndex;
            if (r > Booking_DGV_ListOfCustomer.Rows.Count - 2)
            {
                return;
            }
            else
            {
                Booking_DataGridView_DetailOfBooking.Rows[0].Cells[0].Value = Booking_DGV_ListOfCustomer.Rows[r].Cells[0].Value;
                Booking_DataGridView_DetailOfBooking.Rows[0].Cells[1].Value = Booking_DGV_ListOfCustomer.Rows[r].Cells[1].Value;
            }
        }
        private void Booking_Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Booking_Button_AddBooking_Click(object sender, EventArgs e)
        {
            if (Booking_DataGridView_DetailOfBooking.Rows[0].Cells[0].Value.ToString() != "" && Booking_DataGridView_DetailOfBooking.Rows[0].Cells[2].Value.ToString() != "")
            {

                BS_Layer.BLBooking bl = new BS_Layer.BLBooking();
                if (bl.CreateBooking(Booking_DataGridView_DetailOfBooking.Rows[0].Cells[0].Value.ToString(), Booking_DataGridView_DetailOfBooking.Rows[0].Cells[2].Value.ToString(), Booking_DataGridView_DetailOfBooking.Rows[0].Cells[4].Value.ToString())==true)
                {
                    MessageBox.Show(" Succesfully !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Failed ");
                }                               
            }
            else
            {
                MessageBox.Show("Have some emty information ");
            }
        }
        private void SearchKH_TextBox_TextChanged(object sender, EventArgs e)
        {
            string column;
            switch (SearchKH_ComboBox.Text)
            {
                case "Customer Name":
                    {
                        column = "CustomerName";
                        break;
                    }
                case "Identity Card":
                    {
                        column = "IdentityCard";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            //BS_Layer.BLCustomer bl = new BS_Layer.BLCustomer();
            //Booking_DGV_ListOfCustomer.DataSource = bl.fin(column, SearchKH_TextBox.Text);            
        }
        private void LoadCustomerDataBookingTable()
        {
            try
            {
                BS_Layer.BLCustomer bl = new BS_Layer.BLCustomer();
                Booking_DGV_ListOfCustomer.DataSource = bl.LoadCustomer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Can not fetch data in table Customer !");
            }
        }
        private void InitializerBooking()
        {
            Booking_RadioButton_Ever.Checked = true;
            this.DateTimePicker_AppointmentDate.MinDate = DateTime.Today;

            this.Booking_TextBox_CustomerName.ResetText();
            this.Booking_TextBox_Address.ResetText();
            this.Booking_TextBox_PhoneNumber.ResetText();
            this.Booking_TextBox_IdentityCard.ResetText();
            LoadCustomerDataBookingTable();
            Booking_DataGridView_DetailOfBooking.Rows[0].Cells[0].Value = Booking_DGV_ListOfCustomer.Rows[0].Cells[0].Value;
            Booking_DataGridView_DetailOfBooking.Rows[0].Cells[1].Value = Booking_DGV_ListOfCustomer.Rows[0].Cells[1].Value;
            Booking_DataGridView_DetailOfBooking.Rows[0].Cells[2].Value = this.Room_ID;
            BS_Layer.BLRoom bl = new BS_Layer.BLRoom(); 
            Booking_DataGridView_DetailOfBooking.Rows[0].Cells[3].Value = bl.FindRoom(this.Room_ID).ElementAt(0).Type;
            Booking_DataGridView_DetailOfBooking.Rows[0].Cells[4].Value = DateTimePicker_AppointmentDate.Value.Date;
        }
        private void DateTimePicker_AppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            Booking_DataGridView_DetailOfBooking.Rows[0].Cells[4].Value = DateTimePicker_AppointmentDate.Value.ToString();
        }
        private void Booking_RadioButton_Ever_CheckedChanged(object sender, EventArgs e)
        {
            if(Booking_RadioButton_Ever.Checked == true)
            {
                Booking_Panel_NewCustomer.Enabled = false;
                Booking_Panel_SelectingCustomer.Enabled = true;
            }
            else
            {
                Booking_Panel_NewCustomer.Enabled = true;
                Booking_Panel_SelectingCustomer.Enabled = false;
            }
        }
        private void Booking_Button_Reset_Click(object sender, EventArgs e)
        {            
            InitializerBooking();
        }
        #endregion

        #region  Checkin
        private void Button_Checkin_Click(object sender, EventArgs e)
        {
            tabControl_Main.TabPages.Clear();
            tabControl_Main.TabPages.Add(tabPage_Checkin);
            InitializerCheckin();
        }

        private void Checkin_AddCustomer_Click(object sender, EventArgs e)
        {
            BS_Layer.BLCustomer bl = new BS_Layer.BLCustomer();
            if (bl.CreateCustomer(Checkin_Textbox_CustomerName.Text, Checkin_Textbox_IdentityCard.Text, Checkin_Textbox_PhoneNumber.Text, Checkin_Textbox_Address.Text) == true)
            {
                MessageBox.Show(" Add a new customer successfully ");
                LoadCustomerDataCheckinTable();
            }
            else
            {
                MessageBox.Show(" Adding failed ");
            }
        }
        private void Button_ChooseBooking_Click(object sender, EventArgs e)
        {
            int r = Checkin_Datagridview_Booking.CurrentCell.RowIndex;
            if (r > Checkin_Datagridview_Booking.Rows.Count - 2)
            {
                return;
            }
            else
            {
                Checkin_DataGridView_Detail.Rows[0].Cells[0].Value = Checkin_Datagridview_Booking.Rows[r].Cells[1].Value;
                Checkin_DataGridView_Detail.Rows[0].Cells[1].Value = Checkin_Datagridview_Booking.Rows[r].Cells[2].Value;
            }
        }
        private void Checkin_ChooseCustomer_Click(object sender, EventArgs e)
        {
            int r = Checkin_Datagridview_ListOfCustomer.CurrentCell.RowIndex;
            if (r > Checkin_Datagridview_ListOfCustomer.Rows.Count - 2)
            {
                return;
            }
            else
            {
                Checkin_DataGridView_Detail.Rows[0].Cells[0].Value = Checkin_Datagridview_ListOfCustomer.Rows[r].Cells[0].Value;
                Checkin_DataGridView_Detail.Rows[0].Cells[1].Value = Checkin_Datagridview_ListOfCustomer.Rows[r].Cells[1].Value;
            }
        }

        private void Checkin_Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkin_Button_Confirm_Click(object sender, EventArgs e)
        {
            BS_Layer.BLInvoice bl = new BS_Layer.BLInvoice();
            if (bl.Checkin(Checkin_DataGridView_Detail.Rows[0].Cells[0].Value.ToString(), Checkin_DataGridView_Detail.Rows[0].Cells[2].Value.ToString(), this.EmployeeID.ToString()) == true)
            {
                MessageBox.Show(" Succesfully !");
                this.Close();
            }
            else
            {
                MessageBox.Show(" Failed ");
            }
        }
        private void Checkin_RadioButton_HaveBooking_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkin_RadioButton_HaveBooking.Checked == true)
            {
                Checkin_Panel_HaveBooking.Enabled = true;
                Checkin_Panel_CreateNewCustomer.Enabled = false;
                Checkin_Panel_SelectCustomer.Enabled = false;
            }
            else
            {
                Checkin_Panel_HaveBooking.Enabled = false;
                Checkin_Panel_CreateNewCustomer.Enabled = true;
                Checkin_Panel_SelectCustomer.Enabled = true;
            }
        }

        private void InitializerCheckin()
        {           
            this.DateTimePicker_AppointmentDate.MinDate = DateTime.Today;

            this.Checkin_Textbox_CustomerName.ResetText();
            this.Checkin_Textbox_Address.ResetText();
            this.Checkin_Textbox_PhoneNumber.ResetText();
            this.Checkin_Textbox_IdentityCard.ResetText();
            LoadCustomerDataCheckinTable();
            LoadBookingList();
            Checkin_DataGridView_Detail.Rows[0].Cells[0].Value = Checkin_Datagridview_ListOfCustomer.Rows[0].Cells[0].Value;
            Checkin_DataGridView_Detail.Rows[0].Cells[1].Value = Checkin_Datagridview_ListOfCustomer.Rows[0].Cells[1].Value;
            Checkin_DataGridView_Detail.Rows[0].Cells[2].Value = this.Room_ID;
            BS_Layer.BLRoom bl = new BS_Layer.BLRoom();
            Checkin_DataGridView_Detail.Rows[0].Cells[3].Value = bl.FindRoom(this.Room_ID).ElementAt(0).Type;
            Checkin_DataGridView_Detail.Rows[0].Cells[4].Value = Checkin_DateTimePicker_Today.Value.Date;
        }
        private void LoadCustomerDataCheckinTable()
        {
            try
            {
                BS_Layer.BLCustomer bl = new BS_Layer.BLCustomer();
                Checkin_Datagridview_ListOfCustomer.DataSource = bl.LoadCustomer();
            }
            catch 
            {
                MessageBox.Show("Can not fetch data in table Customer !");
            }
        }
        private void LoadBookingList()
        {
            try
            {
                BS_Layer.BLBooking bl = new BS_Layer.BLBooking();
                var Temp = bl.FindBooking(this.Room_ID);
                if (Temp.Count > 0)
                {
                    var row = Temp.ElementAt(0);
                    Checkin_Datagridview_Booking.Rows[0].Cells[0].Value = row.BookingID;
                    Checkin_Datagridview_Booking.Rows[0].Cells[1].Value = row.CustomerID;
                    Checkin_Datagridview_Booking.Rows[0].Cells[2].Value = row.CustomerName;
                    Checkin_Datagridview_Booking.Rows[0].Cells[3].Value = row.RoomID;
                }
            }
            catch
            {
                MessageBox.Show("Can not fetch data in Booking !");
            }
        }
        #endregion

        #region  Checkout
        private void Button_Checkout_Click(object sender, EventArgs e)
        {
            tabControl_Main.TabPages.Clear();
            tabControl_Main.TabPages.Add(tabPage_CheckOut);
            InitializerCheckout();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkout_Button_Confirm_Click(object sender, EventArgs e)
        {

        }
        private void InitializerCheckout()
        {
            this.DateTimePicker_AppointmentDate.MinDate = DateTime.Today;

            LoadCustomerDataBookingTable();
            
        }
        #endregion

    }
}

