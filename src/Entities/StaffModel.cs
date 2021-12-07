using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public enum UserType
    {
        Undefined = -1,
        Admin = 0,
        Staff = 1,
        Student = 2
    }

    public class StaffModel
    {
        public int staff_id { get; set; }
        public string staff_email { get; set; }
        public string staff_name { get; set; }
        public string staff_password { get; set; }
        public UserType staff_type { get; }
        public byte[] staff_avatar { get; set; }
    }
}
