using PresentationLayer.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Pages
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            label1.Text = Strings.LoginExecuteButtonText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
