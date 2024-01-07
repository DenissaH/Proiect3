using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Nota
    {
        public int Id { get; set; }
        [Range(1, 10, ErrorMessage = "Nota trebuie să fie între 1 și 10!")]
        public int ValoareNota { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNota { get; set; }
        public int? ElevId { get; set; }
        public EleviList? Elev { get; set; }
        public int? MaterieId { get; set; }
        public Materie? Materie { get; set; }

    }
}
