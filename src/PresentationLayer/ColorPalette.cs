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


        public static Color SettingsBackColor = Color.FromArgb(240, 240, 240);
        public static Color SettingsForeColor = Color.Black;
        

        public static Color UserDropdownForeColor = Color.Black;
        public static Color UserDropdownBackColor = Color.White;
        public static Color UserDropdownBorderColor = Color.LightGray;
        public static Color UserDropdownRoleForeColor = Color.FromArgb(105, 105, 105);

        public static Color BookStatusItemBackColor = Color.Transparent;
        public static Color BookStatusItemBottomRibbonForeColor = Color.FromArgb(211, 211, 211);
        public static Color BookStatusItemBottomHoverRibbonForeColor = Color.Black;
        public static Color BookStatusItemBottomHoverRibbonButtonBackColor = Color.White;
        public static Color BookStatusItemBottomHoverRibbonButtonForeColor = Color.Gray;
        public static Color BookStatusItemBottomHoverRibbonReturnForeColor = Color.Green;
        public static Color BookStatusItemTopHoverRibbonLateBackColor = Color.FromArgb(128, 0, 0);
        public static Color BookStatusItemTopHoverRibbonLateForeColor = Color.White;
        public static Color BookStatusItemTopHoverRibbonTwoDaysLeftBackColor = Color.FromArgb(218, 165, 32);
        public static Color BookStatusItemTopHoverRibbonTwoDaysLeftForeColor = Color.White;
        public static Color BookStatusItemTopHoverRibbonReturnedBackColor = Color.FromArgb(85, 107, 47);
        public static Color BookStatusItemTopHoverRibbonReturnedForeColor = Color.White;

        public static Color BookListItemBackColor = Color.White;
        public static Color BookListItemHoverBackColor = Color.Black;
        public static Color BookListItemTopBorderColor= Color.Tomato;
        public static Color BookListItemTitleForeColor= Color.Black;
        public static Color BookListItemAuthorForeColor= Color.FromArgb(100, 100, 100);
        public static Color BookListItemCategoryBackColor= Color.FromArgb(100, 100, 100);
        public static Color BookListItemPageCountBackColor= Color.FromArgb(210, 180, 140);
        public static Color BookListItemPublishYearBackColor= Color.FromArgb(210, 180, 140);
        public static Color BookListItemHoverButtonBackColor = Color.White;
        public static Color BookListItemHoverButtonForeColor = Color.Gray;
        public static Color BookListItemDeleteButtonForeColor = Color.FromArgb(205, 92, 92);
        public static Color BookListItemBorrowButtonForeColor = Color.FromArgb(205, 92, 92);

        public static Color AlertBoxInfoBackColor = Color.FromArgb(207, 226, 255);
        public static Color AlertBoxInfoForeColor = Color.FromArgb(8, 66, 152);
        public static Color AlertBoxInfoBorderColor = Color.FromArgb(182, 212, 254);

        public static Color AlertBoxDangerBackColor = Color.FromArgb(248, 215, 218);
        public static Color AlertBoxDangerForeColor = Color.FromArgb(132, 32, 41);
        public static Color AlertBoxDangerBorderColor = Color.FromArgb(245, 194, 199);

        public static Color AlertBoxWarningBackColor = Color.FromArgb(255, 243, 205);
        public static Color AlertBoxWarningForeColor = Color.FromArgb(102, 77, 3);
        public static Color AlertBoxWarningBorderColor = Color.FromArgb(255, 236, 181);

        public static Color AlertBoxSuccessBackColor = Color.FromArgb(209, 231, 221);
        public static Color AlertBoxSuccessForeColor = Color.FromArgb(15, 81, 50);
        public static Color AlertBoxSuccessBorderColor = Color.FromArgb(186, 219, 204);

        public static Color BorrowDialogBackColor = Color.White;
        public static Color BorrowDialogForeColor = Color.Black;
        public static Color BorrowDialogCloseForeColor = Color.Brown;

        public static Color GenericFormBackColor = Color.White;
        public static Color GenericFormForeColor = Color.Black;

        public static Color SearchBarBackColor = Color.White;
        public static Color SearchBarForeColor = Color.FromArgb(180, 180, 180);
        public static Color SearchBarBorderColor = Color.FromArgb(220, 220, 220);
        public static Color TopBarAddBookBackColor = Color.Transparent;
        public static Color TopBarAddBookForeColor = Color.FromArgb(100, 100, 100);

        public static Color TopBarTitleForeColor = Color.FromArgb(63, 64, 69);
        public static Color TopBarColor = Color.White;

        public static Color DashBoardBackColor = Color.FromArgb(240, 240, 240);
        public static Color DashBoardPanelBackColor = Color.White;
        public static Color DashBoardPanelBorderColor = Color.FromArgb(178, 184, 202);
        public static Color DashboardActivePanelForeColor = Color.FromArgb(105, 105, 105);
    }
}
