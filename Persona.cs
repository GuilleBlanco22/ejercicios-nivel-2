using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_poo
{
    class Persona
    {
        public Persona() {
            edad = 29;
        }
        //ATRIBUTOS QUE LLEVA LA CLASE
        private string nombre;
        private int edad;
        private float sueldo;

        public int Edad
        {
         get {  return edad; } 
         set { edad = value; } 
            }
        
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

       

        //OTRA FORMA DE HACERLO EN C#

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        //METODOS
        public string Saludar()
        {
            return "Hola, mi nombre es " + Nombre;
        }

        public string adivinaEdad()
        {
            if (edad  == 29) {
                return "Correcto :D tengo " + edad; 
        } else {
                return "NO -.-, tengo " + edad + " años";
                    }
        }

        //SOBRECARGA DE METODO
        public string Saludar(string persona)
        {
            return "Hola " + persona + ", mi nombre es " + Nombre;
        }







    }
}