using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Dialogs;
using BusinessLogicLayer.Services;
using BusinessLogicLayer;
using PresentationLayer.Controls;
using Entities;
using PresentationLayer.Resources;

namespace PresentationLayer.SubPages
{
    public partial class MyBooks : Form
    {
        private CustomAppContext AppContext;
        private BorrowingService BorrowingService1;
        private AlertBox MyBooksAlert;

        public MyBooks(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingService1 = new BorrowingService(AppContext);
            InitAlert();
            RefreshMyBooks();
        }

        private void InitAlert()
        {
            MyBooksAlert = new AlertBox();
            MyBooksAlert.Width = this.Width / 2;
        }

        public static void PopulateMyBooks(List<BorrowingModel> Lst, FlowLayoutPanel Pnl, EventHandler action)
        {
            foreach (BorrowingModel Borrow in Lst)
            {
                BookStatusItem Item = new BookStatusItem();
                BorrowingService.BorrowState ItemState = BorrowingService.GetBorrowState(Borrow, out int DayDiff);

                switch (ItemState)
                {
                    case BorrowingService.BorrowState.Error:
                        Item.SetBookStatus(BookStatusItem.BookStatus.Stateless);
                        break;
                    case BorrowingService.BorrowState.Borrowed:
                        Item.SetBookStatus(BookStatusItem.BookStatus.Normal);
                        break;
                    case BorrowingService.BorrowState.Late:
                        Item.SetBookStatus(BookStatusItem.BookStatus.Late);
                        break;
                    case BorrowingService.BorrowState.TwoDaysLeft:
                        Item.SetBookStatus(BookStatusItem.BookStatus.TwoDaysLeft);
                        break;
                    case BorrowingService.BorrowState.Returned:
                        Item.SetBookStatus(BookStatusItem.BookStatus.Returned);
                        break;
                    default:
                        Item.SetBookStatus(BookStatusItem.BookStatus.Stateless);
                        break;
                }

                Item.Borrow = Borrow;
                Item.Text_DayFirstLine.Text = Math.Abs(DayDiff).ToString();
                Item.TitleAlignCenter();

                Pnl.Controls.Add(Item);
                Item.ButtonHandler += action;
            }
        }

        private void RefreshMyBooks()
        {
            flowLayoutPanel1.Controls.Clear();
            PopulateMyBooks(BorrowingService1.GetAllBorrowings(), flowLayoutPanel1, StatusItemClick);
            MyBooksAlert.ShowAlert(AlertBox.AlertType.Warning, Strings.MyBooksEmptyMessage);
            Helpers.AddControlToEmptyContainer(flowLayoutPanel1, MyBooksAlert);
        }

        private void StatusItemClick(object sender, EventArgs e)
        {
            DialogResult Result = DialogResult.Abort;
            if ((sender as Button).Name == "Button_ReturnBook")
            {

                Form ReturnDialog = new BookReturn(AppContext, BookStatusItem.GetItemFromButton(sender).Borrow);
                Point StartP = (sender as Button).PointToScreen(Point.Empty);
                Helpers.SetFormStartPoint(ref ReturnDialog, StartP, 10);

                Result = ReturnDialog.ShowDialog();
            }
            else if ((sender as Button).Name == "Button_BookDetails")
            {
                Result = new BookDetails(AppContext, BookStatusItem.GetItemFromButton(sender).Borrow.book).ShowDialog();
            }
            if (Result == DialogResult.OK || Result == DialogResult.Yes)
            {
                RefreshMyBooks();
                AppContext.UpdateFine();
            }
            else
            {
                BookStatusItem.GetItemFromButton(sender).HideHover();
            }
        }
    }
}