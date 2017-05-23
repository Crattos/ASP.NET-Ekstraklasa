using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Trener
    {
        [Key]
        public int ID_TRENERA { get; set; }
        public int ID_DRUZYNY { get; set; }
        public string IMIE_TRENERA { get; set; }
        public string NAZWISKO_TRENERA { get; set; }

        [Display(Name = "WIEK TRENERA")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime WIEK_TRENERA { get; set; }
        public string NARODOWOSC_TRENERA { get; set; }

    }
}