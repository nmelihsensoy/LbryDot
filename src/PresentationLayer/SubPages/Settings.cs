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
        public Settings()
        {
            InitializeComponent();
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
    }
}
