using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public interface ISushiRepository
    {
        IEnumerable<Sushi> AllSushi { get; }
        IEnumerable<Sushi> TopSushi { get; }

        Sushi getSushiById(int num);
    }
}
