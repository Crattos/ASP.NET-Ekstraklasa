using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Spotkanie
    {
        [Key]
        public int ID_SPOTKANIA { get; set; }
        public int ID_DRUZYNY { get; set; }
        public int ID_MIASTA { get; set; }
        public int DRU_ID_DRUZYNY { get; set; }
        public int BRAMKI_D1 { get; set; }
        public int BRAMKI_D2 { get; set; }

        [Display(Name = "DATA SPOTKANIA")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DATA_SPOTKANIA { get; set; }

    }
}