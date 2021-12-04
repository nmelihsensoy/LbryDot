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
using BusinessLogicLayer.Services;
using Entities;
using BusinessLogicLayer;
using System.Globalization;

namespace PresentationLayer.Dialogs
{
    public partial class BookAddUpdate : Form
    {
        private CustomAppContext AppContext;
        private BooksService BooksService1;
        private byte[] SelectedCoverInBytes;
        private bool IsNewBook = true;
        private int BookId;

        public BookAddUpdate(CustomAppContext _appContext, int _bookId = -1)
        {
            InitializeComponent();
            AppContext = _appContext;
            BookId = _bookId;
            if (_bookId != -1) IsNewBook = false;
            BooksService1 = new BooksService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            ApplyDialogType();
        }

        private void ApplyDialogType()
        {
            if (this.IsNewBook == false)
            {
                BookModel EditBook = BooksService1.GetBookById(BookId);
                Input_ISBN.Text = EditBook.isbn.ToString();
                Input_Title.Text = EditBook.title;
                Input_Author.Text = EditBook.author;
                Input_Category.Text = EditBook.category;
                Input_BookLang.Text = EditBook.language;
                Input_Length.Text = EditBook.number_of_pages.ToString();
                Input_ShelfNumber.Text = EditBook.shelf_number;
                dateTimePicker_PublishYear.Value = DateTime.ParseExact(EditBook.date_of_publication, "yyyy", CultureInfo.InvariantCulture);
                
                if (EditBook.book_cover != null && EditBook.book_cover.Length > 0)
                    Image_BookCover.Image = Helpers.ConvertByteToImage(EditBook.book_cover);
            }
        }

        private void ApplyStrings()
        {
            Text_Title.Text = Strings.BookTitle;
            Text_ISBN.Text = Strings.BookISBN;
            Text_Author.Text = Strings.BookAuthor;
            Text_Category.Text = Strings.BookCategory;
            Text_PublishYear.Text = Strings.BookPublishYear;
            Text_BookLang.Text = Strings.BookLang;
            Text_BookLength.Text = Strings.BookLength;
            Text_BookCover.Text = Strings.BookCover;
            Text_ShelfNumber.Text = Strings.BookShelfNumber;
            Button_SelectCover.Text = Strings.Select;
            Button_Save.Text = Strings.Save;
        }

        private void ApplyColorPalette()
        {
            Panel_Container.BackColor = ColorPalette.GenericFormBackColor;
            Panel_Container.ForeColor = ColorPalette.GenericFormForeColor;
        }

        private void Button_SelectCover_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.jpg;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var length = new System.IO.FileInfo(openFileDialog1.FileName).Length;
                if (length < 1000000)
                {
                    SelectedCoverInBytes = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                    Image_BookCover.Image = Helpers.ConvertByteToImage(SelectedCoverInBytes);
                }
                else
                {
                    MessageBox.Show("File size has to be lower than 1MB");
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                BookModel NewBook = new BookModel();

                //DateTimePicker1.Value.ToString("dd-MMM-yyyy hh:mm:ss")
                //BooksService1.AddBook(NewBook);
            }
            catch (Exception ex)
            {
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox1.Visible = true;
            }

            this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
