
namespace PresentationLayer.Pages
{
    partial class LoginPage
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
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.Pass_Input_Line = new System.Windows.Forms.Panel();
            this.Pass_Input_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.Email_Input_Line = new System.Windows.Forms.Panel();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.Email_Input_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.Lang_Select_Seperator = new System.Windows.Forms.Label();
            this.Lang_TR = new System.Windows.Forms.Button();
            this.Lang_EN = new System.Windows.Forms.Button();
            this.LoginExecute = new System.Windows.Forms.Button();
            this.LoginTypeSelection = new System.Windows.Forms.ComboBox();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.Label();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Input_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_Input_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.Pass_Input_Line);
            this.ContainerPanel.Controls.Add(this.Pass_Input_Icon);
            this.ContainerPanel.Controls.Add(this.Email_Input_Line);
            this.ContainerPanel.Controls.Add(this.Password_Input);
            this.ContainerPanel.Controls.Add(this.Email_Input_Icon);
            this.ContainerPanel.Controls.Add(this.Lang_Select_Seperator);
            this.ContainerPanel.Controls.Add(this.Lang_TR);
            this.ContainerPanel.Controls.Add(this.Lang_EN);
            this.ContainerPanel.Controls.Add(this.LoginExecute);
            this.ContainerPanel.Controls.Add(this.LoginTypeSelection);
            this.ContainerPanel.Controls.Add(this.Email_Input);
            this.ContainerPanel.Controls.Add(this.Logo);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(320, 410);
            this.ContainerPanel.TabIndex = 0;
            this.ContainerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.ContainerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.ContainerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // Pass_Input_Line
            // 
            this.Pass_Input_Line.BackColor = System.Drawing.Color.White;
            this.Pass_Input_Line.Location = new System.Drawing.Point(45, 215);
            this.Pass_Input_Line.Name = "Pass_Input_Line";
            this.Pass_Input_Line.Size = new System.Drawing.Size(230, 10);
            this.Pass_Input_Line.TabIndex = 13;
            // 
            // Pass_Input_Icon
            // 
            this.Pass_Input_Icon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pass_Input_Icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pass_Input_Icon.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.Pass_Input_Icon.IconColor = System.Drawing.SystemColors.ControlText;
            this.Pass_Input_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pass_Input_Icon.IconSize = 24;
            this.Pass_Input_Icon.Location = new System.Drawing.Point(45, 192);
            this.Pass_Input_Icon.Name = "Pass_Input_Icon";
            this.Pass_Input_Icon.Size = new System.Drawing.Size(24, 24);
            this.Pass_Input_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pass_Input_Icon.TabIndex = 12;
            this.Pass_Input_Icon.TabStop = false;
            // 
            // Email_Input_Line
            // 
            this.Email_Input_Line.BackColor = System.Drawing.Color.White;
            this.Email_Input_Line.Location = new System.Drawing.Point(45, 168);
            this.Email_Input_Line.Name = "Email_Input_Line";
            this.Email_Input_Line.Size = new System.Drawing.Size(230, 10);
            this.Email_Input_Line.TabIndex = 10;
            // 
            // Password_Input
            // 
            this.Password_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_Input.Font = new System.Drawing.Font("Avignon Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password_Input.Location = new System.Drawing.Point(75, 197);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.Size = new System.Drawing.Size(200, 15);
            this.Password_Input.TabIndex = 11;
            this.Password_Input.Enter += new System.EventHandler(this.Password_Input_Enter);
            this.Password_Input.Leave += new System.EventHandler(this.Password_Input_Leave);
            // 
            // Email_Input_Icon
            // 
            this.Email_Input_Icon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Email_Input_Icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Email_Input_Icon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Email_Input_Icon.IconColor = System.Drawing.SystemColors.ControlText;
            this.Email_Input_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Email_Input_Icon.IconSize = 24;
            this.Email_Input_Icon.Location = new System.Drawing.Point(45, 145);
            this.Email_Input_Icon.Name = "Email_Input_Icon";
            this.Email_Input_Icon.Size = new System.Drawing.Size(24, 24);
            this.Email_Input_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Email_Input_Icon.TabIndex = 8;
            this.Email_Input_Icon.TabStop = false;
            // 
            // Lang_Select_Seperator
            // 
            this.Lang_Select_Seperator.AutoSize = true;
            this.Lang_Select_Seperator.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lang_Select_Seperator.Location = new System.Drawing.Point(149, 340);
            this.Lang_Select_Seperator.Name = "Lang_Select_Seperator";
            this.Lang_Select_Seperator.Size = new System.Drawing.Size(22, 26);
            this.Lang_Select_Seperator.TabIndex = 7;
            this.Lang_Select_Seperator.Text = "|";
            // 
            // Lang_TR
            // 
            this.Lang_TR.FlatAppearance.BorderSize = 0;
            this.Lang_TR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lang_TR.Location = new System.Drawing.Point(177, 342);
            this.Lang_TR.Name = "Lang_TR";
            this.Lang_TR.Size = new System.Drawing.Size(35, 23);
            this.Lang_TR.TabIndex = 6;
            this.Lang_TR.Text = "TR";
            this.Lang_TR.UseVisualStyleBackColor = true;
            this.Lang_TR.Click += new System.EventHandler(this.Lang_TR_Click);
            // 
            // Lang_EN
            // 
            this.Lang_EN.FlatAppearance.BorderSize = 0;
            this.Lang_EN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lang_EN.Location = new System.Drawing.Point(109, 342);
            this.Lang_EN.Name = "Lang_EN";
            this.Lang_EN.Size = new System.Drawing.Size(34, 23);
            this.Lang_EN.TabIndex = 5;
            this.Lang_EN.Text = "EN";
            this.Lang_EN.UseVisualStyleBackColor = true;
            this.Lang_EN.Click += new System.EventHandler(this.Lang_EN_Click);
            // 
            // LoginExecute
            // 
            this.LoginExecute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginExecute.Location = new System.Drawing.Point(44, 281);
            this.LoginExecute.Name = "LoginExecute";
            this.LoginExecute.Size = new System.Drawing.Size(231, 32);
            this.LoginExecute.TabIndex = 4;
            this.LoginExecute.Text = "Login";
            this.LoginExecute.UseVisualStyleBackColor = true;
            this.LoginExecute.Click += new System.EventHandler(this.LoginExecute_Click);
            // 
            // LoginTypeSelection
            // 
            this.LoginTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginTypeSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginTypeSelection.FormattingEnabled = true;
            this.LoginTypeSelection.Location = new System.Drawing.Point(44, 241);
            this.LoginTypeSelection.Name = "LoginTypeSelection";
            this.LoginTypeSelection.Size = new System.Drawing.Size(231, 21);
            this.LoginTypeSelection.TabIndex = 3;
            // 
            // Email_Input
            // 
            this.Email_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email_Input.Font = new System.Drawing.Font("Avignon Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email_Input.Location = new System.Drawing.Point(75, 150);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(200, 15);
            this.Email_Input.TabIndex = 1;
            this.Email_Input.Enter += new System.EventHandler(this.Email_Input_Enter);
            this.Email_Input.Leave += new System.EventHandler(this.Email_Input_Leave);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logo.Location = new System.Drawing.Point(91, 43);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(139, 63);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Logo";
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(320, 410);
            this.Controls.Add(this.ContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Input_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_Input_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button Lang_TR;
        private System.Windows.Forms.Button Lang_EN;
        private System.Windows.Forms.Button LoginExecute;
        private System.Windows.Forms.ComboBox LoginTypeSelection;
        private System.Windows.Forms.TextBox Email_Input;
        private System.Windows.Forms.Panel Email_Input_Line;
        private FontAwesome.Sharp.IconPictureBox Email_Input_Icon;
        private System.Windows.Forms.Label Lang_Select_Seperator;
        private System.Windows.Forms.Panel Pass_Input_Line;
        private FontAwesome.Sharp.IconPictureBox Pass_Input_Icon;
        private System.Windows.Forms.TextBox Password_Input;
    }
}