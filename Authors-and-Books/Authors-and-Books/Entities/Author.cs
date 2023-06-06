using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors_and_Books.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }

        public ICollection<AuthorBook> Books { get; set; }
    }
}
