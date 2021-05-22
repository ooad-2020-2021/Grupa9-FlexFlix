using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Film
    {
        #region Properties
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public int Godina { get; set; }
        [Required]
        public int Trajanje { get; set; }
        [NotMapped]
        public List<Osoba> Glumci { get; set; }
        [NotMapped]
        public List<Osoba> Reziseri { get; set; }
        [NotMapped]
        public List<TerminPrikazivanja> TerminiPrikazivanja { get; set; }
        [Required]
        public string Slika { get; set; }
        [Required]
        public string Trailer { get; set; }
        public List<Zanr> Zanrovi { get; set; }
        [Required]
        public double CijenaUlaznice { get; set; }
        public double ProsjecnaOcjena { get; set; }
        [NotMapped]
        public List<Ocjena> Ocjene { get; set; }
        [Required]
        public string Opis { get; set; }
        #endregion
    }
}
