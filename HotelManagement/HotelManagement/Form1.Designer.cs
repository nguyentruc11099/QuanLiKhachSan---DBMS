namespace HotelManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCtrl_Room = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Room_RoomTypeID = new System.Windows.Forms.TextBox();
            this.txt_OnFloor = new System.Windows.Forms.TextBox();
            this.txt_RoomID = new System.Windows.Forms.TextBox();
            this.dgv_Room = new System.Windows.Forms.DataGridView();
            this.TabCtrl_Customer = new System.Windows.Forms.TabPage();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.txt_Customer_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Customer_IdentityCard = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.TabCtrl_RoomType = new System.Windows.Forms.TabPage();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_RoomTypeName = new System.Windows.Forms.TextBox();
            this.txt_RoomTypeID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_RoomType = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabCtrl_Employee = new System.Windows.Forms.TabPage();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.txt_Employee_EmployeeTypeID = new System.Windows.Forms.TextBox();
            this.txt_Employee_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Employee_IdentityCard = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabCtrl_Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).BeginInit();
            this.TabCtrl_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.TabCtrl_RoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomType)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.TabCtrl_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCtrl_Room);
            this.tabControl1.Controls.Add(this.TabCtrl_Customer);
            this.tabControl1.Controls.Add(this.TabCtrl_RoomType);
            this.tabControl1.Controls.Add(this.TabCtrl_Employee);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 549);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabCtrl_Room
            // 
            this.TabCtrl_Room.Controls.Add(this.label3);
            this.TabCtrl_Room.Controls.Add(this.label2);
            this.TabCtrl_Room.Controls.Add(this.label1);
            this.TabCtrl_Room.Controls.Add(this.txt_Room_RoomTypeID);
            this.TabCtrl_Room.Controls.Add(this.txt_OnFloor);
            this.TabCtrl_Room.Controls.Add(this.txt_RoomID);
            this.TabCtrl_Room.Controls.Add(this.dgv_Room);
            this.TabCtrl_Room.Location = new System.Drawing.Point(4, 22);
            this.TabCtrl_Room.Name = "TabCtrl_Room";
            this.TabCtrl_Room.Padding = new System.Windows.Forms.Padding(3);
            this.TabCtrl_Room.Size = new System.Drawing.Size(995, 523);
            this.TabCtrl_Room.TabIndex = 0;
            this.TabCtrl_Room.Text = "Room";
            this.TabCtrl_Room.UseVisualStyleBackColor = true;
            this.TabCtrl_Room.Click += new System.EventHandler(this.TabCtrl_Room_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RoomTypeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OnFloor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RoomID";
            // 
            // txt_Room_RoomTypeID
            // 
            this.txt_Room_RoomTypeID.Location = new System.Drawing.Point(124, 72);
            this.txt_Room_RoomTypeID.Name = "txt_Room_RoomTypeID";
            this.txt_Room_RoomTypeID.Size = new System.Drawing.Size(54, 20);
            this.txt_Room_RoomTypeID.TabIndex = 4;
            // 
            // txt_OnFloor
            // 
            this.txt_OnFloor.Location = new System.Drawing.Point(124, 43);
            this.txt_OnFloor.Name = "txt_OnFloor";
            this.txt_OnFloor.Size = new System.Drawing.Size(54, 20);
            this.txt_OnFloor.TabIndex = 3;
            this.txt_OnFloor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_RoomID
            // 
            this.txt_RoomID.Location = new System.Drawing.Point(124, 12);
            this.txt_RoomID.Name = "txt_RoomID";
            this.txt_RoomID.Size = new System.Drawing.Size(54, 20);
            this.txt_RoomID.TabIndex = 2;
            // 
            // dgv_Room
            // 
            this.dgv_Room.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Room.Location = new System.Drawing.Point(15, 115);
            this.dgv_Room.Name = "dgv_Room";
            this.dgv_Room.Size = new System.Drawing.Size(960, 400);
            this.dgv_Room.TabIndex = 0;
            this.dgv_Room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Room_CellClick);
            // 
            // TabCtrl_Customer
            // 
            this.TabCtrl_Customer.Controls.Add(this.txt_CustomerAddress);
            this.TabCtrl_Customer.Controls.Add(this.txt_Customer_PhoneNumber);
            this.TabCtrl_Customer.Controls.Add(this.txt_Customer_IdentityCard);
            this.TabCtrl_Customer.Controls.Add(this.txt_CustomerName);
            this.TabCtrl_Customer.Controls.Add(this.txt_CustomerID);
            this.TabCtrl_Customer.Controls.Add(this.label8);
            this.TabCtrl_Customer.Controls.Add(this.label7);
            this.TabCtrl_Customer.Controls.Add(this.label6);
            this.TabCtrl_Customer.Controls.Add(this.label5);
            this.TabCtrl_Customer.Controls.Add(this.label4);
            this.TabCtrl_Customer.Controls.Add(this.dgv_Customer);
            this.TabCtrl_Customer.Location = new System.Drawing.Point(4, 22);
            this.TabCtrl_Customer.Name = "TabCtrl_Customer";
            this.TabCtrl_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.TabCtrl_Customer.Size = new System.Drawing.Size(995, 523);
            this.TabCtrl_Customer.TabIndex = 1;
            this.TabCtrl_Customer.Text = "Customer";
            this.TabCtrl_Customer.UseVisualStyleBackColor = true;
            this.TabCtrl_Customer.Click += new System.EventHandler(this.TabCtrl_Customer_Click);
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.Location = new System.Drawing.Point(507, 50);
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerAddress.TabIndex = 19;
            // 
            // txt_Customer_PhoneNumber
            // 
            this.txt_Customer_PhoneNumber.Location = new System.Drawing.Point(507, 18);
            this.txt_Customer_PhoneNumber.Name = "txt_Customer_PhoneNumber";
            this.txt_Customer_PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_Customer_PhoneNumber.TabIndex = 18;
            // 
            // txt_Customer_IdentityCard
            // 
            this.txt_Customer_IdentityCard.Location = new System.Drawing.Point(104, 79);
            this.txt_Customer_IdentityCard.Name = "txt_Customer_IdentityCard";
            this.txt_Customer_IdentityCard.Size = new System.Drawing.Size(100, 20);
            this.txt_Customer_IdentityCard.TabIndex = 17;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(104, 47);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerName.TabIndex = 16;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(104, 14);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CustomerAddress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PhoneNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IdentityCard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CustomerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CustomerID";
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(15, 115);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.Size = new System.Drawing.Size(960, 400);
            this.dgv_Customer.TabIndex = 9;
            this.dgv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellClick);
            // 
            // TabCtrl_RoomType
            // 
            this.TabCtrl_RoomType.Controls.Add(this.txt_Price);
            this.TabCtrl_RoomType.Controls.Add(this.txt_RoomTypeName);
            this.TabCtrl_RoomType.Controls.Add(this.txt_RoomTypeID);
            this.TabCtrl_RoomType.Controls.Add(this.label11);
            this.TabCtrl_RoomType.Controls.Add(this.label10);
            this.TabCtrl_RoomType.Controls.Add(this.label9);
            this.TabCtrl_RoomType.Controls.Add(this.dgv_RoomType);
            this.TabCtrl_RoomType.Location = new System.Drawing.Point(4, 22);
            this.TabCtrl_RoomType.Name = "TabCtrl_RoomType";
            this.TabCtrl_RoomType.Padding = new System.Windows.Forms.Padding(3);
            this.TabCtrl_RoomType.Size = new System.Drawing.Size(995, 523);
            this.TabCtrl_RoomType.TabIndex = 2;
            this.TabCtrl_RoomType.Text = "RoomType";
            this.TabCtrl_RoomType.UseVisualStyleBackColor = true;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(100, 81);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 6;
            // 
            // txt_RoomTypeName
            // 
            this.txt_RoomTypeName.Location = new System.Drawing.Point(100, 47);
            this.txt_RoomTypeName.Name = "txt_RoomTypeName";
            this.txt_RoomTypeName.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomTypeName.TabIndex = 5;
            // 
            // txt_RoomTypeID
            // 
            this.txt_RoomTypeID.Location = new System.Drawing.Point(100, 12);
            this.txt_RoomTypeID.Name = "txt_RoomTypeID";
            this.txt_RoomTypeID.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomTypeID.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "RoomTypeID";
            // 
            // dgv_RoomType
            // 
            this.dgv_RoomType.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_RoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RoomType.Location = new System.Drawing.Point(15, 115);
            this.dgv_RoomType.Name = "dgv_RoomType";
            this.dgv_RoomType.Size = new System.Drawing.Size(960, 400);
            this.dgv_RoomType.TabIndex = 0;
            this.dgv_RoomType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RoomType_CellClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(161, 656);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(293, 612);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(293, 656);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(32, 656);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(32, 612);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(161, 612);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // TabCtrl_Employee
            // 
            this.TabCtrl_Employee.Controls.Add(this.txt_PassWord);
            this.TabCtrl_Employee.Controls.Add(this.txt_Employee_IdentityCard);
            this.TabCtrl_Employee.Controls.Add(this.txt_Employee_PhoneNumber);
            this.TabCtrl_Employee.Controls.Add(this.txt_Employee_EmployeeTypeID);
            this.TabCtrl_Employee.Controls.Add(this.txt_EmployeeName);
            this.TabCtrl_Employee.Controls.Add(this.txt_EmployeeID);
            this.TabCtrl_Employee.Controls.Add(this.label17);
            this.TabCtrl_Employee.Controls.Add(this.label16);
            this.TabCtrl_Employee.Controls.Add(this.label15);
            this.TabCtrl_Employee.Controls.Add(this.label14);
            this.TabCtrl_Employee.Controls.Add(this.label13);
            this.TabCtrl_Employee.Controls.Add(this.label12);
            this.TabCtrl_Employee.Controls.Add(this.dgv_Employee);
            this.TabCtrl_Employee.Location = new System.Drawing.Point(4, 22);
            this.TabCtrl_Employee.Name = "TabCtrl_Employee";
            this.TabCtrl_Employee.Padding = new System.Windows.Forms.Padding(3);
            this.TabCtrl_Employee.Size = new System.Drawing.Size(995, 523);
            this.TabCtrl_Employee.TabIndex = 3;
            this.TabCtrl_Employee.Text = "Employee";
            this.TabCtrl_Employee.UseVisualStyleBackColor = true;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(15, 115);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.Size = new System.Drawing.Size(960, 400);
            this.dgv_Employee.TabIndex = 0;
            this.dgv_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "EmployeeID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "EmployeeName";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "EmployeeTypeID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "PhoneNumber";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(274, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "IdentityCard";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(274, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "PassWord";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(109, 12);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txt_EmployeeID.TabIndex = 7;
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.Location = new System.Drawing.Point(109, 46);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txt_EmployeeName.TabIndex = 8;
            // 
            // txt_Employee_EmployeeTypeID
            // 
            this.txt_Employee_EmployeeTypeID.Location = new System.Drawing.Point(109, 78);
            this.txt_Employee_EmployeeTypeID.Name = "txt_Employee_EmployeeTypeID";
            this.txt_Employee_EmployeeTypeID.Size = new System.Drawing.Size(100, 20);
            this.txt_Employee_EmployeeTypeID.TabIndex = 9;
            // 
            // txt_Employee_PhoneNumber
            // 
            this.txt_Employee_PhoneNumber.Location = new System.Drawing.Point(355, 12);
            this.txt_Employee_PhoneNumber.Name = "txt_Employee_PhoneNumber";
            this.txt_Employee_PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_Employee_PhoneNumber.TabIndex = 10;
            // 
            // txt_Employee_IdentityCard
            // 
            this.txt_Employee_IdentityCard.Location = new System.Drawing.Point(355, 46);
            this.txt_Employee_IdentityCard.Name = "txt_Employee_IdentityCard";
            this.txt_Employee_IdentityCard.Size = new System.Drawing.Size(100, 20);
            this.txt_Employee_IdentityCard.TabIndex = 11;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(355, 78);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(100, 20);
            this.txt_PassWord.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 709);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Create);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HotelManagement";
            this.Load += new System.EventHandler(this.HotelManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabCtrl_Room.ResumeLayout(false);
            this.TabCtrl_Room.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).EndInit();
            this.TabCtrl_Customer.ResumeLayout(false);
            this.TabCtrl_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.TabCtrl_RoomType.ResumeLayout(false);
            this.TabCtrl_RoomType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomType)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabCtrl_Employee.ResumeLayout(false);
            this.TabCtrl_Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCtrl_Room;
        private System.Windows.Forms.DataGridView dgv_Room;
        private System.Windows.Forms.TabPage TabCtrl_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Room_RoomTypeID;
        private System.Windows.Forms.TextBox txt_OnFloor;
        private System.Windows.Forms.TextBox txt_RoomID;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.TextBox txt_CustomerAddress;
        private System.Windows.Forms.TextBox txt_Customer_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Customer_IdentityCard;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.TabPage TabCtrl_RoomType;
        private System.Windows.Forms.DataGridView dgv_RoomType;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_RoomTypeName;
        private System.Windows.Forms.TextBox txt_RoomTypeID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TabCtrl_Employee;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_Employee_IdentityCard;
        private System.Windows.Forms.TextBox txt_Employee_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Employee_EmployeeTypeID;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Label label17;
    }
}

