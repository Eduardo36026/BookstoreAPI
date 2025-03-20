using BookstoreAPI.Communication.Requests;
using BookstoreAPI.Communication.Responses;
using BookstoreAPI.Entities;
using BookstoreAPI.Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BookStoreBaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateBook([FromBody] RequestBookJson book)
        {

            var response = new ResponseBookJson
            {
                Id = 1,
                Title = book.Title,
                Author = book.Author,
                Gender = book.Gender,
                Price = book.Price,
                QuantityInStock = book.QuantityInStock,
            };
            return Created(string.Empty, response);
        }


        [HttpGet]
        [Route("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new Book
            {
                Id = 3,
                Title = "The Lord of the Rings",
                Author = "Tolkien",
                Gender = "Fantasy",
                Price = 55.00,
                QuantityInStock = 3
            };
            return Ok(response);
        }


        [HttpGet]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        public IActionResult GetAllBooks()
        {

            var response = new List<Book>()
            {
               new Book {
                Id = 2,
                Title = "The Lord of the Rings",
                Author = "Tolkien",
                Gender = "Fantasy",
                Price = 55.00,
                QuantityInStock = 3
               },
               new Book {
                Id = 3,
                Title = "Percy Jackson",
                Author = "Rick Riordan",
                Gender = "Fantasy",
                Price = 40.00,
                QuantityInStock = 2
               }
            };

            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateBook(
            [FromRoute] int id,
            [FromBody] RequestBookJson book)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteBook(int id)
        {
            return NoContent();
        }

    }
}
