
namespace PresentationLayer.Dialogs
{
    partial class BookAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddUpdate));
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Input_Category = new System.Windows.Forms.ComboBox();
            this.Text_Title_Sec = new System.Windows.Forms.Label();
            this.Input_Title_Sec = new System.Windows.Forms.TextBox();
            this.alertBox1 = new PresentationLayer.Controls.AlertBox();
            this.Text_PublishYear = new System.Windows.Forms.Label();
            this.dateTimePicker_PublishYear = new System.Windows.Forms.DateTimePicker();
            this.Text_ShelfNumber = new System.Windows.Forms.Label();
            this.Input_ShelfNumber = new System.Windows.Forms.TextBox();
            this.Text_BookLength = new System.Windows.Forms.Label();
            this.Input_Length = new System.Windows.Forms.TextBox();
            this.Text_BookLang = new System.Windows.Forms.Label();
            this.Input_BookLang = new System.Windows.Forms.TextBox();
            this.Text_Category = new System.Windows.Forms.Label();
            this.Image_BookCover = new System.Windows.Forms.PictureBox();
            this.Text_Author = new System.Windows.Forms.Label();
            this.Input_Author = new System.Windows.Forms.TextBox();
            this.Input_ISBN = new System.Windows.Forms.TextBox();
            this.Input_Title = new System.Windows.Forms.TextBox();
            this.Text_ISBN = new System.Windows.Forms.Label();
            this.Text_Title = new System.Windows.Forms.Label();
            this.Text_BookCover = new System.Windows.Forms.Label();
            this.Button_Save = new FontAwesome.Sharp.IconButton();
            this.Button_SelectCover = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Container
            // 
            this.Panel_Container.Controls.Add(this.panel1);
            this.Panel_Container.Controls.Add(this.Input_Category);
            this.Panel_Container.Controls.Add(this.Text_Title_Sec);
            this.Panel_Container.Controls.Add(this.Input_Title_Sec);
            this.Panel_Container.Controls.Add(this.alertBox1);
            this.Panel_Container.Controls.Add(this.Text_PublishYear);
            this.Panel_Container.Controls.Add(this.dateTimePicker_PublishYear);
            this.Panel_Container.Controls.Add(this.Text_ShelfNumber);
            this.Panel_Container.Controls.Add(this.Input_ShelfNumber);
            this.Panel_Container.Controls.Add(this.Text_BookLength);
            this.Panel_Container.Controls.Add(this.Input_Length);
            this.Panel_Container.Controls.Add(this.Text_BookLang);
            this.Panel_Container.Controls.Add(this.Input_BookLang);
            this.Panel_Container.Controls.Add(this.Text_Category);
            this.Panel_Container.Controls.Add(this.Image_BookCover);
            this.Panel_Container.Controls.Add(this.Text_Author);
            this.Panel_Container.Controls.Add(this.Input_Author);
            this.Panel_Container.Controls.Add(this.Input_ISBN);
            this.Panel_Container.Controls.Add(this.Input_Title);
            this.Panel_Container.Controls.Add(this.Text_ISBN);
            this.Panel_Container.Controls.Add(this.Text_Title);
            this.Panel_Container.Controls.Add(this.Text_BookCover);
            this.Panel_Container.Controls.Add(this.Button_Save);
            this.Panel_Container.Controls.Add(this.Button_SelectCover);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(685, 324);
            this.Panel_Container.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(295, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 21);
            this.panel1.TabIndex = 40;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Input_Category
            // 
            this.Input_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Input_Category.FormattingEnabled = true;
            this.Input_Category.Location = new System.Drawing.Point(132, 189);
            this.Input_Category.Name = "Input_Category";
            this.Input_Category.Size = new System.Drawing.Size(152, 21);
            this.Input_Category.TabIndex = 39;
            this.Input_Category.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Input_Category_DrawItem);
            // 
            // Text_Title_Sec
            // 
            this.Text_Title_Sec.AutoSize = true;
            this.Text_Title_Sec.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Title_Sec.Location = new System.Drawing.Point(19, 61);
            this.Text_Title_Sec.Name = "Text_Title_Sec";
            this.Text_Title_Sec.Size = new System.Drawing.Size(35, 19);
            this.Text_Title_Sec.TabIndex = 38;
            this.Text_Title_Sec.Text = "Text";
            // 
            // Input_Title_Sec
            // 
            this.Input_Title_Sec.Location = new System.Drawing.Point(132, 60);
            this.Input_Title_Sec.MaxLength = 50;
            this.Input_Title_Sec.Name = "Input_Title_Sec";
            this.Input_Title_Sec.Size = new System.Drawing.Size(187, 20);
            this.Input_Title_Sec.TabIndex = 37;
            // 
            // alertBox1
            // 
            this.alertBox1.Location = new System.Drawing.Point(24, 272);
            this.alertBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Size = new System.Drawing.Size(295, 39);
            this.alertBox1.TabIndex = 36;
            this.alertBox1.Visible = false;
            // 
            // Text_PublishYear
            // 
            this.Text_PublishYear.AutoSize = true;
            this.Text_PublishYear.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_PublishYear.Location = new System.Drawing.Point(20, 233);
            this.Text_PublishYear.Name = "Text_PublishYear";
            this.Text_PublishYear.Size = new System.Drawing.Size(34, 19);
            this.Text_PublishYear.TabIndex = 35;
            this.Text_PublishYear.Text = "text";
            // 
            // dateTimePicker_PublishYear
            // 
            this.dateTimePicker_PublishYear.CustomFormat = "yyyy";
            this.dateTimePicker_PublishYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_PublishYear.Location = new System.Drawing.Point(132, 232);
            this.dateTimePicker_PublishYear.Name = "dateTimePicker_PublishYear";
            this.dateTimePicker_PublishYear.ShowUpDown = true;
            this.dateTimePicker_PublishYear.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker_PublishYear.TabIndex = 34;
            // 
            // Text_ShelfNumber
            // 
            this.Text_ShelfNumber.AutoSize = true;
            this.Text_ShelfNumber.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_ShelfNumber.Location = new System.Drawing.Point(369, 104);
            this.Text_ShelfNumber.Name = "Text_ShelfNumber";
            this.Text_ShelfNumber.Size = new System.Drawing.Size(34, 19);
            this.Text_ShelfNumber.TabIndex = 33;
            this.Text_ShelfNumber.Text = "text";
            // 
            // Input_ShelfNumber
            // 
            this.Input_ShelfNumber.Location = new System.Drawing.Point(480, 103);
            this.Input_ShelfNumber.Name = "Input_ShelfNumber";
            this.Input_ShelfNumber.Size = new System.Drawing.Size(187, 20);
            this.Input_ShelfNumber.TabIndex = 32;
            // 
            // Text_BookLength
            // 
            this.Text_BookLength.AutoSize = true;
            this.Text_BookLength.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookLength.Location = new System.Drawing.Point(369, 61);
            this.Text_BookLength.Name = "Text_BookLength";
            this.Text_BookLength.Size = new System.Drawing.Size(34, 19);
            this.Text_BookLength.TabIndex = 31;
            this.Text_BookLength.Text = "text";
            // 
            // Input_Length
            // 
            this.Input_Length.Location = new System.Drawing.Point(480, 60);
            this.Input_Length.Name = "Input_Length";
            this.Input_Length.Size = new System.Drawing.Size(187, 20);
            this.Input_Length.TabIndex = 30;
            // 
            // Text_BookLang
            // 
            this.Text_BookLang.AutoSize = true;
            this.Text_BookLang.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookLang.Location = new System.Drawing.Point(369, 18);
            this.Text_BookLang.Name = "Text_BookLang";
            this.Text_BookLang.Size = new System.Drawing.Size(34, 19);
            this.Text_BookLang.TabIndex = 29;
            this.Text_BookLang.Text = "text";
            // 
            // Input_BookLang
            // 
            this.Input_BookLang.Location = new System.Drawing.Point(480, 17);
            this.Input_BookLang.Name = "Input_BookLang";
            this.Input_BookLang.Size = new System.Drawing.Size(187, 20);
            this.Input_BookLang.TabIndex = 28;
            // 
            // Text_Category
            // 
            this.Text_Category.AutoSize = true;
            this.Text_Category.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Category.Location = new System.Drawing.Point(20, 190);
            this.Text_Category.Name = "Text_Category";
            this.Text_Category.Size = new System.Drawing.Size(34, 19);
            this.Text_Category.TabIndex = 27;
            this.Text_Category.Text = "text";
            // 
            // Image_BookCover
            // 
            this.Image_BookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image_BookCover.Image = global::PresentationLayer.Properties.Resources.default_book_cover;
            this.Image_BookCover.InitialImage = null;
            this.Image_BookCover.Location = new System.Drawing.Point(480, 146);
            this.Image_BookCover.Name = "Image_BookCover";
            this.Image_BookCover.Size = new System.Drawing.Size(80, 97);
            this.Image_BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_BookCover.TabIndex = 19;
            this.Image_BookCover.TabStop = false;
            // 
            // Text_Author
            // 
            this.Text_Author.AutoSize = true;
            this.Text_Author.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Author.Location = new System.Drawing.Point(20, 147);
            this.Text_Author.Name = "Text_Author";
            this.Text_Author.Size = new System.Drawing.Size(34, 19);
            this.Text_Author.TabIndex = 17;
            this.Text_Author.Text = "text";
            // 
            // Input_Author
            // 
            this.Input_Author.Location = new System.Drawing.Point(132, 146);
            this.Input_Author.Name = "Input_Author";
            this.Input_Author.Size = new System.Drawing.Size(187, 20);
            this.Input_Author.TabIndex = 16;
            // 
            // Input_ISBN
            // 
            this.Input_ISBN.Location = new System.Drawing.Point(132, 103);
            this.Input_ISBN.MaxLength = 20;
            this.Input_ISBN.Name = "Input_ISBN";
            this.Input_ISBN.Size = new System.Drawing.Size(187, 20);
            this.Input_ISBN.TabIndex = 15;
            // 
            // Input_Title
            // 
            this.Input_Title.Location = new System.Drawing.Point(132, 17);
            this.Input_Title.MaxLength = 15;
            this.Input_Title.Name = "Input_Title";
            this.Input_Title.Size = new System.Drawing.Size(187, 20);
            this.Input_Title.TabIndex = 14;
            // 
            // Text_ISBN
            // 
            this.Text_ISBN.AutoSize = true;
            this.Text_ISBN.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_ISBN.Location = new System.Drawing.Point(20, 104);
            this.Text_ISBN.Name = "Text_ISBN";
            this.Text_ISBN.Size = new System.Drawing.Size(34, 19);
            this.Text_ISBN.TabIndex = 13;
            this.Text_ISBN.Text = "text";
            // 
            // Text_Title
            // 
            this.Text_Title.AutoSize = true;
            this.Text_Title.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Title.Location = new System.Drawing.Point(19, 18);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(35, 19);
            this.Text_Title.TabIndex = 12;
            this.Text_Title.Text = "Text";
            // 
            // Text_BookCover
            // 
            this.Text_BookCover.AutoSize = true;
            this.Text_BookCover.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_BookCover.Location = new System.Drawing.Point(369, 147);
            this.Text_BookCover.Name = "Text_BookCover";
            this.Text_BookCover.Size = new System.Drawing.Size(34, 19);
            this.Text_BookCover.TabIndex = 22;
            this.Text_BookCover.Text = "text";
            // 
            // Button_Save
            // 
            this.Button_Save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_Save.IconColor = System.Drawing.Color.Black;
            this.Button_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Save.Location = new System.Drawing.Point(395, 278);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(272, 33);
            this.Button_Save.TabIndex = 21;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_SelectCover
            // 
            this.Button_SelectCover.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_SelectCover.IconColor = System.Drawing.Color.Black;
            this.Button_SelectCover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_SelectCover.Location = new System.Drawing.Point(575, 147);
            this.Button_SelectCover.Name = "Button_SelectCover";
            this.Button_SelectCover.Size = new System.Drawing.Size(92, 23);
            this.Button_SelectCover.TabIndex = 20;
            this.Button_SelectCover.Text = "Select";
            this.Button_SelectCover.UseVisualStyleBackColor = true;
            this.Button_SelectCover.Click += new System.EventHandler(this.Button_SelectCover_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BookAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 324);
            this.Controls.Add(this.Panel_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookAddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookAddUpdate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookAddUpdate_FormClosing);
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.PictureBox Image_BookCover;
        private System.Windows.Forms.Label Text_Author;
        private System.Windows.Forms.TextBox Input_Author;
        private System.Windows.Forms.TextBox Input_ISBN;
        private System.Windows.Forms.TextBox Input_Title;
        private System.Windows.Forms.Label Text_ISBN;
        private System.Windows.Forms.Label Text_Title;
        private System.Windows.Forms.Label Text_BookCover;
        private FontAwesome.Sharp.IconButton Button_Save;
        private FontAwesome.Sharp.IconButton Button_SelectCover;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Text_ShelfNumber;
        private System.Windows.Forms.TextBox Input_ShelfNumber;
        private System.Windows.Forms.Label Text_BookLength;
        private System.Windows.Forms.TextBox Input_Length;
        private System.Windows.Forms.Label Text_BookLang;
        private System.Windows.Forms.TextBox Input_BookLang;
        private System.Windows.Forms.Label Text_Category;
        private System.Windows.Forms.Label Text_PublishYear;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PublishYear;
        private Controls.AlertBox alertBox1;
        private System.Windows.Forms.Label Text_Title_Sec;
        private System.Windows.Forms.TextBox Input_Title_Sec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Input_Category;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}