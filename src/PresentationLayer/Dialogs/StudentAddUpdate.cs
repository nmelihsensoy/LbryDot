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
        private byte[] SelectedAvatarInBytes;
        private bool IsNewStudent = true;
        private int StudentNumber;

        public StudentAddUpdate(CustomAppContext _appContext, int _studentNumber = -1)
        {
            InitializeComponent();
            AppContext = _appContext;
            StudentNumber = _studentNumber;
            if (_studentNumber != -1) IsNewStudent = false;
            StudentsService1 = new StudentsService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            ApplyDialogType();
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

        private void ApplyDialogType()
        {
            if(this.IsNewStudent == false)
            {
                StudentModel EditStudent = StudentsService1.GetStudentById(StudentNumber);
                Input_Email.Text = EditStudent.student_email;
                Input_Name.Text = EditStudent.student_name;
                if (EditStudent.student_avatar != null && EditStudent.student_avatar.Length > 0)
                    Image_StudentAvatar.Image = Helpers.ConvertByteToImage(EditStudent.student_avatar);
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {       
            if(IsNewStudent == true)
            {
                try
                {
                    StudentModel NewStudent = new StudentModel();
                    NewStudent.student_email = Input_Email.Text;
                    NewStudent.student_name = Input_Name.Text;
                    NewStudent.student_password = Input_Password.Text;
                    NewStudent.student_avatar = SelectedAvatarInBytes;

                    StudentsService1.AddStudent(NewStudent);
                }
                catch (Exception ex)
                {
                    AlertBox_UserOperation.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                    AlertBox_UserOperation.Visible = true;
                    this.Height += AlertBox_UserOperation.Height + 10;
                }
            }
            else
            {
                MessageBox.Show("Update");
            }

            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.jpg;*.jpeg";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var length = new System.IO.FileInfo(openFileDialog1.FileName).Length;
                if (length < 500000)
                {
                    SelectedAvatarInBytes = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                    Image_StudentAvatar.Image = Helpers.ConvertByteToImage(SelectedAvatarInBytes);
                }
                else
                {
                    MessageBox.Show("File size has to be lower than 500KB");
                }
            }
        }
    }
}
