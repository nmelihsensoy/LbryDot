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
using PresentationLayer.Controls;

namespace PresentationLayer.SubPages
{
    public partial class Students : Form
    {
        private CustomAppContext AppContext;
        private StudentsService StudentsService1;
        private List<object> AllStudents;
        private bool IsFiltered = false;
        private AlertBox StudentsAlert;

        public Students(CustomAppContext _appContext)
        {
            InitializeComponent();
            AppContext = _appContext;
            StudentsService1 = new StudentsService(AppContext);
            InitAlert(ref StudentsAlert);
            RefreshTable();
            ApplyColorPalette();
            ApplyStrings();
        }

        private void ApplyColorPalette()
        {
            this.BackColor = Color.FromArgb(247, 248, 250);
            dataGridView1.BackgroundColor = Color.FromArgb(247, 248, 250);
        }

        private void ApplyStrings()
        {

        }
        private void InitAlert(ref AlertBox AlertB)
        {
            AlertB = new AlertBox();
            AlertB.Width = this.Width / 2;
            AlertB.Top = dataGridView1.Top;
            AlertB.Left = dataGridView1.Left;
        }

        public void AddButtonClick(object sender, EventArgs e)
        {
            HandleDialog();
        }

        private void HandleDialog(int StudentId = -1) {
            Form Dialog1;
            if (StudentId == -1) {
                Dialog1 = new UserAddUpdate(AppContext);
            }
            else
            {
                Dialog1 = new UserAddUpdate(AppContext, UserType.Student, StudentId);
            }
            using (var form = Dialog1)
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshTable();
                }
            }
        }

        public void SearchStudent(object sender, string text, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            var SearchResults = StudentsService1.SearchStudent(text);
            dataGridView1.DataSource = SearchResults;
            IsFiltered = true;
            if (SearchResults.Count > 0) {
                this.Controls.Remove(StudentsAlert);
                AddTableButtons();
                TableCustom();
            }
            if (SearchResults.Count < 1)
            {
                this.Controls.Remove(StudentsAlert);
                StudentsAlert.ShowAlert(AlertBox.AlertType.Danger, text+" couldn't find");
                StudentsAlert.Visible = true;
                this.Controls.Add(StudentsAlert);
                StudentsAlert.BringToFront();
            }
        }

        public void SearchReset()
        {
            if (IsFiltered)
            {
                this.Controls.Remove(StudentsAlert);
                InitTable();
            }
        }

        private void RefreshTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            AllStudents = StudentsService1.GetAllStudents();
            InitTable();
        }

        private void InitTable()
        {
            if (AllStudents.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = AllStudents;
                this.Controls.Remove(StudentsAlert);
                ApplyTableStyle();
                AddTableButtons();
                TableCustom();
            }

            if (AllStudents.Count < 1)
            {
                StudentsAlert.ShowAlert(AlertBox.AlertType.Warning, "Zero Student");
                StudentsAlert.Visible = true;
                this.Controls.Add(StudentsAlert);
                StudentsAlert.BringToFront();
            }
        }

        private void ApplyTableStyle()
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
            DataGridViewButtonColumn dbtn3 = new DataGridViewButtonColumn();
            dbtn3.Name = "Button_Details";
            dbtn3.Width = 20;

            dbtn3.Text = "Details";
            dbtn3.UseColumnTextForButtonValue = true;

            dbtn3.HeaderText = "";
            dbtn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dbtn3.ReadOnly = false;
            //dbtn.DefaultCellStyle.Padding = null;
            dataGridView1.Columns.Add(dbtn3);

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
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                        HandleDialog(SelectedStudentId);
                    }
                    else if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Delete")
                    {
                        DialogResult dialogResult = MessageBox.Show("Delete \"" + dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].Value.ToString() + "\"", "Are You Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            StudentsService1.DeleteStudentById(SelectedStudentId);
                            RefreshTable();
                        }
                    }else if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Details")
                    {
                        using (var form = new UserDetails(AppContext, SelectedStudentId))
                        {
                            var result = form.ShowDialog();
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Detail Page + " + SelectedStudentId.ToString());
                }
            }

        }
    }   
}
