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

        public Books(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            BooksService1 = new BooksService(AppContext);
            PopulateBooks(BooksService1.GetAllBooks());
        }

        private void PopulateBooks(List<BookModel> Lst)
        {
            foreach (BookModel Book in Lst)
            {
                BookListItem ListItem = new BookListItem();
                ListItem.Book = Book;
                ListItem.SetUserPrivilege(AppContext.GetUserType());

                flowLayoutPanel1.Controls.Add(ListItem);
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

                }
            }
        }

        public void SearchBook(object sender, string text, EventArgs e)
        {

        }

        private void ListClickEvent(object sender, EventArgs e)
        {  
            //MessageBox.Show((sender as Button).Name);
            if ((sender as Button).Name == "Button_BookDetails")
            {
                //MessageBox.Show((sender as Button).Tag.ToString());

                using (var form = new BookDetails(AppContext, (int)(sender as Button).Tag))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("returned OK");
                    }
                }
            }
            else if ((sender as Button).Name == "Button_BookDeleteBorrow")
            {
                if(AppContext.GetUserType() == UserType.Staff)
                {
                    DialogResult dialogResult = MessageBox.Show("Delete Book", "Are You Sure", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {       
                    BorrowingModel BorrowBook1 = new BorrowingModel();
                    BookModel TempBook = new BookModel();
                    TempBook.book_id = (int)(sender as Button).Tag;
                    BorrowBook1.student = AppContext.GetLoggedStudent();
                    BorrowBook1.book = TempBook;
                    //BorrowBook1.student_number = AppContext.GetLoggedStudent().student_number;
                    //BorrowBook1.book_id = (int)(sender as Button).Tag;
                    using (var form = new BookBorrow(AppContext ,BorrowBook1))
                    {
                        form.StartPosition = FormStartPosition.Manual;
                        Point StartP = (sender as Button).PointToScreen(Point.Empty);
                        StartP.X += 20;
                        StartP.Y += 20;
                        form.Location = StartP;
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("returned OK");
                        }
                    }
                }
            }
            else if ((sender as Button).Name == "Button_Edit")
            {

                //MessageBox.Show((sender as Button).Tag.ToString());
                using (var form = new BookAddUpdate(AppContext, (int)(sender as Button).Tag))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                    }
                }
            }
        }

    }
}
