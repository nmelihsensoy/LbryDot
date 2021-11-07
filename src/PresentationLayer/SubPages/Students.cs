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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new StudentAddUpdate())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.Name; 
                    //string dateString = form.ReturnValue2;
                    //Do something here with these values

                    //for example
                    //this.txtSomething.Text = val;
                    MessageBox.Show(val);
                }
            }
        }
    }
}
