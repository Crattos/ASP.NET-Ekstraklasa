using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Pilkarze
    {
        [Key]
        public int ID_PILKARZA { get; set; }
        public int ID_DRUZYNY { get; set; }
        public string IMIE_PILKARZA { get; set; }
        public string NAZWISKO_PILKARZA { get; set; }

        [Display(Name = "WIEK PILKARZA")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime WIEK_PILKARZA { get; set; }
        public string POZYCJA { get; set; }
        public string NARODOWOSC_PILKARZA { get; set; }

    }
}