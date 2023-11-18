using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
     class Program
    {
        static void Main(string[] args)
        {
            //OBJETO INSTANCIADO CON EL CONSTRUCTOR Y ATRUBUTOS PRIVADOS
            
            Persona Cliente = new Persona(1, "Orion", "Ra", 35);

            Cliente.ImprimeArtibutos();

            //Para hacerlo de la forma que esta abajo hay que colocar las los atributos de la clase como publicos

            //OBJETO INSTANCIADO SIN CONSTRUCTOR Y ATRUBUTOS PUCLICOS

            Articulo Producto = new Articulo();

            Producto.Id = 1;
            Producto.Nombre = "Guitarra";
            Producto.Precio = 23.5f;
            Producto.Cantidad = 15;

            Console.WriteLine(Producto.Id);

            Console.WriteLine(Producto.Nombre);

            Console.WriteLine(Producto.Precio);

            Console.WriteLine(Producto.Cantidad);

            Articulo.Mensaje();

           //PASO POR VALOR Y POR REFERENCIA
  
            int num;
            num = 99;
            Articulo.IntentarModificarValor(num);
            Console.WriteLine(num);

            Articulo.IntentarModificarValor1(ref num);
            Console.WriteLine(num);

            //ESTRUCTURA CREADA CON LA PALABRA CLAVE new

            Cuadrado rectanculo = new Cuadrado(6,3);

            Console.WriteLine("El area del rectangulo es {0}", rectanculo.Area());

            //ESTRUCTURA CREADA SIN LA PALABRA CLAVE new

            Cuadrado rombo;

            rombo.ancho = 20;
            rombo.largo = 3;
            Console.WriteLine("El area del rombo es {0}", rombo.Area());


            //NEW EXERCISE


            //int i = 0;

            // Usuarios = new Persona();

            //Console.WriteLine("Ingrese el numero de usuarios");
            //int NumUsua = Convert.ToInt32(Console.ReadLine());

            //for(i = 0; i < NumUsua; i++)
            //{
            //    Console.WriteLine("Ingrese el id del Usuario {0} ", i);
            //    Usuarios.Id = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Ingrese el nombre del Usuario {0} ", i);
            //    Usuarios.Nombre = Console.ReadLine();

            //    Console.WriteLine("Ingrese el apellido Usuario {0} ", i);
            //    Usuarios.Apellido = Console.ReadLine();

            //    Console.WriteLine("Ingrese la edad del Usuario {0} ", i);
            //    Usuarios.Edad = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine(Usuarios.Id);

            //Console.WriteLine(Usuarios.Nombre);

            //Console.WriteLine(Usuarios.Apellido);

            //Console.WriteLine(Usuarios.Edad);
            
            Console.ReadKey();
        }

    }
}
