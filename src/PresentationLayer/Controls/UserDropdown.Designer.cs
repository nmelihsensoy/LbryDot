
namespace PresentationLayer.Controls
{
    partial class UserDropdown
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.DropdownIcon = new FontAwesome.Sharp.IconPictureBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.Label();
            this.UserAvatar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.DropdownIcon);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.UserRole);
            this.panel1.Controls.Add(this.UserAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 42);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.LightGray;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(214, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1, 42);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            this.splitter2.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightGray;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 42);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            this.splitter1.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // DropdownIcon
            // 
            this.DropdownIcon.BackColor = System.Drawing.Color.White;
            this.DropdownIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DropdownIcon.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.DropdownIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.DropdownIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DropdownIcon.IconSize = 16;
            this.DropdownIcon.Location = new System.Drawing.Point(174, 16);
            this.DropdownIcon.Name = "DropdownIcon";
            this.DropdownIcon.Size = new System.Drawing.Size(16, 16);
            this.DropdownIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DropdownIcon.TabIndex = 8;
            this.DropdownIcon.TabStop = false;
            this.DropdownIcon.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserName.Location = new System.Drawing.Point(42, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(63, 15);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // UserRole
            // 
            this.UserRole.AutoSize = true;
            this.UserRole.Font = new System.Drawing.Font("Glasgow Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserRole.Location = new System.Drawing.Point(42, 5);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(48, 14);
            this.UserRole.TabIndex = 6;
            this.UserRole.Text = "UserRole";
            this.UserRole.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // UserAvatar
            // 
            this.UserAvatar.ErrorImage = null;
            this.UserAvatar.Image = global::PresentationLayer.Properties.Resources.gravatar;
            this.UserAvatar.InitialImage = global::PresentationLayer.Properties.Resources.gravatar;
            this.UserAvatar.Location = new System.Drawing.Point(6, 5);
            this.UserAvatar.Name = "UserAvatar";
            this.UserAvatar.Size = new System.Drawing.Size(30, 30);
            this.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserAvatar.TabIndex = 5;
            this.UserAvatar.TabStop = false;
            this.UserAvatar.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // UserDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UserDropdown";
            this.Size = new System.Drawing.Size(215, 42);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Splitter splitter2;
        public System.Windows.Forms.Splitter splitter1;
        public FontAwesome.Sharp.IconPictureBox DropdownIcon;
        public System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Label UserRole;
        public System.Windows.Forms.PictureBox UserAvatar;
    }
}
