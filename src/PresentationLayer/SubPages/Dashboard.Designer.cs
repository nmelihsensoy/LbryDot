
namespace PresentationLayer.SubPages
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Panel_ChartRight = new System.Windows.Forms.Panel();
            this.Splitter_ChartRightBorder = new System.Windows.Forms.Splitter();
            this.Button_ChartSettings = new FontAwesome.Sharp.IconButton();
            this.ZedGraphControl_1 = new ZedGraph.ZedGraphControl();
            this.Panel_ActiveBooks = new System.Windows.Forms.Panel();
            this.Text_ActiveBooksTitle = new System.Windows.Forms.Label();
            this.Splitter_ActiveBooksBorder = new System.Windows.Forms.Splitter();
            this.Splitter_ChartLeftBorder = new System.Windows.Forms.Splitter();
            this.Panel_ChartLeft = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.bookStatusItem4 = new PresentationLayer.Controls.BookStatusItem();
            this.bookStatusItem3 = new PresentationLayer.Controls.BookStatusItem();
            this.bookStatusItem2 = new PresentationLayer.Controls.BookStatusItem();
            this.bookStatusItem1 = new PresentationLayer.Controls.BookStatusItem();
            this.Panel_ChartRight.SuspendLayout();
            this.Panel_ActiveBooks.SuspendLayout();
            this.Panel_ChartLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ChartRight
            // 
            this.Panel_ChartRight.BackColor = System.Drawing.Color.White;
            this.Panel_ChartRight.Controls.Add(this.Splitter_ChartRightBorder);
            this.Panel_ChartRight.Controls.Add(this.Button_ChartSettings);
            this.Panel_ChartRight.Controls.Add(this.ZedGraphControl_1);
            this.Panel_ChartRight.Location = new System.Drawing.Point(332, 12);
            this.Panel_ChartRight.Name = "Panel_ChartRight";
            this.Panel_ChartRight.Size = new System.Drawing.Size(460, 240);
            this.Panel_ChartRight.TabIndex = 1;
            // 
            // Splitter_ChartRightBorder
            // 
            this.Splitter_ChartRightBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Splitter_ChartRightBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_ChartRightBorder.Location = new System.Drawing.Point(0, 237);
            this.Splitter_ChartRightBorder.Name = "Splitter_ChartRightBorder";
            this.Splitter_ChartRightBorder.Size = new System.Drawing.Size(460, 3);
            this.Splitter_ChartRightBorder.TabIndex = 2;
            this.Splitter_ChartRightBorder.TabStop = false;
            // 
            // Button_ChartSettings
            // 
            this.Button_ChartSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ChartSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Button_ChartSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.Button_ChartSettings.IconColor = System.Drawing.Color.Black;
            this.Button_ChartSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ChartSettings.IconSize = 16;
            this.Button_ChartSettings.Location = new System.Drawing.Point(0, 0);
            this.Button_ChartSettings.Name = "Button_ChartSettings";
            this.Button_ChartSettings.Size = new System.Drawing.Size(23, 20);
            this.Button_ChartSettings.TabIndex = 1;
            this.Button_ChartSettings.UseVisualStyleBackColor = true;
            this.Button_ChartSettings.Click += new System.EventHandler(this.Button_ChartSettings_Click);
            // 
            // ZedGraphControl_1
            // 
            this.ZedGraphControl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZedGraphControl_1.Location = new System.Drawing.Point(0, 0);
            this.ZedGraphControl_1.Margin = new System.Windows.Forms.Padding(0);
            this.ZedGraphControl_1.Name = "ZedGraphControl_1";
            this.ZedGraphControl_1.ScrollGrace = 0D;
            this.ZedGraphControl_1.ScrollMaxX = 0D;
            this.ZedGraphControl_1.ScrollMaxY = 0D;
            this.ZedGraphControl_1.ScrollMaxY2 = 0D;
            this.ZedGraphControl_1.ScrollMinX = 0D;
            this.ZedGraphControl_1.ScrollMinY = 0D;
            this.ZedGraphControl_1.ScrollMinY2 = 0D;
            this.ZedGraphControl_1.Size = new System.Drawing.Size(460, 240);
            this.ZedGraphControl_1.TabIndex = 0;
            // 
            // Panel_ActiveBooks
            // 
            this.Panel_ActiveBooks.BackColor = System.Drawing.Color.White;
            this.Panel_ActiveBooks.Controls.Add(this.ıconButton1);
            this.Panel_ActiveBooks.Controls.Add(this.bookStatusItem4);
            this.Panel_ActiveBooks.Controls.Add(this.bookStatusItem3);
            this.Panel_ActiveBooks.Controls.Add(this.bookStatusItem2);
            this.Panel_ActiveBooks.Controls.Add(this.bookStatusItem1);
            this.Panel_ActiveBooks.Controls.Add(this.Text_ActiveBooksTitle);
            this.Panel_ActiveBooks.Controls.Add(this.Splitter_ActiveBooksBorder);
            this.Panel_ActiveBooks.Location = new System.Drawing.Point(12, 280);
            this.Panel_ActiveBooks.Name = "Panel_ActiveBooks";
            this.Panel_ActiveBooks.Size = new System.Drawing.Size(780, 238);
            this.Panel_ActiveBooks.TabIndex = 5;
            // 
            // Text_ActiveBooksTitle
            // 
            this.Text_ActiveBooksTitle.AutoSize = true;
            this.Text_ActiveBooksTitle.Font = new System.Drawing.Font("Avignon Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_ActiveBooksTitle.ForeColor = System.Drawing.Color.DimGray;
            this.Text_ActiveBooksTitle.Location = new System.Drawing.Point(23, 16);
            this.Text_ActiveBooksTitle.Name = "Text_ActiveBooksTitle";
            this.Text_ActiveBooksTitle.Size = new System.Drawing.Size(125, 23);
            this.Text_ActiveBooksTitle.TabIndex = 6;
            this.Text_ActiveBooksTitle.Text = "Active Books";
            // 
            // Splitter_ActiveBooksBorder
            // 
            this.Splitter_ActiveBooksBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Splitter_ActiveBooksBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_ActiveBooksBorder.Location = new System.Drawing.Point(0, 235);
            this.Splitter_ActiveBooksBorder.Name = "Splitter_ActiveBooksBorder";
            this.Splitter_ActiveBooksBorder.Size = new System.Drawing.Size(780, 3);
            this.Splitter_ActiveBooksBorder.TabIndex = 5;
            this.Splitter_ActiveBooksBorder.TabStop = false;
            // 
            // Splitter_ChartLeftBorder
            // 
            this.Splitter_ChartLeftBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Splitter_ChartLeftBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_ChartLeftBorder.Location = new System.Drawing.Point(0, 237);
            this.Splitter_ChartLeftBorder.Name = "Splitter_ChartLeftBorder";
            this.Splitter_ChartLeftBorder.Size = new System.Drawing.Size(303, 3);
            this.Splitter_ChartLeftBorder.TabIndex = 3;
            this.Splitter_ChartLeftBorder.TabStop = false;
            // 
            // Panel_ChartLeft
            // 
            this.Panel_ChartLeft.Controls.Add(this.chart1);
            this.Panel_ChartLeft.Controls.Add(this.Splitter_ChartLeftBorder);
            this.Panel_ChartLeft.Location = new System.Drawing.Point(12, 12);
            this.Panel_ChartLeft.Name = "Panel_ChartLeft";
            this.Panel_ChartLeft.Size = new System.Drawing.Size(303, 240);
            this.Panel_ChartLeft.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(303, 237);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // ıconButton1
            // 
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.ıconButton1.IconColor = System.Drawing.Color.LightGray;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 32;
            this.ıconButton1.Location = new System.Drawing.Point(683, 16);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(67, 23);
            this.ıconButton1.TabIndex = 11;
            this.ıconButton1.UseVisualStyleBackColor = true;
            // 
            // bookStatusItem4
            // 
            this.bookStatusItem4.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem4.Location = new System.Drawing.Point(615, 66);
            this.bookStatusItem4.Name = "bookStatusItem4";
            this.bookStatusItem4.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem4.TabIndex = 10;
            // 
            // bookStatusItem3
            // 
            this.bookStatusItem3.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem3.Location = new System.Drawing.Point(419, 66);
            this.bookStatusItem3.Name = "bookStatusItem3";
            this.bookStatusItem3.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem3.TabIndex = 9;
            // 
            // bookStatusItem2
            // 
            this.bookStatusItem2.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem2.Location = new System.Drawing.Point(223, 66);
            this.bookStatusItem2.Name = "bookStatusItem2";
            this.bookStatusItem2.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem2.TabIndex = 8;
            // 
            // bookStatusItem1
            // 
            this.bookStatusItem1.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem1.Location = new System.Drawing.Point(27, 66);
            this.bookStatusItem1.Name = "bookStatusItem1";
            this.bookStatusItem1.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem1.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.Panel_ActiveBooks);
            this.Controls.Add(this.Panel_ChartLeft);
            this.Controls.Add(this.Panel_ChartRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Panel_ChartRight.ResumeLayout(false);
            this.Panel_ActiveBooks.ResumeLayout(false);
            this.Panel_ActiveBooks.PerformLayout();
            this.Panel_ChartLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_ChartRight;
        private System.Windows.Forms.Panel Panel_ActiveBooks;
        private System.Windows.Forms.Splitter Splitter_ActiveBooksBorder;
        private System.Windows.Forms.Label Text_ActiveBooksTitle;
        private FontAwesome.Sharp.IconButton Button_ChartSettings;
        private System.Windows.Forms.Splitter Splitter_ChartRightBorder;
        private ZedGraph.ZedGraphControl ZedGraphControl_1;
        private System.Windows.Forms.Splitter Splitter_ChartLeftBorder;
        private System.Windows.Forms.Panel Panel_ChartLeft;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Controls.BookStatusItem bookStatusItem1;
        private Controls.BookStatusItem bookStatusItem2;
        private Controls.BookStatusItem bookStatusItem3;
        private Controls.BookStatusItem bookStatusItem4;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}