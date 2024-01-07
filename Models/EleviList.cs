using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class EleviList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage = "Trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau Ana-Maria")]

        [StringLength(30, MinimumLength = 3)]
        
        public string Nume { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage = "Trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau Ana-Maria")]
        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Prenumele este obligatoriu.")]
        public string Prenume { get; set; }
        public ProfilEnum Profil { get; set; }
        public ClasaEnum Clasa { get; set; }
        public DateTime Date { get; internal set; }
        //public string NumeComplet => $"{Nume} {Prenume}";
        //public ICollection<Nota>? Note { get; set; }
        //public ICollection<Absenta>? Absente { get; set; }
    }
    public enum ProfilEnum
    {
        Mateinfo,
        StiinteleNaturii,
        StiinteSociale,
        Filologie
    }
    public enum ClasaEnum
    {
        IX,
        X,
        XI,
        XII
    }
}
