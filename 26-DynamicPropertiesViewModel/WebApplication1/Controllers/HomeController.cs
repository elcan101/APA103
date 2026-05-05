using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using WebApplication1.Models;
using WebApplication1.Views;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ruad", Age = 28 },
            new Student { Id = 2, Name = "Suad", Age = 48 },
            new Student { Id = 3, Name = "Fuad", Age = 58 }
        };

        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher { Id = 1, Name = "Ruad", Salary = 280 },
            new Teacher { Id = 2, Name = "Suad", Salary = 480 },
            new Teacher { Id = 3, Name = "Fuad", Salary = 580 }
        };

        public List<Teacher> Teachers { get; private set; }
        public List<Student> Students { get; private set; }

        public IActionResult Index()
        {
            HomeVM homeVM = new();
            {
                Teachers = teachers,
                    Students = students
            };

            return View(homeVM);
        }
        public IActionResult Details()
        {
            return View(students);
        }
    }
}
