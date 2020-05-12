using AfpaTinderCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCore.Data
{
    public class DataPersonne
    {
        private readonly ApplicationDbContext _context;

        public DataPersonne(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public List<Personne> GetPersonnes()
        {
            return (_context.Personnes.ToList());
        }
    }
}
