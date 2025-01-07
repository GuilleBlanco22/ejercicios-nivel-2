using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    internal class Aguila : animalSalvaje, PuedeVolar
    {
        public string volar()
        {
            return "Vuela lejos...";
        }
    
    }
}
