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
using PresentationLayer.Resources;

namespace PresentationLayer.Dialogs
{
    public partial class StudentDetails : Form
    {
        private CustomAppContext AppContext;
        private BorrowingService BorrowingService1;

        public StudentDetails(CustomAppContext _appContext, int StudentId)
        {
            InitializeComponent();
            AppContext = _appContext;
            BorrowingService1 = new BorrowingService(AppContext);
            var Borrowing1 = BorrowingService1.GetBorrowingsForStudent(StudentId);
            Helpers.InitGenericTableStyle(ref dataGridView1);
            dataGridView1.DataSource = Borrowing1;
            this.Text = Strings.UserDetailsFormTitle;
            BookDetails.BorrowingTableCustomize(ref dataGridView1, new string[] { Strings.BookTableName, Strings.BookTableBorrowDate, Strings.BookTableReturnDate }, alertBox1);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BookDetails.StatusColorHandler(ref dataGridView1, ref sender, ref e);
        }
    }
}
