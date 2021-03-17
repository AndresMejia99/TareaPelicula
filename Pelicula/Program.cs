using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        String titulo;
        Int16 año;

        //Constructores
     
        //Métodos
     
        public Pelicula(string titulo, Int16 año)
            {
            Pelicula p1;
            Pelicula p2;
            } 

        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula("El señor de los anillos: el retorno del rey", 2003);
            Pelicula p2 = new Pelicula("La La Land", 2016);
            p1.Imprime();
            p2.Imprime();
        }
    }
}
