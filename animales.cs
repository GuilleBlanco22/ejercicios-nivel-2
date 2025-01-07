using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    internal class animales
    {
        public string Sexo { get; }
        public string Comer { get; set; }
        public string Comunicarse () {
            return "Ruido ruido...";
        }
        public string HacerNecesidades { get; set; }


    }
}
