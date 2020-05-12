using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCore.Data.Models
{
    public class PersonneLoisir
    {
        public int LoisirId { get; set; }
        public Loisir Loisir { get; set; }
        public int PersonneId { get; set; }
        public Personne Personne { get; set; }
    }
}
