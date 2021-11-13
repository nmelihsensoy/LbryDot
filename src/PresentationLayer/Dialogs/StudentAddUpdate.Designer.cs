
namespace PresentationLayer.Dialogs
{
    partial class StudentAddUpdate
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
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.AlertBox_UserOperation = new PresentationLayer.Controls.AlertBox();
            this.Image_StudentAvatar = new System.Windows.Forms.PictureBox();
            this.Text_Password = new System.Windows.Forms.Label();
            this.Input_Password = new System.Windows.Forms.TextBox();
            this.Input_Name = new System.Windows.Forms.TextBox();
            this.Input_Email = new System.Windows.Forms.TextBox();
            this.Text_Name = new System.Windows.Forms.Label();
            this.Text_Email = new System.Windows.Forms.Label();
            this.Text_Avatar = new System.Windows.Forms.Label();
            this.Button_AddSave = new FontAwesome.Sharp.IconButton();
            this.Button_SelectAvatar = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_StudentAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Container
            // 
            this.Panel_Container.Controls.Add(this.AlertBox_UserOperation);
            this.Panel_Container.Controls.Add(this.Image_StudentAvatar);
            this.Panel_Container.Controls.Add(this.Text_Password);
            this.Panel_Container.Controls.Add(this.Input_Password);
            this.Panel_Container.Controls.Add(this.Input_Name);
            this.Panel_Container.Controls.Add(this.Input_Email);
            this.Panel_Container.Controls.Add(this.Text_Name);
            this.Panel_Container.Controls.Add(this.Text_Email);
            this.Panel_Container.Controls.Add(this.Text_Avatar);
            this.Panel_Container.Controls.Add(this.Button_AddSave);
            this.Panel_Container.Controls.Add(this.Button_SelectAvatar);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(324, 309);
            this.Panel_Container.TabIndex = 0;
            // 
            // AlertBox_UserOperation
            // 
            this.AlertBox_UserOperation.Location = new System.Drawing.Point(24, 311);
            this.AlertBox_UserOperation.MinimumSize = new System.Drawing.Size(150, 0);
            this.AlertBox_UserOperation.Name = "AlertBox_UserOperation";
            this.AlertBox_UserOperation.Size = new System.Drawing.Size(277, 39);
            this.AlertBox_UserOperation.TabIndex = 23;
            // 
            // Image_StudentAvatar
            // 
            this.Image_StudentAvatar.Location = new System.Drawing.Point(114, 162);
            this.Image_StudentAvatar.Name = "Image_StudentAvatar";
            this.Image_StudentAvatar.Size = new System.Drawing.Size(80, 80);
            this.Image_StudentAvatar.TabIndex = 19;
            this.Image_StudentAvatar.TabStop = false;
            // 
            // Text_Password
            // 
            this.Text_Password.AutoSize = true;
            this.Text_Password.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Password.Location = new System.Drawing.Point(20, 114);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(84, 19);
            this.Text_Password.TabIndex = 17;
            this.Text_Password.Text = "Password :";
            // 
            // Input_Password
            // 
            this.Input_Password.Location = new System.Drawing.Point(114, 113);
            this.Input_Password.Name = "Input_Password";
            this.Input_Password.Size = new System.Drawing.Size(187, 20);
            this.Input_Password.TabIndex = 16;
            // 
            // Input_Name
            // 
            this.Input_Name.Location = new System.Drawing.Point(114, 65);
            this.Input_Name.Name = "Input_Name";
            this.Input_Name.Size = new System.Drawing.Size(187, 20);
            this.Input_Name.TabIndex = 15;
            // 
            // Input_Email
            // 
            this.Input_Email.Location = new System.Drawing.Point(114, 17);
            this.Input_Email.Name = "Input_Email";
            this.Input_Email.Size = new System.Drawing.Size(187, 20);
            this.Input_Email.TabIndex = 14;
            // 
            // Text_Name
            // 
            this.Text_Name.AutoSize = true;
            this.Text_Name.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Name.Location = new System.Drawing.Point(20, 66);
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(60, 19);
            this.Text_Name.TabIndex = 13;
            this.Text_Name.Text = "Name :";
            // 
            // Text_Email
            // 
            this.Text_Email.AutoSize = true;
            this.Text_Email.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Email.Location = new System.Drawing.Point(20, 18);
            this.Text_Email.Name = "Text_Email";
            this.Text_Email.Size = new System.Drawing.Size(54, 19);
            this.Text_Email.TabIndex = 12;
            this.Text_Email.Text = "Email :";
            // 
            // Text_Avatar
            // 
            this.Text_Avatar.AutoSize = true;
            this.Text_Avatar.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Avatar.Location = new System.Drawing.Point(20, 162);
            this.Text_Avatar.Name = "Text_Avatar";
            this.Text_Avatar.Size = new System.Drawing.Size(64, 19);
            this.Text_Avatar.TabIndex = 22;
            this.Text_Avatar.Text = "Avatar :";
            // 
            // Button_AddSave
            // 
            this.Button_AddSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_AddSave.IconColor = System.Drawing.Color.Black;
            this.Button_AddSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_AddSave.Location = new System.Drawing.Point(29, 263);
            this.Button_AddSave.Name = "Button_AddSave";
            this.Button_AddSave.Size = new System.Drawing.Size(272, 31);
            this.Button_AddSave.TabIndex = 21;
            this.Button_AddSave.Text = "Save";
            this.Button_AddSave.UseVisualStyleBackColor = true;
            this.Button_AddSave.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // Button_SelectAvatar
            // 
            this.Button_SelectAvatar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_SelectAvatar.IconColor = System.Drawing.Color.Black;
            this.Button_SelectAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_SelectAvatar.Location = new System.Drawing.Point(209, 162);
            this.Button_SelectAvatar.Name = "Button_SelectAvatar";
            this.Button_SelectAvatar.Size = new System.Drawing.Size(92, 23);
            this.Button_SelectAvatar.TabIndex = 20;
            this.Button_SelectAvatar.Text = "Select";
            this.Button_SelectAvatar.UseVisualStyleBackColor = true;
            this.Button_SelectAvatar.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StudentAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 309);
            this.Controls.Add(this.Panel_Container);
            this.Name = "StudentAddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentAddUpdate";
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_StudentAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.PictureBox Image_StudentAvatar;
        private System.Windows.Forms.Label Text_Password;
        private System.Windows.Forms.TextBox Input_Password;
        private System.Windows.Forms.TextBox Input_Name;
        private System.Windows.Forms.TextBox Input_Email;
        private System.Windows.Forms.Label Text_Name;
        private System.Windows.Forms.Label Text_Email;
        private System.Windows.Forms.Label Text_Avatar;
        private FontAwesome.Sharp.IconButton Button_AddSave;
        private FontAwesome.Sharp.IconButton Button_SelectAvatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controls.AlertBox AlertBox_UserOperation;
    }
}