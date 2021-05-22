using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Rezervacija
    {
        #region Properties
        [Required]
        [Key]
        public string Id { get; set; }
        [Required]
        public string Korisnik { get; set; }
        [Required]
        public double Cijena { get; set; }
        [NotMapped]
        public List<Ulaznica> Ulaznice { get; set; }
        #endregion

    }
}
