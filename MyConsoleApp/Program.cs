using System;
using Boomlabs.MyConsoleApp.Animales;
using Boomlabs.MyConsoleApp.Edificios;
using Boomlabs.MyConsoleApp.Cuidador;
using System.Collections.Generic;

namespace Boomlabs.MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            perrito P = new perrito();
            P.Nombre = "Lucas";
            P.Patas = 3;

            perrera catdog = new perrera();
            catdog.perritos = new List<perrito>();
            catdog.perritos.Add(P);

            catdog.BanarPerritos();

            cuidador.Saludar();

            Console.WriteLine($"Lucas Tiene: {P.Patas} patas {P.Ojos} ojos");
        }
    }
}
