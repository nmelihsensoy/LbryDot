using FontAwesome.Sharp;
using PresentationLayer.Dialogs;
using PresentationLayer.Resources;
using PresentationLayer.SubPages;
using PresentationLayer.Controls;
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
using BusinessLogicLayer;

namespace PresentationLayer.Pages
{
    public partial class MainPage : Form
    {
        private Form _activeForm = null;
        List<IconButton> MenuButtons = new List<IconButton>();
        private CustomAppContext AppContext;

        public MainPage(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            ApplyColorPalette();
            ApplyStrings();
            CreateMenuList();
            SetDropdownForLoggedUser();
            ShowStaffMenu();
            PageNavigation(new Dashboard(AppContext));
            //userDropdownContent1.Left = userDropdown_TopBar.Left;
            //userDropdownContent1.Top = userDropdown_TopBar.Bottom;
        }

        private void ApplyColorPalette()
        {
            Text_Logo.ForeColor = ColorPalette.MainSidebarLogoColor;
            Panel_Sidebar.BackColor = ColorPalette.MainSidebarBackColor;
            Panel_Sidebar.ForeColor = ColorPalette.MainSidebarForeColor;
            Button_MenuDashboard.ForeColor = ColorPalette.MainSidebarForeColor;
            Button_MenuDashboard.IconColor = ColorPalette.MainSidebarForeColor;
            Button_MenuMyBooks.ForeColor = ColorPalette.MainSidebarForeColor;
            Button_MenuMyBooks.IconColor = ColorPalette.MainSidebarForeColor;
            Button_MenuBooks.ForeColor = ColorPalette.MainSidebarForeColor;
            Button_MenuBooks.IconColor = ColorPalette.MainSidebarForeColor;
            Button_MenuStudents.ForeColor = ColorPalette.MainSidebarForeColor;
            Button_MenuStudents.IconColor = ColorPalette.MainSidebarForeColor;
            Button_MenuSettings.ForeColor = ColorPalette.MainSidebarForeColor;
            Button_MenuSettings.IconColor = ColorPalette.MainSidebarForeColor;
            Panel_Content.BackColor = ColorPalette.MainContentPanelBackColor;
            Panel_TitleBar.BackColor = ColorPalette.TopBarColor;
            Text_TitleBarTitle.ForeColor = ColorPalette.TopBarTitleForeColor;
            Input_SearchBox.ForeColor = ColorPalette.SearchBarForeColor;
            //Splitter_UserDropdown_Panel_Left.BackColor = ColorPalette.SearchBarBorderColor;
            //Splitter_UserDropdown_Panel_Right.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxLeft.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxRight.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxTop.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxBottom.BackColor = ColorPalette.SearchBarBorderColor;
            Button_AddBook.BackColor = ColorPalette.TopBarAddBookBackColor;
            Button_AddBook.ForeColor = ColorPalette.TopBarAddBookForeColor;
        }

        private void ApplyStrings()
        {
            Text_Logo.Text = Strings.LogoText;
            Button_MenuDashboard.Text = Strings.Dashboard;
            Button_MenuMyBooks.Text = Strings.MyBooks;
            Button_MenuBooks.Text = Strings.Books;
            Button_MenuStudents.Text = Strings.Students;
            Button_MenuSettings.Text = Strings.Settings;
            //Button_UserLogout.Text = Strings.Logout;
            Text_StaffMenuTitle.Text = Strings.Staff.ToUpper();
            Input_SearchBox.Text = Strings.Search;
        }

        private void CreateMenuList()
        {
            MenuButtons.Add(Button_MenuDashboard);
            MenuButtons.Add(Button_MenuStudents);
            MenuButtons.Add(Button_MenuMyBooks);
            MenuButtons.Add(Button_MenuBooks);
            MenuButtons.Add(Button_MenuStudents);
            MenuButtons.Add(Button_MenuSettings);
        }

        private void ShowStaffMenu()
        {
            if (AppContext.GetUserType() == UserType.Staff || AppContext.GetUserType() == UserType.Admin)
            {
                Panel_StaffMenu.Visible = true;
                Button_MenuMyBooks.Visible = false;
                Button_MenuBooks.Top = Button_MenuDashboard.Bottom;
            }
        }

        private void SetDropdownForLoggedUser()
        {
            userDropdown_TopBar.DropdownClick += userDropdown1_Click;
            userDropdown_TopBar.SetMenu(userDropdownMenu1);

            userDropdownMenu1.CurrencySymbol = AppContext.AppSettings.currency_symbol;

            if (AppContext.GetUserType() == UserType.Student)
            {
                userDropdown_TopBar.SetUser(AppContext.GetLoggedStudent());
            }
            else
            {
                userDropdown_TopBar.SetUser(AppContext.GetLoggedStaff());
            }
        }

        //Draggable frameless window 
        bool mouseDown;
        private Point offset;

        //Save the offset point
        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        //Set a new form location using the saved offset point when triggered.
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

        //Navigation between the subpages
        public void PageNavigation(Form F)
        {          
            if (Helpers.CompareForms(_activeForm, F))
            {
                Helpers.OpenSubPages(ref _activeForm, Panel_Content, F);
                MenuUiActive();
                TopBarActiveTitle();
            }           
        }

        //To change menu style by current active page
        //Sub Page names and the menu button names after the prefix 'Button_Menu' must be same.
        private void MenuUiActive()
        {
            string ButtonName = "";
            foreach (var MenuButton in MenuButtons)
            {
                //Button_MenuMyBooks
                //Seperating 'Button_Menu' prefix from button names.
                ButtonName = MenuButton.Name.Substring(11, MenuButton.Name.Length-11);
                
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

        //To change page title by current active page
        private void TopBarActiveTitle()
        {
            AppySearchDefaultStyle();
            if (_activeForm.Text == "Books")
            {
                Panel_SearchBox.Visible = true;
                if(AppContext.GetUserType() == UserType.Staff || AppContext.GetUserType() == UserType.Admin)
                {
                    Button_AddBook.IconChar = IconChar.BookMedical;
                    Button_AddBook.Visible = true;
                }              
            }
            else if(_activeForm.Text == "Students")
            {
                Panel_SearchBox.Visible = true;
                if (AppContext.GetUserType() == UserType.Staff || AppContext.GetUserType() == UserType.Admin)
                {
                    Button_AddBook.IconChar = IconChar.UserPlus;
                    Button_AddBook.Visible = true;
                }
            }
            else
            {
                Panel_SearchBox.Visible = false;
                Button_AddBook.Visible = false;
            }
            
            string PageTitle = Strings.Dashboard;
            if (_activeForm.Text == "MyBooks")
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

            Text_TitleBarTitle.Text = PageTitle;
        }

        private void WindowControls(object sender, EventArgs e)
        {
            if((sender as Button).Name == "Button_WindowClose")
            {
                Helpers.CloseApplication();
            }
            else if ((sender as Button).Name == "Button_WindowMax")
            {
                Helpers.MaximizeWindowToggle(this);
            }
            else if ((sender as Button).Name == "Button_WindowMin")
            {
                Helpers.MinimizeWindow(this);
            }
        }

        //Changing Sub Page based on the clicked menu button.
        private void MenuHandler(object sender, EventArgs e)
        {
            Form SubPage;
            if ((sender as Button).Name == "Button_MenuDash")
            {
                SubPage = new Dashboard(AppContext);   
            }else if((sender as Button).Name == "Button_MenuMyBooks")
            {
                SubPage = new MyBooks(AppContext);
            }
            else if ((sender as Button).Name == "Button_MenuBooks")
            {
                SubPage = new Books(AppContext);
            }
            else if ((sender as Button).Name == "Button_MenuStudents")
            {
                SubPage = new Students(AppContext);
            }
            else if ((sender as Button).Name == "Button_MenuSettings")
            {
                SubPage = new Settings(AppContext);
            }
            else
            {
                SubPage = new Dashboard(AppContext);
            }

            PageNavigation(SubPage);
        }

        private void userDropdown1_Click(object sender, EventArgs e)
        {
            if (sender is Button && (sender as Button).Name == "Button_UserLogout")
            {
                LoginPage LoginForm = new LoginPage(AppContext);
                Helpers.ChangePage(this, LoginForm);
                this.Dispose();
            }
            else
            {
                if (AppContext.GetUserType() == UserType.Student)
                {
                    userDropdownMenu1.SetUser(AppContext.GetLoggedStudent());
                }
            }
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            Form InfoDialog = new Info();
            InfoDialog.ShowDialog();
        }

        private void ıconButton1_MouseHover(object sender, EventArgs e)
        {
            Tooltip_AddBook.Show("Add Book", Button_AddBook);
        }

        private void Button_AddBook_Click(object sender, EventArgs e)
        {
            if (_activeForm.Text == "Students")
            {
                (_activeForm as Students).AddButtonClick(sender, e);
            }
            else if (_activeForm.Text == "Books")
            {
                (_activeForm as Books).AddButtonClick(sender, e);
            }
        }

        private void ApplySearchActiveStyle()
        {
            Input_SearchBox.Font = new Font(Input_SearchBox.Font, FontStyle.Bold);
            Label_Button_Search_X.Visible = true;
            Splitter_SearchBoxLeft.BackColor = ColorPalette.MainPageSearchBarActiveColor;
            Splitter_SearchBoxRight.BackColor = ColorPalette.MainPageSearchBarActiveColor;
            Splitter_SearchBoxTop.BackColor = ColorPalette.MainPageSearchBarActiveColor;
            Splitter_SearchBoxBottom.BackColor = ColorPalette.MainPageSearchBarActiveColor;
        }

        private void AppySearchDefaultStyle()
        {
            Input_SearchBox.Text = Strings.Search;
            Input_SearchBox.ForeColor = ColorPalette.SearchBarForeColor;
            Input_SearchBox.Font = new Font(Input_SearchBox.Font, FontStyle.Italic);
            Label_Button_Search_X.Visible = false;
            Splitter_SearchBoxLeft.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxRight.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxTop.BackColor = ColorPalette.SearchBarBorderColor;
            Splitter_SearchBoxBottom.BackColor = ColorPalette.SearchBarBorderColor;
        }

        private void Input_SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true; //prevent beep sound
                if (!String.IsNullOrEmpty(Input_SearchBox.Text)) {

                    ApplySearchActiveStyle();
                    //Input_SearchBox.Parent.Focus();
                    ActiveControl = null;

                    if (_activeForm.Text == "Students")
                    {
                        (_activeForm as Students).SearchStudent(sender, Input_SearchBox.Text, e);
                    }
                    else if (_activeForm.Text == "Books")
                    {
                        (_activeForm as Books).SearchBook(sender, Input_SearchBox.Text, e);
                    }
                }
                else
                {
                    Input_SearchBox_Clear();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = e.SuppressKeyPress = true;
                Input_SearchBox_Clear();
            }
        }

        private void Input_SearchBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Input_SearchBox.Text) || Input_SearchBox.Text == Strings.Search)
            {
                Input_SearchBox.Clear();
                Input_SearchBox.Font = new Font(Input_SearchBox.Font, FontStyle.Regular);
                Input_SearchBox.ForeColor = ColorPalette.MainPageSearchBarForeColor;
                Label_Button_Search_X.Visible = true;
            }
        }

        private void Label_Button_Search_X_Click(object sender, EventArgs e)
        {
            Input_SearchBox_Clear();
        }

        public void Input_SearchBox_Clear()
        {
            AppySearchDefaultStyle();
            ActiveControl = null;

            if (_activeForm.Text == "Students")
            {
                (_activeForm as Students).SearchReset();
            }
            else if (_activeForm.Text == "Books")
            {
                (_activeForm as Books).SearchReset();
            }
        }
    }
}
