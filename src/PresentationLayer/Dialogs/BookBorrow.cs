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
    public partial class BookBorrow : Form
    {
        public BookBorrow()
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
            Text_SelectDate.Text = Strings.SelectReturnDate;
            Button_Borrow.Text = Strings.ButtonBorrow;
            Button_Close.Text = Strings.Close;
        }

        private void BookBorrow_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            this.Height = this.Height + AlertBox_SuccesError.Height + AlertBox_SuccessInfo.Height + 15;


            AlertBox_SuccesError.Visible = true;
            AlertBox_SuccesError.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, "Error Message");
            AlertBox_SuccessInfo.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Info, "Shelf Number: 35A");
        }
    }
}
