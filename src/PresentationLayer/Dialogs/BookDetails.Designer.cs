
namespace PresentationLayer.Dialogs
{
    partial class BookDetails
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookListItem1 = new PresentationLayer.Controls.BookListItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyBookNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAuthorNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyISBNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 184);
            this.dataGridView1.TabIndex = 1;
            // 
            // bookListItem1
            // 
            this.bookListItem1.Location = new System.Drawing.Point(12, 8);
            this.bookListItem1.Name = "bookListItem1";
            this.bookListItem1.Size = new System.Drawing.Size(464, 150);
            this.bookListItem1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyBookNameToolStripMenuItem,
            this.copyAuthorNameToolStripMenuItem,
            this.copyISBNToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 70);
            // 
            // copyBookNameToolStripMenuItem
            // 
            this.copyBookNameToolStripMenuItem.Name = "copyBookNameToolStripMenuItem";
            this.copyBookNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyBookNameToolStripMenuItem.Text = "Copy Book Name";
            // 
            // copyAuthorNameToolStripMenuItem
            // 
            this.copyAuthorNameToolStripMenuItem.Name = "copyAuthorNameToolStripMenuItem";
            this.copyAuthorNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyAuthorNameToolStripMenuItem.Text = "Copy Author Name";
            // 
            // copyISBNToolStripMenuItem
            // 
            this.copyISBNToolStripMenuItem.Name = "copyISBNToolStripMenuItem";
            this.copyISBNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyISBNToolStripMenuItem.Text = "Copy ISBN";
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 366);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.bookListItem1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.BookListItem bookListItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyBookNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyISBNToolStripMenuItem;
    }
}