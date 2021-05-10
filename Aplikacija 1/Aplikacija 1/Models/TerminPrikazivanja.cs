using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_1.Models
{
    public class TerminPrikazivanja
    {
        #region Properties
        [Key]
        [Required]
        public string Id { get => id; }
        [Required]
        public DanUSedmici Dan { get => dan; set => dan = value; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DatumIVrijeme { get => datumIVrijeme; set => datumIVrijeme = value; }
        #endregion

    }
}
