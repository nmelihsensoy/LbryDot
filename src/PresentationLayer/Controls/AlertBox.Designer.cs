
namespace PresentationLayer.Controls
{
    partial class AlertBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text_Message = new System.Windows.Forms.Label();
            this.Image_TypeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.Splitter_BorderBottom = new System.Windows.Forms.Splitter();
            this.Splitter_BorderTop = new System.Windows.Forms.Splitter();
            this.Splitter_BorderRight = new System.Windows.Forms.Splitter();
            this.Splitter_BorderLeft = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.Image_TypeIcon)).BeginInit();
            this.Panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Message
            // 
            this.Text_Message.AutoSize = true;
            this.Text_Message.Location = new System.Drawing.Point(42, 12);
            this.Text_Message.Name = "Text_Message";
            this.Text_Message.Size = new System.Drawing.Size(35, 13);
            this.Text_Message.TabIndex = 1;
            this.Text_Message.Text = "label1";
            // 
            // Image_TypeIcon
            // 
            this.Image_TypeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(218)))));
            this.Image_TypeIcon.ForeColor = System.Drawing.Color.DimGray;
            this.Image_TypeIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Image_TypeIcon.IconColor = System.Drawing.Color.DimGray;
            this.Image_TypeIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Image_TypeIcon.Location = new System.Drawing.Point(3, 4);
            this.Image_TypeIcon.Name = "Image_TypeIcon";
            this.Image_TypeIcon.Size = new System.Drawing.Size(32, 32);
            this.Image_TypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_TypeIcon.TabIndex = 0;
            this.Image_TypeIcon.TabStop = false;
            // 
            // Panel_Container
            // 
            this.Panel_Container.AutoSize = true;
            this.Panel_Container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(218)))));
            this.Panel_Container.Controls.Add(this.Splitter_BorderBottom);
            this.Panel_Container.Controls.Add(this.Splitter_BorderTop);
            this.Panel_Container.Controls.Add(this.Splitter_BorderRight);
            this.Panel_Container.Controls.Add(this.Splitter_BorderLeft);
            this.Panel_Container.Controls.Add(this.Text_Message);
            this.Panel_Container.Controls.Add(this.Image_TypeIcon);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Panel_Container.Location = new System.Drawing.Point(0, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(150, 39);
            this.Panel_Container.TabIndex = 1;
            // 
            // Splitter_BorderBottom
            // 
            this.Splitter_BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter_BorderBottom.Location = new System.Drawing.Point(1, 38);
            this.Splitter_BorderBottom.Name = "Splitter_BorderBottom";
            this.Splitter_BorderBottom.Size = new System.Drawing.Size(148, 1);
            this.Splitter_BorderBottom.TabIndex = 5;
            this.Splitter_BorderBottom.TabStop = false;
            // 
            // Splitter_BorderTop
            // 
            this.Splitter_BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter_BorderTop.Location = new System.Drawing.Point(1, 0);
            this.Splitter_BorderTop.Name = "Splitter_BorderTop";
            this.Splitter_BorderTop.Size = new System.Drawing.Size(148, 1);
            this.Splitter_BorderTop.TabIndex = 4;
            this.Splitter_BorderTop.TabStop = false;
            // 
            // Splitter_BorderRight
            // 
            this.Splitter_BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter_BorderRight.Location = new System.Drawing.Point(149, 0);
            this.Splitter_BorderRight.Name = "Splitter_BorderRight";
            this.Splitter_BorderRight.Size = new System.Drawing.Size(1, 39);
            this.Splitter_BorderRight.TabIndex = 3;
            this.Splitter_BorderRight.TabStop = false;
            // 
            // Splitter_BorderLeft
            // 
            this.Splitter_BorderLeft.Location = new System.Drawing.Point(0, 0);
            this.Splitter_BorderLeft.Name = "Splitter_BorderLeft";
            this.Splitter_BorderLeft.Size = new System.Drawing.Size(1, 39);
            this.Splitter_BorderLeft.TabIndex = 2;
            this.Splitter_BorderLeft.TabStop = false;
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Container);
            this.MinimumSize = new System.Drawing.Size(150, 0);
            this.Name = "AlertBox";
            this.Size = new System.Drawing.Size(150, 39);
            this.Load += new System.EventHandler(this.AlertBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image_TypeIcon)).EndInit();
            this.Panel_Container.ResumeLayout(false);
            this.Panel_Container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_Message;
        private FontAwesome.Sharp.IconPictureBox Image_TypeIcon;
        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.Splitter Splitter_BorderBottom;
        private System.Windows.Forms.Splitter Splitter_BorderTop;
        private System.Windows.Forms.Splitter Splitter_BorderRight;
        private System.Windows.Forms.Splitter Splitter_BorderLeft;
    }
}
