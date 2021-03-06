using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;

namespace BusinessLogicLayer
{
    //Definitions of function or variables that can only used in BusinessLogicLayer to help another function or variable.
    //Creating with no relation any of classes is required.
    public static class Helpers
    {
        public static int DaysBetween(DateTime Date1, DateTime Date2)
        {
            return (Date2.Date - Date1.Date).Days;
        }

        public static int DaysBetween(string Date1, string Date2)
        {
            return (DateTime.Parse(Date2).Date - DateTime.Parse(Date1).Date).Days;
        }

        public static string HideWords(string Sentence, char Delimiter = ' ', string Censor = "*")
        {
            string[] TempStrArr = Sentence.Split(Delimiter);
            string TempStr = "";
            foreach (var Word in TempStrArr)
            {
                TempStr += Word[0] + Censor + Delimiter;
            }
            return TempStr;
        }

        //https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compute-hash-values
        public static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        //https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compute-hash-values
        public static string MD5Hash(string Text, string Salt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Text + Salt));
            byte[] result = md5.Hash;
            return ByteArrayToString(result);
        }

        public static string GetEncryptionConfig(string id = "Salt")
        {
            return ConfigurationManager.AppSettings.Get(id);
        }

        public static string ColorToPaddedString(Color Clr)
        {
            return (Clr.R.ToString("D3") + "," + Clr.G.ToString("D3") + "," + Clr.B.ToString("D3"));
        }

        public static Color PaddedStringToColor(String Str, Color DefaultColor)
        {
            //Getting numbers that has two or three digits.
            //"Computers233,196,106", "Computers233196106", "Computers33,96,06", "Computers339606"
            Regex RgxPattern = new Regex(@"([0-9]){2,3}"); 
            MatchCollection Matches = RgxPattern.Matches(Str);

            //First matched number is R, Second is G, Third is B
            if (Matches.Count == 3)
            {
                return Color.FromArgb(int.Parse(Matches[0].Value), int.Parse(Matches[1].Value), int.Parse(Matches[2].Value));
            }
            return DefaultColor;
        }

        public static string GetOnlyText(string Str)
        {
            //Getting all letters including turkish characters, spaces and '-'
            return Regex.Replace(Str, @"[^A-z\-ÇçĞğİıÖöŞşÜü\s]+", String.Empty);
        }
    }
}
