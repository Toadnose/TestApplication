using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(){Id = 24001, FirstName = "John", LastName = "Smith", Age = 20});
            students.Add(new Students(){Id = 24002, FirstName = "Chloe", LastName = "Rose", Age = 19});
            students.Add(new Students(){Id = 24003, FirstName = "Samantha", LastName = "Waterstone", Age = 17});
            students.Add(new Students(){Id = 24004, FirstName = "Albert", LastName = "Kyliston", Age = 18});
            students.Add(new Students(){Id = 24005, FirstName = "Rose", LastName = "Chloe", Age = 19});
            students.Add(new Students(){Id = 24006, FirstName = "Stephan", LastName = "Salvator", Age = 24});
            students.Add(new Students(){Id = 24007, FirstName = "Robert", LastName = "Johm", Age = 20});
            students.Add(new Students(){Id = 24008, FirstName = "Isabelle", LastName = "Crossing", Age = 21});
            students.Add(new Students(){Id = 24009, FirstName = "Isabella", LastName = "Crossling", Age = 19});
            students.Add(new Students(){Id = 24010, FirstName = "Xavier", LastName = "Hamilton", Age = 18});
            students.Add(new Students(){Id = 24011, FirstName = "Sebastien", LastName = "Language", Age = 23});
            students.Add(new Students(){Id = 24012, FirstName = "Jason", LastName = "Sharp", Age = 16});
            return students;
        }

        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }
    }

}
