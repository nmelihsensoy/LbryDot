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

namespace PresentationLayer.Pages
{
    public partial class LoginPage : Form
    {
        string trEmailPlaceholder = Helpers.GetValueFromCulture("LoginEmailPlaceholderText", "tr");
        string enEmailPlaceholder = Helpers.GetValueFromCulture("LoginEmailPlaceholderText", "");
        string trPassPlaceholder = Helpers.GetValueFromCulture("LoginPassPlaceholderText", "tr");
        string enPassPlaceholder = Helpers.GetValueFromCulture("LoginPassPlaceholderText", "");

        public LoginPage()
        {
            Helpers.ChangeLanguage();
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();         
            Pass_Input_Line.Height = 1;
            Email_Input_Line.Height = 1;            
        }

        private void ApplyStrings()
        {
            Logo.Text = Strings.LogoText;
            if (Email_Input.Text.Trim() == string.Empty || Email_Input.Text == trEmailPlaceholder || Email_Input.Text == enEmailPlaceholder)
            {
                Email_Input.Text = Strings.LoginEmailPlaceholderText;
            }
            if (Password_Input.Text.Trim() == string.Empty || Password_Input.Text == trPassPlaceholder || Password_Input.Text == enPassPlaceholder)
            {
                Password_Input.Text = Strings.LoginPassPlaceholderText;
            }
            LoginTypeSelection.Items.Clear();
            LoginTypeSelection.Items.Add(Strings.LoginUserTypeStudent);
            LoginTypeSelection.Items.Add(Strings.LoginUserTypeStaff);
            LoginTypeSelection.SelectedIndex = 0;
            LoginExecute.Text = Strings.LoginExecuteButtonText;        
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorPalette.LoginBackColor;
            ContainerPanel.BackColor = ColorPalette.LoginBackColor;
            Logo.ForeColor = ColorPalette.LoginForeColor;  
            Email_Input.BackColor = ColorPalette.LoginFormElementsBackColor;
            Email_Input.ForeColor = ColorPalette.LoginPlaceholderColor;
            Email_Input_Line.BackColor = ColorPalette.LoginForeColor;
            Email_Input_Icon.BackColor = ColorPalette.LoginFormElementsBackColor;
            Email_Input_Icon.ForeColor = ColorPalette.LoginForeColor;   
            Password_Input.BackColor = ColorPalette.LoginFormElementsBackColor;
            Password_Input.ForeColor = ColorPalette.LoginPlaceholderColor;
            Pass_Input_Line.BackColor = ColorPalette.LoginForeColor;
            Pass_Input_Icon.BackColor = ColorPalette.LoginFormElementsBackColor;
            Pass_Input_Icon.ForeColor = ColorPalette.LoginForeColor;      
            LoginTypeSelection.BackColor = ColorPalette.LoginFormElementsBackColor;
            LoginTypeSelection.ForeColor = ColorPalette.LoginForeColor;       
            LoginExecute.BackColor = ColorPalette.LoginFormElementsBackColor;
            LoginExecute.ForeColor = ColorPalette.LoginForeColor;
            Lang_EN.ForeColor = ColorPalette.LoginForeColor;
            Lang_TR.ForeColor = ColorPalette.LoginForeColor;
            Lang_Select_Seperator.ForeColor = ColorPalette.LoginForeColor;
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

        private void Lang_EN_Click(object sender, EventArgs e)
        {
            Helpers.ChangeLanguage();
            ApplyStrings();
        }

        private void Lang_TR_Click(object sender, EventArgs e)
        {
            Helpers.ChangeLanguage("tr");
            ApplyStrings();
        }    

        private void Email_Input_Enter(object sender, EventArgs e)
        {
            //When typing in email box, clear placeholder text and set active color
            if (Email_Input.Text.Trim() == trEmailPlaceholder || Email_Input.Text.Trim() == enEmailPlaceholder)
            {
                Email_Input.Clear();
            }

            Email_Input_Line.BackColor = ColorPalette.LoginFormElementsActiveColor;
            Email_Input_Icon.ForeColor = ColorPalette.LoginFormElementsActiveColor;
        }

        private void Email_Input_Leave(object sender, EventArgs e)
        {
            //When typing is finished if typed text is empty, change empty text with the placeholder text  
            if(Email_Input.Text.Trim() == string.Empty)
            {
                Email_Input.Text = Strings.LoginEmailPlaceholderText;
            }
            Email_Input_Line.BackColor = ColorPalette.LoginForeColor;
            Email_Input_Icon.ForeColor = ColorPalette.LoginForeColor;
        }

        private void Password_Input_Enter(object sender, EventArgs e)
        {
            if (Password_Input.Text.Trim() == trPassPlaceholder || Password_Input.Text.Trim() == enPassPlaceholder)
            {
                Password_Input.Clear();
            }

            Password_Input.PasswordChar = '*';
            Pass_Input_Line.BackColor = ColorPalette.LoginFormElementsActiveColor;
            Pass_Input_Icon.ForeColor = ColorPalette.LoginFormElementsActiveColor;
        }

        private void Password_Input_Leave(object sender, EventArgs e)
        {

            if (Password_Input.Text.Trim() == string.Empty)
            {
                Password_Input.PasswordChar = '\0'; 
                Password_Input.Text = Strings.LoginPassPlaceholderText;
            }

            Pass_Input_Line.BackColor = ColorPalette.LoginForeColor;
            Pass_Input_Icon.ForeColor = ColorPalette.LoginForeColor;
        }
        
        //Logic Part starts after clicking login execute button
        private void LoginExecute_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            Helpers.ChangePage(this, MainForm);
        }     
    }
}
