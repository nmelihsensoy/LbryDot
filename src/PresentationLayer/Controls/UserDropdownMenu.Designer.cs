
namespace PresentationLayer.Controls
{
    partial class UserDropdownMenu
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
            this.Icon_UserID = new FontAwesome.Sharp.IconPictureBox();
            this.Icon_UserMail = new FontAwesome.Sharp.IconPictureBox();
            this.Text_User_ID = new System.Windows.Forms.Label();
            this.Text_UserMail = new System.Windows.Forms.Label();
            this.Panel_UserLogout_Splitter = new System.Windows.Forms.Panel();
            this.Button_UserLogout = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserMail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Icon_UserID);
            this.panel1.Controls.Add(this.Icon_UserMail);
            this.panel1.Controls.Add(this.Text_User_ID);
            this.panel1.Controls.Add(this.Text_UserMail);
            this.panel1.Controls.Add(this.Panel_UserLogout_Splitter);
            this.panel1.Controls.Add(this.Button_UserLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 105);
            this.panel1.TabIndex = 0;
            // 
            // Icon_UserID
            // 
            this.Icon_UserID.BackColor = System.Drawing.Color.White;
            this.Icon_UserID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon_UserID.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.Icon_UserID.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon_UserID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_UserID.IconSize = 22;
            this.Icon_UserID.Location = new System.Drawing.Point(11, 42);
            this.Icon_UserID.Name = "Icon_UserID";
            this.Icon_UserID.Size = new System.Drawing.Size(22, 22);
            this.Icon_UserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icon_UserID.TabIndex = 10;
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
            this.Icon_UserMail.Location = new System.Drawing.Point(11, 10);
            this.Icon_UserMail.Name = "Icon_UserMail";
            this.Icon_UserMail.Size = new System.Drawing.Size(22, 22);
            this.Icon_UserMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Icon_UserMail.TabIndex = 9;
            this.Icon_UserMail.TabStop = false;
            // 
            // Text_User_ID
            // 
            this.Text_User_ID.AutoSize = true;
            this.Text_User_ID.Font = new System.Drawing.Font("Avignon Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_User_ID.Location = new System.Drawing.Point(39, 47);
            this.Text_User_ID.Name = "Text_User_ID";
            this.Text_User_ID.Size = new System.Drawing.Size(19, 14);
            this.Text_User_ID.TabIndex = 8;
            this.Text_User_ID.Text = "12";
            // 
            // Text_UserMail
            // 
            this.Text_UserMail.AutoSize = true;
            this.Text_UserMail.Font = new System.Drawing.Font("Avignon Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_UserMail.Location = new System.Drawing.Point(39, 15);
            this.Text_UserMail.Name = "Text_UserMail";
            this.Text_UserMail.Size = new System.Drawing.Size(123, 14);
            this.Text_UserMail.TabIndex = 7;
            this.Text_UserMail.Text = "email@example.com";
            // 
            // Panel_UserLogout_Splitter
            // 
            this.Panel_UserLogout_Splitter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Panel_UserLogout_Splitter.Location = new System.Drawing.Point(0, 74);
            this.Panel_UserLogout_Splitter.Name = "Panel_UserLogout_Splitter";
            this.Panel_UserLogout_Splitter.Size = new System.Drawing.Size(215, 1);
            this.Panel_UserLogout_Splitter.TabIndex = 6;
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
            this.Button_UserLogout.Location = new System.Drawing.Point(0, 73);
            this.Button_UserLogout.Name = "Button_UserLogout";
            this.Button_UserLogout.Size = new System.Drawing.Size(215, 32);
            this.Button_UserLogout.TabIndex = 1;
            this.Button_UserLogout.Text = "Logout";
            this.Button_UserLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_UserLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_UserLogout.UseVisualStyleBackColor = true;
            this.Button_UserLogout.Click += new System.EventHandler(this.LogoutClickEvent);
            // 
            // UserDropdownMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserDropdownMenu";
            this.Size = new System.Drawing.Size(215, 105);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_UserMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Button_UserLogout;
        private System.Windows.Forms.Panel Panel_UserLogout_Splitter;
        private FontAwesome.Sharp.IconPictureBox Icon_UserID;
        private FontAwesome.Sharp.IconPictureBox Icon_UserMail;
        private System.Windows.Forms.Label Text_User_ID;
        private System.Windows.Forms.Label Text_UserMail;
    }
}
