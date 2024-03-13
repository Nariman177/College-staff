using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookSrore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Лев не Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И.Тургенов", Price = 2120 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А.Чехов", Price = 2180 });
            base.Seed(db);
        }
    }
}