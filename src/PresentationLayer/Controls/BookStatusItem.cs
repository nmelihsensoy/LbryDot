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
using Entities;

namespace PresentationLayer.Controls
{
    //This control is created too populate books and their status. 
    public partial class BookStatusItem : UserControl
    {

        private BookStatus _bookStatus;
        private BorrowingModel _borrow;

        public enum BookStatus
        {
            Stateless = -1,
            Normal = 0,
            Late = 1,
            TwoDaysLeft = 2,
            Returned = 3
        }

        public BookStatusItem()
        {
            InitializeComponent();
            ApplyColorPalette();
            SetBookStatus(BookStatus.Normal);
        }

        private void ApplyColorPalette()
        {
            Panel_Container.BackColor = ColorPalette.BookStatusItemBackColor;
            Panel_Bottom.BackColor = ColorPalette.BookStatusItemBottomRibbonForeColor;
            Panel_Hover_Bottom.BackColor = ColorPalette.BookStatusItemBottomHoverRibbonForeColor;
            Button_BookDetails.BackColor = ColorPalette.BookStatusItemBottomHoverRibbonButtonBackColor;
            Button_BookDetails.ForeColor = ColorPalette.BookStatusItemBottomHoverRibbonButtonForeColor;
            Button_BookDetails.IconColor = ColorPalette.BookStatusItemBottomHoverRibbonButtonForeColor;
        }

        public void SetBookStatus(BookStatus BookS)
        {
            _bookStatus = BookS;
            if (_bookStatus == BookStatus.Returned)
            {
                Panel_Hover_Top.Visible = false;
                Splitter_BorderBottom.BackColor = ColorPalette.BookStatusItemTopHoverRibbonReturnedBackColor;
                Panel_Hover_Top.ForeColor = ColorPalette.BookStatusItemTopHoverRibbonReturnedForeColor;
                Text_DayFirstLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonReturnedBackColor;
                Text_DaySecLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonReturnedBackColor;
                Button_ReturnBook.Visible = false;
            }
            else if (_bookStatus == BookStatus.TwoDaysLeft)
            {
                Splitter_BorderBottom.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Panel_Hover_Top.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Panel_Hover_Top.ForeColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftForeColor;
                Text_DayFirstLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Text_DaySecLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Text_DayFirstLine.Text = "2";
                Text_DaySecLine.Text = Strings.DaysLeft;
                Button_ReturnBook.Visible = true;
            }
            else if (_bookStatus == BookStatus.Late)
            {
                Splitter_BorderBottom.BackColor = ColorPalette.BookStatusItemTopHoverRibbonLateBackColor;
                Panel_Hover_Top.BackColor = ColorPalette.BookStatusItemTopHoverRibbonLateBackColor;
                Panel_Hover_Top.ForeColor = ColorPalette.BookStatusItemTopHoverRibbonLateForeColor;
                Text_DayFirstLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonLateBackColor;
                Text_DaySecLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonLateBackColor;
                Text_DaySecLine.Text = Strings.DaysLate;
                Button_ReturnBook.Enabled = true;
            }
            else if(_bookStatus == BookStatus.Normal)
            {
                Splitter_BorderBottom.BackColor = Color.Gray;
                Panel_Hover_Top.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Panel_Hover_Top.ForeColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftForeColor;
                Text_DayFirstLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Text_DaySecLine.BackColor = ColorPalette.BookStatusItemTopHoverRibbonTwoDaysLeftBackColor;
                Text_DaySecLine.Text = Strings.DaysLeft;
                Button_ReturnBook.Visible = true;
            }else//_bookStatus == BookStatus.Stateless
            {
                Panel_Hover_Top.Visible = false;
                Button_ReturnBook.Enabled = true;
            }

            Text_DayFirstLine.Left = Panel_Hover_Top.Width/2 - Text_DayFirstLine.Width/2;
            Text_DaySecLine.Left = Panel_Hover_Top.Width/2 - Text_DaySecLine.Width/2;

        }
        private void Item_MouseEnter(object sender, EventArgs e)
        {   
            if(_bookStatus != BookStatus.Stateless && _bookStatus != BookStatus.Returned)
            {
                Panel_Hover_Top.Visible = true;
            }           
            Panel_Hover_Bottom.Visible = true;
        }

        //To seamlessly handling hover on a multiple elements, method used in the below.
        //If pointer leaves the container of the multiple elements, hide that elements.
        //https://stackoverflow.com/questions/347439/custom-controls-in-c-sharp-windows-forms-mouse-event-question
        private void Item_MouseLeave(object sender, EventArgs e)
        {
            Rectangle screenBounds = new Rectangle(this.PointToScreen(Panel_Container.Location), Panel_Container.Size);
            if (!screenBounds.Contains(MousePosition))
            {
                Panel_Hover_Top.Visible = false;
                Panel_Hover_Bottom.Visible = false;
            }
        }

        public void HideHover()
        {
            Panel_Hover_Top.Visible = false;
            Panel_Hover_Bottom.Visible = false;
        }

        public BorrowingModel Borrow
        {
            set {
                Image_BookCover.Image = Helpers.ConvertByteToImage(value.book.book_cover, Image_BookCover.Image);
                _borrow = value;
            }
            get
            {
                return _borrow;
            }
        }
        public static BookStatusItem GetItemFromButton(object Button)
        {
            try
            {
                return ((Button as Button).Parent.Parent as BookStatusItem);
            }
            catch
            {
                return null;
            }
        }

        public event EventHandler ButtonHandler;
        private void ButtonClickEvent(object sender, EventArgs e)
        {
            Helpers.SendEvent(ButtonHandler, sender, e);
        }
    }
}
