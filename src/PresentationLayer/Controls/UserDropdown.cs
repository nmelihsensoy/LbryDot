using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controls
{
    public partial class UserDropdown : UserControl
    {
        public event EventHandler DropdownClick;
        private void DropdownClickEvent(object sender, EventArgs e)
        {
            var eventHandler = this.DropdownClick;

            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }
        public UserDropdown()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, UserAvatar.Width, UserAvatar.Height);
            UserAvatar.Region = new Region(path);
        }
    }
}
