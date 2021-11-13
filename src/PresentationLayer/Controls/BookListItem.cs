﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controls
{

    //This control is created to populate less detailed book lists or a more detailed single book item with desired style.
    public partial class BookListItem : UserControl
    {
        private UserType _userType;
        public bool _isLongList;

        public BookListItem()
        {
            InitializeComponent();
            ApplyColorPalette();
            SetUserPrivilege(UserType.Student);
            _isLongList = false;
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
        }

        //To seamlessly handling hover on a multiple elements, method used in the below.
        //If pointer leaves the container of the multiple elements, hide that elements.
        //https://stackoverflow.com/questions/347439/custom-controls-in-c-sharp-windows-forms-mouse-event-question
        private void Item_MouseLeave(object sender, EventArgs e)
        {
            if(Panel_Hover.Visible == true)
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
            Text_BookCategory.Left += Text_PageCount.Width + Text_PublishYear.Width + (Text_PublishYear.Left-Text_PageCount.Left-Text_PublishYear.Width);
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
            }
            else
            {
                Button_BookDeleteBorrow.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
                Button_BookDeleteBorrow.BackColor = ColorPalette.BookListItemHoverButtonBackColor;
                Button_BookDeleteBorrow.IconColor = ColorPalette.BookListItemDeleteButtonForeColor;
            }
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            if (!_isLongList)
            {
                Panel_Hover.Visible = true;
            }
        }

        public Image Cover
        {
            set { Image_BookCover.Image = value; }
        }

        public string Title
        {
            set { Text_BookTitleFirstLine.Text = value; }
        }

        public string Author
        {
            set { Text_BookAuthor.Text = value; }
        }

        public string Category
        {
            set { Text_BookCategory.Text = value; }
        }


        public event EventHandler ButtonHandler;
        private void ButtonClickEvent(object sender, EventArgs e)
        {
            var eventHandler = this.ButtonHandler;

            if (eventHandler != null)
            {
                eventHandler(sender, e); //sending individual button object
            }
        }

    }
}
