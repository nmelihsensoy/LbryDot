using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StaffModel
    {
        public int staff_id { get; set; }
        public string staff_email { get; set; }
        public string staff_name { get; set; }
        public string staff_password { get; set; }
        public int staff_type { get; set; }
        public byte[] staff_avatar { get; set; }
    }
}
