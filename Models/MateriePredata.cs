using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class MateriePredata
    {
        public int Id { get; set; }
        public int? ProfesorId { get; set; }
        public Profesor? Profesor { get; set; }
        public int? MaterieId { get; set; }
        public Materie? Materie { get; set; }

    }
}
