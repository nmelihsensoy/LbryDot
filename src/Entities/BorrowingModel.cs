using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BorrowingModel
    {
        public int borrow_id { get; }
        public int book_id { get; set; }
        public int student_number { get; set; }
        public string issued_date { get; set; }
        public string due_date { get; set; }
        public string returned_date { get; set; }
        public int amount_of_fine { get; set; }
    }
}
