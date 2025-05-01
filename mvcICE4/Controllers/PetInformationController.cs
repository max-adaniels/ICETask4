using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcICE4.Models;
using System.Collections.Generic;

namespace mvcICE4.Controllers
{
    public class PetInformationController : Controller
    {
        // Injecting the application database context
        private readonly ApplicationDbContext _context;
        public PetInformationController(ApplicationDbContext context)
        {
            _context = context;
        }
        // Displays a list of all events
        public async Task<IActionResult> Index()
        {
            var pets = await _context.PetInformation.ToListAsync();
            return View(pets);
        }
        public IActionResult Create()
        {
            return View();
        }

        // Handles the form submission to create a new event
        [HttpPost]
        public async Task<IActionResult> Create(PetInformation pets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pets);
        }
    }
}
