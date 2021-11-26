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
using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using Entities;

namespace PresentationLayer.Dialogs
{
    public partial class StudentAddUpdate : Form
    {
        private CustomAppContext AppContext;
        private StudentsService StudentsService1;

        public StudentAddUpdate(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            StudentsService1 = new StudentsService(AppContext);
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
            try
            {
                StudentModel NewStudent = new StudentModel();
                NewStudent.student_email = Input_Email.Text;
                NewStudent.student_name = Input_Name.Text;
                NewStudent.student_password = Input_Password.Text;
                NewStudent.student_avatar = null;

                StudentsService1.AddStudent(NewStudent);
            }
            catch (Exception ex)
            {
                AlertBox_UserOperation.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                AlertBox_UserOperation.Visible = true;
                this.Height += AlertBox_UserOperation.Height + 10;
            }

            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
