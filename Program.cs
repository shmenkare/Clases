using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Persona
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public int Edad;
    }
    class Articulo
    {
        public int Id;
        public string Nombre;
        public float Precio;
        public int Cantidad;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Persona Cliente = new Persona();

            Cliente.Id = 1;

            Cliente.Nombre = "Orion";

            Cliente.Apellido = "Ra";

            Cliente.Edad = 35;

            Console.WriteLine("El valor del objeto es {0} ",Cliente.Id);

            Console.WriteLine("El valor del objeto es {0} ", Cliente.Nombre);

            Console.WriteLine("El valor del objeto es {0} ", Cliente.Apellido);

            Console.WriteLine("El valor del objeto es {0} ", Cliente.Edad);

            //NEW EXERCISE

            int i = 0;

            Persona Usuarios = new Persona();

            Console.WriteLine("Ingrese el numero de usuarios");
            int NumUsua = Convert.ToInt32(Console.ReadLine());

            for(i = 0; i < NumUsua; i++)
            {
                Console.WriteLine("Ingrese el id del Usuario {0} ", i);
                Usuarios.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del Usuario {0} ", i);
                Usuarios.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido Usuario {0} ", i);
                Usuarios.Apellido = Console.ReadLine();

                Console.WriteLine("Ingrese la edad del Usuario {0} ", i);
                Usuarios.Edad = Convert.ToInt32(Console.ReadLine());
            
            }
            Console.WriteLine(Usuarios.Id);

            Console.WriteLine(Usuarios.Nombre);
         
            Console.WriteLine(Usuarios.Apellido);
       
            Console.WriteLine(Usuarios.Edad);

            //NEW EXERCISE

            Articulo Producto = new Articulo();

            Producto.Id = 1;
            Producto.Nombre = "Guitarra";
            Producto.Precio = 23.5f;
            Producto.Cantidad = 15;


            Console.WriteLine(Producto.Id);

            Console.WriteLine(Producto.Nombre);

            Console.WriteLine(Producto.Precio);

            Console.WriteLine(Producto.Cantidad);

            
            Console.ReadKey();
        }

    }
}
