using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeeklyPlannerApi.Models;

namespace WeeklyPlannerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty
                _context.TodoItems.Add(new TodoItem { Name = "TestItem" });
                _context.SaveChanges();
            }
        }
    }
}
