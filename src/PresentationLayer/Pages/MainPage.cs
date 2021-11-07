using FontAwesome.Sharp;
using PresentationLayer.Resources;
using PresentationLayer.SubPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Pages
{
    public partial class MainPage : Form
    {
        private Form _activeForm = null;
        List<IconButton> MenuButtons = new List<IconButton>();
        public MainPage()
        {
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();
            MenuButtons.Add(MenuDashboard);
            MenuButtons.Add(MenuStudents);
            MenuButtons.Add(MenuMyBooks);
            MenuButtons.Add(MenuBooks);
            MenuButtons.Add(MenuStudents);
            MenuButtons.Add(MenuSettings);
            TopBarUserDropdown.DropdownClick += userDropdown1_Click;
            PageNavigation(new Dashboard());
        }

        private void ApplyColorPalette()
        {
            MainSidebarLogo.ForeColor = ColorPalette.MainSidebarLogoColor;
            SidebarPanel.BackColor = ColorPalette.MainSidebarBackColor;
            SidebarPanel.ForeColor = ColorPalette.MainSidebarForeColor;
            MenuDashboard.ForeColor = ColorPalette.MainSidebarForeColor;
            MenuDashboard.IconColor = ColorPalette.MainSidebarForeColor;
            MenuMyBooks.ForeColor = ColorPalette.MainSidebarForeColor;
            MenuMyBooks.IconColor = ColorPalette.MainSidebarForeColor;
            MenuBooks.ForeColor = ColorPalette.MainSidebarForeColor;
            MenuBooks.IconColor = ColorPalette.MainSidebarForeColor;
            MenuStudents.ForeColor = ColorPalette.MainSidebarForeColor;
            MenuStudents.IconColor = ColorPalette.MainSidebarForeColor;
            MenuSettings.ForeColor = ColorPalette.MainSidebarForeColor;
            MenuSettings.IconColor = ColorPalette.MainSidebarForeColor;
            ContentPanel.BackColor = ColorPalette.MainContentPanelBackColor;
            TitleBarPanel.BackColor = Color.White;
            TopBarPageTitle.ForeColor = Color.FromArgb(63,64,69);
        }

        private void ApplyStrings()
        {
            MainSidebarLogo.Text = Strings.LogoText;
            MenuDashboard.Text = Strings.Dashboard;
            MenuMyBooks.Text = Strings.MyBooks;
            MenuBooks.Text = Strings.Books;
            MenuStudents.Text = Strings.Students;
            MenuSettings.Text = Strings.Settings;
            StaffMenuTitle.Text = Strings.Staff.ToUpper();
            TopBarUserDropdown.UserName.Text = "John Doe";
            TopBarUserDropdown.UserRole.Text = Strings.Student;
        }

        //Draggable frameless window 
        bool mouseDown;
        private Point offset;
        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Draggable_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - offset.X, currentScreenPosition.Y - offset.Y);
            }
        }

        private void Draggable_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //END - Draggable frameless window 

        private void PageNavigation(Form F)
        {          
            if (Helpers.CompareForms(_activeForm, F))
            {
                Helpers.OpenSubPages(ref _activeForm, ContentPanel, F);
                MenuUiActive();
                TopBarActiveTitle();
            }           
        }
  
        private void MenuUiActive()
        {
            string ButtonName = "";
            foreach (var MenuButton in MenuButtons)
            {
                ButtonName = MenuButton.Name.Substring(4, MenuButton.Name.Length-4);

                if (ButtonName == _activeForm.Text)
                {
                    MenuButton.IconColor = ColorPalette.MainSidebarMenuActiveForeColor;
                    MenuButton.ForeColor = ColorPalette.MainSidebarMenuActiveForeColor;
                    MenuButton.BackColor = ColorPalette.MainSidebarMenuActiveBackColor;
                }
                else
                {
                    MenuButton.IconColor = ColorPalette.MainSidebarForeColor;
                    MenuButton.ForeColor = ColorPalette.MainSidebarForeColor;
                    MenuButton.BackColor = ColorPalette.MainSidebarBackColor;
                }
            }
        }
        
        private void TopBarActiveTitle()
        {
            string PageTitle = Strings.Dashboard;
            if (_activeForm.Text == "Dashboard")
            {
                PageTitle = Strings.Dashboard;
            }else if (_activeForm.Text == "MyBooks")
            {
                PageTitle = Strings.MyBooks;
            }
            else if (_activeForm.Text == "Books")
            {
                PageTitle = Strings.Books;
            }
            else if (_activeForm.Text == "Students")
            {
                PageTitle = Strings.Students;
            }
            else if (_activeForm.Text == "Staffs")
            {
                PageTitle = Strings.Staffs;
            }
            else if (_activeForm.Text == "Settings")
            {
                PageTitle = Strings.Settings;
            }

            TopBarPageTitle.Text = PageTitle;
        }

        private void WindowControls(object sender, EventArgs e)
        {
            if((sender as Button).Name == "WindowExit")
            {
                Helpers.CloseApplication();
            }else if ((sender as Button).Name == "WindowMaximize")
            {
                Helpers.MaximizeWindowToggle(this);
            }else if ((sender as Button).Name == "WindowMinimize")
            {
                Helpers.MinimizeWindow(this);
            }
        }

        private void MenuHandler(object sender, EventArgs e)
        {
            Form SubPage;
            if ((sender as Button).Name == "MenuDashboard")
            {
                SubPage = new Dashboard();   
            }else if((sender as Button).Name == "MenuMyBooks")
            {
                SubPage = new MyBooks();
            }
            else if ((sender as Button).Name == "MenuBooks")
            {
                SubPage = new Books();
            }
            else if ((sender as Button).Name == "MenuStudents")
            {
                SubPage = new Students();
            }
            else if ((sender as Button).Name == "MenuSettings")
            {
                SubPage = new Settings();
            }
            else
            {
                SubPage = new Dashboard();
            }

            PageNavigation(SubPage);
        }

        private void userDropdown1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            LoginPage LoginForm = new LoginPage();
            Helpers.ChangePage(this, LoginForm);
        }
    }
}
