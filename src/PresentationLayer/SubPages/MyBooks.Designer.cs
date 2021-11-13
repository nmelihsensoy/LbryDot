
namespace PresentationLayer.SubPages
{
    partial class MyBooks
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookStatusItem3 = new PresentationLayer.Controls.BookStatusItem();
            this.bookStatusItem2 = new PresentationLayer.Controls.BookStatusItem();
            this.bookStatusItem1 = new PresentationLayer.Controls.BookStatusItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bookStatusItem3);
            this.flowLayoutPanel1.Controls.Add(this.bookStatusItem2);
            this.flowLayoutPanel1.Controls.Add(this.bookStatusItem1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 521);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bookStatusItem3
            // 
            this.bookStatusItem3.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem3.Location = new System.Drawing.Point(3, 3);
            this.bookStatusItem3.Name = "bookStatusItem3";
            this.bookStatusItem3.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem3.TabIndex = 12;
            // 
            // bookStatusItem2
            // 
            this.bookStatusItem2.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem2.Location = new System.Drawing.Point(144, 3);
            this.bookStatusItem2.Name = "bookStatusItem2";
            this.bookStatusItem2.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem2.TabIndex = 11;
            // 
            // bookStatusItem1
            // 
            this.bookStatusItem1.BackColor = System.Drawing.Color.Transparent;
            this.bookStatusItem1.Location = new System.Drawing.Point(285, 3);
            this.bookStatusItem1.Name = "bookStatusItem1";
            this.bookStatusItem1.Size = new System.Drawing.Size(135, 128);
            this.bookStatusItem1.TabIndex = 10;
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyBooks";
            this.Text = "MyBooks";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.BookStatusItem bookStatusItem3;
        private Controls.BookStatusItem bookStatusItem2;
        private Controls.BookStatusItem bookStatusItem1;
    }
}