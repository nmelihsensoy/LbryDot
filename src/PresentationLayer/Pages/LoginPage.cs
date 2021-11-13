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
            MainPage MainForm = new MainPage();
            Helpers.ChangePage(this, MainForm);
        }     
    }
}
