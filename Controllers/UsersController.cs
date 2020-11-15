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

        public async Task<IActionResult> Index(string instrumentName)
        {
            //create a view model selectlist with instruments + userInstruments (users)

            // do some coding - filter users to only display those that play the instrument
            var users = from x in _context.UserInstruments.Include(x => x.Instrument).Include(x=>x.ApplicationUser)
                        select x;

            if (!String.IsNullOrEmpty(instrumentName)) {
                users = users.Where(x => x.Instrument.Name == instrumentName);
            }
        
            var inst = await _context.Instruments.ToListAsync();
            inst.Insert(0, new Models.Entities.Instrument() {Name = ""});
            var vm = new UserInstrumentVm() {
                UserInstruments = await users.ToListAsync(),
                Instruments = new SelectList(inst, "Name", "Name"),
                InstrumentName = instrumentName
            };
            
            return View(vm);
        }
    }
}