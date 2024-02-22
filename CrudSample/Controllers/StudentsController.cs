using CrudSample.Data;
using CrudSample.Models;
using CrudSample.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrudSample.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed,
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync(); // will actually save it to the database

            return View();
        }
        
    }
}
