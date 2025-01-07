using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    class Botella
    {
        public Botella(string color, string material)//crear un costructor
        {
            this.color = color;//el color que entra por parametro se pone en color de la botella
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        //sobrecargar el costructor
        public Botella() { }

        //DATOS del objeto
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

       public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material 
        {  
            get { return material; } 
        }
      
        //METODOS
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual; //regla de 3 simples
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
    }
}
