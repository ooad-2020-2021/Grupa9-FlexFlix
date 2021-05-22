using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Osoba
    {
        #region Properties
        [Key]
        [Required]
        private int Id { get => id; }
        [Required]
        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }
        #endregion
    }
}
