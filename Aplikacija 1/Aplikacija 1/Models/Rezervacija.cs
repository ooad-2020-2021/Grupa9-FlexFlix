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
        #region properties
        [Key]
        [Required]
        private string Id { get => id; }
        [Required]
        public string Korisnik { get => korisnik; }
        [Required]
        public double Cijena { get => cijena; }
        [NotMapped]
        public List<Ulaznica> Ulaznice { get => ulaznice; }
        #endregion

    }
}
