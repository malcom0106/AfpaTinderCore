using AfpaTinderCore.Data.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Personne> GetPersonneConnexion(string login, string pwd)
        {
            try
            {
                return await _context.Personnes.Where(p => p.Login == login && p.Password == pwd).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
