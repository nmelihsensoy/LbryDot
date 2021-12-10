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
                int DayDiff = -1;
                BookStatusItem Item = new BookStatusItem();
                if (Borrow.returned_date == DateTime.MinValue)
                {
                    DayDiff = BusinessLogicLayer.Helpers.DaysBetween(Borrow.due_date, DateTime.Today);
                    //MessageBox.Show(Borrow.due_date.ToString());
                    if (DayDiff > -1)
                    {
                        if (DayDiff == 2)
                        {
                            Item.SetBookStatus(BookStatusItem.BookStatus.Late);
                        }
                        else
                        {
                            Item.SetBookStatus(BookStatusItem.BookStatus.Normal);

                        }
                    }
                }
                else
                {
                    Item.SetBookStatus(BookStatusItem.BookStatus.Returned);
                }

                Item.Borrow = Borrow;
                Item.Text_DayFirstLine.Text = Math.Abs(DayDiff).ToString();

                Pnl.Controls.Add(Item);
                Item.ButtonHandler += action;
            }
        }

        private void RefreshMyBooks()
        {
            flowLayoutPanel1.Controls.Clear();
            PopulateMyBooks(BorrowingService1.GetAllBorrowings(), flowLayoutPanel1, StatusItemClick);
            MyBooksAlert.ShowAlert(AlertBox.AlertType.Warning, "There is no any borrowed books");
            Helpers.AddControlToEmptyContainer(flowLayoutPanel1, MyBooksAlert);
        }

        private void StatusItemClick(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "Button_ReturnBook")
            {
                using (var form = new BookIssue(AppContext, BookStatusItem.GetItemFromButton(sender).Borrow))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshMyBooks();
                    }
                    BookStatusItem.GetItemFromButton(sender).HideHover();
                }
            }else if ((sender as Button).Name == "Button_BookDetails")
            {
                using (var form = new BookDetails(AppContext, BookStatusItem.GetItemFromButton(sender).Borrow.book))
                {
                    var result = form.ShowDialog();
                    BookStatusItem.GetItemFromButton(sender).HideHover();
                }
            }
        }
    }
}
