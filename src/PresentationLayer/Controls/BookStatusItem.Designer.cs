
namespace PresentationLayer.Controls
{
    partial class BookStatusItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Image_BookCover = new System.Windows.Forms.PictureBox();
            this.Splitter_BorderBottom = new System.Windows.Forms.Splitter();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Panel_Hover_Bottom = new PresentationLayer.ExtendedPanel();
            this.Button_ReturnBook = new FontAwesome.Sharp.IconButton();
            this.Button_BookDetails = new FontAwesome.Sharp.IconButton();
            this.Panel_Hover_Top = new PresentationLayer.ExtendedPanel();
            this.Text_DaySecLine = new System.Windows.Forms.Label();
            this.Text_DayFirstLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image_BookCover)).BeginInit();
            this.Panel_Container.SuspendLayout();
            this.Panel_Hover_Bottom.SuspendLayout();
            this.Panel_Hover_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Image_BookCover
            // 
            this.Image_BookCover.Image = global::PresentationLayer.Properties.Resources._41SMo7KEbhL__AC_SY780_;
            this.Image_BookCover.Location = new System.Drawing.Point(23, 0);
            this.Image_BookCover.Name = "Image_BookCover";
            this.Image_BookCover.Size = new System.Drawing.Size(88, 115);
            this.Image_BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_BookCover.TabIndex = 1;
            this.Image_BookCover.TabStop = false;
            this.Image_BookCover.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Image_BookCover.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Splitter_BorderBottom
            // 
            this.Splitter_BorderBottom.BackColor = System.Drawing.Color.Maroon;
            this.Splitter_BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_BorderBottom.Location = new System.Drawing.Point(0, 125);
            this.Splitter_BorderBottom.Name = "Splitter_BorderBottom";
            this.Splitter_BorderBottom.Size = new System.Drawing.Size(135, 3);
            this.Splitter_BorderBottom.TabIndex = 5;
            this.Splitter_BorderBottom.TabStop = false;
            this.Splitter_BorderBottom.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Splitter_BorderBottom.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Panel_Container
            // 
            this.Panel_Container.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Container.Controls.Add(this.Panel_Bottom);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(135, 128);
            this.Panel_Container.TabIndex = 6;
            this.Panel_Container.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Panel_Container.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.LightGray;
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 100);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(135, 28);
            this.Panel_Bottom.TabIndex = 0;
            this.Panel_Bottom.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Panel_Bottom.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Panel_Hover_Bottom
            // 
            this.Panel_Hover_Bottom.BackColor = System.Drawing.SystemColors.ControlText;
            this.Panel_Hover_Bottom.Controls.Add(this.Button_ReturnBook);
            this.Panel_Hover_Bottom.Controls.Add(this.Button_BookDetails);
            this.Panel_Hover_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Hover_Bottom.Location = new System.Drawing.Point(0, 77);
            this.Panel_Hover_Bottom.Name = "Panel_Hover_Bottom";
            this.Panel_Hover_Bottom.Size = new System.Drawing.Size(135, 48);
            this.Panel_Hover_Bottom.TabIndex = 4;
            this.Panel_Hover_Bottom.Visible = false;
            this.Panel_Hover_Bottom.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Button_ReturnBook
            // 
            this.Button_ReturnBook.BackColor = System.Drawing.Color.White;
            this.Button_ReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ReturnBook.FlatAppearance.BorderSize = 0;
            this.Button_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ReturnBook.ForeColor = System.Drawing.Color.Wheat;
            this.Button_ReturnBook.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.Button_ReturnBook.IconColor = System.Drawing.Color.DarkGreen;
            this.Button_ReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ReturnBook.IconSize = 16;
            this.Button_ReturnBook.Location = new System.Drawing.Point(73, 15);
            this.Button_ReturnBook.Name = "Button_ReturnBook";
            this.Button_ReturnBook.Size = new System.Drawing.Size(24, 22);
            this.Button_ReturnBook.TabIndex = 3;
            this.Button_ReturnBook.UseVisualStyleBackColor = false;
            this.Button_ReturnBook.Click += new System.EventHandler(this.ButtonClickEvent);
            this.Button_ReturnBook.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Button_BookDetails
            // 
            this.Button_BookDetails.BackColor = System.Drawing.Color.White;
            this.Button_BookDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_BookDetails.FlatAppearance.BorderSize = 0;
            this.Button_BookDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BookDetails.ForeColor = System.Drawing.Color.DarkGray;
            this.Button_BookDetails.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.Button_BookDetails.IconColor = System.Drawing.Color.Gray;
            this.Button_BookDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_BookDetails.IconSize = 16;
            this.Button_BookDetails.Location = new System.Drawing.Point(37, 15);
            this.Button_BookDetails.Name = "Button_BookDetails";
            this.Button_BookDetails.Size = new System.Drawing.Size(24, 22);
            this.Button_BookDetails.TabIndex = 2;
            this.Button_BookDetails.UseVisualStyleBackColor = false;
            this.Button_BookDetails.Click += new System.EventHandler(this.ButtonClickEvent);
            this.Button_BookDetails.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Panel_Hover_Top
            // 
            this.Panel_Hover_Top.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Panel_Hover_Top.Controls.Add(this.Text_DaySecLine);
            this.Panel_Hover_Top.Controls.Add(this.Text_DayFirstLine);
            this.Panel_Hover_Top.Location = new System.Drawing.Point(23, 0);
            this.Panel_Hover_Top.Name = "Panel_Hover_Top";
            this.Panel_Hover_Top.Opacity = 70;
            this.Panel_Hover_Top.Size = new System.Drawing.Size(88, 44);
            this.Panel_Hover_Top.TabIndex = 3;
            this.Panel_Hover_Top.Visible = false;
            this.Panel_Hover_Top.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Text_DaySecLine
            // 
            this.Text_DaySecLine.AutoSize = true;
            this.Text_DaySecLine.BackColor = System.Drawing.Color.Maroon;
            this.Text_DaySecLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_DaySecLine.ForeColor = System.Drawing.Color.White;
            this.Text_DaySecLine.Location = new System.Drawing.Point(18, 24);
            this.Text_DaySecLine.Name = "Text_DaySecLine";
            this.Text_DaySecLine.Size = new System.Drawing.Size(56, 13);
            this.Text_DaySecLine.TabIndex = 1;
            this.Text_DaySecLine.Text = "message";
            // 
            // Text_DayFirstLine
            // 
            this.Text_DayFirstLine.AutoSize = true;
            this.Text_DayFirstLine.BackColor = System.Drawing.Color.Goldenrod;
            this.Text_DayFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_DayFirstLine.ForeColor = System.Drawing.Color.White;
            this.Text_DayFirstLine.Location = new System.Drawing.Point(37, 5);
            this.Text_DayFirstLine.Name = "Text_DayFirstLine";
            this.Text_DayFirstLine.Size = new System.Drawing.Size(14, 13);
            this.Text_DayFirstLine.TabIndex = 0;
            this.Text_DayFirstLine.Text = "2";
            // 
            // BookStatusItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel_Hover_Bottom);
            this.Controls.Add(this.Splitter_BorderBottom);
            this.Controls.Add(this.Panel_Hover_Top);
            this.Controls.Add(this.Image_BookCover);
            this.Controls.Add(this.Panel_Container);
            this.Name = "BookStatusItem";
            this.Size = new System.Drawing.Size(135, 128);
            this.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Image_BookCover)).EndInit();
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Hover_Bottom.ResumeLayout(false);
            this.Panel_Hover_Top.ResumeLayout(false);
            this.Panel_Hover_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_BookCover;
        private ExtendedPanel Panel_Hover_Top;
        private ExtendedPanel Panel_Hover_Bottom;
        private FontAwesome.Sharp.IconButton Button_ReturnBook;
        private FontAwesome.Sharp.IconButton Button_BookDetails;
        private System.Windows.Forms.Splitter Splitter_BorderBottom;
        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.Label Text_DaySecLine;
        private System.Windows.Forms.Label Text_DayFirstLine;
    }
}
