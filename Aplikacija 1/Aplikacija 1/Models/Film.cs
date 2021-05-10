using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Film
    {
        #region Properties
        [Key]
        [Required]
        public string Naziv { get => naziv; }
        [Required]
        public int Godina { get => godina; }
        [Required]
        public int Trajanje { get => trajanje; }
        [NotMapped]
        public List<string> Glumci { get => glumci; }
        [NotMapped]
        public List<string> Reziseri { get => reziseri; }
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
        public List<int> Ocjene { get => ocjene; set => ocjene = value; }
        [Required]
        public string Opis { get => opis; set => opis = value; }
        [NotMapped]
        public List<string> Komentari { get => komentari; set => komentari = value; }
        #endregion
    }
}
