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
        [Key]
        [Required]
        public string Id { get => id; }
        [Required]
        public int BrojSjedista { get => brojSjedista; }
        [NotMapped]
        public List<Sjediste> Sjedista { get => sjedista; }
        #endregion

    }
}
