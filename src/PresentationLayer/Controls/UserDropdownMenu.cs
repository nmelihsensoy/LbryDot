using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace PresentationLayer.Controls
{
    public partial class UserDropdownMenu : UserControl
    {
        public event EventHandler LogoutClick;
        private void LogoutClickEvent(object sender, EventArgs e)
        {
            Helpers.SendEvent(LogoutClick, sender, e);
        }

        public UserDropdownMenu()
        {
            InitializeComponent();
            Panel_UserLogout_Splitter.Top = Button_UserLogout.Top - Panel_UserLogout_Splitter.Height - 1;
        }

        public void SetUser(StaffModel Model)
        {
            Text_UserMail.Text = Model.staff_email;
            Text_User_ID.Text = Model.staff_id.ToString();
        }

        public void SetUser(StudentModel Model)
        {
            Text_UserMail.Text = Model.student_email;
            Text_User_ID.Text = Model.student_number.ToString();
        }

        public void ToggleMenu()
        {
            if (this.Visible == true)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }

    }
}
