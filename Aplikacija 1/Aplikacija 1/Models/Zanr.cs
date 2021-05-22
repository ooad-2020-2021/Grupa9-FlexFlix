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
        [Key]
        [Required]
        public int Id { get => id; }
        [Required]
        public string ZanrTip { get => zanrTip; }
        #endregion
    }
}
