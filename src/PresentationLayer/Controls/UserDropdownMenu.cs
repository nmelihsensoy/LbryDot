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
using PresentationLayer.Resources;

namespace PresentationLayer.Controls
{
    public partial class UserDropdownMenu : UserControl
    {
        public event EventHandler LogoutClick;
        public string CurrencySymbol = "";

        private void LogoutClickEvent(object sender, EventArgs e)
        {
            Helpers.SendEvent(LogoutClick, sender, e);
        }

        public UserDropdownMenu()
        {
            InitializeComponent();
            Panel_UserLogout_Splitter.Top = Button_UserLogout.Top - Panel_UserLogout_Splitter.Height - 1;
            ApplyStrings();
        }

        private void ApplyStrings()
        {
            Button_UserLogout.Text = Strings.Logout;
        }

        public void SetUser(StaffModel Model)
        {
            Text_UserMail.Text = Model.staff_email;
            Text_User_ID.Text = "#" + Model.staff_id.ToString();
            ApplyStyleForStaff();
        }

        public void SetUser(StudentModel Model)
        {
            Text_UserMail.Text = Model.student_email;
            Text_User_ID.Text = "#" + Model.student_number.ToString();
            label1.Text = Model.total_fine.ToString() + CurrencySymbol + " " + Strings.TotalFine;
            label2.Text = Model.active_fine.ToString() + CurrencySymbol + " " + Strings.ActiveFine;
        }

        private void ApplyStyleForStaff()
        {
            iconPictureBox1.Visible = false;
            label1.Visible = false;
            iconPictureBox2.Visible = false;
            label2.Visible = false;
            this.Height -= iconPictureBox1.Height + iconPictureBox2.Height + (Icon_UserID.Top - Icon_UserMail.Bottom) * 2;
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
