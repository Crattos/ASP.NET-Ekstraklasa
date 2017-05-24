using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Druzyny
    {
        [Key]
        public int ID_DRUZYNY { get; set; }
        public int ID_MIASTA { get; set; }
        public string NAZWA_DRUZYNY { get; set; }
        public int PUNKTY { get; set; }
        public int BRAMKI { get; set; }
        public int ILOSC_SPOTKAN { get; set; }

    }
}