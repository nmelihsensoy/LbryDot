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

namespace PresentationLayer.Dialogs
{
    public partial class StudentAddUpdate : Form
    {
        //public string NameASD { get; set; }
        //public string ReturnValue2 { get; set; }

        public StudentAddUpdate()
        {
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();
        }

        private void ApplyStrings()
        {
            Text_Email.Text = Strings.StudentEmail;
            Text_Name.Text = Strings.StudentName;
            Text_Password.Text = Strings.StudentPass;
            Text_Avatar.Text = Strings.StudentAvatar;
            Button_SelectAvatar.Text = Strings.Select;
            Button_AddSave.Text = Strings.Save;
        }

        private void ApplyColorPalette()
        {
            Panel_Container.BackColor = ColorPalette.GenericFormBackColor;
            Panel_Container.ForeColor = ColorPalette.GenericFormForeColor;
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            //this.NameASD = Input_Email.Text; 
            //this.DialogResult = DialogResult.OK;
            //this.Close();
            this.Height += AlertBox_UserOperation.Height + 10;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
