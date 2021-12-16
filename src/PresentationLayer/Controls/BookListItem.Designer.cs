
namespace PresentationLayer.Controls
{
    partial class BookListItem
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
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.Panel_Hover = new PresentationLayer.Controls.ExtendedPanel();
            this.Button_Edit = new FontAwesome.Sharp.IconButton();
            this.Button_BookDeleteBorrow = new FontAwesome.Sharp.IconButton();
            this.Button_BookDetails = new FontAwesome.Sharp.IconButton();
            this.Text_BookCategory = new System.Windows.Forms.Label();
            this.Text_ISBN = new System.Windows.Forms.Label();
            this.Text_BookTitleSecLine = new System.Windows.Forms.Label();
            this.Text_PublishYear = new System.Windows.Forms.Label();
            this.Text_PageCount = new System.Windows.Forms.Label();
            this.Splitter_TopBorder = new System.Windows.Forms.Splitter();
            this.Text_BookAuthor = new System.Windows.Forms.Label();
            this.Text_BookTitleFirstLine = new System.Windows.Forms.Label();
            this.Image_BookCover = new System.Windows.Forms.PictureBox();
            this.Panel_Container.SuspendLayout();
            this.Panel_Hover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Container
            // 
            this.Panel_Container.BackColor = System.Drawing.Color.White;
            this.Panel_Container.Controls.Add(this.Panel_Hover);
            this.Panel_Container.Controls.Add(this.Text_BookCategory);
            this.Panel_Container.Controls.Add(this.Text_ISBN);
            this.Panel_Container.Controls.Add(this.Text_BookTitleSecLine);
            this.Panel_Container.Controls.Add(this.Text_PublishYear);
            this.Panel_Container.Controls.Add(this.Text_PageCount);
            this.Panel_Container.Controls.Add(this.Splitter_TopBorder);
            this.Panel_Container.Controls.Add(this.Text_BookAuthor);
            this.Panel_Container.Controls.Add(this.Text_BookTitleFirstLine);
            this.Panel_Container.Controls.Add(this.Image_BookCover);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(248, 150);
            this.Panel_Container.TabIndex = 0;
            this.Panel_Container.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Panel_Hover
            // 
            this.Panel_Hover.BackColor = System.Drawing.Color.Black;
            this.Panel_Hover.Controls.Add(this.Button_Edit);
            this.Panel_Hover.Controls.Add(this.Button_BookDeleteBorrow);
            this.Panel_Hover.Controls.Add(this.Button_BookDetails);
            this.Panel_Hover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Hover.Location = new System.Drawing.Point(0, 3);
            this.Panel_Hover.Name = "Panel_Hover";
            this.Panel_Hover.Opacity = 60;
            this.Panel_Hover.Size = new System.Drawing.Size(248, 147);
            this.Panel_Hover.TabIndex = 12;
            this.Panel_Hover.Visible = false;
            this.Panel_Hover.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Panel_Hover.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.Color.White;
            this.Button_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Edit.FlatAppearance.BorderSize = 0;
            this.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Edit.ForeColor = System.Drawing.Color.White;
            this.Button_Edit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Button_Edit.IconColor = System.Drawing.Color.Gray;
            this.Button_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Edit.IconSize = 26;
            this.Button_Edit.Location = new System.Drawing.Point(109, 20);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(34, 30);
            this.Button_Edit.TabIndex = 2;
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // Button_BookDeleteBorrow
            // 
            this.Button_BookDeleteBorrow.BackColor = System.Drawing.Color.White;
            this.Button_BookDeleteBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_BookDeleteBorrow.FlatAppearance.BorderSize = 0;
            this.Button_BookDeleteBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BookDeleteBorrow.ForeColor = System.Drawing.Color.White;
            this.Button_BookDeleteBorrow.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Button_BookDeleteBorrow.IconColor = System.Drawing.Color.IndianRed;
            this.Button_BookDeleteBorrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_BookDeleteBorrow.IconSize = 26;
            this.Button_BookDeleteBorrow.Location = new System.Drawing.Point(130, 60);
            this.Button_BookDeleteBorrow.Name = "Button_BookDeleteBorrow";
            this.Button_BookDeleteBorrow.Size = new System.Drawing.Size(34, 30);
            this.Button_BookDeleteBorrow.TabIndex = 1;
            this.Button_BookDeleteBorrow.UseVisualStyleBackColor = false;
            this.Button_BookDeleteBorrow.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // Button_BookDetails
            // 
            this.Button_BookDetails.BackColor = System.Drawing.Color.White;
            this.Button_BookDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_BookDetails.FlatAppearance.BorderSize = 0;
            this.Button_BookDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BookDetails.ForeColor = System.Drawing.Color.White;
            this.Button_BookDetails.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.Button_BookDetails.IconColor = System.Drawing.Color.Gray;
            this.Button_BookDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_BookDetails.IconSize = 26;
            this.Button_BookDetails.Location = new System.Drawing.Point(85, 60);
            this.Button_BookDetails.Name = "Button_BookDetails";
            this.Button_BookDetails.Size = new System.Drawing.Size(34, 30);
            this.Button_BookDetails.TabIndex = 0;
            this.Button_BookDetails.UseVisualStyleBackColor = false;
            this.Button_BookDetails.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // Text_BookCategory
            // 
            this.Text_BookCategory.AutoSize = true;
            this.Text_BookCategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Text_BookCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookCategory.Location = new System.Drawing.Point(103, 74);
            this.Text_BookCategory.Name = "Text_BookCategory";
            this.Text_BookCategory.Padding = new System.Windows.Forms.Padding(5);
            this.Text_BookCategory.Size = new System.Drawing.Size(75, 23);
            this.Text_BookCategory.TabIndex = 3;
            this.Text_BookCategory.Text = "Technology";
            this.Text_BookCategory.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Text_ISBN
            // 
            this.Text_ISBN.AutoSize = true;
            this.Text_ISBN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_ISBN.Location = new System.Drawing.Point(104, 74);
            this.Text_ISBN.Name = "Text_ISBN";
            this.Text_ISBN.Size = new System.Drawing.Size(113, 17);
            this.Text_ISBN.TabIndex = 13;
            this.Text_ISBN.Text = "978-3-16-148410-0";
            this.Text_ISBN.Visible = false;
            // 
            // Text_BookTitleSecLine
            // 
            this.Text_BookTitleSecLine.AutoSize = true;
            this.Text_BookTitleSecLine.Font = new System.Drawing.Font("Avignon Pro Demi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookTitleSecLine.Location = new System.Drawing.Point(103, 31);
            this.Text_BookTitleSecLine.Name = "Text_BookTitleSecLine";
            this.Text_BookTitleSecLine.Size = new System.Drawing.Size(105, 16);
            this.Text_BookTitleSecLine.TabIndex = 9;
            this.Text_BookTitleSecLine.Text = "Title Second Line";
            this.Text_BookTitleSecLine.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Text_PublishYear
            // 
            this.Text_PublishYear.AutoSize = true;
            this.Text_PublishYear.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Text_PublishYear.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_PublishYear.Location = new System.Drawing.Point(170, 107);
            this.Text_PublishYear.Name = "Text_PublishYear";
            this.Text_PublishYear.Padding = new System.Windows.Forms.Padding(5);
            this.Text_PublishYear.Size = new System.Drawing.Size(39, 23);
            this.Text_PublishYear.TabIndex = 8;
            this.Text_PublishYear.Text = "2017";
            this.Text_PublishYear.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Text_PageCount
            // 
            this.Text_PageCount.AutoSize = true;
            this.Text_PageCount.BackColor = System.Drawing.Color.Tan;
            this.Text_PageCount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_PageCount.Location = new System.Drawing.Point(103, 107);
            this.Text_PageCount.Name = "Text_PageCount";
            this.Text_PageCount.Padding = new System.Windows.Forms.Padding(5);
            this.Text_PageCount.Size = new System.Drawing.Size(52, 23);
            this.Text_PageCount.TabIndex = 7;
            this.Text_PageCount.Text = "120 Pg.";
            this.Text_PageCount.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Splitter_TopBorder
            // 
            this.Splitter_TopBorder.BackColor = System.Drawing.Color.Tomato;
            this.Splitter_TopBorder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Splitter_TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter_TopBorder.Location = new System.Drawing.Point(0, 0);
            this.Splitter_TopBorder.Name = "Splitter_TopBorder";
            this.Splitter_TopBorder.Size = new System.Drawing.Size(248, 3);
            this.Splitter_TopBorder.TabIndex = 5;
            this.Splitter_TopBorder.TabStop = false;
            this.Splitter_TopBorder.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Splitter_TopBorder.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // Text_BookAuthor
            // 
            this.Text_BookAuthor.AutoSize = true;
            this.Text_BookAuthor.Font = new System.Drawing.Font("Avignon Pro Demi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookAuthor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Text_BookAuthor.Location = new System.Drawing.Point(103, 50);
            this.Text_BookAuthor.Name = "Text_BookAuthor";
            this.Text_BookAuthor.Size = new System.Drawing.Size(54, 14);
            this.Text_BookAuthor.TabIndex = 2;
            this.Text_BookAuthor.Text = "John Doe";
            this.Text_BookAuthor.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Text_BookTitleFirstLine
            // 
            this.Text_BookTitleFirstLine.AutoSize = true;
            this.Text_BookTitleFirstLine.Font = new System.Drawing.Font("Avignon Pro Demi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookTitleFirstLine.Location = new System.Drawing.Point(103, 15);
            this.Text_BookTitleFirstLine.Name = "Text_BookTitleFirstLine";
            this.Text_BookTitleFirstLine.Size = new System.Drawing.Size(81, 16);
            this.Text_BookTitleFirstLine.TabIndex = 1;
            this.Text_BookTitleFirstLine.Text = "Title First Line";
            this.Text_BookTitleFirstLine.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // Image_BookCover
            // 
            this.Image_BookCover.Image = global::PresentationLayer.Properties.Resources._41SMo7KEbhL__AC_SY780_;
            this.Image_BookCover.Location = new System.Drawing.Point(10, 15);
            this.Image_BookCover.Name = "Image_BookCover";
            this.Image_BookCover.Size = new System.Drawing.Size(88, 115);
            this.Image_BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_BookCover.TabIndex = 0;
            this.Image_BookCover.TabStop = false;
            this.Image_BookCover.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            // 
            // BookListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Container);
            this.Name = "BookListItem";
            this.Size = new System.Drawing.Size(248, 150);
            this.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Container.PerformLayout();
            this.Panel_Hover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image_BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.Splitter Splitter_TopBorder;
        private System.Windows.Forms.Label Text_BookCategory;
        private System.Windows.Forms.Label Text_BookAuthor;
        private System.Windows.Forms.Label Text_BookTitleFirstLine;
        private System.Windows.Forms.PictureBox Image_BookCover;
        private System.Windows.Forms.Label Text_PublishYear;
        private System.Windows.Forms.Label Text_PageCount;
        private System.Windows.Forms.Label Text_BookTitleSecLine;
        private ExtendedPanel Panel_Hover;
        private FontAwesome.Sharp.IconButton Button_BookDetails;
        private FontAwesome.Sharp.IconButton Button_BookDeleteBorrow;
        private System.Windows.Forms.Label Text_ISBN;
        private FontAwesome.Sharp.IconButton Button_Edit;
    }
}
