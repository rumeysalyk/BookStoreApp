using System.Collections.Generic;

namespace BookStoreApp.Models
{
    public class BookCategory
    {
        public Book book { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set;}
        
    }
}