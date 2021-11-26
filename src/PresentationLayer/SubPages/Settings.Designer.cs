
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
            this.alertBox1 = new PresentationLayer.Controls.AlertBox();
            this.SuspendLayout();
            // 
            // Input_Setting
            // 
            this.Input_Setting.Location = new System.Drawing.Point(199, 70);
            this.Input_Setting.Name = "Input_Setting";
            this.Input_Setting.Size = new System.Drawing.Size(187, 20);
            this.Input_Setting.TabIndex = 16;
            // 
            // Text_SettingInput
            // 
            this.Text_SettingInput.AutoSize = true;
            this.Text_SettingInput.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_SettingInput.Location = new System.Drawing.Point(45, 71);
            this.Text_SettingInput.Name = "Text_SettingInput";
            this.Text_SettingInput.Size = new System.Drawing.Size(144, 19);
            this.Text_SettingInput.TabIndex = 15;
            this.Text_SettingInput.Text = "Daily Fine Amount :";
            // 
            // Button_SaveButton
            // 
            this.Button_SaveButton.Location = new System.Drawing.Point(259, 114);
            this.Button_SaveButton.Name = "Button_SaveButton";
            this.Button_SaveButton.Size = new System.Drawing.Size(127, 30);
            this.Button_SaveButton.TabIndex = 17;
            this.Button_SaveButton.Text = "Save";
            this.Button_SaveButton.UseVisualStyleBackColor = true;
            this.Button_SaveButton.Click += new System.EventHandler(this.Button_SaveButton_Click);
            // 
            // alertBox1
            // 
            this.alertBox1.Location = new System.Drawing.Point(49, 166);
            this.alertBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Size = new System.Drawing.Size(337, 39);
            this.alertBox1.TabIndex = 18;
            this.alertBox1.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 506);
            this.Controls.Add(this.alertBox1);
            this.Controls.Add(this.Button_SaveButton);
            this.Controls.Add(this.Input_Setting);
            this.Controls.Add(this.Text_SettingInput);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Setting;
        private System.Windows.Forms.Label Text_SettingInput;
        private System.Windows.Forms.Button Button_SaveButton;
        private Controls.AlertBox alertBox1;
    }
}