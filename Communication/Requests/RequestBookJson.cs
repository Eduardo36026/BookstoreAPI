using BookstoreAPI.Entities.Enums;

namespace BookstoreAPI.Communication.Requests
{
    public class RequestBookJson
    {
        
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        
        public string Gender { get; set; } = string.Empty;
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

    }
}
