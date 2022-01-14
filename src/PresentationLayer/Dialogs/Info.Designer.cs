
namespace PresentationLayer.Dialogs
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Button_WindowClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Logo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.Button_WindowClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Text_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 191);
            this.panel1.TabIndex = 0;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.Black;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(3, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(326, 3);
            this.splitter4.TabIndex = 14;
            this.splitter4.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Black;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(3, 188);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(326, 3);
            this.splitter3.TabIndex = 13;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Black;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(329, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 191);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 191);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // Button_WindowClose
            // 
            this.Button_WindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_WindowClose.FlatAppearance.BorderSize = 0;
            this.Button_WindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_WindowClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Button_WindowClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Button_WindowClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Button_WindowClose.IconSize = 16;
            this.Button_WindowClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_WindowClose.Location = new System.Drawing.Point(299, 1);
            this.Button_WindowClose.Margin = new System.Windows.Forms.Padding(1);
            this.Button_WindowClose.Name = "Button_WindowClose";
            this.Button_WindowClose.Size = new System.Drawing.Size(32, 32);
            this.Button_WindowClose.TabIndex = 10;
            this.Button_WindowClose.UseVisualStyleBackColor = true;
            this.Button_WindowClose.Click += new System.EventHandler(this.Button_WindowClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "github.com/nmelihsensoy/LbryDot";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Text_Logo
            // 
            this.Text_Logo.AutoSize = true;
            this.Text_Logo.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Text_Logo.Location = new System.Drawing.Point(97, 14);
            this.Text_Logo.Name = "Text_Logo";
            this.Text_Logo.Size = new System.Drawing.Size(139, 63);
            this.Text_Logo.TabIndex = 8;
            this.Text_Logo.Text = "Logo";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 191);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Text_Logo;
        private FontAwesome.Sharp.IconButton Button_WindowClose;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
    }
}