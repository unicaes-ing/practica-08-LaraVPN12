using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Práctica_8_2
    {
        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private double precio;

            public void setCantidad(int cantidad)
            {
                if (cantidad>0)
                {
                    this.cantidad = cantidad;
                }
            }
            public int getCantidad()
            {
                return cantidad;
            }

            public void setPrecio(double precio)
            {
                if (precio>0)
                {
                    this.precio = precio;
                }
            }
            public double getPrecio()
            {
                return precio +(precio*0.13);
            }
        }
        static void Main(string[] args)
        {
            
            int cant;
            Producto[] Compras;
            Console.WriteLine("Ingrese la cantidad de productos a comprar");
            cant = Convert.ToInt32(Console.ReadLine());
            Compras = new Producto[cant];
            for (int i = 0; i < Compras.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto N°{0}:",i+1);
                Compras[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad N°{0}:",i+1);
                Compras[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Ingrese el precio del producto N°{0}",i+1);
                Compras[i].setPrecio(Convert.ToDouble(Console.ReadLine()));
            }
            Console.Clear();
            foreach (Producto product in Compras)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Nombre\tCantidad\tPrecio+Iva");
                Console.WriteLine("{0}\t{1}\t{2:C2}",
                    product.nombre,
                    product.getCantidad(),
                    product.getPrecio());
            }
            Console.ReadKey();


        }
    }
}
