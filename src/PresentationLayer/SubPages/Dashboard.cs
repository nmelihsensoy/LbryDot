using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using PresentationLayer.Dialogs;
using PresentationLayer.Pages;
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
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;
using Entities;

namespace PresentationLayer.SubPages
{
    public partial class Dashboard : Form
    {
		GraphPane myPane;
		private CustomAppContext AppContext;
		private BooksService BooksService1;
		private BorrowingService BorrowingService1;
		private double[] BorrowedVal;
		private double[] ReturnedVal;
		private string[] DayTitles;

		public Dashboard(CustomAppContext _appContext)
        {
            InitializeComponent();
			AppContext = _appContext;
			BooksService1 = new BooksService(AppContext);
			BorrowingService1 = new BorrowingService(AppContext);
			SetViewForUserTypes();
			ApplyColorPalette();
			ApplyStrings();
			BorrowingService1.GetChartData(out BorrowedVal, out ReturnedVal, out DayTitles, 30);
			BarChartInit(ReturnedVal, BorrowedVal, DayTitles);
			int[] TmpPieValue = BooksService1.GetAvailableCount();
			DrawPieChart(TmpPieValue[1], (TmpPieValue[0] - TmpPieValue[1]));
		}

		private void ApplyColorPalette()
        {
			this.BackColor = ColorPalette.DashBoardBackColor;
			Panel_ActiveBooks.BackColor = ColorPalette.DashBoardPanelBackColor;
			Panel_ChartLeft.BackColor = ColorPalette.DashBoardPanelBackColor;
			Panel_ChartRight.BackColor = ColorPalette.DashBoardPanelBackColor;
			Splitter_ActiveBooksBorder.BackColor = ColorPalette.DashBoardPanelBorderColor;
			Splitter_ChartLeftBorder.BackColor = ColorPalette.DashBoardPanelBorderColor;
			Splitter_ChartRightBorder.BackColor = ColorPalette.DashBoardPanelBorderColor;
			Text_ActiveBooksTitle.ForeColor = ColorPalette.DashboardActivePanelForeColor;
		}

		private void ApplyStrings()
		{
			Text_ActiveBooksTitle.Text = Strings.ActiveBooks;
		}

		private void SetViewForUserTypes()
        {
			if (AppContext.GetUserType() == Entities.UserType.Student) {
				MyBooks.PopulateMyBooks(BorrowingService1.GetActives(4), flowLayoutPanel1, StatusItemClick);
			}
			else if (AppContext.GetUserType() == Entities.UserType.Staff)
            {
				Panel_ActiveBooks.Visible = false;
			}
        }

		private void BarChartInit(double[] Y1, double[] Y2, string[] Titles)
		{
			myPane = ZedGraphControl_1.GraphPane;
			myPane.Border.IsVisible = false;
			myPane.Margin.All = 5;
			myPane.XAxis.MajorTic.IsBetweenLabels = true;
			myPane.XAxis.Scale.TextLabels = Titles;
			myPane.XAxis.Type = ZedGraph.AxisType.Text;
			myPane.XAxis.Scale.Min = Titles.Length-4;
			myPane.XAxis.Scale.Max = Titles.Length+1;
			myPane.Chart.Fill = new Fill(new SolidBrush(ColorPalette.SettingsBackColor));
			//myPane.Chart.Fill = new Fill(ColorPalette.SettingsBackColor, Color.White);

			myPane.Legend.IsVisible = true;
			myPane.Legend.Border.IsVisible = false;
			myPane.Legend.FontSpec.Size = 14;

			myPane.Title.Text = Strings.ChartTitle;
			myPane.XAxis.Title.Text = Strings.ChartXTitle;
			myPane.YAxis.Title.Text = Strings.ChartYTitle;

            myPane.YAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.MinorStep = 1;
            myPane.YAxis.MinorTic.Size = 1;
            BarItem myCurve = myPane.AddBar(Strings.BarName1, null, Y1, Color.Transparent);
			myCurve.Bar.Border.IsVisible = false;
			myCurve.Bar.Fill = new Fill(new SolidBrush(Color.FromArgb(123, 215, 60)));

			myCurve = myPane.AddBar(Strings.BarName2, null, Y2, Color.Transparent);
			myCurve.Bar.Fill = new Fill(new SolidBrush(Color.FromArgb(252, 69, 73)));
			myCurve.Bar.Border.IsVisible = false;


			ZedGraphControl_1.AxisChange();
		}

		private void ChangeChartTitle(string NewTitle)
        {
			myPane.Title.Text = NewTitle;
			ZedGraphControl_1.Invalidate();
		}

        private void Button_ChartSettings_Click(object sender, EventArgs e)
        {
			using (var form = new DashboardGraphSettings(myPane.Title.Text))
			{
				form.StartPosition = FormStartPosition.Manual;
				form.Location = Button_ChartSettings.PointToScreen(Point.Empty);
				var result = form.ShowDialog();

				if (result == DialogResult.OK)
				{
					ChangeChartTitle(form.TitleResult);
				}
			}
		}

		private void StatusItemClick(object sender, EventArgs e)
		{ 
			
		}

		private void DrawPieChart(int value1, int value2)
		{
			chart1.Series.Clear();
			chart1.Legends.Clear();

			chart1.Legends.Add("MyLegend");
			chart1.Legends[0].Docking = Docking.Bottom;

			string seriesname = "MySeries";
			chart1.Series.Add(seriesname);
			chart1.Series[seriesname].ChartType = SeriesChartType.Doughnut;
			chart1.Series[seriesname]["PieLabelStyle"] = "Disabled";

			if (value1 < 1)
			{
				chart1.Series[seriesname].Points.AddXY("There are no any books available.", 100);
				chart1.Series[seriesname].Points[0].Color = Color.FromArgb(44, 201, 252);
			}
			else
			{
				chart1.Series[seriesname].ChartType = SeriesChartType.Doughnut;
				//chart1.Series[seriesname]["PieLabelOffset"] = "5:5";
				//chart1.Series[seriesname].SetCustomProperty("PieLabelStyle", "outside");
				
				
				chart1.Series[seriesname].Points.AddXY(Strings.AvailableBooks, value1);
				chart1.Series[seriesname].Points[0].Color = Color.FromArgb(44, 201, 252);
				chart1.Series[seriesname].Points[0].LegendText = Strings.AvailableBooks + " (#VAL{0})";
				chart1.Series[seriesname].Points.AddXY(Strings.BorrowedBooks, value2);
				chart1.Series[seriesname].Points[1].Color = Color.FromArgb(253, 169, 41);
				chart1.Series[seriesname].Points[1].LegendText = Strings.BorrowedBooks + " (#VAL{0})";
				//chart1.Series[seriesname].Label = "#VAL{0}";//"#PERCENT{0.00 %}";
			}
		}

        private void ıconButton1_Click(object sender, EventArgs e)
        {
			MainPage Parent1 = (MainPage)this.ParentForm;
			Parent1.PageNavigation(new MyBooks(AppContext));
		}

        private void Dashboard_Resize(object sender, EventArgs e)
        {
			Panel_ChartLeft.Width = this.Width * 35 / 100;
			Panel_ChartLeft.Height = this.Height * 45 / 100;

			Panel_ChartRight.Width = this.Width * 60 / 100;
			Panel_ChartRight.Height = this.Height * 45 / 100;
			Panel_ChartRight.Left = (this.Width - Panel_ChartRight.Width) - this.Padding.Right;

			Panel_ChartLeft.Width += (Panel_ChartRight.Left - Panel_ChartLeft.Right) - this.Padding.Left;
			Panel_ActiveBooks.Width = this.Width - (this.Padding.Left + this.Padding.Right);
			Panel_ActiveBooks.Height = this.Height * 45 / 100;
			Panel_ActiveBooks.Top = Panel_ChartLeft.Bottom + this.Padding.Top;
		}

        private void ZedGraphControl_1_DoubleClick(object sender, EventArgs e)
        {
            ZedGraphControl_1.ZoomOutAll(myPane);
            //ZedGraphControl_1.RestoreScale(ZedGraphControl_1.GraphPane);
        }
    }
}
