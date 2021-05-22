using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Dvorana
    {
        #region Properties
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int BrojSjedista { get; set; }
        [NotMapped]
        public List<Sjediste> Sjedista { get; set; }
        #endregion

    }
}
