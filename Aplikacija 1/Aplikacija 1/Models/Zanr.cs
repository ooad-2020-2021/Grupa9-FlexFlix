using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Zanr
    {
        #region Properties
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string ZanrTip { get; set; }
        #endregion
    }
}
