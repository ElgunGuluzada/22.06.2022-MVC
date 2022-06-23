using System.Collections.Generic;

namespace _22._06._2022_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string CreateDate { get; set; }
        public string AuthorName { get; set; }
        public List<BookGenre> BookGenres { get; set; }
    }
}
