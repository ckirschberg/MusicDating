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
            UserInstrumentVm vm = await UserServices.SearchForUsers(_context, instrumentName, genreId);
            
            return View(vm);
        }
    }
}