using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCore.Data.Models
{
    public class Loisir
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Nom { get; set; }

        public bool Statut { get; set; }

        public List<PersonneLoisir> PersonneLoisirs { get; set; }
    }
}
