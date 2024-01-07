using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class MedieMaterie
    {
        public int Id { get; set; }
        public int? ElevId { get; set; }
        [ForeignKey("ElevId")]
        public EleviList? Elev { get; set; }
        public int? MaterieId { get; set; }
        [ForeignKey("MaterieId")]
        public Materie? Materie { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Medie { get; set; }
    }
}
