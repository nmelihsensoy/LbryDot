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
using Entities;
using BusinessLogicLayer;
using PresentationLayer.Controls;

namespace PresentationLayer.SubPages
{
    public partial class Books : Form
    {
        private CustomAppContext AppContext;
        private BooksService BooksService1;
        private AlertBox BookAlert;
        private AlertBox SearchAlert;

        public Books(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            BooksService1 = new BooksService(AppContext);
            InitAlert(ref BookAlert);
            InitAlert(ref SearchAlert);
            RefreshBooks();
        }

        private void InitAlert(ref AlertBox AlertB)
        {
            AlertB = new AlertBox();
            AlertB.Width = this.Width / 2;
        }

        private void PopulateBooks(List<BookModel> Lst, FlowLayoutPanel Pnl)
        {
            foreach (BookModel Book in Lst)
            {
                BookListItem ListItem = new BookListItem();
                ListItem.SetUserPrivilege(AppContext.GetUserType());
                ListItem.Book = Book;

                Pnl.Controls.Add(ListItem);
                ListItem.ButtonHandler += ListClickEvent;
            }
        }

        public void AddButtonClick(object sender, EventArgs e)
        {
            using (var form = new BookAddUpdate(AppContext))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshBooks();
                }
            }
        }

        public void SearchBook(object sender, string text, EventArgs e)
        {
            //this.ParentForm.ActiveControl = null;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.Controls.Clear();
            var SearchResult = BooksService1.SearchBook(text);
            PopulateBooks(SearchResult, flowLayoutPanel2);
            SearchAlert.ShowAlert(AlertBox.AlertType.Warning, text + " : book couldn't find.");
            Helpers.AddControlToEmptyContainer(flowLayoutPanel2, SearchAlert);
        }

        public void SearchReset()
        {
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Controls.Clear();
        }

        private void RefreshBooks()
        {
            flowLayoutPanel1.Controls.Clear();
            PopulateBooks(BooksService1.GetAllBooks(), flowLayoutPanel1);
            BookAlert.ShowAlert(AlertBox.AlertType.Warning, "There is no any book.");
            Helpers.AddControlToEmptyContainer(flowLayoutPanel1, BookAlert);
        }

        private void ListClickEvent(object sender, EventArgs e)
        {  
            if ((sender as Button).Name == "Button_BookDetails")
            {
                using (var form = new BookDetails(AppContext, BookListItem.GetItemFromButton(sender).Book))
                {
                    var result = form.ShowDialog();
                    BookListItem.GetItemFromButton(sender).HideHover();
                }
            }
            else if ((sender as Button).Name == "Button_BookDeleteBorrow")
            {
                if(AppContext.GetUserType() == UserType.Staff)
                {
                    DialogResult dialogResult = MessageBox.Show("Delete Book", "Are You Sure", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BooksService1.DeleteBook(BookListItem.GetItemFromButton(sender).Book);
                        RefreshBooks();
                    }
                    BookListItem.GetItemFromButton(sender).HideHover();
                }
                else
                {       
                    using (var form = new BookBorrow(AppContext ,BookListItem.GetItemFromButton(sender).Book))
                    {
                        form.StartPosition = FormStartPosition.Manual;
                        Point StartP = (sender as Button).PointToScreen(Point.Empty);
                        StartP.X += 20;
                        StartP.Y += 20;
                        form.Location = StartP;
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            RefreshBooks();
                        }
                        BookListItem.GetItemFromButton(sender).HideHover();
                    }
                }
            }
            else if ((sender as Button).Name == "Button_Edit")
            {
                using (var form = new BookAddUpdate(AppContext, BookListItem.GetItemFromButton(sender).Book))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshBooks();
                    }
                    BookListItem.GetItemFromButton(sender).HideHover();
                }
            }
        }
    }
}
