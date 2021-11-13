using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Dialogs;

namespace PresentationLayer.SubPages
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            bookListItem1.ButtonHandler += ListClickEvent;
        }

        private void ListClickEvent(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as Button).Name + bookListItem1.TestVal);
            if((sender as Button).Name == "Button_BookDetails")
            {
                using (var form = new BookDetails())
                {
                    var result = form.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        MessageBox.Show("returned OK");
                    }
                }
            }else if ((sender as Button).Name == "Button_BookDeleteBorrow")
            {
                using (var form = new BookBorrow())
                {
                    form.StartPosition = FormStartPosition.Manual;
                    Point StartP = bookListItem1.PointToScreen(Point.Empty);
                    StartP.X += 20;
                    StartP.Y += 20;
                    form.Location = StartP;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("returned OK");
                    }
                }
            }
        }

    }
}
