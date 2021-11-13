using PresentationLayer.Dialogs;
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

namespace PresentationLayer.SubPages
{
    public partial class Dashboard : Form
    {
		GraphPane myPane;

		public Dashboard()
        {
            InitializeComponent();
			ApplyColorPalette();
			ApplyStrings();
			myPane = ZedGraphControl_1.GraphPane;
			BarChartInit();
			DrawPieChart(90, 10);
			bookStatusItem1.SetBookStatus(PresentationLayer.Controls.BookStatusItem.BookStatus.Late);
			bookStatusItem2.SetBookStatus(PresentationLayer.Controls.BookStatusItem.BookStatus.Returned);
			bookStatusItem3.SetBookStatus(PresentationLayer.Controls.BookStatusItem.BookStatus.TwoDaysLeft);
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


		private void BarChartInit()
        {
			double[] y = { 80, 70, 50, 30, 20 };
			double[] y2 = { 70, 50, 50, 70, 80 };
			string[] str = { "5.11.2021", "6.11.2021", "7.11.2021", "8.11.2021", "9.11.2021" };

			myPane.Border.IsVisible = false;
			myPane.Margin.All = 5;
			myPane.XAxis.MajorTic.IsBetweenLabels = true;
			myPane.XAxis.Scale.TextLabels = str;
			myPane.XAxis.Type = ZedGraph.AxisType.Text;
			myPane.Chart.Fill = new Fill(new SolidBrush(ColorPalette.SettingsBackColor));
			//myPane.Chart.Fill = new Fill(ColorPalette.SettingsBackColor, Color.White);

			myPane.Legend.IsVisible = true;

			myPane.Title.Text = Strings.ChartTitle;
			myPane.XAxis.Title.Text = Strings.ChartXTitle;
			myPane.YAxis.Title.Text = Strings.ChartYTitle;

			BarItem myCurve = myPane.AddBar(Strings.BarName1, null, y, Color.Transparent);
			myCurve.Bar.Border.IsVisible = false;
			myCurve.Bar.Fill = new Fill(new SolidBrush(Color.FromArgb(123, 215, 60)));

			myCurve = myPane.AddBar(Strings.BarName2, null, y2, Color.Transparent);
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
			


			chart1.Series[seriesname].Points.AddXY(Strings.AvailableBooks, value1);
			chart1.Series[seriesname].Points[0].Color = Color.FromArgb(44, 201, 252);
			chart1.Series[seriesname].Points.AddXY(Strings.BorrowedBooks, value2);
			chart1.Series[seriesname].Points[1].Color = Color.FromArgb(253, 169, 41);
		}
    }
}
