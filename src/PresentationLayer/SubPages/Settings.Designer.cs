﻿
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
            this.Input_Setting = new System.Windows.Forms.TextBox();
            this.Text_SettingInput = new System.Windows.Forms.Label();
            this.Button_SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.alertBox2 = new PresentationLayer.Controls.AlertBox();
            this.alertBox1 = new PresentationLayer.Controls.AlertBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Text_ActiveBooksTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alertBox3 = new PresentationLayer.Controls.AlertBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_Setting
            // 
            this.Input_Setting.Location = new System.Drawing.Point(169, 54);
            this.Input_Setting.Name = "Input_Setting";
            this.Input_Setting.Size = new System.Drawing.Size(187, 20);
            this.Input_Setting.TabIndex = 16;
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
            this.Button_SaveButton.Location = new System.Drawing.Point(229, 93);
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
            this.button1.Location = new System.Drawing.Point(19, 52);
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
            this.button2.Location = new System.Drawing.Point(132, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Load Mock Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alertBox2
            // 
            this.alertBox2.Location = new System.Drawing.Point(19, 189);
            this.alertBox2.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox2.Name = "alertBox2";
            this.alertBox2.Size = new System.Drawing.Size(337, 55);
            this.alertBox2.TabIndex = 21;
            this.alertBox2.Visible = false;
            // 
            // alertBox1
            // 
            this.alertBox1.Location = new System.Drawing.Point(19, 140);
            this.alertBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Size = new System.Drawing.Size(337, 44);
            this.alertBox1.TabIndex = 18;
            this.alertBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Text_ActiveBooksTitle);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.Text_SettingInput);
            this.panel1.Controls.Add(this.Input_Setting);
            this.panel1.Controls.Add(this.Button_SaveButton);
            this.panel1.Controls.Add(this.alertBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 202);
            this.panel1.TabIndex = 22;
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
            this.panel2.Controls.Add(this.alertBox2);
            this.panel2.Location = new System.Drawing.Point(12, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 261);
            this.panel2.TabIndex = 23;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 258);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(374, 3);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Admin Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(229, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.alertBox3);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.splitter3);
            this.panel3.Location = new System.Drawing.Point(401, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 372);
            this.panel3.TabIndex = 24;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 369);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(375, 3);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
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
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(19, 51);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.Text = "Add";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(109, 51);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 27;
            this.iconButton2.Text = "Edit";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(201, 52);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(75, 23);
            this.iconButton3.TabIndex = 28;
            this.iconButton3.Text = "Delete";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 186);
            this.listBox1.TabIndex = 29;
            // 
            // alertBox3
            // 
            this.alertBox3.Location = new System.Drawing.Point(19, 296);
            this.alertBox3.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox3.Name = "alertBox3";
            this.alertBox3.Size = new System.Drawing.Size(337, 55);
            this.alertBox3.TabIndex = 27;
            this.alertBox3.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 506);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Setting;
        private System.Windows.Forms.Label Text_SettingInput;
        private System.Windows.Forms.Button Button_SaveButton;
        private Controls.AlertBox alertBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Controls.AlertBox alertBox2;
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
        private Controls.AlertBox alertBox3;
        private System.Windows.Forms.ListBox listBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}