using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Absenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Data absentei este obligatorie.")]
        [DataType(DataType.Date)]
        public DateTime DataAbsentei { get; set; }
        [Required(ErrorMessage = "Statusul absentei este obligatoriu.")]
        public StatusAbsentaEnum StatusAbsenta { get; set; }
        public int? ElevId { get; set; }
        public EleviList? Elev { get; set; }
        public int? MaterieId { get; set; }
        public Materie? Materie { get; set; }
    }
    public enum StatusAbsentaEnum
    {
        Motivat,
        Nemotivat
    }
}
