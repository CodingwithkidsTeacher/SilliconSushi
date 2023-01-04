using System.Collections.Generic;

namespace SilliconSushi.Models
{
    public class ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
