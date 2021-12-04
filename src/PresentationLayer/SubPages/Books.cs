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
            //bookListItem1.ButtonHandler += ListClickEvent;
            PopulateBooks(BooksService1.GetAllBooks());
        }

        private void PopulateBooks(List<BookModel> Lst)
        {
            foreach (BookModel book in Lst)
            {
                BookListItem ListItem = new BookListItem();
                ListItem.Title = book.title;
                ListItem.BookId = book.book_id;
                ListItem.SetUserPrivilege((UserType)AppContext.GetUserType());
                ListItem.Author = book.author;
                ListItem.Category = book.category;
                ListItem.Cover = Helpers.ConvertByteToImage(book.book_cover);

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
                MessageBox.Show((sender as Button).Tag.ToString());

                using (var form = new BookDetails())
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
                if(AppContext.GetUserType() == 2)
                {
                    BorrowingModel BorrowBook1 = new BorrowingModel();
                    BorrowBook1.student_number = AppContext.GetLoggedStudent().student_number;
                    BorrowBook1.book_id = (int)(sender as Button).Tag;
                    using (var form = new BookBorrow(BorrowBook1))
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
