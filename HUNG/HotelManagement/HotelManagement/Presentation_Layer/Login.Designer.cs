namespace HotelManagement.Presentation_Layer
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Account = new System.Windows.Forms.PictureBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.rbtn_Receptionist = new System.Windows.Forms.RadioButton();
            this.label_Account = new System.Windows.Forms.Label();
            this.rbtn_Admin = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox_Account);
            this.panel1.Controls.Add(this.txb_Password);
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.txb_Account);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.rbtn_Receptionist);
            this.panel1.Controls.Add(this.label_Account);
            this.panel1.Controls.Add(this.rbtn_Admin);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 610);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox_Account
            // 
            this.pictureBox_Account.Location = new System.Drawing.Point(201, 10);
            this.pictureBox_Account.Name = "pictureBox_Account";
            this.pictureBox_Account.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_Account.TabIndex = 19;
            this.pictureBox_Account.TabStop = false;
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Password.Location = new System.Drawing.Point(40, 304);
            this.txb_Password.Multiline = true;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(424, 52);
            this.txb_Password.TabIndex = 10;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(34, 257);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(149, 31);
            this.label_Password.TabIndex = 11;
            this.label_Password.Text = "Password :";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(288, 449);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(226, 73);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txb_Account
            // 
            this.txb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Account.Location = new System.Drawing.Point(40, 166);
            this.txb_Account.Multiline = true;
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(424, 52);
            this.txb_Account.TabIndex = 9;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(11, 449);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(226, 73);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = " Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // rbtn_Receptionist
            // 
            this.rbtn_Receptionist.AutoSize = true;
            this.rbtn_Receptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Receptionist.Location = new System.Drawing.Point(288, 383);
            this.rbtn_Receptionist.Name = "rbtn_Receptionist";
            this.rbtn_Receptionist.Size = new System.Drawing.Size(149, 29);
            this.rbtn_Receptionist.TabIndex = 12;
            this.rbtn_Receptionist.TabStop = true;
            this.rbtn_Receptionist.Text = "Receptionist";
            this.rbtn_Receptionist.UseVisualStyleBackColor = true;
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Account.Location = new System.Drawing.Point(34, 119);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(87, 31);
            this.label_Account.TabIndex = 8;
            this.label_Account.Text = "User :";
            // 
            // rbtn_Admin
            // 
            this.rbtn_Admin.AutoSize = true;
            this.rbtn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Admin.Location = new System.Drawing.Point(63, 383);
            this.rbtn_Admin.Name = "rbtn_Admin";
            this.rbtn_Admin.Size = new System.Drawing.Size(162, 29);
            this.rbtn_Admin.TabIndex = 10;
            this.rbtn_Admin.TabStop = true;
            this.rbtn_Admin.Text = "Administrator ";
            this.rbtn_Admin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 613);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Account;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.RadioButton rbtn_Receptionist;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.RadioButton rbtn_Admin;
    }
}