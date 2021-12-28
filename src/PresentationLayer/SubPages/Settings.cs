using BusinessLogicLayer.Services;
using Entities;
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
using PresentationLayer.Dialogs;
using BusinessLogicLayer;

namespace PresentationLayer.SubPages
{
    public partial class Settings : Form
    {
        private BusinessLogicLayer.CustomAppContext AppContext;
        private SettingsService SettingsService1;
        private StaffService StaffService1;

        public Settings(BusinessLogicLayer.CustomAppContext _appContext=null)
        {
            InitializeComponent();
            AppContext = _appContext;
            SettingsService1 = new SettingsService(AppContext);
            StaffService1 = new StaffService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            SetViewForUserTypes();
            RefreshStaff();
        }

        private void ApplyStrings()
        {
            Text_SettingInput.Text = Strings.Setting1;
            Button_SaveButton.Text = Strings.Save;
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorPalette.SettingsBackColor;
            this.ForeColor = ColorPalette.SettingsForeColor;
        }

        private void SetViewForUserTypes()
        {
            if (AppContext.GetUserType() == UserType.Admin)
            {
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Input_Setting.Text = AppContext.AppSettings.daily_fine_amount.ToString();

        }

        private void RefreshStaff()
        {
            listBox1.DataSource = StaffService1.GetAllStaff();
            listBox1.DisplayMember = "staff_name";
        }

        private void Button_SaveButton_Click(object sender, EventArgs e)
        {
            SettingsModel NewSettings = new SettingsModel();
            NewSettings.daily_fine_amount = Int32.Parse(Input_Setting.Text);
            try
            {
                SettingsService1.ChangeSettings(NewSettings);
                AppContext.UpdateSettings();
            }
            catch (Exception ex)
            {
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsService StSer = new StudentsService(AppContext);
            BooksService BSer = new BooksService(AppContext);
            BorrowingService BorSer = new BorrowingService(AppContext);
            StaffService StaffSer = new StaffService(AppContext);
            MockData MockData1 = new MockData();

            try
            {
                StaffSer.AddStaff(MockData1.MockStaff);
                StSer.BulkAdd(MockData1.StdList);
                BSer.BulkAdd(MockData1.BookList);
                BorSer.BulkAdd(MockData1.BorrowsList);

                alertBox2.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, "Success");
                alertBox2.Visible = true;
            }
            catch(Exception ex)
            {
                alertBox2.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AppContext.DbReset();
                Application.Restart();
            }
            catch(Exception ex)
            {
                alertBox2.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox2.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string NewPass = textBox1.Text;
                StaffModel TmpStaff = AppContext.GetLoggedStaff();
                TmpStaff.staff_password = NewPass;
                StaffService1.UpdateStaff(TmpStaff);
            }
            catch (Exception ex)
            {
                alertBox2.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox2.Visible = true;
            }
        }


        private void StaffOperations_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "Button_AddStaff")
            {
                using (var form = new UserAddUpdate(AppContext, UserType.Staff))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshStaff();
                    }
                }
            }
            else
            {
                StaffModel SelectedStaff = (listBox1.SelectedItem as StaffModel);
                if ((sender as Button).Name == "Button_EditStaff")
                {
                    using (var form = new UserAddUpdate(AppContext, UserType.Staff, SelectedStaff.staff_id))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            RefreshStaff();
                        }
                    }
                }
                else if ((sender as Button).Name == "Button_DeleteStaff")
                {
                    DialogResult dialogResult = MessageBox.Show("Delete \"" + SelectedStaff.staff_name + "\"", "Are You Sure", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        StaffService1.DeleteStaff(SelectedStaff);
                        RefreshStaff();
                    }
                }
            }
        }
    }
}
