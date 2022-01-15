
namespace PresentationLayer.SubPages
{
    partial class Settings
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
            this.Text_SettingInput = new System.Windows.Forms.Label();
            this.Button_SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_Setting = new System.Windows.Forms.NumericUpDown();
            this.Text_ActiveBooksTitle = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Button_DeleteStaff = new FontAwesome.Sharp.IconButton();
            this.Button_EditStaff = new FontAwesome.Sharp.IconButton();
            this.Button_AddStaff = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.alertBox1 = new PresentationLayer.Controls.AlertBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Setting)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_SettingInput
            // 
            this.Text_SettingInput.AutoSize = true;
            this.Text_SettingInput.BackColor = System.Drawing.Color.Transparent;
            this.Text_SettingInput.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_SettingInput.Location = new System.Drawing.Point(15, 55);
            this.Text_SettingInput.Name = "Text_SettingInput";
            this.Text_SettingInput.Size = new System.Drawing.Size(144, 19);
            this.Text_SettingInput.TabIndex = 15;
            this.Text_SettingInput.Text = "Daily Fine Amount :";
            // 
            // Button_SaveButton
            // 
            this.Button_SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SaveButton.Location = new System.Drawing.Point(229, 143);
            this.Button_SaveButton.Name = "Button_SaveButton";
            this.Button_SaveButton.Size = new System.Drawing.Size(127, 30);
            this.Button_SaveButton.TabIndex = 17;
            this.Button_SaveButton.Text = "Save";
            this.Button_SaveButton.UseVisualStyleBackColor = true;
            this.Button_SaveButton.Click += new System.EventHandler(this.Button_SaveButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reset Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(132, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Load Mock Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Input_Setting);
            this.panel1.Controls.Add(this.Text_ActiveBooksTitle);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.Text_SettingInput);
            this.panel1.Controls.Add(this.Button_SaveButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 202);
            this.panel1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 92);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Currency Symbol :";
            // 
            // Input_Setting
            // 
            this.Input_Setting.Location = new System.Drawing.Point(182, 54);
            this.Input_Setting.Name = "Input_Setting";
            this.Input_Setting.Size = new System.Drawing.Size(174, 20);
            this.Input_Setting.TabIndex = 25;
            // 
            // Text_ActiveBooksTitle
            // 
            this.Text_ActiveBooksTitle.AutoSize = true;
            this.Text_ActiveBooksTitle.Font = new System.Drawing.Font("Avignon Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_ActiveBooksTitle.ForeColor = System.Drawing.Color.DimGray;
            this.Text_ActiveBooksTitle.Location = new System.Drawing.Point(15, 11);
            this.Text_ActiveBooksTitle.Name = "Text_ActiveBooksTitle";
            this.Text_ActiveBooksTitle.Size = new System.Drawing.Size(179, 23);
            this.Text_ActiveBooksTitle.TabIndex = 24;
            this.Text_ActiveBooksTitle.Text = "System Parameters";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 199);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(374, 3);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 234);
            this.panel2.TabIndex = 23;
            this.panel2.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(229, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Avignon Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Admin Settings";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 26;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 231);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(374, 3);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.Button_DeleteStaff);
            this.panel3.Controls.Add(this.Button_EditStaff);
            this.panel3.Controls.Add(this.Button_AddStaff);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.splitter3);
            this.panel3.Location = new System.Drawing.Point(401, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 308);
            this.panel3.TabIndex = 24;
            this.panel3.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 186);
            this.listBox1.TabIndex = 29;
            // 
            // Button_DeleteStaff
            // 
            this.Button_DeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DeleteStaff.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.Button_DeleteStaff.IconColor = System.Drawing.Color.Black;
            this.Button_DeleteStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_DeleteStaff.IconSize = 24;
            this.Button_DeleteStaff.Location = new System.Drawing.Point(123, 47);
            this.Button_DeleteStaff.Name = "Button_DeleteStaff";
            this.Button_DeleteStaff.Size = new System.Drawing.Size(46, 36);
            this.Button_DeleteStaff.TabIndex = 28;
            this.Button_DeleteStaff.UseVisualStyleBackColor = true;
            this.Button_DeleteStaff.Click += new System.EventHandler(this.StaffOperations_Click);
            // 
            // Button_EditStaff
            // 
            this.Button_EditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EditStaff.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.Button_EditStaff.IconColor = System.Drawing.Color.Black;
            this.Button_EditStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_EditStaff.IconSize = 24;
            this.Button_EditStaff.Location = new System.Drawing.Point(71, 47);
            this.Button_EditStaff.Name = "Button_EditStaff";
            this.Button_EditStaff.Size = new System.Drawing.Size(46, 36);
            this.Button_EditStaff.TabIndex = 27;
            this.Button_EditStaff.UseVisualStyleBackColor = true;
            this.Button_EditStaff.Click += new System.EventHandler(this.StaffOperations_Click);
            // 
            // Button_AddStaff
            // 
            this.Button_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddStaff.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.Button_AddStaff.IconColor = System.Drawing.Color.Black;
            this.Button_AddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_AddStaff.IconSize = 24;
            this.Button_AddStaff.Location = new System.Drawing.Point(19, 47);
            this.Button_AddStaff.Name = "Button_AddStaff";
            this.Button_AddStaff.Size = new System.Drawing.Size(46, 36);
            this.Button_AddStaff.TabIndex = 26;
            this.Button_AddStaff.UseVisualStyleBackColor = true;
            this.Button_AddStaff.Click += new System.EventHandler(this.StaffOperations_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Avignon Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Staff";
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 305);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(375, 3);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // alertBox1
            // 
            this.alertBox1.Location = new System.Drawing.Point(401, 336);
            this.alertBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Size = new System.Drawing.Size(375, 53);
            this.alertBox1.TabIndex = 18;
            this.alertBox1.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 506);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.alertBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Setting)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Text_SettingInput;
        private System.Windows.Forms.Button Button_SaveButton;
        private Controls.AlertBox alertBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label Text_ActiveBooksTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Button_DeleteStaff;
        private FontAwesome.Sharp.IconButton Button_EditStaff;
        private FontAwesome.Sharp.IconButton Button_AddStaff;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown Input_Setting;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}