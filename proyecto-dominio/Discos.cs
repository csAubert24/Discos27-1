using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_dominio
{
     public class Discos
    {
        public string titulo { get; set; }  
        public int canciones { get; set; }  
        public string url { get; set; }

        public elemento Estilo { get; set; }
        public elemento formato { get; set; }
    }
}
