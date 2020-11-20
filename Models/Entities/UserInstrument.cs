using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicDating.Models.Entities 
{
    public class UserInstrument 
    {
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }
    
        public int Level { get; set; }

        public ICollection<UserInstrumentGenre> UserInstrumentsGenres { get; set; }   
    }
}