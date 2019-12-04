using HotelManagement.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        BLRoom dbR = new BLRoom();
        int NumberTab;
        bool isCreated = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void HotelManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_Save.Enabled = false;
            txt_RoomID.Enabled = false;    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabCtrl_Room_Click(object sender, EventArgs e)
        {
        }
        public void LoadData()
        {
            if (NumberTab == 0)
            {
                dgv_Room.AutoResizeColumns();
                BLRoom dbR = new BLRoom();
                dgv_Room.DataSource = dbR.LoadRoom();
                dgv_Room_CellClick(null, null);
            }
            if(NumberTab == 1)
            {
                dgv_Customer.AutoResizeColumns();
                BLCustomer dbC = new BLCustomer();
                dgv_Customer.DataSource = dbC.LoadCustomer();
                dgv_Customer_CellClick(null, null);
            }
            if(NumberTab == 2)
            {
                dgv_RoomType.AutoResizeColumns();
                BLRoomType dbRT = new BLRoomType();
                dgv_RoomType.DataSource = dbRT.LoadRoomType();
                dgv_RoomType_CellClick(null, null);
            }
            if (NumberTab == 3)
            {
                dgv_Employee.AutoResizeColumns();
                BLEmployee dbE = new BLEmployee();
                dgv_Employee.DataSource = dbE.LoadEmployee();
                dgv_Employee_CellClick(null, null);
            }
        }

        private void dgv_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Room.CurrentCell.RowIndex;
            txt_RoomID.Text = dgv_Room.Rows[r].Cells[0].Value.ToString();
            txt_Room_RoomTypeID.Text = dgv_Room.Rows[r].Cells[1].Value.ToString();
            txt_OnFloor.Text = dgv_Room.Rows[r].Cells[2].Value.ToString();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            txt_RoomID.Clear();
            txt_Room_RoomTypeID.Clear();
            txt_OnFloor.Clear();
            isCreated = true;
            txt_RoomID.Enabled = true;
            btn_Save.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (isCreated == true)
            {
                if (NumberTab == 0)
                {
                    BLRoom blR = new BLRoom();
                    blR.CreateRoom(txt_RoomID.Text, txt_Room_RoomTypeID.Text, txt_OnFloor.Text);
                    LoadData();
                }
                if (NumberTab == 1)
                {
                    BLCustomer blC = new BLCustomer();
                    blC.CreateCustomer(txt_CustomerID.Text, txt_CustomerName.Text, txt_Customer_IdentityCard.Text, txt_Customer_PhoneNumber.Text, txt_CustomerAddress.Text);
                    LoadData();
                }
                if (NumberTab == 2)
                {
                    BLRoomType blRT = new BLRoomType();
                    blRT.CreateRoomType(txt_RoomTypeName.Text, txt_Price.Text);
                    LoadData();
                }
                if (NumberTab == 3)
                {
                    BLEmployee blE = new BLEmployee();
                    blE.CreateEmployee(txt_EmployeeID.Text, txt_EmployeeName.Text, txt_Employee_EmployeeTypeID.Text, txt_Employee_PhoneNumber.Text, txt_Employee_IdentityCard.Text, txt_PassWord.Text);
                    LoadData();
                }                       
            }                           
            else                       
            {                           
                if (NumberTab == 0)     
                {
                    BLRoom blR = new BLRoom();
                    blR.UpdateRoom(txt_RoomID.Text, txt_Room_RoomTypeID.Text, txt_OnFloor.Text);
                    LoadData();
                }
                if (NumberTab == 1)
                {
                    BLCustomer blC = new BLCustomer();
                    blC.UpdateCustomer(txt_CustomerID.Text, txt_CustomerName.Text, txt_Customer_IdentityCard.Text, txt_Customer_PhoneNumber.Text, txt_CustomerAddress.Text);
                    LoadData();
                }
                if (NumberTab == 2)
                {
                    BLRoomType blRT = new BLRoomType();
                    blRT.UpdateRoomType(txt_RoomTypeID.Text, txt_RoomTypeName.Text, txt_Price.Text);
                    LoadData();
                }
                if (NumberTab == 3)
                {
                    BLEmployee blE = new BLEmployee();
                    blE.UpdateEmployee(txt_EmployeeID.Text, txt_EmployeeName.Text, txt_Employee_EmployeeTypeID.Text, txt_Employee_PhoneNumber.Text, txt_Employee_IdentityCard.Text, txt_PassWord.Text);
                    LoadData();
                }
            }
            btn_Save.Enabled = false;
            txt_RoomID.Enabled = false;
            btn_Create.Enabled = true;
            btn_Update.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLRoom blR = new BLRoom();
            blR.UndoRoom();
            LoadData();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLRoom blR = new BLRoom();
            blR.RedoRoom();
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {            
            isCreated = false;
            btn_Save.Enabled = true;
            btn_Create.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (NumberTab == 0)
            {
                BLRoom blR = new BLRoom();
                blR.DeleteRoom(txt_RoomID.Text);
                LoadData();
            }
            if (NumberTab == 1)
            {
                BLCustomer blC = new BLCustomer();
                blC.DeleteCustomer(txt_CustomerID.Text);
                LoadData();
            }
            if (NumberTab == 2)
            {
                BLRoomType blRT = new BLRoomType();
                blRT.DeleteRoomType(txt_RoomTypeID.Text);
                LoadData();
            }
            if (NumberTab == 3)
            {
                BLEmployee blE = new BLEmployee();
                blE.DeleteEmployee(txt_EmployeeID.Text);
                LoadData();
            }
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Customer.CurrentCell.RowIndex;
            txt_CustomerID.Text = dgv_Customer.Rows[r].Cells[0].Value.ToString();
            txt_CustomerName.Text = dgv_Customer.Rows[r].Cells[1].Value.ToString();
            txt_Customer_IdentityCard.Text = dgv_Customer.Rows[r].Cells[2].Value.ToString();
            txt_Customer_PhoneNumber.Text = dgv_Customer.Rows[r].Cells[3].Value.ToString();
            txt_CustomerAddress.Text = dgv_Customer.Rows[r].Cells[4].Value.ToString();

        }

        private void TabCtrl_Customer_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (tabControl1.SelectedIndex == i)
                {
                    NumberTab = i;
                }
            }
            LoadData();
        }

        private void dgv_RoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_RoomType.CurrentCell.RowIndex;
            txt_RoomTypeID.Text = dgv_RoomType.Rows[r].Cells[0].Value.ToString();
            txt_RoomTypeName.Text = dgv_RoomType.Rows[r].Cells[1].Value.ToString();
            txt_Price.Text = dgv_RoomType.Rows[r].Cells[2].Value.ToString();
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Employee.CurrentCell.RowIndex;
            txt_EmployeeID.Text = dgv_Employee.Rows[r].Cells[0].Value.ToString();
            txt_EmployeeName.Text = dgv_Employee.Rows[r].Cells[1].Value.ToString();
            txt_Employee_EmployeeTypeID.Text = dgv_Employee.Rows[r].Cells[2].Value.ToString();
            txt_Employee_PhoneNumber.Text = dgv_Employee.Rows[r].Cells[3].Value.ToString();
            txt_Employee_IdentityCard.Text = dgv_Employee.Rows[r].Cells[4].Value.ToString();
            txt_PassWord.Text = dgv_Employee.Rows[r].Cells[5].Value.ToString();
        }
    }
}
