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
        
        public MyBooks(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingService1 = new BorrowingService(AppContext);
            PopulateMyBooks(BorrowingService1.GetAllBorrowings(), flowLayoutPanel1, StatusItemClick);
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

        private void StatusItemClick(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as Button).Name);
            if ((sender as Button).Name == "Button_ReturnBook")
            {
                using (var form = new BookIssue(AppContext, ((BorrowingModel)(sender as Button).Tag)))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("returned OK");
                    }
                }
            }else if ((sender as Button).Name == "Button_BookDetails")
            {
                using (var form = new BookDetails(AppContext, ((BorrowingModel)(sender as Button).Tag).book.book_id))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("returned OK");
                    }
                }
            }
        }
    }
}
