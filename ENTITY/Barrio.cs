using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Barrio
    {
        public string IdBarrio { get; set; }
        public string NombreBarrio { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
