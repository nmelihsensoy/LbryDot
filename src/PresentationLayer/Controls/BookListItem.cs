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

namespace PresentationLayer.Controls
{

    //This control is created to populate less detailed book lists or a more detailed single book item with desired style.
    public partial class BookListItem : UserControl
    {
        private UserType _userType;
        private bool _isLongList;
        private BookModel _bookModel;

        public BookListItem()
        {
            InitializeComponent();
            ApplyColorPalette();
            SetUserPrivilege(UserType.Student);
            _isLongList = false;
            Text_BookTitleSecLine.Text = "";
        }

        private void ApplyColorPalette()
        {
            Panel_Container.BackColor = ColorPalette.BookListItemBackColor;
            Splitter_TopBorder.BackColor = ColorPalette.BookListItemTopBorderColor;
            Text_BookTitleFirstLine.ForeColor = ColorPalette.BookListItemTitleForeColor;
            Text_BookTitleSecLine.ForeColor = ColorPalette.BookListItemTitleForeColor;
            Text_BookAuthor.ForeColor = ColorPalette.BookListItemAuthorForeColor;
            Text_BookCategory.BackColor = ColorPalette.BookListItemCategoryBackColor;
            Text_PageCount.BackColor = ColorPalette.BookListItemPageCountBackColor;
            Text_PublishYear.BackColor = ColorPalette.BookListItemPublishYearBackColor;
            //Text_ISBN.BackColor = Color.Red;
        }

        //To seamlessly handling hover on a multiple elements, method used in the below.
        //If pointer leaves the container of the multiple elements, hide that elements.
        //https://stackoverflow.com/questions/347439/custom-controls-in-c-sharp-windows-forms-mouse-event-question
        private void Item_MouseLeave(object sender, EventArgs e)
        {
            if (Panel_Hover.Visible == true)
            {
                //Getting the container element bounds.
                Rectangle screenBounds = new Rectangle(this.PointToScreen(Panel_Hover.Location), Panel_Hover.Size);
                if (!screenBounds.Contains(MousePosition))
                {
                    Panel_Hover.Visible = false;
                }
            }
        }

        public void MakeExtendedListItem()
        {
            _isLongList = true;
            Text_ISBN.Visible = true;
            Text_BookCategory.Top = Text_PublishYear.Top;
            Text_BookCategory.Left = Text_PublishYear.Right + (Text_PublishYear.Left - Text_PageCount.Right);
        }

        public void SetUserPrivilege(UserType Type)
        {
            //Showing delete button by logged usertype
            _userType = Type;
            if (_userType == UserType.Student)
            {
                Button_BookDeleteBorrow.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
                Button_BookDeleteBorrow.BackColor = ColorPalette.BookListItemHoverButtonBackColor;
                Button_BookDeleteBorrow.IconColor = ColorPalette.BookListItemBorrowButtonForeColor;
                Button_Edit.Visible = false;
            }
            else
            {
                Button_BookDeleteBorrow.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
                Button_BookDeleteBorrow.BackColor = ColorPalette.BookListItemHoverButtonBackColor;
                Button_BookDeleteBorrow.IconColor = ColorPalette.BookListItemDeleteButtonForeColor;
                Button_Edit.Visible = true;
            }
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            if (!_isLongList)
            {
                Panel_Hover.Visible = true;
            }
        }

        public BookModel Book {
            set {
                if (!_isLongList && value.title.Length > 15)
                {
                    Text_BookTitleFirstLine.Text = value.title.Substring(0, 15);
                    Text_BookTitleSecLine.Text = value.title.Substring(15, value.title.Length-15);
                }
                else
                {
                    Text_BookTitleFirstLine.Text = value.title;
                }

                Text_BookAuthor.Text = value.author;
                Text_BookCategory.Text = BusinessLogicLayer.Helpers.GetOnlyText(value.category);
                Splitter_TopBorder.BackColor = BusinessLogicLayer.Helpers.PaddedStringToColor(value.category, Splitter_TopBorder.BackColor);
                Text_BookCategory.BackColor = Splitter_TopBorder.BackColor;
                Text_ISBN.Text = value.isbn;
                Image_BookCover.Image = Helpers.ConvertByteToImage(value.book_cover, Image_BookCover.Image);
                _bookModel = value;

                if (_userType == UserType.Student && value.is_available == 0)
                {
                    Button_BookDeleteBorrow.Enabled = false;
                }
            }
            get
            {
                return _bookModel;
            }
        }

        public void HideHover()
        {
            Panel_Hover.Visible = false;
        }

        public event EventHandler ButtonHandler;
        private void ButtonClickEvent(object sender, EventArgs e)
        {
            Helpers.SendEvent(ButtonHandler, sender, e);
        }

        public static BookListItem GetItemFromButton(object Button)
        {
            try
            {
                return ((Button as Button).Parent.Parent.Parent as BookListItem);
            }
            catch
            {
                return null;
            }
        }

    }
}
