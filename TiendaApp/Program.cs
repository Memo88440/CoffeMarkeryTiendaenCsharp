using System;
using TiendaApp.Modelos;
using System.Collections.Generic;

namespace TiendaApp
{
    class Program
    {
        static void ImprimirMenu(){
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Borrar Producto");
            Console.WriteLine("3. Mostrar Producto");
            Console.WriteLine("4. Vender Producto");
            Console.WriteLine("5. Listar Productos");
            Console.WriteLine("6. Salir");
        }

        static int Main(string[] args)
        {
           //vamos a crear el inventario de una tienda y permita manejar las ventas.

            //debemos crear un Menu.

            //crear Tienda

            Tienda MiTienda = new Tienda();
            MiTienda.Nombre = "Lochis";
            MiTienda.Abierto = true;

            MiTienda.Productos = new List<Producto>();

             while (true)
            {

                
                ImprimirMenu();
                string Respuesta = Console.ReadLine();

                switch (Respuesta)
                {
                    case "1":
                    

                    MiTienda.AgregarProductoPerecedero();
                    break;
                    case "2":
                    //Borrar Producto
                    Console.Write("digite el ID del Producto a Borrar: ");
                    
                    MiTienda.BorrarProducto(Int32.Parse(Console.ReadLine()));
                    break;
                    case "3":
                    //Mostrar Producto
                    Console.Write("Digite el ID del Producto a Mostrar: ");
                    
                    MiTienda.MostrarProducto(Int32.Parse(Console.ReadLine()));
                    break;
                    case "4":
                    //Vender Producto
                    //La cantidad se va disminuir y la caja va a umentar
                    Console.Write("Digite el ID del Producto a Vender: ");
                    
                    MiTienda.VenderProducto(Int32.Parse(Console.ReadLine()));
                    break;
                    case "5":
                    //Imprimir Productos
                    MiTienda.ImprimirProductos();
                    break;
                    case "6":
                    //salir
                    Console.WriteLine("Salir");
                    return 0;
                    default:
                    //imprimir el menu
                    Console.WriteLine("No esta Imprimiendo");
                    break;
                }

            }

            return 0;
        }

        
    }
}
