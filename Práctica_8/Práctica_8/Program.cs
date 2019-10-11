using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Program
    {
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;

            public void setCum(double cum)
            {
                if (cum>=0 && cum<=10)
                {
                    this.cum = cum;
                }
            }

            public double getCum()
            {
                return cum;
            }
        }
        static void Main(string[] args)
        {
            Estudiante estudiantes = new Estudiante();
            Console.WriteLine("Ingrese Carnet:");
            estudiantes.carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre:");
            estudiantes.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la carrera del estudiante");
            estudiantes.carrera = Console.ReadLine();
            Console.WriteLine("Ingrese el CUM del estudiante");
            estudiantes.setCum(Convert.ToDouble(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Nombre: {0}\nCarnet: {1}\nCarrera: {2}\nCUM: {3}",
                estudiantes.nombre,
                estudiantes.carnet,
                estudiantes.carrera,
                estudiantes.getCum());
            Console.ReadKey();

        }
    }
}
