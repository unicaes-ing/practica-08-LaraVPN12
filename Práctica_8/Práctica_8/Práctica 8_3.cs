using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Práctica_8_3
    {
        public struct Materia
        {
            public string nombre;
            private double nota;

            public void setNota(double nota)
            {
                if (nota >= 0 && nota <= 10)
                {
                    this.nota = nota;
                }
               
            }
            public double getNota()
            {
                return nota;
            }
            public string Resultado(double nota)
            {
                if (nota>=7 && nota<=10)
                {
                    string A = "APROBADO";
                    return A;
                }
                else
                {
                    string R= "REPROBADO";
                    return R;
                }
            }
        }

        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;
        }
        static void Main(string[] args)
        {
            Materia asignatura = new Materia();
            int cant;
            Alumno[] arreglo;
            Console.WriteLine("Ingrese la cantidad de estudiantes");
            cant=Convert.ToInt32(Console.ReadLine());
            arreglo= new Alumno[cant];
            for (int i = 0; i < arreglo.Length; i++)
			{
                 Console.WriteLine("Nombre:");
                 arreglo[i].nombre = Console.ReadLine();
                 Console.WriteLine("Carnet");
                 arreglo[i].carnet = Console.ReadLine();
                 Console.WriteLine("Carrera:");
                 arreglo[i].carrera = Console.ReadLine();
                 Console.WriteLine("Ingrese nombre de la Materia N° 1");
                 arreglo[i].materia1.nombre = Console.ReadLine();
                 Console.WriteLine("Ingres nota de la Materia N°1");
                 arreglo[i].materia1.setNota(Convert.ToDouble(Console.ReadLine()));
                 Console.WriteLine("Ingrese nombre de la Materia N° 2");
                 arreglo[i].materia2.nombre = Console.ReadLine();
                 Console.WriteLine("Ingres nota de la Materia N°2");
                 arreglo[i].materia2.setNota(Convert.ToDouble(Console.ReadLine()));
                 Console.WriteLine("Ingrese nombre de la Materia N° 3");
                 arreglo[i].materia3.nombre = Console.ReadLine();
                 Console.WriteLine("Ingres nota de la Materia N°3");
                 arreglo[i].materia3.setNota(Convert.ToDouble(Console.ReadLine()));
                 Console.WriteLine("Ingrese nombre de la Materia N° 4");
                 arreglo[i].materia4.nombre = Console.ReadLine();
                 Console.WriteLine("Ingres nota de la Materia N°4");
                 arreglo[i].materia4.setNota(Convert.ToDouble(Console.ReadLine()));
                
                
			}
            Console.Clear();
            foreach (Alumno collection in arreglo)
            {
                Console.WriteLine("Nombre: {0}", collection.nombre);
                Console.WriteLine("Carnet; {0}", collection.carnet);
                Console.WriteLine("Carrera: {0}",collection.carrera);
                Console.WriteLine("==============================================");
                Console.WriteLine("{0}\t{1}\t{2}", collection.materia1.nombre, collection.materia1.getNota(), asignatura.Resultado(collection.materia1.getNota()));
                Console.WriteLine("{0}\t{1}\t{2}", collection.materia2.nombre, collection.materia2.getNota(), asignatura.Resultado(collection.materia2.getNota()));
                Console.WriteLine("{0}\t{1}\t{2}", collection.materia3.nombre, collection.materia3.getNota(), asignatura.Resultado(collection.materia3.getNota()));
                Console.WriteLine("{0}\t{1}\t{2}", collection.materia4.nombre, collection.materia4.getNota(), asignatura.Resultado(collection.materia2.getNota()));
            }
            Console.ReadKey();
        }
    }
}
