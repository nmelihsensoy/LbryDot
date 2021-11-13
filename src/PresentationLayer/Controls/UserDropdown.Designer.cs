
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
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.Splitter_BorderRight = new System.Windows.Forms.Splitter();
            this.Splitter_BorderLeft = new System.Windows.Forms.Splitter();
            this.DropdownIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Text_UserName = new System.Windows.Forms.Label();
            this.Text_UserRole = new System.Windows.Forms.Label();
            this.Image_UserAvatar = new System.Windows.Forms.PictureBox();
            this.Panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_UserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Container
            // 
            this.Panel_Container.BackColor = System.Drawing.Color.White;
            this.Panel_Container.Controls.Add(this.Splitter_BorderRight);
            this.Panel_Container.Controls.Add(this.Splitter_BorderLeft);
            this.Panel_Container.Controls.Add(this.DropdownIcon);
            this.Panel_Container.Controls.Add(this.Text_UserName);
            this.Panel_Container.Controls.Add(this.Text_UserRole);
            this.Panel_Container.Controls.Add(this.Image_UserAvatar);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(215, 42);
            this.Panel_Container.TabIndex = 1;
            this.Panel_Container.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // Splitter_BorderRight
            // 
            this.Splitter_BorderRight.BackColor = System.Drawing.Color.LightGray;
            this.Splitter_BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter_BorderRight.Location = new System.Drawing.Point(214, 0);
            this.Splitter_BorderRight.Name = "Splitter_BorderRight";
            this.Splitter_BorderRight.Size = new System.Drawing.Size(1, 42);
            this.Splitter_BorderRight.TabIndex = 10;
            this.Splitter_BorderRight.TabStop = false;
            this.Splitter_BorderRight.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // Splitter_BorderLeft
            // 
            this.Splitter_BorderLeft.BackColor = System.Drawing.Color.LightGray;
            this.Splitter_BorderLeft.Location = new System.Drawing.Point(0, 0);
            this.Splitter_BorderLeft.Name = "Splitter_BorderLeft";
            this.Splitter_BorderLeft.Size = new System.Drawing.Size(1, 42);
            this.Splitter_BorderLeft.TabIndex = 9;
            this.Splitter_BorderLeft.TabStop = false;
            this.Splitter_BorderLeft.Click += new System.EventHandler(this.DropdownClickEvent);
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
            // Text_UserName
            // 
            this.Text_UserName.AutoSize = true;
            this.Text_UserName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_UserName.Location = new System.Drawing.Point(42, 20);
            this.Text_UserName.Name = "Text_UserName";
            this.Text_UserName.Size = new System.Drawing.Size(63, 15);
            this.Text_UserName.TabIndex = 7;
            this.Text_UserName.Text = "UserName";
            this.Text_UserName.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // Text_UserRole
            // 
            this.Text_UserRole.AutoSize = true;
            this.Text_UserRole.Font = new System.Drawing.Font("Glasgow Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_UserRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Text_UserRole.Location = new System.Drawing.Point(42, 5);
            this.Text_UserRole.Name = "Text_UserRole";
            this.Text_UserRole.Size = new System.Drawing.Size(48, 14);
            this.Text_UserRole.TabIndex = 6;
            this.Text_UserRole.Text = "UserRole";
            this.Text_UserRole.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // Image_UserAvatar
            // 
            this.Image_UserAvatar.ErrorImage = null;
            this.Image_UserAvatar.Image = global::PresentationLayer.Properties.Resources.gravatar;
            this.Image_UserAvatar.InitialImage = global::PresentationLayer.Properties.Resources.gravatar;
            this.Image_UserAvatar.Location = new System.Drawing.Point(6, 5);
            this.Image_UserAvatar.Name = "Image_UserAvatar";
            this.Image_UserAvatar.Size = new System.Drawing.Size(30, 30);
            this.Image_UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_UserAvatar.TabIndex = 5;
            this.Image_UserAvatar.TabStop = false;
            this.Image_UserAvatar.Click += new System.EventHandler(this.DropdownClickEvent);
            // 
            // UserDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel_Container);
            this.Name = "UserDropdown";
            this.Size = new System.Drawing.Size(215, 42);
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropdownIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_UserAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Panel_Container;
        public System.Windows.Forms.Splitter Splitter_BorderRight;
        public System.Windows.Forms.Splitter Splitter_BorderLeft;
        public FontAwesome.Sharp.IconPictureBox DropdownIcon;
        public System.Windows.Forms.Label Text_UserName;
        public System.Windows.Forms.Label Text_UserRole;
        public System.Windows.Forms.PictureBox Image_UserAvatar;
    }
}
