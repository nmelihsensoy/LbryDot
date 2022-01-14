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
using PresentationLayer.Resources;
using PresentationLayer.Controls;

namespace PresentationLayer.Dialogs
{
    public partial class BookDetails : Form
    {
        private CustomAppContext AppContext;
        private BookModel _book;
        private BorrowingService BorrowingService1;

        public BookDetails(CustomAppContext _appContext, BookModel Book)
        {
            InitializeComponent();
            AppContext = _appContext;
            _book = Book;
            BorrowingService1 = new BorrowingService(AppContext);
            SetBookDetailsById();
            Helpers.InitGenericTableStyle(ref dataGridView1);
            if (AppContext.GetUserType() == UserType.Staff || AppContext.GetUserType() == UserType.Admin)
            {
                dataGridView1.DataSource = BorrowingService1.GetBorrowingsForBook(_book.book_id);
            }
            else
            {
                dataGridView1.DataSource = BorrowingService1.GetBorrowingsForBook(_book.book_id, true, AppContext.GetLoggedStudent().student_name);
            }
            BorrowingTableCustomize(ref dataGridView1, new string[] { Strings.StudentTableName,  Strings.BookTableBorrowDate, Strings.BookTableReturnDate }, alertBox1);
        }

        private void SetBookDetailsById()
        {
            bookListItem1.MakeExtendedListItem();
            bookListItem1.SetUserPrivilege(UserType.Student);
            bookListItem1.Book = _book;
            this.Text = _book.title;
        }

        public static void BorrowingTableCustomize(ref DataGridView Table,  string [] ColNames, AlertBox AlertB)
        {
            if (Table.Columns.Count > 0)
            {
                AlertB.Visible = false;
                Table.Columns["Due_Date"].Visible = false;

                for (int i = 0; i < ColNames.Length; i++)
                {
                    Table.Columns[i].HeaderText = ColNames[i];
                }

                InsertStatusColumn(ref Table, 0, "Status", 7);
            }
            else
            {
                Table.Visible = false;
                AlertB.ShowAlert(AlertBox.AlertType.Warning, "Book has not borrowed yet.", false);
                AlertB.Visible = true;
            }
        }

        private static void InsertStatusColumn(ref DataGridView Table, int ColIndex, string ColName, int ColWidth)
        {
            DataGridViewColumn StatusCol = new DataGridViewColumn();
            StatusCol.CellTemplate = new DataGridViewTextBoxCell();
            StatusCol.Name = ColName;

            Table.Columns.Insert(ColIndex, StatusCol);

            if (ColWidth > 0)
            {
                Table.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                Table.Columns[0].Width = ColWidth;
            }
            else
            {
                Table.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void bookListItem1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CopyVal = "";
            if ((sender as ToolStripMenuItem).Name == "copyTitleToolStripMenuItem")
            {
                CopyVal = _book.title;
            }else if ((sender as ToolStripMenuItem).Name == "copyISBNToolStripMenuItem")
            {
                CopyVal = _book.isbn;
            }

            Clipboard.SetText(CopyVal);
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.cellformatting?view=windowsdesktop-6.0
        public static void StatusColorHandler(ref DataGridView Table, ref object sender, ref DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0) //Name="Status"
            {
                try
                {
                    int index_due = Table.Columns["Due_Date"].Index;
                    int index_returned = Table.Columns["Returned_Date"].Index;
                    DateTime CellDtDue = (DateTime)Table.Rows[e.RowIndex].Cells[index_due].Value;
                    DateTime CellDtReturned = (DateTime)Table.Rows[e.RowIndex].Cells[index_returned].Value;

                    BorrowingService.BorrowState ItemState = BorrowingService.GetBorrowState(CellDtReturned, CellDtDue, out int DayDiff);
                    Color SelectedColor = Color.White;

                    switch (ItemState)
                    {
                        case BorrowingService.BorrowState.Error:
                            break;
                        case BorrowingService.BorrowState.Borrowed:
                            SelectedColor = ColorPalette.TableNormalColor;
                            break;
                        case BorrowingService.BorrowState.Late:
                            SelectedColor = ColorPalette.TableLateColor;
                            break;
                        case BorrowingService.BorrowState.TwoDaysLeft:
                            SelectedColor = ColorPalette.Table2DaysLeftColor;
                            break;
                        case BorrowingService.BorrowState.Returned:
                            SelectedColor = ColorPalette.TableReturnedColor;
                            break;
                        default:
                            break;
                    }

                    e.CellStyle.BackColor = SelectedColor;
                    Table.Rows[e.RowIndex].Cells[0].Style.SelectionBackColor = SelectedColor;
                }
                catch
                {

                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            StatusColorHandler(ref dataGridView1, ref sender, ref e);
        }
    }
}
