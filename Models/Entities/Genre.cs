using System.Collections.Generic;

namespace MusicDating.Models.Entities {
    public class Genre {
        public int GenreId { get; set; }
        public string Name { get; set; }


        public ICollection<GenreEnsemble> GenreEnsembles { get; set; }

    }
}
