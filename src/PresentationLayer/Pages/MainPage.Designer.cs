
namespace PresentationLayer.Pages
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Panel_Sidebar = new System.Windows.Forms.Panel();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Text_Logo = new System.Windows.Forms.Label();
            this.Panel_StaffMenu = new System.Windows.Forms.Panel();
            this.Button_MenuSettings = new FontAwesome.Sharp.IconButton();
            this.Button_MenuStudents = new FontAwesome.Sharp.IconButton();
            this.Text_StaffMenuTitle = new System.Windows.Forms.Label();
            this.Button_InfoDialog = new FontAwesome.Sharp.IconButton();
            this.Button_MenuBooks = new FontAwesome.Sharp.IconButton();
            this.Button_MenuMyBooks = new FontAwesome.Sharp.IconButton();
            this.Button_MenuDashboard = new FontAwesome.Sharp.IconButton();
            this.Panel_TitleBar = new System.Windows.Forms.Panel();
            this.Button_AddBook = new FontAwesome.Sharp.IconButton();
            this.Panel_SearchBox = new System.Windows.Forms.Panel();
            this.Splitter_SearchBoxBottom = new System.Windows.Forms.Splitter();
            this.Splitter_SearchBoxTop = new System.Windows.Forms.Splitter();
            this.Splitter_SearchBoxRight = new System.Windows.Forms.Splitter();
            this.Splitter_SearchBoxLeft = new System.Windows.Forms.Splitter();
            this.Input_SearchBox = new System.Windows.Forms.TextBox();
            this.Button_WindowMin = new FontAwesome.Sharp.IconButton();
            this.Button_WindowMax = new FontAwesome.Sharp.IconButton();
            this.Button_WindowClose = new FontAwesome.Sharp.IconButton();
            this.Text_TitleBarTitle = new System.Windows.Forms.Label();
            this.Splitter_TopBar_Content = new System.Windows.Forms.Splitter();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.Panel_UserDropdown = new System.Windows.Forms.Panel();
            this.Panel_UserLogout_Splitter = new System.Windows.Forms.Panel();
            this.Button_UserLogout = new FontAwesome.Sharp.IconButton();
            this.Icon_UserID = new FontAwesome.Sharp.IconPictureBox();
            this.Icon_UserMail = new FontAwesome.Sharp.IconPictureBox();
            this.Text_User_ID = new System.Windows.Forms.Label();
            this.Text_UserMail = new System.Windows.Forms.Label();
            this.Splitter_UserDropdown_Panel_Right = new System.Windows.Forms.Splitter();
            this.Splitter_UserDropdown_Panel_Left = new System.Windows.Forms.Splitter();
            this.Splitter_UserLogout_Bottom = new System.Windows.Forms.Splitter();
            this.Tooltip_AddBook = new System.Windows.Forms.ToolTip(this.components);
            this.userDropdown_TopBar = new PresentationLayer.Controls.UserDropdown();
            this.Panel_Sidebar.SuspendLayout();
            this.Panel_Logo.SuspendLayout();
            this.Panel_StaffMenu.SuspendLayout();
            this.Panel_TitleBar.SuspendLayout();
            this.Panel_SearchBox.SuspendLayout();
            this.Panel_Content.SuspendLayout();
            this.Panel_UserDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserMail)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Sidebar
            // 
            this.Panel_Sidebar.Controls.Add(this.Panel_Logo);
            this.Panel_Sidebar.Controls.Add(this.Panel_StaffMenu);
            this.Panel_Sidebar.Controls.Add(this.Button_InfoDialog);
            this.Panel_Sidebar.Controls.Add(this.Button_MenuBooks);
            this.Panel_Sidebar.Controls.Add(this.Button_MenuMyBooks);
            this.Panel_Sidebar.Controls.Add(this.Button_MenuDashboard);
            this.Panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Panel_Sidebar.Name = "Panel_Sidebar";
            this.Panel_Sidebar.Size = new System.Drawing.Size(214, 600);
            this.Panel_Sidebar.TabIndex = 0;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.Controls.Add(this.Text_Logo);
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(214, 134);
            this.Panel_Logo.TabIndex = 0;
            this.Panel_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Panel_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Panel_Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Text_Logo
            // 
            this.Text_Logo.AutoSize = true;
            this.Text_Logo.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Logo.Location = new System.Drawing.Point(40, 30);
            this.Text_Logo.Name = "Text_Logo";
            this.Text_Logo.Size = new System.Drawing.Size(139, 63);
            this.Text_Logo.TabIndex = 0;
            this.Text_Logo.Text = "Logo";
            this.Text_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Text_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Text_Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Panel_StaffMenu
            // 
            this.Panel_StaffMenu.Controls.Add(this.Button_MenuSettings);
            this.Panel_StaffMenu.Controls.Add(this.Button_MenuStudents);
            this.Panel_StaffMenu.Controls.Add(this.Text_StaffMenuTitle);
            this.Panel_StaffMenu.Location = new System.Drawing.Point(1, 312);
            this.Panel_StaffMenu.Name = "Panel_StaffMenu";
            this.Panel_StaffMenu.Size = new System.Drawing.Size(219, 208);
            this.Panel_StaffMenu.TabIndex = 0;
            this.Panel_StaffMenu.Visible = false;
            // 
            // Button_MenuSettings
            // 
            this.Button_MenuSettings.FlatAppearance.BorderSize = 0;
            this.Button_MenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MenuSettings.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_MenuSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.Button_MenuSettings.IconColor = System.Drawing.Color.Black;
            this.Button_MenuSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MenuSettings.IconSize = 28;
            this.Button_MenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuSettings.Location = new System.Drawing.Point(1, 85);
            this.Button_MenuSettings.Name = "Button_MenuSettings";
            this.Button_MenuSettings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_MenuSettings.Size = new System.Drawing.Size(212, 48);
            this.Button_MenuSettings.TabIndex = 5;
            this.Button_MenuSettings.Text = "Settings";
            this.Button_MenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_MenuSettings.UseVisualStyleBackColor = true;
            this.Button_MenuSettings.Click += new System.EventHandler(this.MenuHandler);
            // 
            // Button_MenuStudents
            // 
            this.Button_MenuStudents.FlatAppearance.BorderSize = 0;
            this.Button_MenuStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MenuStudents.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_MenuStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.Button_MenuStudents.IconColor = System.Drawing.Color.Black;
            this.Button_MenuStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MenuStudents.IconSize = 28;
            this.Button_MenuStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuStudents.Location = new System.Drawing.Point(1, 33);
            this.Button_MenuStudents.Name = "Button_MenuStudents";
            this.Button_MenuStudents.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_MenuStudents.Size = new System.Drawing.Size(212, 48);
            this.Button_MenuStudents.TabIndex = 4;
            this.Button_MenuStudents.Text = "Students";
            this.Button_MenuStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_MenuStudents.UseVisualStyleBackColor = true;
            this.Button_MenuStudents.Click += new System.EventHandler(this.MenuHandler);
            // 
            // Text_StaffMenuTitle
            // 
            this.Text_StaffMenuTitle.AutoSize = true;
            this.Text_StaffMenuTitle.Font = new System.Drawing.Font("Glasgow", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_StaffMenuTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Text_StaffMenuTitle.Location = new System.Drawing.Point(22, 12);
            this.Text_StaffMenuTitle.Name = "Text_StaffMenuTitle";
            this.Text_StaffMenuTitle.Size = new System.Drawing.Size(35, 15);
            this.Text_StaffMenuTitle.TabIndex = 0;
            this.Text_StaffMenuTitle.Text = "STAFF";
            // 
            // Button_InfoDialog
            // 
            this.Button_InfoDialog.FlatAppearance.BorderSize = 0;
            this.Button_InfoDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_InfoDialog.ForeColor = System.Drawing.Color.White;
            this.Button_InfoDialog.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.Button_InfoDialog.IconColor = System.Drawing.Color.White;
            this.Button_InfoDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_InfoDialog.IconSize = 12;
            this.Button_InfoDialog.Location = new System.Drawing.Point(184, 565);
            this.Button_InfoDialog.Name = "Button_InfoDialog";
            this.Button_InfoDialog.Size = new System.Drawing.Size(23, 23);
            this.Button_InfoDialog.TabIndex = 0;
            this.Button_InfoDialog.UseVisualStyleBackColor = true;
            this.Button_InfoDialog.Click += new System.EventHandler(this.ıconButton5_Click);
            // 
            // Button_MenuBooks
            // 
            this.Button_MenuBooks.FlatAppearance.BorderSize = 0;
            this.Button_MenuBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MenuBooks.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_MenuBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Button_MenuBooks.IconColor = System.Drawing.Color.Black;
            this.Button_MenuBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MenuBooks.IconSize = 28;
            this.Button_MenuBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuBooks.Location = new System.Drawing.Point(1, 258);
            this.Button_MenuBooks.Name = "Button_MenuBooks";
            this.Button_MenuBooks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_MenuBooks.Size = new System.Drawing.Size(212, 48);
            this.Button_MenuBooks.TabIndex = 3;
            this.Button_MenuBooks.Text = "Books";
            this.Button_MenuBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_MenuBooks.UseVisualStyleBackColor = true;
            this.Button_MenuBooks.Click += new System.EventHandler(this.MenuHandler);
            // 
            // Button_MenuMyBooks
            // 
            this.Button_MenuMyBooks.FlatAppearance.BorderSize = 0;
            this.Button_MenuMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MenuMyBooks.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_MenuMyBooks.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.Button_MenuMyBooks.IconColor = System.Drawing.Color.Black;
            this.Button_MenuMyBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MenuMyBooks.IconSize = 28;
            this.Button_MenuMyBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuMyBooks.Location = new System.Drawing.Point(1, 205);
            this.Button_MenuMyBooks.Name = "Button_MenuMyBooks";
            this.Button_MenuMyBooks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_MenuMyBooks.Size = new System.Drawing.Size(212, 48);
            this.Button_MenuMyBooks.TabIndex = 2;
            this.Button_MenuMyBooks.Text = "My Books";
            this.Button_MenuMyBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuMyBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_MenuMyBooks.UseVisualStyleBackColor = true;
            this.Button_MenuMyBooks.Click += new System.EventHandler(this.MenuHandler);
            // 
            // Button_MenuDashboard
            // 
            this.Button_MenuDashboard.FlatAppearance.BorderSize = 0;
            this.Button_MenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MenuDashboard.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_MenuDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Button_MenuDashboard.IconColor = System.Drawing.Color.Black;
            this.Button_MenuDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MenuDashboard.IconSize = 28;
            this.Button_MenuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_MenuDashboard.Location = new System.Drawing.Point(1, 155);
            this.Button_MenuDashboard.Name = "Button_MenuDashboard";
            this.Button_MenuDashboard.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_MenuDashboard.Size = new System.Drawing.Size(212, 48);
            this.Button_MenuDashboard.TabIndex = 1;
            this.Button_MenuDashboard.Text = "Dashboard";
            this.Button_MenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_MenuDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_MenuDashboard.UseVisualStyleBackColor = true;
            this.Button_MenuDashboard.Click += new System.EventHandler(this.MenuHandler);
            // 
            // Panel_TitleBar
            // 
            this.Panel_TitleBar.Controls.Add(this.userDropdown_TopBar);
            this.Panel_TitleBar.Controls.Add(this.Button_AddBook);
            this.Panel_TitleBar.Controls.Add(this.Panel_SearchBox);
            this.Panel_TitleBar.Controls.Add(this.Button_WindowMin);
            this.Panel_TitleBar.Controls.Add(this.Button_WindowMax);
            this.Panel_TitleBar.Controls.Add(this.Button_WindowClose);
            this.Panel_TitleBar.Controls.Add(this.Text_TitleBarTitle);
            this.Panel_TitleBar.Controls.Add(this.Splitter_TopBar_Content);
            this.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TitleBar.Location = new System.Drawing.Point(214, 0);
            this.Panel_TitleBar.Name = "Panel_TitleBar";
            this.Panel_TitleBar.Size = new System.Drawing.Size(810, 55);
            this.Panel_TitleBar.TabIndex = 1;
            this.Panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Panel_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Panel_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Button_AddBook
            // 
            this.Button_AddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Button_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddBook.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.Button_AddBook.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.Button_AddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_AddBook.IconSize = 18;
            this.Button_AddBook.Location = new System.Drawing.Point(123, 11);
            this.Button_AddBook.Name = "Button_AddBook";
            this.Button_AddBook.Size = new System.Drawing.Size(31, 31);
            this.Button_AddBook.TabIndex = 9;
            this.Button_AddBook.UseVisualStyleBackColor = true;
            this.Button_AddBook.Click += new System.EventHandler(this.Button_AddBook_Click);
            this.Button_AddBook.MouseHover += new System.EventHandler(this.ıconButton1_MouseHover);
            // 
            // Panel_SearchBox
            // 
            this.Panel_SearchBox.BackColor = System.Drawing.Color.White;
            this.Panel_SearchBox.Controls.Add(this.Splitter_SearchBoxBottom);
            this.Panel_SearchBox.Controls.Add(this.Splitter_SearchBoxTop);
            this.Panel_SearchBox.Controls.Add(this.Splitter_SearchBoxRight);
            this.Panel_SearchBox.Controls.Add(this.Splitter_SearchBoxLeft);
            this.Panel_SearchBox.Controls.Add(this.Input_SearchBox);
            this.Panel_SearchBox.Location = new System.Drawing.Point(160, 12);
            this.Panel_SearchBox.Name = "Panel_SearchBox";
            this.Panel_SearchBox.Size = new System.Drawing.Size(257, 30);
            this.Panel_SearchBox.TabIndex = 8;
            this.Panel_SearchBox.Visible = false;
            // 
            // Splitter_SearchBoxBottom
            // 
            this.Splitter_SearchBoxBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.Splitter_SearchBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_SearchBoxBottom.Location = new System.Drawing.Point(2, 28);
            this.Splitter_SearchBoxBottom.Name = "Splitter_SearchBoxBottom";
            this.Splitter_SearchBoxBottom.Size = new System.Drawing.Size(253, 2);
            this.Splitter_SearchBoxBottom.TabIndex = 12;
            this.Splitter_SearchBoxBottom.TabStop = false;
            // 
            // Splitter_SearchBoxTop
            // 
            this.Splitter_SearchBoxTop.BackColor = System.Drawing.Color.LightGray;
            this.Splitter_SearchBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter_SearchBoxTop.Location = new System.Drawing.Point(2, 0);
            this.Splitter_SearchBoxTop.Name = "Splitter_SearchBoxTop";
            this.Splitter_SearchBoxTop.Size = new System.Drawing.Size(253, 2);
            this.Splitter_SearchBoxTop.TabIndex = 11;
            this.Splitter_SearchBoxTop.TabStop = false;
            // 
            // Splitter_SearchBoxRight
            // 
            this.Splitter_SearchBoxRight.BackColor = System.Drawing.Color.LightGray;
            this.Splitter_SearchBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter_SearchBoxRight.Location = new System.Drawing.Point(255, 0);
            this.Splitter_SearchBoxRight.Name = "Splitter_SearchBoxRight";
            this.Splitter_SearchBoxRight.Size = new System.Drawing.Size(2, 30);
            this.Splitter_SearchBoxRight.TabIndex = 10;
            this.Splitter_SearchBoxRight.TabStop = false;
            // 
            // Splitter_SearchBoxLeft
            // 
            this.Splitter_SearchBoxLeft.BackColor = System.Drawing.Color.LightGray;
            this.Splitter_SearchBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.Splitter_SearchBoxLeft.Name = "Splitter_SearchBoxLeft";
            this.Splitter_SearchBoxLeft.Size = new System.Drawing.Size(2, 30);
            this.Splitter_SearchBoxLeft.TabIndex = 9;
            this.Splitter_SearchBoxLeft.TabStop = false;
            // 
            // Input_SearchBox
            // 
            this.Input_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input_SearchBox.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Input_SearchBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Input_SearchBox.Location = new System.Drawing.Point(5, 5);
            this.Input_SearchBox.Name = "Input_SearchBox";
            this.Input_SearchBox.Size = new System.Drawing.Size(249, 18);
            this.Input_SearchBox.TabIndex = 8;
            this.Input_SearchBox.Text = "Search";
            this.Input_SearchBox.Enter += new System.EventHandler(this.Input_SearchBox_Enter);
            this.Input_SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_SearchBox_KeyDown);
            this.Input_SearchBox.Leave += new System.EventHandler(this.Input_SearchBox_Leave);
            // 
            // Button_WindowMin
            // 
            this.Button_WindowMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_WindowMin.AutoSize = true;
            this.Button_WindowMin.FlatAppearance.BorderSize = 0;
            this.Button_WindowMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_WindowMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Button_WindowMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Button_WindowMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_WindowMin.IconSize = 16;
            this.Button_WindowMin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_WindowMin.Location = new System.Drawing.Point(700, 11);
            this.Button_WindowMin.Margin = new System.Windows.Forms.Padding(1);
            this.Button_WindowMin.Name = "Button_WindowMin";
            this.Button_WindowMin.Size = new System.Drawing.Size(32, 32);
            this.Button_WindowMin.TabIndex = 3;
            this.Button_WindowMin.UseVisualStyleBackColor = true;
            this.Button_WindowMin.Click += new System.EventHandler(this.WindowControls);
            // 
            // Button_WindowMax
            // 
            this.Button_WindowMax.AutoSize = true;
            this.Button_WindowMax.FlatAppearance.BorderSize = 0;
            this.Button_WindowMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_WindowMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.Button_WindowMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Button_WindowMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_WindowMax.IconSize = 16;
            this.Button_WindowMax.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_WindowMax.Location = new System.Drawing.Point(734, 11);
            this.Button_WindowMax.Margin = new System.Windows.Forms.Padding(1);
            this.Button_WindowMax.Name = "Button_WindowMax";
            this.Button_WindowMax.Size = new System.Drawing.Size(32, 32);
            this.Button_WindowMax.TabIndex = 2;
            this.Button_WindowMax.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_WindowMax.UseVisualStyleBackColor = true;
            this.Button_WindowMax.Click += new System.EventHandler(this.WindowControls);
            // 
            // Button_WindowClose
            // 
            this.Button_WindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_WindowClose.FlatAppearance.BorderSize = 0;
            this.Button_WindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_WindowClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Button_WindowClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Button_WindowClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Button_WindowClose.IconSize = 16;
            this.Button_WindowClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_WindowClose.Location = new System.Drawing.Point(768, 11);
            this.Button_WindowClose.Margin = new System.Windows.Forms.Padding(1);
            this.Button_WindowClose.Name = "Button_WindowClose";
            this.Button_WindowClose.Size = new System.Drawing.Size(32, 32);
            this.Button_WindowClose.TabIndex = 0;
            this.Button_WindowClose.UseVisualStyleBackColor = true;
            this.Button_WindowClose.Click += new System.EventHandler(this.WindowControls);
            // 
            // Text_TitleBarTitle
            // 
            this.Text_TitleBarTitle.AutoSize = true;
            this.Text_TitleBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_TitleBarTitle.Location = new System.Drawing.Point(14, 15);
            this.Text_TitleBarTitle.Name = "Text_TitleBarTitle";
            this.Text_TitleBarTitle.Size = new System.Drawing.Size(103, 24);
            this.Text_TitleBarTitle.TabIndex = 0;
            this.Text_TitleBarTitle.Text = "MainPage";
            // 
            // Splitter_TopBar_Content
            // 
            this.Splitter_TopBar_Content.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Splitter_TopBar_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_TopBar_Content.Location = new System.Drawing.Point(0, 52);
            this.Splitter_TopBar_Content.Name = "Splitter_TopBar_Content";
            this.Splitter_TopBar_Content.Size = new System.Drawing.Size(810, 3);
            this.Splitter_TopBar_Content.TabIndex = 5;
            this.Splitter_TopBar_Content.TabStop = false;
            // 
            // Panel_Content
            // 
            this.Panel_Content.Controls.Add(this.Panel_UserDropdown);
            this.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Content.Location = new System.Drawing.Point(214, 55);
            this.Panel_Content.Margin = new System.Windows.Forms.Padding(1);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(810, 545);
            this.Panel_Content.TabIndex = 2;
            // 
            // Panel_UserDropdown
            // 
            this.Panel_UserDropdown.BackColor = System.Drawing.Color.White;
            this.Panel_UserDropdown.Controls.Add(this.Panel_UserLogout_Splitter);
            this.Panel_UserDropdown.Controls.Add(this.Button_UserLogout);
            this.Panel_UserDropdown.Controls.Add(this.Icon_UserID);
            this.Panel_UserDropdown.Controls.Add(this.Icon_UserMail);
            this.Panel_UserDropdown.Controls.Add(this.Text_User_ID);
            this.Panel_UserDropdown.Controls.Add(this.Text_UserMail);
            this.Panel_UserDropdown.Controls.Add(this.Splitter_UserDropdown_Panel_Right);
            this.Panel_UserDropdown.Controls.Add(this.Splitter_UserDropdown_Panel_Left);
            this.Panel_UserDropdown.Controls.Add(this.Splitter_UserLogout_Bottom);
            this.Panel_UserDropdown.Location = new System.Drawing.Point(469, -2);
            this.Panel_UserDropdown.Name = "Panel_UserDropdown";
            this.Panel_UserDropdown.Size = new System.Drawing.Size(215, 105);
            this.Panel_UserDropdown.TabIndex = 0;
            this.Panel_UserDropdown.Visible = false;
            // 
            // Panel_UserLogout_Splitter
            // 
            this.Panel_UserLogout_Splitter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Panel_UserLogout_Splitter.Location = new System.Drawing.Point(0, 72);
            this.Panel_UserLogout_Splitter.Name = "Panel_UserLogout_Splitter";
            this.Panel_UserLogout_Splitter.Size = new System.Drawing.Size(215, 1);
            this.Panel_UserLogout_Splitter.TabIndex = 5;
            // 
            // Button_UserLogout
            // 
            this.Button_UserLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_UserLogout.FlatAppearance.BorderSize = 0;
            this.Button_UserLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UserLogout.Font = new System.Drawing.Font("Avignon Pro Demi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_UserLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Button_UserLogout.IconColor = System.Drawing.Color.Black;
            this.Button_UserLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_UserLogout.IconSize = 26;
            this.Button_UserLogout.Location = new System.Drawing.Point(1, 72);
            this.Button_UserLogout.Name = "Button_UserLogout";
            this.Button_UserLogout.Size = new System.Drawing.Size(213, 32);
            this.Button_UserLogout.TabIndex = 0;
            this.Button_UserLogout.Text = "Logout";
            this.Button_UserLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_UserLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_UserLogout.UseVisualStyleBackColor = true;
            this.Button_UserLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // Icon_UserID
            // 
            this.Icon_UserID.BackColor = System.Drawing.Color.White;
            this.Icon_UserID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon_UserID.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.Icon_UserID.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon_UserID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_UserID.IconSize = 22;
            this.Icon_UserID.Location = new System.Drawing.Point(9, 41);
            this.Icon_UserID.Name = "Icon_UserID";
            this.Icon_UserID.Size = new System.Drawing.Size(22, 22);
            this.Icon_UserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icon_UserID.TabIndex = 4;
            this.Icon_UserID.TabStop = false;
            // 
            // Icon_UserMail
            // 
            this.Icon_UserMail.BackColor = System.Drawing.Color.White;
            this.Icon_UserMail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon_UserMail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.Icon_UserMail.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon_UserMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_UserMail.IconSize = 22;
            this.Icon_UserMail.Location = new System.Drawing.Point(9, 9);
            this.Icon_UserMail.Name = "Icon_UserMail";
            this.Icon_UserMail.Size = new System.Drawing.Size(22, 22);
            this.Icon_UserMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Icon_UserMail.TabIndex = 3;
            this.Icon_UserMail.TabStop = false;
            // 
            // Text_User_ID
            // 
            this.Text_User_ID.AutoSize = true;
            this.Text_User_ID.Font = new System.Drawing.Font("Avignon Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_User_ID.Location = new System.Drawing.Point(37, 46);
            this.Text_User_ID.Name = "Text_User_ID";
            this.Text_User_ID.Size = new System.Drawing.Size(19, 14);
            this.Text_User_ID.TabIndex = 2;
            this.Text_User_ID.Text = "12";
            // 
            // Text_UserMail
            // 
            this.Text_UserMail.AutoSize = true;
            this.Text_UserMail.Font = new System.Drawing.Font("Avignon Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_UserMail.Location = new System.Drawing.Point(37, 14);
            this.Text_UserMail.Name = "Text_UserMail";
            this.Text_UserMail.Size = new System.Drawing.Size(123, 14);
            this.Text_UserMail.TabIndex = 1;
            this.Text_UserMail.Text = "email@example.com";
            // 
            // Splitter_UserDropdown_Panel_Right
            // 
            this.Splitter_UserDropdown_Panel_Right.BackColor = System.Drawing.Color.Black;
            this.Splitter_UserDropdown_Panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter_UserDropdown_Panel_Right.Location = new System.Drawing.Point(214, 0);
            this.Splitter_UserDropdown_Panel_Right.Name = "Splitter_UserDropdown_Panel_Right";
            this.Splitter_UserDropdown_Panel_Right.Size = new System.Drawing.Size(1, 104);
            this.Splitter_UserDropdown_Panel_Right.TabIndex = 7;
            this.Splitter_UserDropdown_Panel_Right.TabStop = false;
            // 
            // Splitter_UserDropdown_Panel_Left
            // 
            this.Splitter_UserDropdown_Panel_Left.BackColor = System.Drawing.Color.Black;
            this.Splitter_UserDropdown_Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Splitter_UserDropdown_Panel_Left.Name = "Splitter_UserDropdown_Panel_Left";
            this.Splitter_UserDropdown_Panel_Left.Size = new System.Drawing.Size(1, 104);
            this.Splitter_UserDropdown_Panel_Left.TabIndex = 6;
            this.Splitter_UserDropdown_Panel_Left.TabStop = false;
            // 
            // Splitter_UserLogout_Bottom
            // 
            this.Splitter_UserLogout_Bottom.BackColor = System.Drawing.Color.Black;
            this.Splitter_UserLogout_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_UserLogout_Bottom.Location = new System.Drawing.Point(0, 104);
            this.Splitter_UserLogout_Bottom.Name = "Splitter_UserLogout_Bottom";
            this.Splitter_UserLogout_Bottom.Size = new System.Drawing.Size(215, 1);
            this.Splitter_UserLogout_Bottom.TabIndex = 8;
            this.Splitter_UserLogout_Bottom.TabStop = false;
            // 
            // userDropdown_TopBar
            // 
            this.userDropdown_TopBar.BackColor = System.Drawing.Color.White;
            this.userDropdown_TopBar.Location = new System.Drawing.Point(469, 6);
            this.userDropdown_TopBar.Name = "userDropdown_TopBar";
            this.userDropdown_TopBar.Size = new System.Drawing.Size(215, 42);
            this.userDropdown_TopBar.TabIndex = 10;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.Panel_Content);
            this.Controls.Add(this.Panel_TitleBar);
            this.Controls.Add(this.Panel_Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Panel_Sidebar.ResumeLayout(false);
            this.Panel_Logo.ResumeLayout(false);
            this.Panel_Logo.PerformLayout();
            this.Panel_StaffMenu.ResumeLayout(false);
            this.Panel_StaffMenu.PerformLayout();
            this.Panel_TitleBar.ResumeLayout(false);
            this.Panel_TitleBar.PerformLayout();
            this.Panel_SearchBox.ResumeLayout(false);
            this.Panel_SearchBox.PerformLayout();
            this.Panel_Content.ResumeLayout(false);
            this.Panel_UserDropdown.ResumeLayout(false);
            this.Panel_UserDropdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Sidebar;
        private System.Windows.Forms.Panel Panel_TitleBar;
        private System.Windows.Forms.Panel Panel_Content;
        private System.Windows.Forms.Label Text_TitleBarTitle;
        private FontAwesome.Sharp.IconButton Button_WindowMin;
        private FontAwesome.Sharp.IconButton Button_WindowMax;
        private FontAwesome.Sharp.IconButton Button_WindowClose;
        private FontAwesome.Sharp.IconButton Button_MenuDashboard;
        private FontAwesome.Sharp.IconButton Button_MenuMyBooks;
        private FontAwesome.Sharp.IconButton Button_MenuBooks;
        private FontAwesome.Sharp.IconButton Button_MenuSettings;
        private FontAwesome.Sharp.IconButton Button_MenuStudents;
        private FontAwesome.Sharp.IconButton Button_InfoDialog;
        private System.Windows.Forms.Panel Panel_StaffMenu;
        private System.Windows.Forms.Label Text_StaffMenuTitle;
        private System.Windows.Forms.Splitter Splitter_TopBar_Content;
        private System.Windows.Forms.Panel Panel_UserDropdown;
        private System.Windows.Forms.Panel Panel_UserLogout_Splitter;
        private FontAwesome.Sharp.IconButton Button_UserLogout;
        private FontAwesome.Sharp.IconPictureBox Icon_UserID;
        private FontAwesome.Sharp.IconPictureBox Icon_UserMail;
        private System.Windows.Forms.Label Text_User_ID;
        private System.Windows.Forms.Label Text_UserMail;
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Label Text_Logo;
        private System.Windows.Forms.TextBox Input_SearchBox;
        private System.Windows.Forms.Panel Panel_SearchBox;
        private System.Windows.Forms.Splitter Splitter_SearchBoxBottom;
        private System.Windows.Forms.Splitter Splitter_SearchBoxTop;
        private System.Windows.Forms.Splitter Splitter_SearchBoxRight;
        private System.Windows.Forms.Splitter Splitter_SearchBoxLeft;
        private System.Windows.Forms.Splitter Splitter_UserDropdown_Panel_Right;
        private System.Windows.Forms.Splitter Splitter_UserDropdown_Panel_Left;
        private System.Windows.Forms.Splitter Splitter_UserLogout_Bottom;
        private FontAwesome.Sharp.IconButton Button_AddBook;
        private System.Windows.Forms.ToolTip Tooltip_AddBook;
        private Controls.UserDropdown userDropdown_TopBar;
    }
}