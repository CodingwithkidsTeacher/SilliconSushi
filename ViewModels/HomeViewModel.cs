using SilliconSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sushi> SushiOfTheDay { get; set; }
    }
}
