using System;
using System.Collections.Generic;
using TiendaApp.Modelos;
using TiendaApp.Modelos.Productos;
using TiendaApp.Models;

namespace TiendaApp.Modelos{

    public class Tienda{

        public string Nombre { get; set; }
        public bool Abierto { get; set; }

        private float Caja {get; set;}

        public List<Producto> Productos {get; set;}

        public void AgregarProductoPerecedero(){

            //Agregar Producto
            Perecedero p = new Perecedero();

            p.FechaDeVencimiento = new DateTime(2022, 01, 01);

            Perecedero p2 = new Perecedero(new DateTime(2022, 01, 01));

            Prestobarba pr = new Prestobarba();
            
            Producto p3 = p2;


            Console.Write("ID: ");
            p.ID = Int32.Parse(Console.ReadLine());

            Console.Write("Titulo: ");
            p.Titulo = Console.ReadLine();

            Console.Write("Restantes: ");
            p.Restantes = Int32.Parse(Console.ReadLine());

            Console.Write("Precio: ");
            p.Precio = float.Parse(Console.ReadLine());

            this.Productos.Add(p);
            

        }

        public void BorrarProducto(int id){
            Producto p = this.Productos.Find(c=>c.ID==id);
            if (p == null)
            {
                Console.WriteLine($"El Producto no {id} no esta");
            }

            this.Productos.Remove(p);
            Console.WriteLine($"El Producto ha sido Eliminado");
        }

        public void MostrarProducto(int id){

            Producto p = this.Productos.Find(c=>c.ID==id);
            if (p != null)
            {
            Console.WriteLine($"\n\nID: {p.ID}\n Titulo: {p.Titulo}\n Restantes: {p.Restantes}\n Precio: {p.Precio} \n\n");
            }
            else
            {
                Console.WriteLine($"No existe el ID {id}");
            }
        }

        public void VenderProducto(int id){
            //La cantidad se va disminuir y la caja va a umentar, se recibe un ID
            Producto p = this.Productos.Find(c=>c.ID==id);

            this.Productos.Remove(p);
            p.Restantes --;

            this.Productos.Add(p);
            this.Caja += p.Precio;

            Console.WriteLine($"El Caja hay {this.Caja} en Efectivo");


        }
        
        public void ImprimirProductos(){
            foreach (var p in this.Productos)
            {
                Console.WriteLine($"\n\nID: {p.ID}\n Titulo: {p.Titulo}\n Restantes: {p.Restantes}\n Precio: {p.Precio} \n\n");
            }

        }
    }
}