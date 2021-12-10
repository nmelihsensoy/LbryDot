using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using Entities;

namespace PresentationLayer.Dialogs
{
    public partial class BookDetails : Form
    {
        private CustomAppContext AppContext;
        private BookModel _book;
        private BorrowingService BorrowingService1;

        public BookDetails(CustomAppContext _appContext, BookModel Book)
        {
            AppContext = _appContext;
            BorrowingService1 = new BorrowingService(AppContext);
            _book = Book;
            InitializeComponent();
            SetBookDetailsById();
            InitTable();
            bookListItem1.MakeExtendedListItem();
            if (AppContext.GetUserType() == UserType.Staff)
            {
                dataGridView1.DataSource = BorrowingService1.GetBorrowingsForBook(_book.book_id);
            }
            else
            {
                dataGridView1.DataSource = BorrowingService1.GetBorrowingsForBook(_book.book_id, true);
            }
            TableCustom();
        }

        private void SetBookDetailsById()
        {
            bookListItem1.MakeExtendedListItem();
            bookListItem1.SetUserPrivilege(UserType.Student);
            bookListItem1.Book = _book;
        }

        private void TableCustom()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Student Name";
                dataGridView1.Columns[1].HeaderText = "Borrow Date";
                dataGridView1.Columns[2].HeaderText = "Return Date";
            }
        }

        private void InitTable()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ClearSelection(); 
        }

    }
}
