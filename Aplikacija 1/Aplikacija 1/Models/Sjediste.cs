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
        [Key]
        [Required]
        public string Id { get => id; }
        [Required]
        public bool JeLiSlobodno { get => jeLiSlobodno; set => jeLiSlobodno = value; }
        #endregion

    }
}
