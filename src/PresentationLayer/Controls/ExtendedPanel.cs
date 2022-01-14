using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controls
{
    // Custom panel control to create transparent panels.
    //https://stackoverflow.com/questions/32400320/any-trick-to-use-opacity-on-a-panel-in-visual-studio-window-form
    public class ExtendedPanel : Panel
    {
        //https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles
        private const int WS_EX_TRANSPARENT = 0x20;
        public ExtendedPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        //Making opacity parameter available in the properties.
        private int opacity = 50;
        [DefaultValue(50)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }

        //Overriding CreateParams to set extended style to form.
        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.createparams?view=windowsdesktop-5.0
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
