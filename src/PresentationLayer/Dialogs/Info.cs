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

namespace PresentationLayer.Dialogs
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Button_WindowClose_Click(object sender, EventArgs e)
        {
            Helpers.CloseForm(this);
        }

        private void Info_Load(object sender, EventArgs e)
        {
            Text_Logo.Text = Strings.LogoText;
        }
    }
}
