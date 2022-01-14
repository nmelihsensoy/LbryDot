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
    public partial class DashboardGraphSettings : Form
    {
        public string TitleResult = "";
        private string DefaultTitle;

        public DashboardGraphSettings(string CurrentTitle, string _defaultTitle)
        {
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();
            DefaultTitle = _defaultTitle;
            Input_Title.Text = CurrentTitle;
        }

        private void ApplyStrings()
        {
            Text_Title.Text = Strings.Title;
            Button_Change.Text = Strings.Save;
            Button_LoadDefault.Text = Strings.LoadDefault;
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorPalette.GenericFormBackColor;
            this.ForeColor = ColorPalette.GenericFormForeColor;
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            TitleResult = Input_Title.Text;
        }

        private void Button_LoadDefault_Click(object sender, EventArgs e)
        {
            Input_Title.Text = DefaultTitle;
        }
    }
}
