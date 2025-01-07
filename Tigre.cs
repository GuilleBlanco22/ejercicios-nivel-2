using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    internal class Tigre: animalSalvaje, PuedeCorrer
    {
        public string correr()
        {
            return "Corre rapido";
        }
    }
}
