using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Vesper.DAL;

namespace Vesper.Controllers
{
    public class ServiceController : Controller
    {

        private readonly VesperDbContext _context;

        public ServiceController(VesperDbContext context)
        {
            _context = context;
        }

        public IActionResult Index
        {
            get
            {
                var model = _context.Services.ToList();

                return View(model);
            }
        }


    }
}
