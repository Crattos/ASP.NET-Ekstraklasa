using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Miasto
    {
        [Key]
        public int ID{ get; set; }
        public string NAZWA_MIASTA { get; set; }
    }

}