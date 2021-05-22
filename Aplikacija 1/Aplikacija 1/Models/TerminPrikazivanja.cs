using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class TerminPrikazivanja
    {
        #region Properties
        [Key]
        [Required]
        private string Id { get => id; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime vrijeme { get => datumIVrijeme; set => datumIVrijeme = value; }
        #endregion

    }
}
