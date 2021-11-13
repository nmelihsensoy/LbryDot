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
    public partial class MyBooks : Form
    {
        public MyBooks()
        {
            InitializeComponent();
            bookStatusItem1.ButtonHandler += StatusItemClick;
        }

        private void StatusItemClick(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as Button).Name);
            if ((sender as Button).Name == "Button_ReturnBook")
            {
                using (var form = new BookIssue())
                {
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
