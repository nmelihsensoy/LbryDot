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
        private BookModel _editBook;
        public DialogResult ReturnType = DialogResult.Cancel;
        private List<CategoryModel> Categories;

        public BookAddUpdate(CustomAppContext _appContext, BookModel EditBook=null)
        {
            InitializeComponent();
            AppContext = _appContext;
            _editBook = EditBook;
            if (EditBook != null && EditBook.book_id > 0) IsNewBook = false;
            BooksService1 = new BooksService(AppContext);
            ApplyColorPalette();
            ApplyStrings();
            Categories = BooksService1.GetCategoriesList();
            InitCategoryInput();
            ApplyDialogType();
        }

        private void ApplyDialogType()
        {
            if (this.IsNewBook == false)
            {
                Input_ISBN.Text = _editBook.isbn.ToString();
                if (_editBook.title.Length > 15)
                {
                    Input_Title.Text = _editBook.title.Substring(0, 15);
                    Input_Title_Sec.Text = _editBook.title.Substring(15, _editBook.title.Length - 15);
                }
                else
                {
                    Input_Title.Text = _editBook.title;
                }
                
                Input_Author.Text = _editBook.author;
                var Found = Categories.Find(x => x.CategoryRaw.Contains(_editBook.category));
                Input_Category.SelectedItem = Found;
                panel1.BackColor = Found.CategoryColor;
                Input_BookLang.Text = _editBook.language;
                Input_Length.Text = _editBook.number_of_pages.ToString();
                Input_ShelfNumber.Text = _editBook.shelf_number;
                dateTimePicker_PublishYear.Value = new DateTime(_editBook.date_of_publication, 1,1);
                SelectedCoverInBytes = _editBook.book_cover;
                Image_BookCover.Image = Helpers.ConvertByteToImage(_editBook.book_cover, Image_BookCover.Image);
            }
        }

        private void ApplyStrings()
        {
            Text_Title.Text = Strings.BookTitle;
            Text_Title_Sec.Text = Strings.BookTitle;
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

        private void InitCategoryInput()
        {
            Input_Category.DataSource = Categories;
            Input_Category.DisplayMember = "CategoryName";
            Input_Category.SelectedIndex = -1;
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

        private void SetModelFromInputs(BookModel Book)
        {
            Book.isbn = Input_ISBN.Text;
            Book.title = Input_Title.Text + Input_Title_Sec.Text;
            Book.date_of_publication = dateTimePicker_PublishYear.Value.Year;
            Book.author = Input_Author.Text;
            Book.number_of_pages = Int32.Parse(Input_Length.Text);
            Book.category = Input_Category.Text + BusinessLogicLayer.Helpers.ColorToPaddedString(panel1.BackColor);
            Book.language = Input_BookLang.Text;
            Book.shelf_number = Input_ShelfNumber.Text;
            Book.book_cover = SelectedCoverInBytes;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string SuccessMsg = "";
                if (IsNewBook == true)
                {
                    BookModel NewBook = new BookModel();
                    SetModelFromInputs(NewBook);

                    BooksService1.AddBook(NewBook);
                    SuccessMsg = "Book Added Succesfully";
                }
                else
                {
                    SetModelFromInputs(_editBook);
                    BooksService1.UpdateBook(_editBook);
                    SuccessMsg = "Book Edited Succesfully";
                }
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Success, SuccessMsg);
                alertBox1.Visible = true;
                ReturnType = DialogResult.OK;
            }
            catch (Exception ex)
            {
                alertBox1.ShowAlert(PresentationLayer.Controls.AlertBox.AlertType.Danger, ex.Message);
                alertBox1.Visible = true;
            }
        }

        private void BookAddUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = ReturnType;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void Input_Category_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var Selected = (((ComboBox)sender).Items[e.Index] as CategoryModel);
            e.Graphics.FillRectangle(new SolidBrush(Selected.CategoryColor), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            e.Graphics.DrawString(Selected.CategoryName, e.Font, new SolidBrush(Color.White), e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }
    }
}
