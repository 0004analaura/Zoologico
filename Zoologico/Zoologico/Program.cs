using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool abandonar = false;

            do
            {
                Console.WriteLine("0. Abandonar");
                Console.WriteLine("1. Visitar al Leon");
                Console.WriteLine("2. Visitar al Elefante");
                Console.WriteLine("3. Visitar a la Jirafa");
                Console.WriteLine("4. Visitar al Tigre");
                Console.WriteLine("5, Visitar al Mono");
                Console.WriteLine("6. Visitar al oso");
                Console.WriteLine("7. Visitar al Cocodrilo");
                Console.WriteLine("8. Visitar a la serpiente");
                Console.WriteLine("9. Visitar al Pingüino");
                Console.WriteLine("10. Visitar al Lobo");
                Console.WriteLine("11. Visitar a la Cebra");
                Console.WriteLine("12. Visitar al Rinoceronte");
                Console.WriteLine("13. Visitar al Panda");
                Console.WriteLine("14. Visitar al Pavo Real");
                Console.WriteLine("15. Visitar a la Tortuga");

                Console.WriteLine("Elige una opcion");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0: abandonar = true; break;
                    case 1: Visitas.visitarLeon(); break;
                    case 2: Visitas.visitarElefante(); break;
                    case 3: Visitas.visitarJirafa(); break;
                    case 4: Visitas.visitarTigre(); break;
                    case 5: Visitas.visitarMono(); break;
                    case 6: Visitas.visitarOso(); break;
                    case 7: Visitas.visitarCocodrilo(); break;
                    case 8: Visitas.visitarSerpiente(); break;
                    case 9: Visitas.visitarPingüino(); break;
                    case 10: Visitas.visitarLobo(); break;
                    case 11: Visitas.visitarCebra(); break;
                    case 12: Visitas.visitarRinoceronte(); break;
                    case 13: Visitas.visitarPanda(); break;
                    case 14: Visitas.visitarPavoReal(); break;
                    case 15: Visitas.visitarTortuga(); break;
                }

                Console.ReadKey();
                Console.Clear();
            

            } while (!abandonar);

            Console.ReadKey(true);
        }
    }
}
