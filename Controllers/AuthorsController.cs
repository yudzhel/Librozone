using Librozone.Data;
using Librozone.Data.Services;
using Librozone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Librozone.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsService _service;

        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allAuthors = await _service.GetAllAsync();
            return View(allAuthors);
        }

        //GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL,Bio")]Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            await _service.AddAsync(author);
            return RedirectToAction(nameof(Index));
        }

        //GET: Authors/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);

            if (authorDetails == null) return View("Empty");
            return View(authorDetails);
        }


    }






}
