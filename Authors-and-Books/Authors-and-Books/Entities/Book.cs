using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors_and_Books.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Content { get; set; }
        public ICollection<AuthorBook> Authors { get; set; }
        
    }
}
