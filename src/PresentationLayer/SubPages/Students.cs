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
using PresentationLayer.Dialogs;

namespace PresentationLayer.SubPages
{
    public partial class Students : Form
    {
        private CustomAppContext AppContext;

        public Students(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            InitTable();
        }

        public void AddButtonClick(object sender, EventArgs e)
        {
            using (var form = new StudentAddUpdate(AppContext))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Success");
                }
            }
        }

        public void SearchStudent(object sender, string text, EventArgs e)
        {

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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ClearSelection();

            DataTable table = new DataTable();

            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add(123123123, "John Doe", "test@uni.edu");
            dataGridView1.DataSource = table;

            DataGridViewButtonColumn dbtn = new DataGridViewButtonColumn();
            dbtn.Width = 20;


            dbtn.Text = "Delete";
            dbtn.UseColumnTextForButtonValue = true;

            dbtn.HeaderText = "";
            dataGridView1.Columns.Add(dbtn);

            //dataGridView1.AllowUserToAddRows = false;
        }
    }   
}
