using AlquileresMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlquileresMVC.Controllers
{    
    public class AlquileresController : Controller
    {
        private readonly ApplicationDbContext context;

        public AlquileresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var alquileres = await context.Alquileres.ToListAsync();
            return View(alquileres);
        }

        [HttpGet]
        public async Task<ActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Alquiler());

            var alquiler = await context.Alquileres.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (alquiler == null)
                return NotFound();

            return View(alquiler);            
        }

        [HttpGet]
        public async Task<ActionResult> ConfirmDelete(int? id)
        {
            if (id == null)
                return NotFound();

            var alquiler = await context.Alquileres.FirstOrDefaultAsync(x => x.Id == id);

            if (alquiler == null)
                return NotFound();

            return View(alquiler);
        }

    }
}
