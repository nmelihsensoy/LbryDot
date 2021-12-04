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
using Entities;

namespace PresentationLayer.Dialogs
{
    public partial class BookBorrow : Form
    {
        BorrowingModel BorrowBook1;
        
        public BookBorrow(BorrowingModel _borrowBook)
        {
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();
            BorrowBook1 = _borrowBook;
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
            BorrowBook1.issued_date = Helpers.GetTimeStamp();
            BorrowBook1.due_date = dateTimePicker_ReturnDate.Value.ToString("dd/MM/yyyy");

            MessageBox.Show(BorrowBook1.ToString());

            this.Height = this.Height + AlertBox_SuccesError.Height + AlertBox_SuccessInfo.Height + 15;

            AlertBox_SuccesError.Visible = true;
            AlertBox_SuccesError.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, "Error Message");
            AlertBox_SuccessInfo.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Info, "Shelf Number: 35A");
        }
    }
}
