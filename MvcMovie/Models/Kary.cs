using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Kary
    {
        public int ID_SPOTKANIA { get; set; }
        public int ID_DRUZYNY { get; set; }
        [Key]
        public int ID_PILKARZA { get; set; }
        public int MINUTA_KARY { get; set; }
        public string KARA { get; set; }

    }
}