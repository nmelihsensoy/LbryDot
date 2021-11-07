using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public static class ColorPalette
    {
        private static Color blue = Color.FromArgb(24, 32, 63);
        private static Color light_blue = Color.FromArgb(0, 120, 215);

        public static Color LoginBackColor = blue;
        public static Color LoginForeColor = Color.White;
        public static Color LoginFormElementsBackColor = blue;
        public static Color LoginFormElementsActiveColor = light_blue;
        public static Color LoginPlaceholderColor = Color.White;

        public static Color MainSidebarLogoColor = Color.White;
        public static Color MainSidebarBackColor = blue;
        public static Color MainSidebarForeColor = Color.FromArgb(92, 100, 128);
        public static Color MainSidebarMenuHover = light_blue;
        public static Color MainSidebarMenuActiveBackColor = light_blue;
        public static Color MainSidebarMenuActiveForeColor = Color.White;
        public static Color MainContentPanelBackColor = Color.FromArgb(247, 249, 251);
    }
}
