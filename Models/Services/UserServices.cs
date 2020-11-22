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

namespace MusicDating.Models.Services
{
    public class UserServices {
        public async static Task<UserInstrumentVm> SearchForUsers(ApplicationDbContext _context, string instrumentName, int genreId) 
        {
           var users = from x in _context.UserInstruments.Include(y=>y.UserInstrumentGenres)
            .Include(x => x.Instrument).Include(x=>x.ApplicationUser)
                        select x;

            var genres = from x in _context.UserInstrumentGenres.Include(y=>y.Genre)
                         select x.Genre;
            

            if (!String.IsNullOrEmpty(instrumentName)) {
                users = users.Where(x => x.Instrument.Name == instrumentName);
            }
            if (genreId != 0) {
                       // To be continued
                        
            }
        
    
            var vm = new UserInstrumentVm() {
                UserInstruments = await users.ToListAsync(),
                Genres = new SelectList(await genres.Distinct().ToListAsync(), "GenreId", "Name"),
                Instruments = new SelectList(await _context.Instruments.ToListAsync(), "Name", "Name"),
                InstrumentName = instrumentName,
                GenreId = genreId
            }; 

            return vm;
        }
    }
    
}