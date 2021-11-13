
namespace PresentationLayer.Dialogs
{
    partial class DashboardGraphSettings
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
            this.Input_Title = new System.Windows.Forms.TextBox();
            this.Text_Title = new System.Windows.Forms.Label();
            this.Button_Change = new System.Windows.Forms.Button();
            this.Button_LoadDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_Title
            // 
            this.Input_Title.Location = new System.Drawing.Point(56, 12);
            this.Input_Title.Name = "Input_Title";
            this.Input_Title.Size = new System.Drawing.Size(187, 20);
            this.Input_Title.TabIndex = 16;
            // 
            // Text_Title
            // 
            this.Text_Title.AutoSize = true;
            this.Text_Title.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Title.Location = new System.Drawing.Point(13, 13);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(41, 19);
            this.Text_Title.TabIndex = 15;
            this.Text_Title.Text = "Title: ";
            // 
            // Button_Change
            // 
            this.Button_Change.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Change.Location = new System.Drawing.Point(126, 47);
            this.Button_Change.Name = "Button_Change";
            this.Button_Change.Size = new System.Drawing.Size(117, 23);
            this.Button_Change.TabIndex = 17;
            this.Button_Change.Text = "Change";
            this.Button_Change.UseVisualStyleBackColor = true;
            this.Button_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // Button_LoadDefault
            // 
            this.Button_LoadDefault.Location = new System.Drawing.Point(17, 47);
            this.Button_LoadDefault.Name = "Button_LoadDefault";
            this.Button_LoadDefault.Size = new System.Drawing.Size(103, 23);
            this.Button_LoadDefault.TabIndex = 18;
            this.Button_LoadDefault.Text = "Load Default";
            this.Button_LoadDefault.UseVisualStyleBackColor = true;
            this.Button_LoadDefault.Click += new System.EventHandler(this.Button_LoadDefault_Click);
            // 
            // DashboardGraphSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 82);
            this.Controls.Add(this.Button_LoadDefault);
            this.Controls.Add(this.Button_Change);
            this.Controls.Add(this.Input_Title);
            this.Controls.Add(this.Text_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardGraphSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashboardGraphSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Title;
        private System.Windows.Forms.Label Text_Title;
        private System.Windows.Forms.Button Button_Change;
        private System.Windows.Forms.Button Button_LoadDefault;
    }
}