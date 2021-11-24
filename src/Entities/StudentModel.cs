using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentModel
    {
        public int student_number { get; set; }
        public string student_email { get; set; }
        public string student_password { get; set; }
        public string student_name { get; set; }
        public byte[] student_avatar { get; set; }
    }
}
