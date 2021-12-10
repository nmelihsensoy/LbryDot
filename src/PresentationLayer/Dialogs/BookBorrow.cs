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
        private BorrowingService BorrowingService1;
        private DialogResult ResultType = DialogResult.Cancel;
        private BookModel _book;

        public BookBorrow(CustomAppContext _appContext, BookModel Book)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingService1 = new BorrowingService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            _book = Book;
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
                BorrowingModel BorrowBook1 = new BorrowingModel();
                BorrowBook1.book = _book;
                BorrowBook1.student = AppContext.GetLoggedStudent();
                BorrowBook1.issued_date = DateTime.Now;
                BorrowBook1.due_date = dateTimePicker_ReturnDate.Value;

                BorrowingService1.AddBorrowing(BorrowBook1);
                AlertBox_SuccesError.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, "Borrow Success");
                AlertBox_SuccesError.Visible = true;
                AlertBox_SuccessInfo.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Info, "Shelf: "+BorrowBook1.book.shelf_number);
                AlertBox_SuccessInfo.Visible = true;
                this.Height = this.Height + AlertBox_SuccesError.Height + AlertBox_SuccessInfo.Height + 15;
                ResultType = DialogResult.OK;
            }
            catch (Exception ex)
            {
                AlertBox_SuccesError.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                AlertBox_SuccesError.Visible = true;
                this.Height = this.Height + AlertBox_SuccesError.Height + 15;
                ResultType = DialogResult.Abort;
            }
        }

        private void BookBorrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = ResultType;
        }
    }
}
