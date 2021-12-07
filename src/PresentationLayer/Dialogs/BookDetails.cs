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
        private int BookId;
        private BooksService BooksService1;

        public BookDetails(CustomAppContext _appContext, int _bookId)
        {
            AppContext = _appContext;
            BooksService1 = new BooksService(AppContext);
            BookId = _bookId;
            InitializeComponent();
            SetBookDetailsById();
            InitTable();
        }

        private void SetBookDetailsById()
        {
            BookModel Book1 = BooksService1.GetBookById(BookId);
            bookListItem1.MakeExtendedListItem();
            bookListItem1.SetUserPrivilege(UserType.Student);
            bookListItem1.Book = Book1;
        }

        private void InitTable()
        {
            bookListItem1.MakeExtendedListItem();
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

            DataTable table = new DataTable();

            table.Columns.Add("Student", typeof(string));
            table.Columns.Add("Borrow Date", typeof(string));
            table.Columns.Add("Returned Date", typeof(string));

            table.Rows.Add("John Doe", "01.11.2021", "09.11.2021");
            dataGridView1.DataSource = table;
        }

    }
}
