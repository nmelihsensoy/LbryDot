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
        public BookModel book { get; set; }
        public StudentModel student { get; set; }
        public DateTime issued_date { get; set; }
        public DateTime due_date { get; set; }
        public DateTime returned_date { get; set; } 
        public int amount_of_fine { get; set; }
    }
}
