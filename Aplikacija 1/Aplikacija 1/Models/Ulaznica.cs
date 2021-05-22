using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class Ulaznica
    {
        #region Properties
        [Required]
        [Key]
        public string Id { get; set; }
        [Required]
        public string Film { get; set; }
        [Required]
        public double Cijena { get; set; }
        [Required]
        public string DvoranaId { get; set; }
        [Required]
        public string SjedisteId { get; set; }
        [Required]
        public TerminPrikazivanja Termin { get; set; }
        #endregion

    }
}
