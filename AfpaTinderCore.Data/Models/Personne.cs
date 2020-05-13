using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCore.Data.Models
{
    public class Personne
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Saisir votre nom")]
        public string Nom { get; set; }

        [StringLength(50,ErrorMessage ="Caracteres Maxi : 50")]
        [Required]
        public string Prenom { get; set; }

        [StringLength(100)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(50)]
        [Required]
        public string Login { get; set; }
        [MaxLength(50)]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(10)]
        public string Telephone { get; set; }
        public bool Statut { get; set; }
        [Required]
        public int Age { get; set; }
        public int Enfants { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [Required]
        public bool IsGeoloc { get; set; }

        public bool IsAppliMobile { get; set; }
        public List<PersonneLoisir> PersonneLoisirs { get; set; }

        [InverseProperty("Personne")]
        public List<Favori> Favoris { get; set; }

        public Allure Allure { get; set; }
        public OrientationSexuelle OrientationSexuelle { get; set; }
        public TypeRelation TypeRelation { get; set; }
        public SituationFamiliale SituationFamiliale { get; set; }
    }
}
