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
using Entities;

namespace PresentationLayer.Controls
{
    public partial class UserDropdown : UserControl
    {
        private UserDropdownMenu _menu = null;
        public event EventHandler DropdownClick;
        public bool CustomMenu = false;

        private void DropdownClickEvent(object sender, EventArgs e)
        {
            if (!CustomMenu && _menu != null)
            {
                _menu.ToggleMenu();
            }

            Helpers.SendEvent(DropdownClick, this, e);
        }

        private void MenuClickEvent(object sender, EventArgs e)
        {
            Helpers.SendEvent(DropdownClick, sender, e);
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

        public void SetUser(StaffModel Model)
        {
            if(Model.staff_type == UserType.Admin)
            {
                Text_UserRole.Text = Strings.AdminRole;
            }else
            {
                Text_UserRole.Text = Strings.StaffRole;
            }
            Text_UserName.Text = Model.staff_name;
            Image_UserAvatar.Image = Helpers.ConvertByteToImage(Model.staff_avatar);
            if(_menu != null)
            {
                _menu.SetUser(Model);
            }
        }

        public void SetUser(StudentModel Model)
        {
            Text_UserRole.Text = Strings.StudentRole;
            Text_UserName.Text = Model.student_name;
            Image_UserAvatar.Image = Helpers.ConvertByteToImage(Model.student_avatar);
            if (_menu != null)
            {
                _menu.SetUser(Model);
            }
        }

        public void SetMenu(UserDropdownMenu Menu)
        {
            _menu = Menu;
            Menu.LogoutClick += MenuClickEvent;
        }

    }
}
