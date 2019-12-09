using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Presentation_Layer;

namespace HotelManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login loginform = new Login();
            loginform.ShowDialog();
            if (loginform != null)
            {
                if (loginform.EmployeeID != 0)
                {
                    Application.Run(new HotelManagement.Presentation_Layer.Main(loginform.EmployeeID));
                }
            }
        }
    }
}
