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
using BusinessLogicLayer.Services;
using BusinessLogicLayer;

namespace PresentationLayer.Dialogs
{
    public partial class BookBorrow : Form
    {
        private CustomAppContext AppContext;
        private BorrowingModel BorrowBook1;
        private BorrowingService BorrowingService1;
        
        public BookBorrow(CustomAppContext _appContext, BorrowingModel _borrowBook)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingService1 = new BorrowingService(AppContext);
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
            dateTimePicker_ReturnDate.MinDate = DateTime.Now;
        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowBook1.issued_date = DateTime.Now;
                BorrowBook1.due_date = dateTimePicker_ReturnDate.Value;

                BorrowingService1.AddBorrowing(BorrowBook1);
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            catch (Exception ex)
            {
                this.Height = this.Height + AlertBox_SuccesError.Height + AlertBox_SuccessInfo.Height + 15;
                MessageBox.Show(ex.Message);
                AlertBox_SuccesError.Visible = true;
                AlertBox_SuccesError.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, ex.Message);
                AlertBox_SuccessInfo.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Info, "Shelf Number: 35A");
            }
        }
    }
}
