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

        public async Task<IActionResult> Index(string instrumentName)
        {
            //create a view model selectlist with instruments + userInstruments (users)

            // do some coding - filter users to only display those that play the instrument
            var users = from x in _context.UserInstruments.Include(x => x.Instrument).Include(x=>x.ApplicationUser)
                        select x;



            
            return View(await users.ToListAsync());
        }

    }
}