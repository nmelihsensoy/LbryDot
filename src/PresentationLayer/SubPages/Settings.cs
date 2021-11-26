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

namespace PresentationLayer.SubPages
{
    public partial class Settings : Form
    {
        private BusinessLogicLayer.CustomAppContext AppContext;
        private SettingsService SettingsService1;
        public Settings(BusinessLogicLayer.CustomAppContext _appContext=null)
        {
            InitializeComponent();
            AppContext = _appContext;
            SettingsService1 = new SettingsService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
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

        private void Settings_Load(object sender, EventArgs e)
        {
            SettingsModel CurrentSettings = new SettingsModel();
            CurrentSettings = SettingsService1.GetCurrentSettings();

            Input_Setting.Text = CurrentSettings.daily_fine_amount.ToString();

        }

        private void Button_SaveButton_Click(object sender, EventArgs e)
        {
            SettingsModel NewSettings = new SettingsModel();
            NewSettings.daily_fine_amount = Int32.Parse(Input_Setting.Text);
            try
            {
                SettingsService1.ChangeSettings(NewSettings);
            }
            catch (Exception ex)
            {
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox1.Visible = true;
            }
        }
    }
}
