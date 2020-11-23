using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicDating.Models.Entities 
{
    public class UserInstrumentGenre
    {
<<<<<<< HEAD
        [Key]
        public int UserInstrumentGenreId { get; set; }
        public string Id { get; set; }
        public int InstrumentId { get; set; }
        
        [ForeignKey("Id,InstrumentId")]
=======
        public int UserInstrumentGenreId { get; set; }



        public string Id { get; set; }
        public int InstrumentId { get; set; }
        
        [ForeignKey("Id, InstrumentId")]
>>>>>>> development
        public UserInstrument UserInstrument { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
<<<<<<< HEAD
    }   
=======
    }
>>>>>>> development
}