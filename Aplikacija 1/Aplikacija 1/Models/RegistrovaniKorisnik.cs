using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class RegistrovaniKorisnik
    {
        #region Properties
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Email { get; set; }
        public string ProfilnaFotografija { get; set; }
        [Required]
        public bool JeLiAdmin { get; set; }
        #endregion

    }
}
