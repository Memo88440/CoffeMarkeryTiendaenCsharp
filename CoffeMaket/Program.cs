using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeMaket
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var wq = new Worked();

            wq.AguaOlla();
            wq.OllaEstufa();
            wq.PrenderEstufa();
            //HervirAgua();
            //Thread th = new Thread(Worked.HervirAgua);
            var hv = wq.HervirAgua();
            
            wq.TazasMesa();
            wq.CafeTazas();
            wq.AzucarTazas();
            Console.WriteLine(await hv);
            wq.AguaTazas();

            Console.WriteLine("Cafe Listo");

        }
    }

    public class Worked{

        // 1. Poner agua en la olla.
        // 2. Poner la olla en la estufa.
        // 3. Prender la estufa.
        // 4. Hervir el agua.
        // 5. Poner tazas en la mesa.
        // 6. Poner cafe en las tazas.
        // 7. Poner azucar en las tazas.
        // 8. Poner agua en las tazas.

        public void AguaOlla(){
            
            Console.WriteLine("Poner agua en la olla");
        }

        public void OllaEstufa(){
            Console.WriteLine("Poner la olla en la estufa");
        }

        public void PrenderEstufa(){
            Console.WriteLine("Preder la estufa");
        }

        public Task<string> HervirAgua(){

            Console.WriteLine("Hervir el agua");

            Task.Delay(15000);

            //Console.WriteLine("Lista el agua");

            return Task.FromResult<string>("Lista el agua");
            
        }

        public void TazasMesa(){
            Console.WriteLine("Poner tazas en la mesa");
        }

        public void CafeTazas(){
            Console.WriteLine("Poner cafe enlas tazas");
        }

        public void AzucarTazas(){
            Console.WriteLine("Poner azucar en las tazas");
        }

        public void AguaTazas(){
            Console.WriteLine("Poner agua en las tazas");
        }
    }
}
