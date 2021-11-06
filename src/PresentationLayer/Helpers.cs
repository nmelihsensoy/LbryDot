using PresentationLayer.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    //Definitions of function or varibles that can only used in PresentationLayer to help another function or variable.
    //Creating with no relation any of classes is required.
    public static class Helpers
    {

        //Get currently active language value. "" : EN, "tr" : TR
        public static string GetCurrentLanguage()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            return currentCulture.ToString();
        }

        public static void ChangeLanguage(string CultureAbbr = "")
        {
            //Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            
            if (GetCurrentLanguage() != CultureAbbr)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureAbbr);
            }     
        }

        public static void ChangePage(Form Current, Form Next)
        {
            Current.Hide();
            Next.Show();
        }
    }
}
