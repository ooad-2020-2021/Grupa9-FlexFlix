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
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public int OcjenaVrijednost { get; set; }
        public string Komentar { get; set; }
        #endregion
    }
}
