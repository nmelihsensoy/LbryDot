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
using BusinessLogicLayer;
using BusinessLogicLayer.Services;

namespace PresentationLayer.Dialogs
{
    public partial class BookReturn : Form
    {
        private CustomAppContext AppContext;
        private BorrowingService BorrowingService1;
        private BorrowingModel BorrowingModel1;
        private DialogResult ResultType = DialogResult.Cancel;

        public BookReturn(CustomAppContext _appContext, BorrowingModel _borrowingModel1)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingModel1 = _borrowingModel1;
            BorrowingService1 = new BorrowingService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            CreateFeeMessage();
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

        private void CreateFeeMessage()
        {
            BorrowingModel1 = BorrowingService1.CalculateFee(BorrowingModel1);

            if(BorrowingModel1.amount_of_fine > 0)
            {
                Text_FineAmount.Text = Strings.Fee + ": " + BorrowingModel1.amount_of_fine.ToString() + AppContext.AppSettings.currency_symbol;
            }
            else
            {
                Text_FineAmount.Text = Strings.NoFine;
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowingService1.ReturnBook(BorrowingModel1);
                alertBox1.Visible = true;
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, Strings.BookReturnSuccessMsg, false);
                alertBox2.Visible = true;
                alertBox2.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Info, Strings.BookReturnTransactionMsg+" #" + BorrowingModel1.borrow_id.ToString() );
                this.Height = this.Height + alertBox1.Height + alertBox2.Height + 15;
                ResultType = DialogResult.OK;
                Button_Return.Enabled = false;
            }
            catch (Exception ex)
            {
                alertBox1.Visible = true;
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                this.Height = this.Height + alertBox1.Height + 15;
               
                ResultType = DialogResult.Abort;
            }
        }

        private void BookIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = ResultType;
        }
    }
}
