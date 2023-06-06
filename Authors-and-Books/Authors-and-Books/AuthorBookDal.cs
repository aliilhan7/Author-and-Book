using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authors_and_Books.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authors_and_Books
{
    public class AuthorBookDal
    {
        public List<Author> ListAll()
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                return context.Authors.ToList();
            }
        }
        public List<Book> ListAll2()
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                return context.Books.ToList();
            }
        }


        public void Add(Author author)
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                context.Authors.Add(author);
                //var entity = context.entry(authortitle);
                //entity.state = entitystate.modified;
                context.SaveChanges();
            }
        }
        public void Add(Book book)
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                context.Books.Add(book);
                //var entity = context.entry(authortitle);
                //entity.state = entitystate.modified;
                context.SaveChanges();
            }
        }
        public void Update(Author author)
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                var entity = context.Entry(author);
                entity.State= EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Update(Book book)
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Author author)
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                var entity = context.Entry(author);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Delete(Book book)
        {
            using (AuthorBookContext context = new AuthorBookContext())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
