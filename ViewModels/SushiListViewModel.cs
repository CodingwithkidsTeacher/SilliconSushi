using SilliconSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.ViewModels
{
    public class SushiListViewModel
    {
        public IEnumerable<Sushi> Sushis { get; set; }
        public string CurrentCategory { get; set; }
    }
}
