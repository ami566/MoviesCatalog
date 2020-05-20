using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    // The class defines the different columns for the table Studios.
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
