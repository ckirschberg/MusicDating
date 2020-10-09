using System.Collections.Generic;

namespace MusicDating.Models.Entities {
    public class Ensemble {
        public int EnsembleId { get; set; }
        public string Name { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }


        public ICollection<GenreEnsemble> GenreEnsembles { get; set; }

    }
}
