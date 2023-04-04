using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vesper.DAL;

namespace Vesper.Controllers

{
    public class TeamController : Controller
    {
       
            private readonly VesperDbContext _context;

            public TeamController(VesperDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var model = _context.TeamMembers.ToList();

                return View(model);
            }
        
    }
}
