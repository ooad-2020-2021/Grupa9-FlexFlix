using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Ocjena
    {
        #region Properties
        [Key]
        [Required]
        public int Id { get => id;  }
        [Required]
        public int FilmId { get => filmId; }
        [Required]
        public int OcjenaVrijednost { get => ocjenaVrijednost; }
        public string Komentar { get => komentar; set => komentar = value; }
        #endregion
    }
}
