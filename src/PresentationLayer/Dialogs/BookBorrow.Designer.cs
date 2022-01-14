
namespace PresentationLayer.Dialogs
{
    partial class BookBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBorrow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlertBox_SuccessInfo = new PresentationLayer.Controls.AlertBox();
            this.AlertBox_SuccesError = new PresentationLayer.Controls.AlertBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Borrow = new System.Windows.Forms.Button();
            this.Text_SelectDate = new System.Windows.Forms.Label();
            this.dateTimePicker_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AlertBox_SuccessInfo);
            this.panel1.Controls.Add(this.AlertBox_SuccesError);
            this.panel1.Controls.Add(this.Button_Close);
            this.panel1.Controls.Add(this.Button_Borrow);
            this.panel1.Controls.Add(this.Text_SelectDate);
            this.panel1.Controls.Add(this.dateTimePicker_ReturnDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 155);
            this.panel1.TabIndex = 0;
            // 
            // AlertBox_SuccessInfo
            // 
            this.AlertBox_SuccessInfo.Location = new System.Drawing.Point(12, 201);
            this.AlertBox_SuccessInfo.MinimumSize = new System.Drawing.Size(150, 0);
            this.AlertBox_SuccessInfo.Name = "AlertBox_SuccessInfo";
            this.AlertBox_SuccessInfo.Size = new System.Drawing.Size(200, 39);
            this.AlertBox_SuccessInfo.TabIndex = 32;
            // 
            // AlertBox_SuccesError
            // 
            this.AlertBox_SuccesError.Location = new System.Drawing.Point(12, 156);
            this.AlertBox_SuccesError.MinimumSize = new System.Drawing.Size(150, 0);
            this.AlertBox_SuccesError.Name = "AlertBox_SuccesError";
            this.AlertBox_SuccesError.Size = new System.Drawing.Size(200, 39);
            this.AlertBox_SuccesError.TabIndex = 31;
            this.AlertBox_SuccesError.Visible = false;
            // 
            // Button_Close
            // 
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.ForeColor = System.Drawing.Color.Brown;
            this.Button_Close.Location = new System.Drawing.Point(12, 114);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(200, 32);
            this.Button_Close.TabIndex = 30;
            this.Button_Close.Text = "ButtonText";
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // Button_Borrow
            // 
            this.Button_Borrow.Location = new System.Drawing.Point(12, 76);
            this.Button_Borrow.Name = "Button_Borrow";
            this.Button_Borrow.Size = new System.Drawing.Size(200, 32);
            this.Button_Borrow.TabIndex = 29;
            this.Button_Borrow.Text = "ButtonText";
            this.Button_Borrow.UseVisualStyleBackColor = true;
            this.Button_Borrow.Click += new System.EventHandler(this.Button_Borrow_Click);
            // 
            // Text_SelectDate
            // 
            this.Text_SelectDate.AutoSize = true;
            this.Text_SelectDate.Font = new System.Drawing.Font("Avignon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_SelectDate.Location = new System.Drawing.Point(8, 11);
            this.Text_SelectDate.Name = "Text_SelectDate";
            this.Text_SelectDate.Size = new System.Drawing.Size(35, 19);
            this.Text_SelectDate.TabIndex = 28;
            this.Text_SelectDate.Text = "Text";
            // 
            // dateTimePicker_ReturnDate
            // 
            this.dateTimePicker_ReturnDate.Location = new System.Drawing.Point(12, 42);
            this.dateTimePicker_ReturnDate.Name = "dateTimePicker_ReturnDate";
            this.dateTimePicker_ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ReturnDate.TabIndex = 27;
            // 
            // BookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(227, 155);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookBorrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookBorrow_FormClosing);
            this.Load += new System.EventHandler(this.BookBorrow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.AlertBox AlertBox_SuccesError;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Borrow;
        private System.Windows.Forms.Label Text_SelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReturnDate;
        private Controls.AlertBox AlertBox_SuccessInfo;
    }
}