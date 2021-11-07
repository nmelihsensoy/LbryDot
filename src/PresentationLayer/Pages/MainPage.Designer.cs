
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
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.StaffMenu = new System.Windows.Forms.Panel();
            this.MenuSettings = new FontAwesome.Sharp.IconButton();
            this.MenuStudents = new FontAwesome.Sharp.IconButton();
            this.StaffMenuTitle = new System.Windows.Forms.Label();
            this.ıconButton5 = new FontAwesome.Sharp.IconButton();
            this.MenuBooks = new FontAwesome.Sharp.IconButton();
            this.MenuMyBooks = new FontAwesome.Sharp.IconButton();
            this.MenuDashboard = new FontAwesome.Sharp.IconButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.MainSidebarLogo = new System.Windows.Forms.Label();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.WindowMinimize = new FontAwesome.Sharp.IconButton();
            this.WindowMaximize = new FontAwesome.Sharp.IconButton();
            this.WindowExit = new FontAwesome.Sharp.IconButton();
            this.TopBarPageTitle = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuLogout = new FontAwesome.Sharp.IconButton();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopBarUserDropdown = new PresentationLayer.Controls.UserDropdown();
            this.SidebarPanel.SuspendLayout();
            this.StaffMenu.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.Controls.Add(this.StaffMenu);
            this.SidebarPanel.Controls.Add(this.ıconButton5);
            this.SidebarPanel.Controls.Add(this.MenuBooks);
            this.SidebarPanel.Controls.Add(this.MenuMyBooks);
            this.SidebarPanel.Controls.Add(this.MenuDashboard);
            this.SidebarPanel.Controls.Add(this.LogoPanel);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(220, 600);
            this.SidebarPanel.TabIndex = 0;
            // 
            // StaffMenu
            // 
            this.StaffMenu.Controls.Add(this.MenuSettings);
            this.StaffMenu.Controls.Add(this.MenuStudents);
            this.StaffMenu.Controls.Add(this.StaffMenuTitle);
            this.StaffMenu.Location = new System.Drawing.Point(1, 312);
            this.StaffMenu.Name = "StaffMenu";
            this.StaffMenu.Size = new System.Drawing.Size(219, 208);
            this.StaffMenu.TabIndex = 0;
            // 
            // MenuSettings
            // 
            this.MenuSettings.FlatAppearance.BorderSize = 0;
            this.MenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSettings.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.MenuSettings.IconColor = System.Drawing.Color.Black;
            this.MenuSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuSettings.IconSize = 28;
            this.MenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuSettings.Location = new System.Drawing.Point(1, 85);
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MenuSettings.Size = new System.Drawing.Size(218, 48);
            this.MenuSettings.TabIndex = 5;
            this.MenuSettings.Text = "Settings";
            this.MenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuSettings.UseVisualStyleBackColor = true;
            this.MenuSettings.Click += new System.EventHandler(this.MenuHandler);
            // 
            // MenuStudents
            // 
            this.MenuStudents.FlatAppearance.BorderSize = 0;
            this.MenuStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuStudents.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.MenuStudents.IconColor = System.Drawing.Color.Black;
            this.MenuStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuStudents.IconSize = 28;
            this.MenuStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuStudents.Location = new System.Drawing.Point(1, 33);
            this.MenuStudents.Name = "MenuStudents";
            this.MenuStudents.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MenuStudents.Size = new System.Drawing.Size(218, 48);
            this.MenuStudents.TabIndex = 4;
            this.MenuStudents.Text = "Students";
            this.MenuStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuStudents.UseVisualStyleBackColor = true;
            this.MenuStudents.Click += new System.EventHandler(this.MenuHandler);
            // 
            // StaffMenuTitle
            // 
            this.StaffMenuTitle.AutoSize = true;
            this.StaffMenuTitle.Font = new System.Drawing.Font("Glasgow", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffMenuTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffMenuTitle.Location = new System.Drawing.Point(22, 12);
            this.StaffMenuTitle.Name = "StaffMenuTitle";
            this.StaffMenuTitle.Size = new System.Drawing.Size(35, 15);
            this.StaffMenuTitle.TabIndex = 0;
            this.StaffMenuTitle.Text = "STAFF";
            // 
            // ıconButton5
            // 
            this.ıconButton5.FlatAppearance.BorderSize = 0;
            this.ıconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton5.ForeColor = System.Drawing.Color.White;
            this.ıconButton5.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.ıconButton5.IconColor = System.Drawing.Color.White;
            this.ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton5.IconSize = 12;
            this.ıconButton5.Location = new System.Drawing.Point(184, 565);
            this.ıconButton5.Name = "ıconButton5";
            this.ıconButton5.Size = new System.Drawing.Size(23, 23);
            this.ıconButton5.TabIndex = 0;
            this.ıconButton5.UseVisualStyleBackColor = true;
            // 
            // MenuBooks
            // 
            this.MenuBooks.FlatAppearance.BorderSize = 0;
            this.MenuBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBooks.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.MenuBooks.IconColor = System.Drawing.Color.Black;
            this.MenuBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBooks.IconSize = 28;
            this.MenuBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBooks.Location = new System.Drawing.Point(1, 258);
            this.MenuBooks.Name = "MenuBooks";
            this.MenuBooks.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MenuBooks.Size = new System.Drawing.Size(218, 48);
            this.MenuBooks.TabIndex = 3;
            this.MenuBooks.Text = "Books";
            this.MenuBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuBooks.UseVisualStyleBackColor = true;
            this.MenuBooks.Click += new System.EventHandler(this.MenuHandler);
            // 
            // MenuMyBooks
            // 
            this.MenuMyBooks.FlatAppearance.BorderSize = 0;
            this.MenuMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuMyBooks.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuMyBooks.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.MenuMyBooks.IconColor = System.Drawing.Color.Black;
            this.MenuMyBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMyBooks.IconSize = 28;
            this.MenuMyBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuMyBooks.Location = new System.Drawing.Point(1, 205);
            this.MenuMyBooks.Name = "MenuMyBooks";
            this.MenuMyBooks.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MenuMyBooks.Size = new System.Drawing.Size(218, 48);
            this.MenuMyBooks.TabIndex = 2;
            this.MenuMyBooks.Text = "My Books";
            this.MenuMyBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuMyBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuMyBooks.UseVisualStyleBackColor = true;
            this.MenuMyBooks.Click += new System.EventHandler(this.MenuHandler);
            // 
            // MenuDashboard
            // 
            this.MenuDashboard.FlatAppearance.BorderSize = 0;
            this.MenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuDashboard.Font = new System.Drawing.Font("Avignon Pro Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.MenuDashboard.IconColor = System.Drawing.Color.Black;
            this.MenuDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuDashboard.IconSize = 28;
            this.MenuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuDashboard.Location = new System.Drawing.Point(1, 155);
            this.MenuDashboard.Name = "MenuDashboard";
            this.MenuDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MenuDashboard.Size = new System.Drawing.Size(218, 48);
            this.MenuDashboard.TabIndex = 1;
            this.MenuDashboard.Text = "Dashboard";
            this.MenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuDashboard.UseVisualStyleBackColor = true;
            this.MenuDashboard.Click += new System.EventHandler(this.MenuHandler);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.MainSidebarLogo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(220, 134);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.LogoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // MainSidebarLogo
            // 
            this.MainSidebarLogo.AutoSize = true;
            this.MainSidebarLogo.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainSidebarLogo.Location = new System.Drawing.Point(40, 30);
            this.MainSidebarLogo.Name = "MainSidebarLogo";
            this.MainSidebarLogo.Size = new System.Drawing.Size(139, 63);
            this.MainSidebarLogo.TabIndex = 0;
            this.MainSidebarLogo.Text = "Logo";
            this.MainSidebarLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.MainSidebarLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.MainSidebarLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.Controls.Add(this.TopBarUserDropdown);
            this.TitleBarPanel.Controls.Add(this.WindowMinimize);
            this.TitleBarPanel.Controls.Add(this.WindowMaximize);
            this.TitleBarPanel.Controls.Add(this.WindowExit);
            this.TitleBarPanel.Controls.Add(this.TopBarPageTitle);
            this.TitleBarPanel.Controls.Add(this.splitter1);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(220, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(804, 55);
            this.TitleBarPanel.TabIndex = 1;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.TitleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.TitleBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // WindowMinimize
            // 
            this.WindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMinimize.AutoSize = true;
            this.WindowMinimize.FlatAppearance.BorderSize = 0;
            this.WindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.WindowMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.WindowMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WindowMinimize.IconSize = 16;
            this.WindowMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WindowMinimize.Location = new System.Drawing.Point(694, 11);
            this.WindowMinimize.Margin = new System.Windows.Forms.Padding(1);
            this.WindowMinimize.Name = "WindowMinimize";
            this.WindowMinimize.Size = new System.Drawing.Size(32, 32);
            this.WindowMinimize.TabIndex = 3;
            this.WindowMinimize.UseVisualStyleBackColor = true;
            this.WindowMinimize.Click += new System.EventHandler(this.WindowControls);
            // 
            // WindowMaximize
            // 
            this.WindowMaximize.AutoSize = true;
            this.WindowMaximize.FlatAppearance.BorderSize = 0;
            this.WindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.WindowMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.WindowMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WindowMaximize.IconSize = 16;
            this.WindowMaximize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WindowMaximize.Location = new System.Drawing.Point(728, 11);
            this.WindowMaximize.Margin = new System.Windows.Forms.Padding(1);
            this.WindowMaximize.Name = "WindowMaximize";
            this.WindowMaximize.Size = new System.Drawing.Size(32, 32);
            this.WindowMaximize.TabIndex = 2;
            this.WindowMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WindowMaximize.UseVisualStyleBackColor = true;
            this.WindowMaximize.Click += new System.EventHandler(this.WindowControls);
            // 
            // WindowExit
            // 
            this.WindowExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowExit.FlatAppearance.BorderSize = 0;
            this.WindowExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.WindowExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.WindowExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.WindowExit.IconSize = 16;
            this.WindowExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WindowExit.Location = new System.Drawing.Point(762, 11);
            this.WindowExit.Margin = new System.Windows.Forms.Padding(1);
            this.WindowExit.Name = "WindowExit";
            this.WindowExit.Size = new System.Drawing.Size(32, 32);
            this.WindowExit.TabIndex = 0;
            this.WindowExit.UseVisualStyleBackColor = true;
            this.WindowExit.Click += new System.EventHandler(this.WindowControls);
            // 
            // TopBarPageTitle
            // 
            this.TopBarPageTitle.AutoSize = true;
            this.TopBarPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopBarPageTitle.Location = new System.Drawing.Point(21, 15);
            this.TopBarPageTitle.Name = "TopBarPageTitle";
            this.TopBarPageTitle.Size = new System.Drawing.Size(103, 24);
            this.TopBarPageTitle.TabIndex = 0;
            this.TopBarPageTitle.Text = "MainPage";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 52);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(804, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(220, 55);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(804, 545);
            this.ContentPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MenuLogout);
            this.panel1.Controls.Add(this.ıconPictureBox2);
            this.panel1.Controls.Add(this.ıconPictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(455, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 5;
            // 
            // MenuLogout
            // 
            this.MenuLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuLogout.FlatAppearance.BorderSize = 0;
            this.MenuLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLogout.Font = new System.Drawing.Font("Avignon Pro Demi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.MenuLogout.IconColor = System.Drawing.Color.Black;
            this.MenuLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuLogout.IconSize = 26;
            this.MenuLogout.Location = new System.Drawing.Point(0, 73);
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(215, 32);
            this.MenuLogout.TabIndex = 0;
            this.MenuLogout.Text = "Logout";
            this.MenuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuLogout.UseVisualStyleBackColor = true;
            this.MenuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.ıconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox2.IconSize = 22;
            this.ıconPictureBox2.Location = new System.Drawing.Point(9, 41);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(22, 22);
            this.ıconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ıconPictureBox2.TabIndex = 4;
            this.ıconPictureBox2.TabStop = false;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 22;
            this.ıconPictureBox1.Location = new System.Drawing.Point(9, 9);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(22, 22);
            this.ıconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ıconPictureBox1.TabIndex = 3;
            this.ıconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Avignon Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Avignon Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "nmelihsensoy@gmail.com";
            // 
            // TopBarUserDropdown
            // 
            this.TopBarUserDropdown.BackColor = System.Drawing.Color.White;
            this.TopBarUserDropdown.Location = new System.Drawing.Point(455, 5);
            this.TopBarUserDropdown.Name = "TopBarUserDropdown";
            this.TopBarUserDropdown.Size = new System.Drawing.Size(215, 44);
            this.TopBarUserDropdown.TabIndex = 6;
            this.TopBarUserDropdown.Click += new System.EventHandler(this.userDropdown1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.SidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "Main";
            this.SidebarPanel.ResumeLayout(false);
            this.StaffMenu.ResumeLayout(false);
            this.StaffMenu.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label MainSidebarLogo;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label TopBarPageTitle;
        private FontAwesome.Sharp.IconButton WindowMinimize;
        private FontAwesome.Sharp.IconButton WindowMaximize;
        private FontAwesome.Sharp.IconButton WindowExit;
        private FontAwesome.Sharp.IconButton MenuDashboard;
        private FontAwesome.Sharp.IconButton MenuMyBooks;
        private FontAwesome.Sharp.IconButton MenuBooks;
        private FontAwesome.Sharp.IconButton MenuSettings;
        private FontAwesome.Sharp.IconButton MenuStudents;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private System.Windows.Forms.Panel StaffMenu;
        private System.Windows.Forms.Label StaffMenuTitle;
        private System.Windows.Forms.Splitter splitter1;
        private Controls.UserDropdown TopBarUserDropdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton MenuLogout;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}