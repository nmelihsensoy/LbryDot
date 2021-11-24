
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.alertBox1 = new PresentationLayer.Controls.AlertBox();
            this.Panel_Pass_Line = new System.Windows.Forms.Panel();
            this.Icon_Input_Pass = new FontAwesome.Sharp.IconPictureBox();
            this.Panel_Input_Email = new System.Windows.Forms.Panel();
            this.Input_Password = new System.Windows.Forms.TextBox();
            this.Icon_Input_Email = new FontAwesome.Sharp.IconPictureBox();
            this.Seperator_Lang_Buttons = new System.Windows.Forms.Label();
            this.Button_Lang_TR = new System.Windows.Forms.Button();
            this.Button_Lang_EN = new System.Windows.Forms.Button();
            this.Button_Execute_Login = new System.Windows.Forms.Button();
            this.ComboBox_LoginType = new System.Windows.Forms.ComboBox();
            this.Input_Email = new System.Windows.Forms.TextBox();
            this.Text_Logo = new System.Windows.Forms.Label();
            this.Panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Input_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Input_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Container
            // 
            this.Panel_Container.BackColor = System.Drawing.SystemColors.Window;
            this.Panel_Container.Controls.Add(this.alertBox1);
            this.Panel_Container.Controls.Add(this.Panel_Pass_Line);
            this.Panel_Container.Controls.Add(this.Icon_Input_Pass);
            this.Panel_Container.Controls.Add(this.Panel_Input_Email);
            this.Panel_Container.Controls.Add(this.Input_Password);
            this.Panel_Container.Controls.Add(this.Icon_Input_Email);
            this.Panel_Container.Controls.Add(this.Seperator_Lang_Buttons);
            this.Panel_Container.Controls.Add(this.Button_Lang_TR);
            this.Panel_Container.Controls.Add(this.Button_Lang_EN);
            this.Panel_Container.Controls.Add(this.Button_Execute_Login);
            this.Panel_Container.Controls.Add(this.ComboBox_LoginType);
            this.Panel_Container.Controls.Add(this.Input_Email);
            this.Panel_Container.Controls.Add(this.Text_Logo);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(320, 430);
            this.Panel_Container.TabIndex = 0;
            this.Panel_Container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Panel_Container.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Panel_Container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // alertBox1
            // 
            this.alertBox1.Location = new System.Drawing.Point(44, 126);
            this.alertBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Size = new System.Drawing.Size(231, 35);
            this.alertBox1.TabIndex = 14;
            this.alertBox1.Visible = false;
            // 
            // Panel_Pass_Line
            // 
            this.Panel_Pass_Line.BackColor = System.Drawing.Color.White;
            this.Panel_Pass_Line.Location = new System.Drawing.Point(45, 247);
            this.Panel_Pass_Line.Name = "Panel_Pass_Line";
            this.Panel_Pass_Line.Size = new System.Drawing.Size(230, 10);
            this.Panel_Pass_Line.TabIndex = 13;
            // 
            // Icon_Input_Pass
            // 
            this.Icon_Input_Pass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon_Input_Pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon_Input_Pass.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.Icon_Input_Pass.IconColor = System.Drawing.SystemColors.ControlText;
            this.Icon_Input_Pass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_Input_Pass.IconSize = 24;
            this.Icon_Input_Pass.Location = new System.Drawing.Point(45, 224);
            this.Icon_Input_Pass.Name = "Icon_Input_Pass";
            this.Icon_Input_Pass.Size = new System.Drawing.Size(24, 24);
            this.Icon_Input_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Icon_Input_Pass.TabIndex = 12;
            this.Icon_Input_Pass.TabStop = false;
            // 
            // Panel_Input_Email
            // 
            this.Panel_Input_Email.BackColor = System.Drawing.Color.White;
            this.Panel_Input_Email.Location = new System.Drawing.Point(45, 200);
            this.Panel_Input_Email.Name = "Panel_Input_Email";
            this.Panel_Input_Email.Size = new System.Drawing.Size(230, 10);
            this.Panel_Input_Email.TabIndex = 10;
            // 
            // Input_Password
            // 
            this.Input_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input_Password.Font = new System.Drawing.Font("Avignon Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Input_Password.Location = new System.Drawing.Point(75, 229);
            this.Input_Password.Name = "Input_Password";
            this.Input_Password.Size = new System.Drawing.Size(200, 15);
            this.Input_Password.TabIndex = 11;
            this.Input_Password.Enter += new System.EventHandler(this.Password_Input_Enter);
            this.Input_Password.Leave += new System.EventHandler(this.Password_Input_Leave);
            // 
            // Icon_Input_Email
            // 
            this.Icon_Input_Email.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon_Input_Email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon_Input_Email.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Icon_Input_Email.IconColor = System.Drawing.SystemColors.ControlText;
            this.Icon_Input_Email.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_Input_Email.IconSize = 24;
            this.Icon_Input_Email.Location = new System.Drawing.Point(45, 177);
            this.Icon_Input_Email.Name = "Icon_Input_Email";
            this.Icon_Input_Email.Size = new System.Drawing.Size(24, 24);
            this.Icon_Input_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Icon_Input_Email.TabIndex = 8;
            this.Icon_Input_Email.TabStop = false;
            // 
            // Seperator_Lang_Buttons
            // 
            this.Seperator_Lang_Buttons.AutoSize = true;
            this.Seperator_Lang_Buttons.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Seperator_Lang_Buttons.Location = new System.Drawing.Point(149, 372);
            this.Seperator_Lang_Buttons.Name = "Seperator_Lang_Buttons";
            this.Seperator_Lang_Buttons.Size = new System.Drawing.Size(22, 26);
            this.Seperator_Lang_Buttons.TabIndex = 7;
            this.Seperator_Lang_Buttons.Text = "|";
            // 
            // Button_Lang_TR
            // 
            this.Button_Lang_TR.FlatAppearance.BorderSize = 0;
            this.Button_Lang_TR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Lang_TR.Location = new System.Drawing.Point(177, 374);
            this.Button_Lang_TR.Name = "Button_Lang_TR";
            this.Button_Lang_TR.Size = new System.Drawing.Size(35, 23);
            this.Button_Lang_TR.TabIndex = 6;
            this.Button_Lang_TR.Text = "TR";
            this.Button_Lang_TR.UseVisualStyleBackColor = true;
            this.Button_Lang_TR.Click += new System.EventHandler(this.Lang_TR_Click);
            // 
            // Button_Lang_EN
            // 
            this.Button_Lang_EN.FlatAppearance.BorderSize = 0;
            this.Button_Lang_EN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Lang_EN.Location = new System.Drawing.Point(109, 374);
            this.Button_Lang_EN.Name = "Button_Lang_EN";
            this.Button_Lang_EN.Size = new System.Drawing.Size(34, 23);
            this.Button_Lang_EN.TabIndex = 5;
            this.Button_Lang_EN.Text = "EN";
            this.Button_Lang_EN.UseVisualStyleBackColor = true;
            this.Button_Lang_EN.Click += new System.EventHandler(this.Lang_EN_Click);
            // 
            // Button_Execute_Login
            // 
            this.Button_Execute_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_Execute_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Execute_Login.Location = new System.Drawing.Point(44, 313);
            this.Button_Execute_Login.Name = "Button_Execute_Login";
            this.Button_Execute_Login.Size = new System.Drawing.Size(231, 32);
            this.Button_Execute_Login.TabIndex = 4;
            this.Button_Execute_Login.Text = "Login";
            this.Button_Execute_Login.UseVisualStyleBackColor = true;
            this.Button_Execute_Login.Click += new System.EventHandler(this.LoginExecute_Click);
            // 
            // ComboBox_LoginType
            // 
            this.ComboBox_LoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_LoginType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_LoginType.FormattingEnabled = true;
            this.ComboBox_LoginType.Location = new System.Drawing.Point(44, 273);
            this.ComboBox_LoginType.Name = "ComboBox_LoginType";
            this.ComboBox_LoginType.Size = new System.Drawing.Size(231, 21);
            this.ComboBox_LoginType.TabIndex = 3;
            // 
            // Input_Email
            // 
            this.Input_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input_Email.Font = new System.Drawing.Font("Avignon Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Input_Email.Location = new System.Drawing.Point(75, 182);
            this.Input_Email.Name = "Input_Email";
            this.Input_Email.Size = new System.Drawing.Size(200, 15);
            this.Input_Email.TabIndex = 1;
            this.Input_Email.Enter += new System.EventHandler(this.Email_Input_Enter);
            this.Input_Email.Leave += new System.EventHandler(this.Email_Input_Leave);
            // 
            // Text_Logo
            // 
            this.Text_Logo.AutoSize = true;
            this.Text_Logo.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Logo.Location = new System.Drawing.Point(91, 43);
            this.Text_Logo.Name = "Text_Logo";
            this.Text_Logo.Size = new System.Drawing.Size(139, 63);
            this.Text_Logo.TabIndex = 0;
            this.Text_Logo.Text = "Logo";
            this.Text_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            this.Text_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseMove);
            this.Text_Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseUp);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(320, 430);
            this.Controls.Add(this.Panel_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Input_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Input_Email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.Label Text_Logo;
        private System.Windows.Forms.Button Button_Lang_TR;
        private System.Windows.Forms.Button Button_Lang_EN;
        private System.Windows.Forms.Button Button_Execute_Login;
        private System.Windows.Forms.ComboBox ComboBox_LoginType;
        private System.Windows.Forms.TextBox Input_Email;
        private System.Windows.Forms.Panel Panel_Input_Email;
        private FontAwesome.Sharp.IconPictureBox Icon_Input_Email;
        private System.Windows.Forms.Label Seperator_Lang_Buttons;
        private System.Windows.Forms.Panel Panel_Pass_Line;
        private FontAwesome.Sharp.IconPictureBox Icon_Input_Pass;
        private System.Windows.Forms.TextBox Input_Password;
        private Controls.AlertBox alertBox1;
    }
}