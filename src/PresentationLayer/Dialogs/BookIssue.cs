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
    public partial class BookIssue : Form
    {
        private CustomAppContext AppContext;
        private BorrowingService BorrowingService1;
        private BorrowingModel BorrowingModel1;

        public BookIssue(CustomAppContext _appContext, BorrowingModel _borrowingModel1)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingModel1 = _borrowingModel1;
            BorrowingService1 = new BorrowingService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            ApplyFineMessage();
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

        private void ApplyFineMessage()
        {
            BorrowingModel1 = BorrowingService1.CalculateFee(BorrowingModel1);

            if(BorrowingModel1.amount_of_fine > 0)
            {
                Text_FineAmount.Text = "Fee: " + BorrowingModel1.amount_of_fine.ToString();
            }
            else
            {
                Text_FineAmount.Text = Strings.NoFine;
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {

        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowingService1.ReturnBook(BorrowingModel1);
                //this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            catch (Exception ex)
            {
                this.Height = this.Height + alertBox1.Height + alertBox1.Height + 15;
                MessageBox.Show(ex.Message);
                alertBox1.Visible = true;
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, ex.Message);
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Info, "Shelf Number: 35A");
            }
        }
    }
}
