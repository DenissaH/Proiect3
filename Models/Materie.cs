using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Materie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Numele materiei este obligatoriu.")]
        public string Nume { get; set; }
        public ICollection<MateriePredata> MateriiPredate { get; set; }
        public ICollection<Absenta>? Absente { get; set; }
        public ICollection<MedieMaterie>? MediiMaterie { get; set; }
        public ICollection<Nota>? Note { get; set; }
    }
}
