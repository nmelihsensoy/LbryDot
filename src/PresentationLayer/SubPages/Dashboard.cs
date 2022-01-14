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
using PresentationLayer.Controls;

namespace PresentationLayer.SubPages
{
    public partial class Dashboard : Form
    {
		GraphPane myPane;
		GraphPane myPane2;
		private CustomAppContext AppContext;
		private BooksService BooksService1;
		private BorrowingService BorrowingService1;
		private StudentsService StudentsService1;
		private StaffService StaffService1;
		private double[] BorrowedVal;
		private double[] ReturnedVal;
		private string[] DayTitles;
		int[] TmpPieValue;

		public Dashboard(CustomAppContext _appContext)
        {
            InitializeComponent();
			AppContext = _appContext;
			BooksService1 = new BooksService(AppContext);
			BorrowingService1 = new BorrowingService(AppContext);
			StudentsService1 = new StudentsService(AppContext);
			StaffService1 = new StaffService(AppContext);
			SetViewForUserTypes();
			ApplyColorPalette();
			ApplyStrings();
			BorrowingService1.GetChartData(out BorrowedVal, out ReturnedVal, out DayTitles, 30);
			BarChartInit(ReturnedVal, BorrowedVal, DayTitles);
			TmpPieValue = BooksService1.GetAvailableCount();
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
			label1.ForeColor = ColorPalette.DashboardActivePanelForeColor;
			label4.ForeColor = ColorPalette.DashboardActivePanelForeColor;
			label2.ForeColor = ColorPalette.DashboardWidgetColor1;
			label3.ForeColor = ColorPalette.DashboardWidgetColor2;
			splitter2.BackColor = ColorPalette.DashboardWidgetColor1;
			splitter3.BackColor = ColorPalette.DashboardWidgetColor2;
		}

		private void ApplyStrings()
		{
			Text_ActiveBooksTitle.Text = Strings.ActiveBooks;
			label1.Text = Strings.TotalStudent;
			label4.Text = Strings.TotalStaff;
		}

		private void RefreshMyBooks()
        {
			flowLayoutPanel1.Controls.Clear();
			MyBooks.PopulateMyBooks(BorrowingService1.GetActives(4), flowLayoutPanel1, StatusItemClick);
		}

		private void SetViewForUserTypes()
        {
			if (AppContext.GetUserType() == Entities.UserType.Student) {
				RefreshMyBooks();
			}
			else if (AppContext.GetUserType() == Entities.UserType.Staff || AppContext.GetUserType() == Entities.UserType.Admin)
            {
				Panel_ActiveBooks.Visible = false;
				panel1.Visible = true;
				panel2.Visible = true;
				panel3.Visible = true;
				StaffChartInit();
				TotalWidgetsInit();
			}
        }

		private void TotalWidgetsInit()
        {
			label2.Text = StudentsService1.GetStudentsCount().ToString();
			label3.Text = StaffService1.GetStaffCount().ToString();
		}

		private void BarChartInit(double[] Y1, double[] Y2, string[] Titles)
		{
			myPane = ZedGraphControl_1.GraphPane;
			//ZedGraphControl_1.IsEnableHZoom = false;
			//ZedGraphControl_1.IsEnableVZoom = true;

			myPane.Border.IsVisible = false;
			myPane.Margin.All = 5;
			myPane.XAxis.MajorTic.IsBetweenLabels = true;
			myPane.XAxis.Scale.TextLabels = Titles;
			myPane.XAxis.Type = ZedGraph.AxisType.Text;
			myPane.XAxis.Scale.Min = Titles.Length-4.5;
			myPane.XAxis.Scale.Max = Titles.Length+0.5;
			myPane.Chart.Fill = new Fill(new SolidBrush(ColorPalette.SettingsBackColor));

			myPane.Legend.IsVisible = true;
			myPane.Legend.Border.IsVisible = false;
			myPane.Legend.FontSpec.Size = 14;

			myPane.Title.Text = Strings.ChartTitle;
			myPane.XAxis.Title.Text = Strings.ChartXTitle;
			myPane.YAxis.Title.Text = Strings.ChartYTitle;

            myPane.YAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.MinorStep = 1;
            myPane.YAxis.MinorTic.Size = 1;
            BarItem myCurve = myPane.AddBar(Strings.BarName2, null, Y2, Color.Transparent);
			myCurve.Bar.Border.IsVisible = false;
			myCurve.Bar.Fill = new Fill(new SolidBrush(ColorPalette.DashboardRightWidgetColor1));

			myCurve = myPane.AddBar(Strings.BarName1, null, Y1, Color.Transparent);
			myCurve.Bar.Fill = new Fill(new SolidBrush(ColorPalette.DashboardRightWidgetColor2));
			myCurve.Bar.Border.IsVisible = false;


			ZedGraphControl_1.AxisChange();
		}

		private void StaffChartInit()
		{
			zedGraphControl1.IsShowPointValues = true;
			myPane2 = zedGraphControl1.GraphPane;
			zedGraphControl1.IsEnableHZoom = true;
			zedGraphControl1.IsEnableVZoom = false;
			zedGraphControl1.IsEnableVPan = false;

            myPane2.Border.IsVisible = false;
			myPane2.Legend.Border.IsVisible = false;
			myPane2.Margin.All = 5;

            myPane2.XAxis.Type = ZedGraph.AxisType.Date;
            myPane2.XAxis.Scale.Format = "dd-MMM-yy";
            myPane2.XAxis.Scale.MajorUnit = DateUnit.Day;
            myPane2.XAxis.Scale.MinorStep = 1;
            myPane2.XAxis.Scale.Min = new XDate(DateTime.Now.AddDays(-7));
            myPane2.XAxis.Scale.Max = new XDate(DateTime.Today);

			myPane2.Chart.Fill = new Fill(new SolidBrush(ColorPalette.GenericFormBackColor));

			myPane2.Legend.IsVisible = true;
			myPane2.Legend.FontSpec.Size = 14;

			myPane2.Title.Text = Strings.DashboardStaffChartTitle;
			myPane2.XAxis.Title.Text = Strings.DashboardStaffChartXTitle;
			myPane2.YAxis.Title.Text = Strings.DashboardStaffChartYTitle;

			PointPairList list1 = new PointPairList();
			PointPairList list2 = new PointPairList();

			var BookStatsTemp = BooksService1.GetBookChartData();

            foreach (var item in BookStatsTemp)
            {
				list2.Add(new XDate(item.date.Date), item.count);
            }
            if (BookStatsTemp.Count > 0)
            {
				//list2.Add(new XDate(DateTime.Today.Date), BookStatsTemp.Last<StatModel>().count);
				StatModel TmpModel = BookStatsTemp.Last<StatModel>();
				DateTime TmpDate = TmpModel.date.Date;
				DateTime TmpToday = DateTime.Today.Date;
				while (DateTime.Compare(TmpDate, TmpToday) < 0 )
                {
					TmpDate = TmpDate.AddDays(+1);
					list2.Add(new XDate(TmpDate), TmpModel.count);
				}
			}

			var BorrowedDataTemp = BorrowingService1.GetFullChartData();
			bool IsItemZero = false;
			foreach (var item in BorrowedDataTemp)
			{
                if (IsItemZero)
                {
					list1.Add(new XDate(item.date.AddDays(-1).Date), 0);
					IsItemZero = false;
				}
				list1.Add(new XDate(item.date.Date), item.count);
				if (item.count == 0) IsItemZero = true;
			}

            if (BorrowedDataTemp.Count > 0)
            {
				list1.Add(new XDate(DateTime.Today.Date), BorrowedDataTemp.Last<StatModel>().count);
			}

			LineItem myCurve = myPane2.AddCurve(Strings.DashboardStaffChartCurveTitle1,
				list1, ColorPalette.DashboardStaffChartColor1, SymbolType.Diamond);

			LineItem myCurve2 = myPane2.AddCurve(Strings.DashboardStaffChartCurveTitle2,
				list2, ColorPalette.DashboardStaffChartColor2, SymbolType.Circle);;

			BarItem myCurve3 = myPane2.AddBar(Strings.DashboardStaffChartCurveTitle3, null, null, Color.Transparent);
			myCurve3.Bar.Fill = new Fill(new SolidBrush(ColorPalette.DashboardStaffChartColor3));
			myCurve3.Bar.Border.Color = ColorPalette.DashboardStaffChartColor4;

			myPane2.XAxis.MajorGrid.IsVisible = true;
			myPane2.YAxis.MajorGrid.IsVisible = true;
			myPane2.XAxis.MajorGrid.Color = ColorPalette.DashboardStaffChartColor5;
			myPane2.YAxis.MajorGrid.Color = ColorPalette.DashboardStaffChartColor5;

			myPane2.Legend.Position = ZedGraph.LegendPos.Top;

			myCurve.Line.Width = 1.5F;
			myCurve2.Line.Width = 3.0F;

			myCurve.Line.Fill = new Fill(new SolidBrush(ColorPalette.DashboardStaffChartColor6)); 
			myCurve2.Line.Fill = new Fill(new SolidBrush(ColorPalette.DashboardStaffChartColor7));
			//myCurve.Line.IsSmooth = true;
			//myCurve.Line.SmoothTension = 0.2F;

			myCurve.Symbol.Size = 20.0F;
			myCurve2.Symbol.Size = 15.0F;
			myCurve.Symbol.Fill = new Fill(ColorPalette.GenericFormBackColor);
			myCurve2.Symbol.Fill = new Fill(ColorPalette.GenericFormBackColor);

			zedGraphControl1.AxisChange();
		}

		private void ChangeChartTitle(string NewTitle, ZedGraphControl Zgc)
        {
			Zgc.GraphPane.Title.Text = NewTitle;
			Zgc.Invalidate();
		}

        private void Button_ChartSettings_Click(object sender, EventArgs e)
        {
			Form GraphSettingsDialog;
			Point StartP = (sender as Button).PointToScreen(Point.Empty);
			ZedGraphControl SelectedChart;

			if ((sender as Button).Name == "Button_ChartSettings")
            {
				GraphSettingsDialog = new DashboardGraphSettings(myPane.Title.Text, Strings.ChartTitle);
				SelectedChart = ZedGraphControl_1;
			}
            else if((sender as Button).Name == "iconButton1")
            {
				GraphSettingsDialog = new DashboardGraphSettings(zedGraphControl1.GraphPane.Title.Text, Strings.DashboardStaffChartTitle);
				SelectedChart = zedGraphControl1;
            }
            else
            {
				return;
            }
	
			Helpers.SetFormStartPoint(ref GraphSettingsDialog, StartP, 0, 0);

			if (GraphSettingsDialog.ShowDialog() == DialogResult.OK)
			{
				ChangeChartTitle((GraphSettingsDialog as DashboardGraphSettings).TitleResult, SelectedChart);
			}
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
				chart1.Series[seriesname].Points.AddXY(Strings.DashboardPieChartEmptyMessage, 100);
				chart1.Series[seriesname].Points[0].Color = ColorPalette.DashboardPieChartColor1;
			}
			else
			{
				chart1.Series[seriesname].ChartType = SeriesChartType.Doughnut;
				//chart1.Series[seriesname]["PieLabelOffset"] = "5:5";
				//chart1.Series[seriesname].SetCustomProperty("PieLabelStyle", "outside");

				chart1.Series[seriesname].Points.AddXY(Strings.AvailableBooks, value1);
				chart1.Series[seriesname].Points[0].Color = ColorPalette.DashboardPieChartColor1;
				chart1.Series[seriesname].Points[0].LegendText = Strings.AvailableBooks + " (#VAL{0})";
				chart1.Series[seriesname].Points.AddXY(Strings.BorrowedBooks, value2);
				chart1.Series[seriesname].Points[1].Color = ColorPalette.DashboardPieChartColor2;
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

			panel1.Top = Panel_ChartLeft.Bottom + this.Padding.Top;
			panel1.Height = this.Height * 45 / 100;

			panel2.Top = Panel_ChartLeft.Bottom + this.Padding.Top;
			panel2.Left = this.Padding.Left;
			panel3.Left = this.Padding.Left;
			panel2.Height = (panel1.Height - this.Padding.Top) * 50 / 100;
			panel3.Height = panel2.Height;
			panel2.Width = this.Width * 25 / 100;
			panel3.Width = panel2.Width;
			panel3.Top = panel2.Bottom + this.Padding.Top;

			panel1.Left = panel2.Right + this.Padding.Right;
			panel1.Width = this.Width - (panel2.Width + this.Padding.Left + this.Padding.Right + this.Padding.Right);
		}

        private void ZedGraphControl_1_DoubleClick(object sender, EventArgs e)
        {
            ZedGraphControl_1.ZoomOutAll(myPane);
			ChangeChartTitle(Strings.ChartTitle, ZedGraphControl_1);
			//ZedGraphControl_1.RestoreScale(ZedGraphControl_1.GraphPane);
		}

		private void RightChartScaleY(object sender, EventArgs e)
        {
			//ZedGraphControl_1.RestoreScale(myPane);
			myPane.YAxis.Scale.Min = 0;
			myPane.YAxis.Scale.MaxAuto = true;
			ZedGraphControl_1.AxisChange();
			ZedGraphControl_1.Invalidate();
		}

		private void RightChartHelp(object sender, EventArgs e)
        {

        }

        private void ZedGraphControl_1_ContextMenuBuilder(ZedGraphControl sender, ContextMenuStrip menuStrip, Point mousePt, ZedGraphControl.ContextMenuObjectState objState)
        {
			ToolStripMenuItem item1 = new ToolStripMenuItem();
			item1.Name = "scale_y_axis";
			item1.Text = Strings.DashboardChartScaleYAxis;
			item1.Click += RightChartScaleY;
			menuStrip.Items.Add(item1);

			ToolStripMenuItem item2 = new ToolStripMenuItem();
			item2.Name = "info";
			item2.Text = Strings.DashboardChartInfoMenuTitle;
			item2.Click += RightChartHelp;
			menuStrip.Items.Add(item2);
		}

        private void zedGraphControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			zedGraphControl1.ZoomOutAll(zedGraphControl1.GraphPane);
		}

		private void StatusItemClick(object sender, EventArgs e)
		{
			DialogResult Result = DialogResult.Abort;
			if ((sender as Button).Name == "Button_ReturnBook")
			{
				Form ReturnDialog = new BookReturn(AppContext, BookStatusItem.GetItemFromButton(sender).Borrow);
				Point StartP = (sender as Button).PointToScreen(Point.Empty);
				Helpers.SetFormStartPoint(ref ReturnDialog, StartP, 10);

				Result = ReturnDialog.ShowDialog();
			}
			else if ((sender as Button).Name == "Button_BookDetails")
			{
				Result = new BookDetails(AppContext, BookStatusItem.GetItemFromButton(sender).Borrow.book).ShowDialog();
			}
			if (Result == DialogResult.OK || Result == DialogResult.Yes)
			{
				RefreshMyBooks();
				AppContext.UpdateFine();
			}
			else
			{
				BookStatusItem.GetItemFromButton(sender).HideHover();
			}
		}
    }
}
