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
        [Key]
        [Required]
        private string Id { get => id; }
        [Required]
        public string Film { get => film; }
        [Required]
        public double Cijena { get => cijena; }
        [Required]
        public string DvoranaId { get => dvoranaId; }
        [Required]
        public string SjedisteId { get => sjedisteId; }
        [Required]
        public TerminPrikazivanja Termin { get => termin; }
        #endregion

    }
}
