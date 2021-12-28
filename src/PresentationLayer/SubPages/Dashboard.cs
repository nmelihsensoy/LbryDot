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
			label2.ForeColor = Color.FromArgb(255, 67, 67);
			label3.ForeColor = Color.FromArgb(24, 200, 255);
			splitter2.BackColor = Color.FromArgb(255, 67, 67);
			splitter3.BackColor = Color.FromArgb(24, 200, 255);
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
            BarItem myCurve = myPane.AddBar(Strings.BarName2, null, Y2, Color.Transparent);
			myCurve.Bar.Border.IsVisible = false;
			myCurve.Bar.Fill = new Fill(new SolidBrush(Color.FromArgb(123, 215, 60)));

			myCurve = myPane.AddBar(Strings.BarName1, null, Y1, Color.Transparent);
			myCurve.Bar.Fill = new Fill(new SolidBrush(Color.FromArgb(252, 69, 73)));
			myCurve.Bar.Border.IsVisible = false;


			ZedGraphControl_1.AxisChange();
		}

		private void StaffChartInit2()
		{
			myPane2 = zedGraphControl1.GraphPane;

			myPane2.Border.IsVisible = false;
			myPane2.Margin.All = 5;

            myPane2.XAxis.Type = ZedGraph.AxisType.Date;
            myPane2.XAxis.Scale.Format = "dd-MMM-yy";
            myPane2.XAxis.Scale.MajorUnit = DateUnit.Day;
            myPane2.XAxis.Scale.MajorStep = 1;
            myPane2.XAxis.Scale.Min = new XDate(DateTime.Now.AddDays(-7));
            myPane2.XAxis.Scale.Max = new XDate(DateTime.Today);

            myPane2.Chart.Fill = new Fill(new SolidBrush(ColorPalette.SettingsBackColor));

			myPane2.Legend.IsVisible = true;
			myPane2.Legend.Border.IsVisible = false;
			myPane2.Legend.FontSpec.Size = 14;

			myPane2.Title.Text = "Title";
			myPane2.XAxis.Title.Text = "Days";
			myPane2.YAxis.Title.Text = "Count";

            //double[] y = { 100, 115, 75};
            //double[] y2 = { 90, 100, 95};
            //double[] y3 = { 80, 110, 65};




            PointPairList list1 = new PointPairList();
			PointPairList list2 = new PointPairList();
			PointPairList list3 = new PointPairList();
			list1.Add(new XDate(DateTime.Today), 100);
			list2.Add(new XDate(DateTime.Today), 150);
			list3.Add(new XDate(DateTime.Today), 150);

			list1.Add(new XDate(DateTime.Today.AddDays(-1)), 80);
			list2.Add(new XDate(DateTime.Today.AddDays(-1)), 150);
			list3.Add(new XDate(DateTime.Today.AddDays(-1)), 150);

			list1.Add(new XDate(DateTime.Today.AddDays(-2)), 20);
			list2.Add(new XDate(DateTime.Today.AddDays(-2)), 180);
			list3.Add(new XDate(DateTime.Today.AddDays(-2)), 180);


			LineItem myCurve3 = myPane2.AddCurve("Curve 4",
			list3, Color.Black, SymbolType.Circle);
			//myCurve3.Line.Fill = new Fill(Color.White, Color.LightSkyBlue, -45F);

			myCurve3.Symbol.Size = 8.0F;
			myCurve3.Symbol.Fill = new Fill(Color.White);
			myCurve3.Line.Width = 2.0F;

			CurveItem myCurve = myPane2.AddBar("Porsche",
				list1, Color.Red);

			CurveItem myCurve2 = myPane2.AddBar("TEST",
				list2, Color.Blue);

			

			// Indicate that the bars are overlay type, which are drawn on top of eachother
			myPane2.BarSettings.Type = BarType.Overlay;

			// Fill the axis background with a color gradientC:\Documents and Settings\champioj\Desktop\ZedGraph-4.9-CVS\demo\ZedGraph.Demo\StepChartDemo.cs
			myPane2.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0F);

			zedGraphControl1.AxisChange();
			//myPane2.YAxis.Scale.Max += myPane2.YAxis.Scale.MajorStep;
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
            //myPane2.XAxis.Scale.MajorStep = 1;
            myPane2.XAxis.Scale.MinorStep = 1;
            myPane2.XAxis.Scale.Min = new XDate(DateTime.Now.AddDays(-7));
            myPane2.XAxis.Scale.Max = new XDate(DateTime.Today);

			myPane2.Chart.Fill = new Fill(new SolidBrush(Color.White));

			myPane2.Legend.IsVisible = true;
			myPane2.Legend.FontSpec.Size = 14;

			myPane2.Title.Text = "Available Books By Days";
			myPane2.XAxis.Title.Text = "Days";
			myPane2.YAxis.Title.Text = "Count";

			PointPairList list1 = new PointPairList();
			PointPairList list2 = new PointPairList();
			//for (int i = 0; i < 36; i++)
			//{
			//	double x = (double)i + 5;
			//	double y1 = 1.5 + Math.Sin((double)i * 0.2);
			//	double y2 = 3.0 * (1.5 + Math.Sin((double)i * 0.2));
			//	list1.Add(x, y1);
			//	list2.Add(x, y2);
			//}

			//list2.Add(new XDate(DateTime.Today.AddDays(-30)), 10);
			//list2.Add(new XDate(DateTime.Today.AddDays(-25)), 12);
			//list2.Add(new XDate(DateTime.Today), 12);

			//list1.Add(new XDate(DateTime.Today.AddDays(-30)), 4);
			//list1.Add(new XDate(DateTime.Today.AddDays(-25)), 7);
			//list1.Add(new XDate(DateTime.Today.AddDays(-20)), 0);
			//list1.Add(new XDate(DateTime.Today.AddDays(-15)), 2);
			//list1.Add(new XDate(DateTime.Today.AddDays(-10)), 12);
			//list1.Add(new XDate(DateTime.Today), 5);


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

			// Generate a red curve with diamond
			// symbols, and "Porsche" in the legend
			LineItem myCurve = myPane2.AddCurve("Borrowed Book",
				list1, Color.FromArgb(75, 75, 75), SymbolType.Diamond);

			// Generate a blue curve with circle
			// symbols, and "Piper" in the legend
			LineItem myCurve2 = myPane2.AddCurve("Total Book",
				list2, Color.FromArgb(236, 177, 117), SymbolType.Circle);;

			BarItem myCurve3 = myPane2.AddBar("Available Book", null, null, Color.Blue);
			myCurve3.Bar.Fill = new Fill(new SolidBrush(Color.FromArgb(80, 106, 214, 217)));
			myCurve3.Bar.Border.Color = Color.FromArgb(90, 106, 214, 217);

			// Change the color of the title
			//myPane2.Title.FontSpec.FontColor = Color.Green;

			// Add gridlines to the plot, and make them gray
			myPane2.XAxis.MajorGrid.IsVisible = true;
			myPane2.YAxis.MajorGrid.IsVisible = true;
			myPane2.XAxis.MajorGrid.Color = Color.LightGray;
			myPane2.YAxis.MajorGrid.Color = Color.LightGray;

			// Move the legend location
			myPane2.Legend.Position = ZedGraph.LegendPos.Top;

			// Make both curves thicker
			myCurve.Line.Width = 1.5F;
			myCurve2.Line.Width = 3.0F;

			// Fill the area under the curves
			myCurve.Line.Fill = new Fill(new SolidBrush(Color.FromArgb(80, 144, 140, 221))); 
			myCurve2.Line.Fill = new Fill(new SolidBrush(Color.FromArgb(60, 106, 214, 217)));
			//myCurve.Line.IsSmooth = true;
			//myCurve.Line.SmoothTension = 0.2F;

			//myCurve2.Line.IsSmooth = true;
			//myCurve2.Line.SmoothTension = 0.6F;

			// Increase the symbol sizes, and fill them with solid white
			myCurve.Symbol.Size = 20.0F;
			myCurve2.Symbol.Size = 15.0F;
			myCurve.Symbol.Fill = new Fill(Color.White);
			myCurve2.Symbol.Fill = new Fill(Color.White);

			zedGraphControl1.AxisChange();
		}

		private void ChangeChartTitle(string NewTitle, ZedGraphControl Zgc)
        {
			Zgc.GraphPane.Title.Text = NewTitle;
			Zgc.Invalidate();
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
					ChangeChartTitle(form.TitleResult, ZedGraphControl_1);
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
			item1.Text = "Scale Y Axis";
			item1.Click += RightChartScaleY;
			menuStrip.Items.Add(item1);

			ToolStripMenuItem item2 = new ToolStripMenuItem();
			item2.Name = "info";
			item2.Text = "Help Info";
			item2.Click += RightChartHelp;
			menuStrip.Items.Add(item2);
		}

        private void zedGraphControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			zedGraphControl1.ZoomOutAll(zedGraphControl1.GraphPane);
		}

        private void iconButton1_Click(object sender, EventArgs e)
        {
			using (var form = new DashboardGraphSettings(zedGraphControl1.GraphPane.Title.Text))
			{
				form.StartPosition = FormStartPosition.Manual;
				form.Location = iconButton1.PointToScreen(Point.Empty);
				var result = form.ShowDialog();

				if (result == DialogResult.OK)
				{
					ChangeChartTitle(form.TitleResult, zedGraphControl1);
				}
			}
		}
    }
}
