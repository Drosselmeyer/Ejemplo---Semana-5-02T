using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Alumno
    {
        //Programar las propiedades de forma privada
        private string Carnet;
        private string Nombre;
        private string Direccion;
        private int NIE;

        //Constructor por defecto
        public Alumno()
        {
            this.Carnet = "";
            this.Nombre = "";
            this.Direccion = "";
            this.NIE = 0;
        }

        public Alumno(string carnet, string nombre, string direccion, int nie)
        {
            this.Carnet = carnet;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.NIE = nie;
        }

        //Setter y Getters de las propiedades
        public void setCarnet(string carnet)
        {
            this.Carnet = carnet;
        }

        public string getCarnet()
        {
            return this.Carnet;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

        public void setDireccion(string direccion)
        {
            this.Direccion = direccion;
        }

        public string getDireccion()
        {
            return this.Direccion;
        }

        public void setNIE(int nie)
        {
            this.NIE = nie;
        }

        public int getNIE()
        {
            return this.NIE;
        }

        //Metodos programados
        public void entregarTareas()
        { 
            Console.WriteLine("El alumno "+ this.Nombre + " ha entregado la tarea");
        }

        public void realizarExamen()
        {
            Console.WriteLine("El alumno " + this.Nombre + " ha realizado el examen");
        }

        public void registrar()
        {
            Console.WriteLine("Se registraron los datos");
        }
    }
}
