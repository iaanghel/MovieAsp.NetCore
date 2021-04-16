using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie.Data;
using Movie.Models;

namespace Movie.Controllers
{
    public class MovieReviewsController : Controller
    {
        private readonly MovieContext _context;

        public MovieReviewsController(MovieContext context)
        {
            _context = context;
        }

        // GET: MovieReviews
        public async Task<IActionResult> Index(int id)
        {
            return View(await _context.MovieReview.Where(e => e.MovieId == id).ToListAsync());
        }

        

        

        // POST: MovieReviews/Create
        
        [HttpPost]        
        public async Task<IActionResult> Create( MovieReview movieReview)
        {
            movieReview.Date = DateTime.Now;
            
            _context.Add(movieReview);
            await _context.SaveChangesAsync();
            return Ok();
            
        }

        
    }
}
