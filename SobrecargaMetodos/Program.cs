using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creacion de variable para recibir del metodo concatenar
            string nombreYApellidos;
            // instanciamos para hacer uso del metodo
            Nombres nombres = new Nombres();

            nombreYApellidos = nombres.Concatenar("Fabricio "," Dominguez", "rodriguez");

            // mostramos las cadenas ya concatenadas
            Console.WriteLine(nombreYApellidos);

            //Instanciando clase Ramdom

            Random random = new Random();

            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(10,30));
        }
    }
  class Nombres
    {
        // Metodo

        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + "" + apellidoPa;

            return nombreApellido;
        }

        public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + "" + apellidoPa  + " " + apellido2Pa;

            return nombreApellido;
        }



    }
   
}
