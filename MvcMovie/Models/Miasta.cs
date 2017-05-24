using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Miasta
    {
        [Key]
        public int ID_MIASTA{ get; set; }
        public string NAZWA_MIASTA { get; set; }
    }

}