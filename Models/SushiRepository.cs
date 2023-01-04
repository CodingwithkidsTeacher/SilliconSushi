using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public class SushiRepository: ISushiRepository
    {
        private readonly ApplicationDbContext _db;

        public SushiRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Sushi> AllSushi
        {
            get
            {
                return _db.Sushis.Where(s => s.InStock == true);
            }
        }

        public IEnumerable<Sushi> TopSushi
        {
            get
            {
                return _db.Sushis.Where(s => s.SushiOfTheDay);
            }
        }

        public Sushi getSushiById(int sushiId)
        {
            return _db.Sushis.FirstOrDefault(s => s.SushiId == sushiId);
        }
    }
}
