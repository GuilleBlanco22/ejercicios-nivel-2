using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ej_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            Canario c1 = new Canario();
            Tigre t1 = new Tigre();
            Aguila  a1 = new Aguila();
            Tiburon tib = new Tiburon();
            Conejo con1 = new Conejo();


            Console.WriteLine(g1.Comunicarse());
            Console.WriteLine(c1.Comunicarse());
            Console.WriteLine(tib.nada());
            Console.WriteLine(con1.Comer());

            














































          
           /*Persona per1 = new Persona("Pepe"); //ACA CREO UNA VARIABLE DE TIPO "PERSONA"
           
           per1.setNombre("Pepe"); //LE CARGO UN NOMBRE A ESA VARIABLE
           Console.WriteLine(per1.Saludar());//MUESTRO EL NOMBRE
           Console.WriteLine("Adivina cuantos años tengo :p");
           int.Parse(Console.ReadLine());
           Console.WriteLine(per1.adivinaEdad());*/

            /*per1.Edad = 30;

             Console.WriteLine("la edad es " + per1.Edad);

             p1.Nombre = "guille";

             Console.WriteLine("El nombre es " + per1.Nombre);*/
            /* EJEMPLO PERRO
             perro p1 = new perro();
             p1.Edad = 7;
             Console.WriteLine("edad: " + p1.Edad);
             p1.Nombre = "Pin";
             Console.WriteLine("Nombre: " + p1.Nombre);
             Console.WriteLine("Ingrese el color del perro");
             p1.Color = Console.ReadLine();
             Console.WriteLine("Color: " + p1.Color);


             perro p2 = new perro();
             Console.WriteLine("ingrese la edad");
             p2.Edad = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese color");
             p2.Color = Console.ReadLine();
             Console.WriteLine("ingrese nombre");
             p2.Nombre = Console.ReadLine(); 



             Console.WriteLine("edad: " + p2.Edad);
             Console.WriteLine("color: " + p2.Color);
             Console.WriteLine("Nombre: " + p2.Nombre);*/

            /*Persona per2 = new Persona();   EJEMPLO PERSONA 2
             per2.Nombre = "Ivanna";
             Console.WriteLine("Nombre: " + per2.Nombre);
             Console.WriteLine("cuantos años tiene?");
             per2.Edad = int.Parse(Console.ReadLine());
             Console.WriteLine("Ivanna tiene " + per2.Edad + " años");*/



            //EJEMPLO BOTELLA
            /*
            Botella b1 = new Botella("Rojo", "Plastico");
           

            Console.WriteLine("capacidad de la botella " + b1.Capacidad);
            Console.WriteLine("la cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("luego de recargar, la cantidad actual es: " + b1.CantidadActual);*/

            
        }
    }
}
