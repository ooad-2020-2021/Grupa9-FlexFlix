using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Sjediste
    {
        #region Properties
        [Required]
        [Key]
        public string Id { get; set; }
        [Required]
        public bool JeLiSlobodno { get; set; }
        #endregion

    }
}
