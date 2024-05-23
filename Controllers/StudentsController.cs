using Microsoft.AspNetCore.Mvc;

namespace Walks.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    public StudentsController() { }

    [HttpGet(Name = "GetAllStudents")]
    public IActionResult GetAllStudents()
    {
        string[] students = new string[] { "Student1", "Student2", "Student3" };
        return Ok(students);
    }
}
