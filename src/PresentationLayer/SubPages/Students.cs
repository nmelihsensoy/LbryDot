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
using BusinessLogicLayer.Services;
using Entities;

namespace PresentationLayer.SubPages
{
    public partial class Students : Form
    {
        private CustomAppContext AppContext;
        private StudentsService StudentsService1;
        private List<object> AllStudents;

        public Students(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            StudentsService1 = new StudentsService(AppContext);
            AllStudents = StudentsService1.GetAllStudents();
            dataGridView1.DataSource = AllStudents;
            InitTable();
            AddTableButtons();
            TableCustom();
            this.BackColor = Color.FromArgb(247, 248, 250);
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
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = StudentsService1.SearchStudent(text);
            AddTableButtons();
            TableCustom();
        }

        private void InitTable()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 248, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(28, 36, 59);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ClearSelection();
            dataGridView1.ReadOnly = true;
        }

        private void AddTableButtons()
        {
            DataGridViewButtonColumn dbtn = new DataGridViewButtonColumn();
            dbtn.Name = "Button_Edit";
            dbtn.Width = 20;


            dbtn.Text = "Edit";
            dbtn.UseColumnTextForButtonValue = true;

            dbtn.HeaderText = "";
            dbtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dbtn.ReadOnly = false;
            //dbtn.DefaultCellStyle.Padding = null;
            dataGridView1.Columns.Add(dbtn);

            DataGridViewButtonColumn dbtn2 = new DataGridViewButtonColumn();
            dbtn2.Width = 20;
            dbtn2.Name = "Button_Delete";


            dbtn2.Text = "Delete";
            dbtn2.UseColumnTextForButtonValue = true;

            dbtn2.HeaderText = "";
            dbtn2.ReadOnly = false;
            dataGridView1.Columns.Add(dbtn2);
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void TableCustom()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Student Number";
            dataGridView1.Columns[1].HeaderText = "Student Name";
            dataGridView1.Columns[2].HeaderText = "Student Email";
            dataGridView1.Columns[3].HeaderText = "Operations";
        }

        //https://stackoverflow.com/questions/3577297/how-to-handle-click-event-in-button-column-in-datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int SelectedStudentId = (int)dataGridView1.Rows[e.RowIndex].Cells["Student_Number"].Value;
                    if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Edit")
                    {
                        using (var form = new StudentAddUpdate(AppContext, SelectedStudentId))
                        {
                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {

                            }
                            else
                            {
                                //MessageBox.Show("Didnt Changed");
                            }
                        }
                    }
                    else if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Delete")
                    {
                        DialogResult dialogResult = MessageBox.Show("Delete \"" + dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].Value.ToString() + "\"", "Are You Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {

                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Detail Page");
                }
            }

        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 3)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.DimGray;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 3)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
            }
        }
    }   
}
