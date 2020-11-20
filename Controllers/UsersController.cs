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
using MusicDating.Models.Services;

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
            
            // do some coding - filter users to only display those that play the instrument
            UserInstrumentVm vm = await UserServices.SearchForUsers(_context, instrumentName, genreId);
            
            return View(vm);
        }
    }
}