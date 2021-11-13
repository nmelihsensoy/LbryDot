
namespace PresentationLayer.Dialogs
{
    partial class BookIssue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.alertBox2 = new PresentationLayer.Controls.AlertBox();
            this.alertBox1 = new PresentationLayer.Controls.AlertBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Text_FineAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.alertBox2);
            this.panel1.Controls.Add(this.alertBox1);
            this.panel1.Controls.Add(this.Button_Close);
            this.panel1.Controls.Add(this.Button_Return);
            this.panel1.Controls.Add(this.Text_FineAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 121);
            this.panel1.TabIndex = 0;
            // 
            // alertBox2
            // 
            this.alertBox2.Location = new System.Drawing.Point(16, 167);
            this.alertBox2.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox2.Name = "alertBox2";
            this.alertBox2.Size = new System.Drawing.Size(243, 39);
            this.alertBox2.TabIndex = 37;
            // 
            // alertBox1
            // 
            this.alertBox1.Location = new System.Drawing.Point(16, 122);
            this.alertBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Size = new System.Drawing.Size(244, 39);
            this.alertBox1.TabIndex = 36;
            // 
            // Button_Close
            // 
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.Location = new System.Drawing.Point(16, 83);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(244, 30);
            this.Button_Close.TabIndex = 35;
            this.Button_Close.Text = "CloseText";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Return
            // 
            this.Button_Return.Location = new System.Drawing.Point(16, 47);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(244, 30);
            this.Button_Return.TabIndex = 34;
            this.Button_Return.Text = "ButtonText";
            this.Button_Return.UseVisualStyleBackColor = true;
            // 
            // Text_FineAmount
            // 
            this.Text_FineAmount.AutoSize = true;
            this.Text_FineAmount.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_FineAmount.Location = new System.Drawing.Point(12, 12);
            this.Text_FineAmount.Name = "Text_FineAmount";
            this.Text_FineAmount.Size = new System.Drawing.Size(35, 19);
            this.Text_FineAmount.TabIndex = 33;
            this.Text_FineAmount.Text = "Text";
            // 
            // BookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 121);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookIssue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.AlertBox alertBox2;
        private Controls.AlertBox alertBox1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Label Text_FineAmount;
    }
}