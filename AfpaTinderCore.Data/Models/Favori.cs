using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCore.Data.Models
{
    public class Favori
    {
        public int Id { get; set; }
        public int PersonneId { get; set; }
        [ForeignKey("PersonneId")]
        public Personne Personne { get; set; }
        public Personne FavoriPersonne { get; set; }
    }
}
