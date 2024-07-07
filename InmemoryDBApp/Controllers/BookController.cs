using InmemoryDBApp.DataDto;
using InmemoryDBApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InmemoryDBApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DbContextAPI dbContext;
        public BookController(DbContextAPI dbContext) {
            this.dbContext = dbContext;

        }
        [HttpGet]
        public IActionResult GetAllBooks() {
           var result = dbContext.Books.ToList();
           return Ok(result);
        }
        [HttpPost]
        public IActionResult PostBook(BookVm request)
        {
            var newBook = new Book
            {
                Id = Guid.NewGuid(),
                BoookName = request.BoookName,
                Description = request.Description,
                Title = request.Title
            };
            dbContext.Books.Add(newBook);
            dbContext.SaveChanges();
            return Ok(newBook);
        }
    }
}
