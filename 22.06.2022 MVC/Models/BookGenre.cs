namespace _22._06._2022_MVC.Models
{
    public class BookGenre
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }

        public Book Books { get; set; }
        public Genre Genres { get; set; }
    }
}
