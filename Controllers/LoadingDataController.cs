using Microsoft.AspNetCore.Mvc;
using Task11PatternAndRelatedDataLoading.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Task11PatternAndRelatedDataLoading.Models;

namespace Task12PatternAndRelatedDataLoading.Controllers
{
    public class LoadingDataController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;
        public LoadingDataController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult EagerLoading()
        {
            var studentList = _applicationDbContext.Students
                .Include(a => a.Department)
                    .ThenInclude(b => b.University)
                        .ToList();

            return Ok(studentList);
        }

        public IActionResult ExplicitLoading()
        {
            var studentList = _applicationDbContext.Students.ToList();

            foreach (var student in studentList)
            {
                _applicationDbContext.Entry(student).Reference(a => a.Department).Load();
                _applicationDbContext.Entry(student.Department).Reference(a => a.University).Load();
            }
            return Ok(studentList);
        }

        public IActionResult LazyLoading()
        {
            var depts = _applicationDbContext.Departments.ToList();
            return Ok(depts);
        }
    }
}
