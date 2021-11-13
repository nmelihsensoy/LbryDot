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
    public partial class BookIssue : Form
    {
        public BookIssue()
        {
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorPalette.BorrowDialogBackColor;
            this.ForeColor = ColorPalette.BorrowDialogForeColor;
            Button_Close.ForeColor = ColorPalette.BorrowDialogCloseForeColor;
        }

        private void ApplyStrings()
        {
            Text_FineAmount.Text = Strings.NoFine;
            Button_Return.Text = Strings.ButtonReturn;
            Button_Close.Text = Strings.Close;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {

        }
    }
}
