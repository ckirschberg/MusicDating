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

        public async Task<IActionResult> Index(string instrumentName, int genreId)
        {
            //create a view model selectlist with instruments + userInstruments (users)

            // I am showing all instruments in the database. Some of you found (only) the instruments that are in use by musicians.

            // Get all genres in use by userinstruments
            var genreQuery = from x in _context.UserInstrumentGenres.Include(x=>x.Genre)
                        select x.Genre;

            // do some coding - filter users to only display those that play the instrument
            var users = from x in _context.ApplicationUsers.Include(x=>x.UserInstruments)
                        .ThenInclude(y=>y.UserInstrumentsGenres).ThenInclude(y=>y.Genre)
                        .Include(y=>y.UserInstruments).ThenInclude(x => x.Instrument)
                        select x;




            if (!String.IsNullOrEmpty(instrumentName)) {
                users = from u in users
                        from g in u.UserInstruments
                        where g.Instrument.Name == instrumentName
                        select u;
            }
            if(genreId != 0){
                users = from u in users
                        from g in u.UserInstruments 
                        from ge in g.UserInstrumentsGenres
                        where ge.GenreId == genreId
                        select u;
            }
        
    
            var vm = new UserInstrumentVm() {
                ApplicationUsers = await users.ToListAsync(),
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync(), "GenreId", "Name"),
                Instruments = new SelectList(await _context.Instruments.ToListAsync(), "Name", "Name"),
                InstrumentName = instrumentName,
                GenreId = genreId
            };
            
            return View(vm);
        }
    }
}