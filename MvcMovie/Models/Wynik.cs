using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Wynik
    {
        [Key]
        public int ID_SPOTKANIA { get; set; }
        public int ID_DRUZYNY { get; set; }
        public int ID_PILKARZA { get; set; }
        public int MINUTA_WYNIKU { get; set; }

    }
}