using BookstoreAPI.Entities.Enums;

namespace BookstoreAPI.Entities
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
