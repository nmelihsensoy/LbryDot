using Entities;
using PresentationLayer.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.Services;

namespace PresentationLayer.Pages
{
    public partial class LoginPage : Form
    {
        string trEmailPlaceholder = Helpers.GetValueFromCulture("LoginEmailPlaceholderText", "tr");
        string enEmailPlaceholder = Helpers.GetValueFromCulture("LoginEmailPlaceholderText", "");
        string trPassPlaceholder = Helpers.GetValueFromCulture("LoginPassPlaceholderText", "tr");
        string enPassPlaceholder = Helpers.GetValueFromCulture("LoginPassPlaceholderText", "");
        private CustomAppContext AppContext;

        public LoginPage(CustomAppContext _appContext)
        {
            Helpers.ChangeLanguage();
            InitializeComponent();
            AppContext = _appContext;
            ApplyColorPalette();
            ApplyStrings();         
            Panel_Pass_Line.Height = 1;
            Panel_Input_Email.Height = 1;            
        }

        private void ApplyStrings()
        {
            Text_Logo.Text = Strings.LogoText;
            //Handling if user changed language after entered credentials.
            if (Input_Email.Text.Trim() == string.Empty || Input_Email.Text == trEmailPlaceholder || Input_Email.Text == enEmailPlaceholder)
            {
                //Set Email placeholder text if user changed language before entering Email.
                Input_Email.Text = Strings.LoginEmailPlaceholderText;
            }
            if (Input_Password.Text.Trim() == string.Empty || Input_Password.Text == trPassPlaceholder || Input_Password.Text == enPassPlaceholder)
            {
                //Set Password placeholder text if user changed language before entering password.
                Input_Password.Text = Strings.LoginPassPlaceholderText;
            }
            ComboBox_LoginType.Items.Clear();
            ComboBox_LoginType.Items.Add(Strings.LoginUserTypeStudent);
            ComboBox_LoginType.Items.Add(Strings.LoginUserTypeStaff);
            ComboBox_LoginType.SelectedIndex = 0;
            Button_Execute_Login.Text = Strings.LoginExecuteButtonText;        
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorPalette.LoginBackColor;
            Panel_Container.BackColor = ColorPalette.LoginBackColor;
            Text_Logo.ForeColor = ColorPalette.LoginForeColor;  
            Input_Email.BackColor = ColorPalette.LoginFormElementsBackColor;
            Input_Email.ForeColor = ColorPalette.LoginPlaceholderColor;
            Panel_Input_Email.BackColor = ColorPalette.LoginForeColor;
            Icon_Input_Email.BackColor = ColorPalette.LoginFormElementsBackColor;
            Icon_Input_Email.ForeColor = ColorPalette.LoginForeColor;   
            Input_Password.BackColor = ColorPalette.LoginFormElementsBackColor;
            Input_Password.ForeColor = ColorPalette.LoginPlaceholderColor;
            Panel_Pass_Line.BackColor = ColorPalette.LoginForeColor;
            Icon_Input_Pass.BackColor = ColorPalette.LoginFormElementsBackColor;
            Icon_Input_Pass.ForeColor = ColorPalette.LoginForeColor;      
            ComboBox_LoginType.BackColor = ColorPalette.LoginFormElementsBackColor;
            ComboBox_LoginType.ForeColor = ColorPalette.LoginForeColor;       
            Button_Execute_Login.BackColor = ColorPalette.LoginFormElementsBackColor;
            Button_Execute_Login.ForeColor = ColorPalette.LoginForeColor;
            Button_Lang_EN.ForeColor = ColorPalette.LoginForeColor;
            Button_Lang_TR.ForeColor = ColorPalette.LoginForeColor;
            Seperator_Lang_Buttons.ForeColor = ColorPalette.LoginForeColor;
            Button_WindowClose.ForeColor = ColorPalette.LoginForeColor;
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

        private void Lang_EN_Click(object sender, EventArgs e)
        {
            int StoreState = ComboBox_LoginType.SelectedIndex;
            Helpers.ChangeLanguage();
            ApplyStrings();
            ComboBox_LoginType.SelectedIndex = StoreState;
        }

        private void Lang_TR_Click(object sender, EventArgs e)
        {
            int StoreState = ComboBox_LoginType.SelectedIndex;
            Helpers.ChangeLanguage("tr");
            ApplyStrings();
            ComboBox_LoginType.SelectedIndex = StoreState;
        }    

        private void Email_Input_Enter(object sender, EventArgs e)
        {
            //When typing in email box, clear placeholder text and set active color
            if (Input_Email.Text.Trim() == trEmailPlaceholder || Input_Email.Text.Trim() == enEmailPlaceholder)
            {
                Input_Email.Clear();
            }

            Panel_Input_Email.BackColor = ColorPalette.LoginFormElementsActiveColor;
            Icon_Input_Email.ForeColor = ColorPalette.LoginFormElementsActiveColor;
        }

        private void Email_Input_Leave(object sender, EventArgs e)
        {
            //When typing is finished and typed text is empty, change empty text with the placeholder text  
            if(Input_Email.Text.Trim() == string.Empty)
            {
                Input_Email.Text = Strings.LoginEmailPlaceholderText;
            }
            Panel_Input_Email.BackColor = ColorPalette.LoginForeColor;
            Icon_Input_Email.ForeColor = ColorPalette.LoginForeColor;
        }

        private void Password_Input_Enter(object sender, EventArgs e)
        {
            //When typing in password box, clear placeholder text and set active color
            if (Input_Password.Text.Trim() == trPassPlaceholder || Input_Password.Text.Trim() == enPassPlaceholder)
            {
                Input_Password.Clear();
            }

            Input_Password.PasswordChar = '*';
            Panel_Pass_Line.BackColor = ColorPalette.LoginFormElementsActiveColor;
            Icon_Input_Pass.ForeColor = ColorPalette.LoginFormElementsActiveColor;
        }

        private void Password_Input_Leave(object sender, EventArgs e)
        {
            //When typing is finished and typed text is empty, change empty text with the placeholder text  
            if (Input_Password.Text.Trim() == string.Empty)
            {
                Input_Password.PasswordChar = '\0'; 
                Input_Password.Text = Strings.LoginPassPlaceholderText;
            }

            Panel_Pass_Line.BackColor = ColorPalette.LoginForeColor;
            Icon_Input_Pass.ForeColor = ColorPalette.LoginForeColor;
        }
        
        //Logic Part starts after clicking the login execute button
        private void LoginExecute_Click(object sender, EventArgs e)
        {
            LoginModel LoginData = new LoginModel();
            int SelectedRole = ComboBox_LoginType.SelectedIndex;

            //Ignore placeholder text for database check
            if (Input_Email.Text.Trim() == string.Empty || Input_Email.Text == trEmailPlaceholder || Input_Email.Text == enEmailPlaceholder)
            {
                LoginData.Email = string.Empty;
            }
            else
            {
                LoginData.Email = Input_Email.Text;
            }
            if (Input_Password.Text.Trim() == string.Empty || Input_Password.Text == trPassPlaceholder || Input_Password.Text == enPassPlaceholder)
            {
                LoginData.Password = string.Empty;
            }
            else
            {
                LoginData.Password = Input_Password.Text;
            }    

            try
            {
                MainPage MainForm = null;
                if (SelectedRole == 0)
                {
                    StudentsService StudentsService1 = new StudentsService(AppContext);
                    StudentModel LoggedStudent = new StudentModel();
                    LoggedStudent = StudentsService1.LoginStudent(LoginData);
                    if (LoggedStudent != null)
                    {
                        AppContext.SetLoggedUser(LoggedStudent);
                        MainForm = new MainPage(AppContext);
                    }
                }
                else if (SelectedRole == 1)
                {
                    StaffService StaffService1 = new StaffService(AppContext);
                    StaffModel LoggedStaff = new StaffModel();

                    LoggedStaff = StaffService1.LoginStaff(LoginData);
                    if(LoggedStaff != null)
                    {
                        AppContext.SetLoggedUser(LoggedStaff);
                        MainForm = new MainPage(AppContext);
                    }
                }

                Helpers.ChangePage(this, MainForm);
            }
            catch (Exception ex)
            {
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox1.Visible = true;
            }
        }

        private void Button_WindowClose_Click(object sender, EventArgs e)
        {
            Helpers.CloseApplication();
        }
    }
}
