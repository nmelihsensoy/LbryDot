
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
            this.Splitter_ActiveBooksBorder = new System.Windows.Forms.Splitter();
            this.Text_ActiveBooksTitle = new System.Windows.Forms.Label();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_ActiveBooks = new System.Windows.Forms.Panel();
            this.ZedGraphControl_1 = new ZedGraph.ZedGraphControl();
            this.Button_ChartSettings = new FontAwesome.Sharp.IconButton();
            this.Splitter_ChartRightBorder = new System.Windows.Forms.Splitter();
            this.Panel_ChartRight = new System.Windows.Forms.Panel();
            this.Splitter_ChartLeftBorder = new System.Windows.Forms.Splitter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_ChartLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.Panel_ActiveBooks.SuspendLayout();
            this.Panel_ChartRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Panel_ChartLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // ıconButton1
            // 
            this.ıconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 143);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // Panel_ActiveBooks
            // 
            this.Panel_ActiveBooks.BackColor = System.Drawing.Color.White;
            this.Panel_ActiveBooks.Controls.Add(this.flowLayoutPanel1);
            this.Panel_ActiveBooks.Controls.Add(this.ıconButton1);
            this.Panel_ActiveBooks.Controls.Add(this.Text_ActiveBooksTitle);
            this.Panel_ActiveBooks.Controls.Add(this.Splitter_ActiveBooksBorder);
            this.Panel_ActiveBooks.Location = new System.Drawing.Point(12, 280);
            this.Panel_ActiveBooks.Name = "Panel_ActiveBooks";
            this.Panel_ActiveBooks.Size = new System.Drawing.Size(780, 238);
            this.Panel_ActiveBooks.TabIndex = 5;
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
            this.ZedGraphControl_1.ContextMenuBuilder += new ZedGraph.ZedGraphControl.ContextMenuBuilderEventHandler(this.ZedGraphControl_1_ContextMenuBuilder);
            this.ZedGraphControl_1.DoubleClick += new System.EventHandler(this.ZedGraphControl_1_DoubleClick);
            // 
            // Button_ChartSettings
            // 
            this.Button_ChartSettings.FlatAppearance.BorderSize = 0;
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
            // Panel_ChartRight
            // 
            this.Panel_ChartRight.BackColor = System.Drawing.Color.White;
            this.Panel_ChartRight.Controls.Add(this.Splitter_ChartRightBorder);
            this.Panel_ChartRight.Controls.Add(this.Button_ChartSettings);
            this.Panel_ChartRight.Controls.Add(this.ZedGraphControl_1);
            this.Panel_ChartRight.Location = new System.Drawing.Point(332, 12);
            this.Panel_ChartRight.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ChartRight.Name = "Panel_ChartRight";
            this.Panel_ChartRight.Size = new System.Drawing.Size(460, 240);
            this.Panel_ChartRight.TabIndex = 1;
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(303, 237);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Panel_ChartLeft
            // 
            this.Panel_ChartLeft.Controls.Add(this.chart1);
            this.Panel_ChartLeft.Controls.Add(this.Splitter_ChartLeftBorder);
            this.Panel_ChartLeft.Location = new System.Drawing.Point(12, 12);
            this.Panel_ChartLeft.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ChartLeft.Name = "Panel_ChartLeft";
            this.Panel_ChartLeft.Size = new System.Drawing.Size(303, 240);
            this.Panel_ChartLeft.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.zedGraphControl1);
            this.panel1.Location = new System.Drawing.Point(202, 270);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 263);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(23, 20);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.Button_ChartSettings_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 260);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(590, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(590, 263);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Location = new System.Drawing.Point(12, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 123);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Avignon Pro", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 76);
            this.label2.TabIndex = 9;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Avignon Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 120);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(173, 3);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.splitter3);
            this.panel3.Location = new System.Drawing.Point(9, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 123);
            this.panel3.TabIndex = 14;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Avignon Pro", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 76);
            this.label3.TabIndex = 9;
            this.label3.Text = "2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Avignon Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Staff";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 120);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(173, 3);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_ActiveBooks);
            this.Controls.Add(this.Panel_ChartLeft);
            this.Controls.Add(this.Panel_ChartRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Dashboard";
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.Panel_ActiveBooks.ResumeLayout(false);
            this.Panel_ActiveBooks.PerformLayout();
            this.Panel_ChartRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Panel_ChartLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter Splitter_ActiveBooksBorder;
        private System.Windows.Forms.Label Text_ActiveBooksTitle;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Panel_ActiveBooks;
        private ZedGraph.ZedGraphControl ZedGraphControl_1;
        private FontAwesome.Sharp.IconButton Button_ChartSettings;
        private System.Windows.Forms.Splitter Splitter_ChartRightBorder;
        private System.Windows.Forms.Panel Panel_ChartRight;
        private System.Windows.Forms.Splitter Splitter_ChartLeftBorder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel Panel_ChartLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}