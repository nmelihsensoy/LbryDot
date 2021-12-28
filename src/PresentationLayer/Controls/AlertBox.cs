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
    //Creating a custom control to generalize diffrent types of alerts.
    //Usage: After adding the control instance to form, ShowAlert method should used to change style and message.
    //Visibility, Size etc. properties has to be changed in the form that has any instance of AlertBox.
    public partial class AlertBox : UserControl
    {
        public enum AlertType
        {
            Info = 0,
            Success = 1,
            Warning = 2,
            Danger = 3
        }

        public AlertBox()
        {
            InitializeComponent();
        }


        //To change alert box style based on a type
        private void SetStyleByType(AlertType Type)
        {
            if (Type == AlertType.Success)
            {
                Image_TypeIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                Panel_Container.BackColor = ColorPalette.AlertBoxSuccessBackColor;
                Splitter_BorderLeft.BackColor = ColorPalette.AlertBoxSuccessBorderColor;
                Splitter_BorderRight.BackColor = ColorPalette.AlertBoxSuccessBorderColor;
                Splitter_BorderTop.BackColor = ColorPalette.AlertBoxSuccessBorderColor;
                Splitter_BorderBottom.BackColor = ColorPalette.AlertBoxSuccessBorderColor;
                Text_Message.ForeColor = ColorPalette.AlertBoxSuccessForeColor;
                Image_TypeIcon.IconColor =  ColorPalette.AlertBoxSuccessForeColor;
                Image_TypeIcon.BackColor =  ColorPalette.AlertBoxSuccessBackColor;
            }
            else if (Type == AlertType.Warning)
            {
                Image_TypeIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                Panel_Container.BackColor = ColorPalette.AlertBoxWarningBackColor;
                Splitter_BorderLeft.BackColor = ColorPalette.AlertBoxWarningBorderColor;
                Splitter_BorderRight.BackColor = ColorPalette.AlertBoxWarningBorderColor;
                Splitter_BorderTop.BackColor = ColorPalette.AlertBoxWarningBorderColor;
                Splitter_BorderBottom.BackColor = ColorPalette.AlertBoxWarningBorderColor;
                Text_Message.ForeColor = ColorPalette.AlertBoxWarningForeColor;
                Image_TypeIcon.IconColor =  ColorPalette.AlertBoxWarningForeColor;
                Image_TypeIcon.BackColor =  ColorPalette.AlertBoxWarningBackColor;
            }
            else if (Type == AlertType.Danger)
            {
                Image_TypeIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                Panel_Container.BackColor = ColorPalette.AlertBoxDangerBackColor;
                Splitter_BorderLeft.BackColor = ColorPalette.AlertBoxDangerBorderColor;
                Splitter_BorderRight.BackColor = ColorPalette.AlertBoxDangerBorderColor;
                Splitter_BorderTop.BackColor = ColorPalette.AlertBoxDangerBorderColor;
                Splitter_BorderBottom.BackColor = ColorPalette.AlertBoxDangerBorderColor;
                Text_Message.ForeColor = ColorPalette.AlertBoxDangerForeColor;
                Image_TypeIcon.IconColor =  ColorPalette.AlertBoxDangerForeColor;
                Image_TypeIcon.BackColor =  ColorPalette.AlertBoxDangerBackColor;
            }
            else //Type == AlertType.Info
            {
                Image_TypeIcon.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                Panel_Container.BackColor = ColorPalette.AlertBoxInfoBackColor;
                Splitter_BorderLeft.BackColor = ColorPalette.AlertBoxInfoBorderColor;
                Splitter_BorderRight.BackColor = ColorPalette.AlertBoxInfoBorderColor;
                Splitter_BorderTop.BackColor = ColorPalette.AlertBoxInfoBorderColor;
                Splitter_BorderBottom.BackColor = ColorPalette.AlertBoxInfoBorderColor;
                Text_Message.ForeColor = ColorPalette.AlertBoxInfoForeColor;
                Image_TypeIcon.IconColor =  ColorPalette.AlertBoxInfoForeColor;
                Image_TypeIcon.BackColor =  ColorPalette.AlertBoxInfoBackColor;
            }
        }

        //If wanted to change font style this method should be used.
        public void ShowAlert(AlertType Type, string Msg, Font Fnt)
        {
            SetStyleByType(Type);
            MakeTextVerticalCenter();
            Text_Message.Font = Fnt;
            Text_Message.Text = Msg;
        }

        //Sets alert type and message
        public void ShowAlert(AlertType Type, string Msg)
        {
            SetStyleByType(Type);
            MakeTextVerticalCenter();
            Text_Message.Text = Msg;
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            MakeTextVerticalCenter();
        }

        private void MakeTextVerticalCenter()
        {
            Image_TypeIcon.Top = (Panel_Container.Height / 2) - (Image_TypeIcon.Height / 2);
            Text_Message.Top = (Panel_Container.Height / 2) - (Text_Message.Height / 2);
        }
    }
}
