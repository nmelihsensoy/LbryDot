using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    //Definitions of function or varibles that can only used in BusinessLogicLayer to help another function or variable.
    //Creating with no relation any of classes is required.
    public static class Helpers
    {
        public static int DaysBetween(DateTime Date1, DateTime Date2)
        {
            return (Date2 - Date1).Days;
        }

        public static int DaysBetween(string Date1, string Date2)
        {
            return (DateTime.Parse(Date2) - DateTime.Parse(Date1)).Days;
        }
    }
}
