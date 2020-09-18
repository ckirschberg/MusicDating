using System.ComponentModel.DataAnnotations;

namespace MusicDating 
{
    public class Instrument 
    {
        public int InstrumentId { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}