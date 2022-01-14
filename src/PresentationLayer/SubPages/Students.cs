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
using PresentationLayer.Resources;

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
            this.BackColor = ColorPalette.StudentsPageBackColor;
            Table_Students.BackgroundColor = ColorPalette.StudentsPageBackColor;
        }

        private void ApplyStrings()
        {

        }
        private void InitAlert(ref AlertBox AlertB)
        {
            AlertB = new AlertBox();
            AlertB.Width = this.Width / 2;
            AlertB.Top = Table_Students.Top;
            AlertB.Left = Table_Students.Left;
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
            ClearTable();
            var SearchResults = StudentsService1.SearchStudent(text);
            Table_Students.DataSource = SearchResults;
            IsFiltered = true;
            if (SearchResults.Count > 0) {
                this.Controls.Remove(StudentsAlert);
                AddTableButtons();
                TableCustom();
            }
            if (SearchResults.Count < 1)
            {
                this.Controls.Remove(StudentsAlert);
                StudentsAlert.ShowAlert(AlertBox.AlertType.Danger, text+" "+Strings.SearchNotFoundMessage);
                StudentsAlert.Visible = true;
                this.Controls.Add(StudentsAlert);
                StudentsAlert.BringToFront();
            }
        }

        private void ClearTable()
        {
            Table_Students.DataSource = null;
            Table_Students.Columns.Clear();
            Table_Students.Rows.Clear();
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
            ClearTable();
            AllStudents = StudentsService1.GetAllStudents();
            InitTable();
        }

        private void InitTable()
        {
            if (AllStudents.Count > 0)
            {
                Table_Students.DataSource = null;
                Table_Students.Columns.Clear();
                Table_Students.Rows.Clear();
                Table_Students.DataSource = AllStudents;
                this.Controls.Remove(StudentsAlert);
                ApplyTableStyle();
                AddTableButtons();
                TableCustom();
            }

            if (AllStudents.Count < 1)
            {
                StudentsAlert.ShowAlert(AlertBox.AlertType.Warning, Strings.StudentTableEmptyMessage);
                StudentsAlert.Visible = true;
                this.Controls.Add(StudentsAlert);
                StudentsAlert.BringToFront();
            }
        }

        private void ApplyTableStyle()
        {
            Table_Students.RowHeadersVisible = false;
            Table_Students.BorderStyle = BorderStyle.None;
            Table_Students.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            Table_Students.DefaultCellStyle.SelectionBackColor = Table_Students.DefaultCellStyle.BackColor;
            Table_Students.DefaultCellStyle.SelectionForeColor = Table_Students.DefaultCellStyle.ForeColor;
            Table_Students.EnableHeadersVisualStyles = false;
            Table_Students.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Table_Students.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            Table_Students.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.StudentsPageBackColor;
            Table_Students.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.StudentsPageTableForeColor;
            Table_Students.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Table_Students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table_Students.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Table_Students.RowTemplate.Height = 30;
            Table_Students.AllowUserToResizeRows = false;
            Table_Students.AllowUserToResizeColumns = false;
            Table_Students.ClearSelection();
            Table_Students.ReadOnly = true;
        }

        private void AddTableButtons()
        {
            //Details Button
            DataGridViewButtonColumn dbtn3 = new DataGridViewButtonColumn();
            dbtn3.Name = "Button_Details";
            dbtn3.Width = 20;

            dbtn3.Text = Strings.StudentTableDetails;
            dbtn3.UseColumnTextForButtonValue = true;

            dbtn3.HeaderText = "";
            dbtn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dbtn3.ReadOnly = false;
            //dbtn.DefaultCellStyle.Padding = null;
            Table_Students.Columns.Add(dbtn3);

            //Edit Button
            DataGridViewButtonColumn dbtn = new DataGridViewButtonColumn();
            dbtn.Name = "Button_Edit";
            dbtn.Width = 20;

            dbtn.Text = Strings.StudentTableEdit;
            dbtn.UseColumnTextForButtonValue = true;

            dbtn.HeaderText = "";
            dbtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dbtn.ReadOnly = false;
            //dbtn.DefaultCellStyle.Padding = null;
            Table_Students.Columns.Add(dbtn);

            //Delete Button
            DataGridViewButtonColumn dbtn2 = new DataGridViewButtonColumn();
            dbtn2.Width = 20;
            dbtn2.Name = "Button_Delete";

            dbtn2.Text = Strings.StudentTableDelete;
            dbtn2.UseColumnTextForButtonValue = true;

            dbtn2.HeaderText = "";
            dbtn2.ReadOnly = false;
            Table_Students.Columns.Add(dbtn2);
            Table_Students.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void TableCustom()
        {
            Table_Students.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Change column titles
            Table_Students.Columns[0].HeaderText = Strings.StudentTableNumber;
            Table_Students.Columns[1].HeaderText = Strings.StudentTableName;
            Table_Students.Columns[2].HeaderText = Strings.StudentTableEmail;
            Table_Students.Columns[3].HeaderText = Strings.StudentTableOperations;
        }

        //https://stackoverflow.com/questions/3577297/how-to-handle-click-event-in-button-column-in-datagridview
        private void Table_Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int SelectedStudentId = (int)Table_Students.Rows[e.RowIndex].Cells["Student_Number"].Value;
                    if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Edit")
                    {
                        HandleDialog(SelectedStudentId);
                    }
                    else if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Delete")
                    {
                        DialogResult dialogResult = MessageBox.Show(Strings.Delete + " \"" + Table_Students.Rows[e.RowIndex].Cells["Student_Name"].Value.ToString() + "\"", Strings.SureDialog, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                StudentsService1.DeleteStudentById(SelectedStudentId);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                            
                            RefreshTable();
                        }
                    }
                    else if ((senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Name == "Button_Details")
                    {
                        using (var form = new StudentDetails(AppContext, SelectedStudentId))
                        {
                            var result = form.ShowDialog();
                        }
                    }
                }
            }
        }
    }   
}
