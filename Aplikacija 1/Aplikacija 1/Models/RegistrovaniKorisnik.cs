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
        [Key]
        private int Id { get => id; }
        [Required]
        public string Username { get => username; set => username = value; }
        [Required]
        public string Password { get => password; set => password = value; }
        [Required]
        public string Ime { get => ime; set => ime = value; }
        [Required]
        public string Prezime { get => prezime; set => prezime = value; }
        [Required]
        public string Email { get => email; set => email = value; }
        public string ProfilnaFotografija { get => profilnaFotografija; set => profilnaFotografija = value; }
        [Required]
        public bool JeLiAdmin { get => jeLiAdmin; set => jeLiAdmin = value; }
        #endregion

    }
}
