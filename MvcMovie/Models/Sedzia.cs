using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Sedzia
    {
        [Key]
        public int ID_SEDZI{ get; set; }
        public string IMIE_SEDZI { get; set; }
        public string NAZWISKO_SEDZI { get; set; }
    }
}