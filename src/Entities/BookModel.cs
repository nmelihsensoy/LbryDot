using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BookModel
    {
        public int book_id { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int date_of_publication { get; set; }
        public string author { get; set; }
        public int number_of_pages { get; set; }
        public string category { get; set; }
        public string language { get; set; }
        public byte[] book_cover { get; set; }
        public string shelf_number { get; set; }
        public short is_available { get; set; }
        public DateTime added_date { get; set; }
    }
}
