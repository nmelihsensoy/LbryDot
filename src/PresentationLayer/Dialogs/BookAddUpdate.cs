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

namespace PresentationLayer.Dialogs
{
    public partial class BookAddUpdate : Form
    {
        public BookAddUpdate()
        {
            InitializeComponent();
            ApplyColorPalette();
            ApplyStrings();
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
    }
}
