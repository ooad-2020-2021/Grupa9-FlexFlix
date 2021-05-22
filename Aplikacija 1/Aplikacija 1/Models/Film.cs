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
        [Key]
        private int Id { get => Id; }
        [Required]
        public string Naziv { get => naziv; }
        [Required]
        public int Godina { get => godina; }
        [Required]
        public int Trajanje { get => trajanje; }
        [NotMapped]
        public List<Glumac> Glumci { get => glumci; }
        [NotMapped]
        public List<Reziser> Reziseri { get => reziseri; }
        [NotMapped]
        public List<TerminPrikazivanja> TerminiPrikazivanja { get => terminiPrikazivanja; set => terminiPrikazivanja = value; }
        [Required]
        public string Slika { get => slika; set => slika = value; }
        [Required]
        public string Trailer { get => trailer; }
        public List<Zanr> Zanrovi { get => zanrovi; }
        [Required]
        public double CijenaUlaznice { get => cijenaUlaznice; set => cijenaUlaznice = value; }
        public double ProsjecnaOcjena { get => prosjecnaOcjena; set => prosjecnaOcjena = value; }
        [NotMapped]
        public List<Ocjena> Ocjene { get => ocjene; set => ocjene = value; }
        [Required]
        public string Opis { get => opis; set => opis = value; }
        #endregion
    }
}
