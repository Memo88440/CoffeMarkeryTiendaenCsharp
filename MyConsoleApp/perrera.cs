using System;
using System.Collections.Generic;
using Boomlabs.MyConsoleApp.Animales;

namespace Boomlabs.MyConsoleApp.Edificios{

    class perrera{

     public List<perrito> perritos {get; set;}

        public void BanarPerritos(){
            foreach (var perros in perritos)
            {
            Console.WriteLine($"Banando   {perros.Nombre}");
            }
        }
    }
}