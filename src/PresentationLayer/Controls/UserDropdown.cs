using PresentationLayer.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controls
{
    public enum UserType
    {
        Admin = 0,
        Staff = 1,
        Student = 2
    }

    public partial class UserDropdown : UserControl
    {
        public event EventHandler DropdownClick;
        private void DropdownClickEvent(object sender, EventArgs e)
        {
            var eventHandler = this.DropdownClick;

            if (eventHandler != null)
            {
                eventHandler(this, e); //sending parent control object
            }
        }
        public UserDropdown()
        {
            InitializeComponent();
            ApplyColorPalette();
            Helpers.MakePictureBoxCircle(Image_UserAvatar);
        }

        private void ApplyColorPalette()
        {
            Panel_Container.BackColor = ColorPalette.UserDropdownBackColor;
            Panel_Container.ForeColor = ColorPalette.UserDropdownForeColor;
            Text_UserRole.ForeColor = ColorPalette.UserDropdownRoleForeColor;
        }

        public Image Avatar
        {
            set { Image_UserAvatar.Image = value; }
        }

        public UserType Role
        {
            set {
                if (value == UserType.Admin)
                {
                    Text_UserRole.Text = Strings.AdminRole;
                }else if (value == UserType.Staff)
                {
                    Text_UserRole.Text = Strings.StaffRole;
                }
                else if (value == UserType.Student)
                {
                    Text_UserRole.Text = Strings.StudentRole;
                }
            }
        }

        public string UserFullName
        {
            set { Text_UserName.Text = value; }
        }
    }
}
