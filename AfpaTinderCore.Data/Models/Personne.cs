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
        public string Nom { get; set; }
        public List<PersonneLoisir> PersonneLoisirs { get; set; }

        [InverseProperty("Personne")]
        public List<Favori> Favoris { get; set; }

        public Allure Allure { get; set; }
        public OrientationSexuelle OrientationSexuelle { get; set; }
        public TypeRelation TypeRelation { get; set; }
        public SituationFamiliale SituationFamiliale { get; set; }
    }
}
