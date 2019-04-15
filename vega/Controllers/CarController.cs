using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class CarController: Controller
    {
        private VegaDbContext _context;
        public CarController(VegaDbContext context){
            _context = context;
        }

        [HttpGet("api/makes")]
        public IEnumerable<Make> GetMakes() => _context.Makes.ToList();
    }
}