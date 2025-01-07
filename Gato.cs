using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    internal class Gato: animalDomestico, PuedeCorrer
    {
        public string correr() {
            return "Corre mucho y se cansa...";
        }

        public new string Comunicarse() {
            return "Miau miau...";
        }
    }
}
