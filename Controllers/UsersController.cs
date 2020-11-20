using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicDating.Models;
using MusicDating.Data;
using Microsoft.EntityFrameworkCore;
using MusicDating.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MusicDating.Controllers
{
    public class UsersController : Controller
    {
        // Access to the database
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string instrumentName, string genreName)
        {
            //create a view model selectlist with instruments + userInstruments (users)

            // I am showing all instruments in the database. Some of you found (only) the instruments that are in use by musicians.

            // Get all genres in use by userinstruments
            var genreQuery = from x in _context.UserInstrumentGenres.Include(x=>x.Genre)
                        select x.Genre;

            // do some coding - filter users to only display those that play the instrument
            var users = from x in _context.UserInstruments.Include(x=>x.UserInstrumentsGenres).ThenInclude(y=>y.Genre)
                .Include(x => x.Instrument).Include(x=>x.ApplicationUser)
                        select x;

            if (!String.IsNullOrEmpty(instrumentName)) {
                users = users.Where(x => x.Instrument.Name == instrumentName);
            }
            if(!String.IsNullOrEmpty(genreName)){
                users = from u in users
                        from g in u.UserInstrumentsGenres
                        where g.Genre.Name == genreName
                        select u;
            }
        
    
            var vm = new UserInstrumentVm() {
                UserInstruments = await users.ToListAsync(),
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync(), "Name", "Name"),
                Instruments = new SelectList(await _context.Instruments.ToListAsync(), "Name", "Name"),
                InstrumentName = instrumentName,
                GenreName = genreName
            };
            
            return View(vm);
        }
    }
}