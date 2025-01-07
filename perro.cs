using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    internal class perro: animalDomestico, PuedeCorrer
    {
        private string nombre;
        private string color;
        private int edad;

        public string correr() {
            return "Corre y corre";
                }
        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


    }
}
