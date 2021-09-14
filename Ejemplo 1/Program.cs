using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos la primera instancia
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno("AG123456","Juan", "Soyapango",12345);


            Console.WriteLine("Ingrese el nombre del primer alumno");
            //Leyendo lo que deseo guardar y almacenar
            alumno1.setNombre(Console.ReadLine());
            Console.WriteLine("Ingrese la direccion del primer alumno");
            alumno1.setDireccion(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Ingrese el nombre del segundo alumno");
            //Leyendo lo que deseo guardar y almacenar
            alumno2.setNombre(Console.ReadLine());
            Console.WriteLine("Ingrese la direccion del segundo alumno");
            alumno2.setDireccion(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            //Imprimimos
            Console.Write("El primer alumno se llama: ");
            //Estoy mostrando la propiedad Nombre
            Console.WriteLine(alumno1.getNombre());
            Console.WriteLine(alumno1.getDireccion());

            Console.Write("El segundo alumno se llama: ");
            //Estoy mostrando la propiedad Nombre
            Console.WriteLine(alumno2.getNombre());
            Console.WriteLine(alumno2.getDireccion());

            Console.WriteLine("-----------------------------------");
            alumno1.realizarExamen();
            alumno2.entregarTareas();
            Console.ReadKey();
        }
    }
}
