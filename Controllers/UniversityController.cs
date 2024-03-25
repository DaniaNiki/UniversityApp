using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UniversityApp.Data;
using Microsoft.EntityFrameworkCore;
using UniversityApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Controllers;

[Route("studs")]
public class UniversityController : Controller
{
    private readonly UniversityContext _context;

    public UniversityController(ILogger<UniversityController> logger, UniversityContext context)
    {
       
        _context = context;

    }

    [HttpGet("Index")]
    public async Task<IActionResult> Index()
    {
        try{
            var students = await _context.Students.Select(s => new
            {
                s.Name,
                s.Score
            }).ToListAsync();
            Console.WriteLine("Data is succeed!" + $"{students.Count}");
            return View(students);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return View();
        }

    }

}
