using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SettingsModel
    {
        public int id { get; }
        public int daily_fine_amount { get; set; }
        public string currency_symbol { get; set; }
    }
}
