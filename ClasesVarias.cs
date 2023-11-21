using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    internal class Persona
    {
        private int Id;
        private string Nombre;
        private string Apellido;
        private int Edad;

        //METODO CONSTRUCTOR

        public Persona(int Id, string Nombre, string Apellido, int Edad)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
        
        }
       
        public void ImprimeArtibutos()
        {
            Console.WriteLine("El valor de Id es {0} ", Id);

            Console.WriteLine("El Nombre es {0} ", Nombre);

            Console.WriteLine("El Apellido es {0} ", Apellido);

            Console.WriteLine("La Edad es {0} ", Edad);

        }
    }
    
    class Articulo
    {
        public int Id;
        public string Nombre;
        public float Precio;
        public int Cantidad;

        public static void Mensaje()
        {
            Console.WriteLine("Articulo en oferta");
        }

        public static void IntentarModificarValor(int ivalor)
        {
            int n = 5;
            ivalor = 10 + n;
        }
        public static void IntentarModificarValor1(ref int ivalor)
        {
            int n = 5;
            ivalor = 10 + n;
        }
    }

    struct Cuadrado
    {
        public int ancho;
        public int largo;

        public Cuadrado(int ancho, int largo) 
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        public int Area()
        {
            int res;
            res = ancho * largo;
            return res;
        
        }

    
    
    }
}
