using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    internal class Visitas
    {
       public static void visitarLeon()
        {
            Leon leon = new Leon("Mario", "Macho");
            Console.WriteLine("Esta es la jaula de {0}", leon);
            leon.sonar();
            leon.comer();
            leon.mover();

        }


        public static void visitarJirafa()
        {
            Jirafa jirafa = new Jirafa("Elsa", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", jirafa);
            jirafa.sonar();
            jirafa.comer();
            jirafa.mover();

        }

        public static void visitarElefante()
        {
            Elefante elefante = new Elefante("Ricardo", "Macho");
            Console.WriteLine("Esta es la jaula de {0}", elefante);
            elefante.sonar();
            elefante.comer();
            elefante.mover();

        }

        public static void visitarTigre()
        {
            Tigre tigre = new Tigre("Mario", "Macho");
            Console.WriteLine("Esta es la jaula de {0}", tigre);
            tigre.sonar();
            tigre.comer();
            tigre.mover();

        }

        public static void visitarMono()
        {
            Mono mono = new Mono("Jorge", "Macho");
            Console.WriteLine("Esta es la jaula de {0}", mono);
            mono.sonar();
            mono.comer();
            mono.mover();

        }

        public static void visitarOso()
        {
            Oso oso = new Oso("Karla", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", oso);
            oso.sonar();
            oso.comer();
            oso.mover();

        }

        public static void visitarCocodrilo()
        {
            Cocodrilo cocodrilo = new Cocodrilo("Marta", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", cocodrilo);
            cocodrilo.sonar();
            cocodrilo.comer();
            cocodrilo.mover();

        }

        public static void visitarSerpiente()
        {
            Serpiente serpiente = new Serpiente("Sarita", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", serpiente);
            serpiente.sonar();
            serpiente.comer();
            serpiente.mover();

        }

        public static void visitarPingüino()
        {
            Pingüino pingüino = new Pingüino("Leonardo", "Macho");
            Console.WriteLine("Esta es la jaula de {0}", pingüino);
            pingüino.sonar();
            pingüino.comer();
            pingüino.mover();

        }

        public static void visitarLobo()
        {
            Lobo lobo = new Lobo("Mario", "Macho");
            Console.WriteLine("Esta es la jaula de {0}", lobo);
            lobo.sonar();
            lobo.comer();
            lobo.mover();

        }

        public static void visitarCebra()
        {
            Cebra cebra = new Cebra("Doris", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", cebra);
            cebra.sonar();
            cebra.comer();
            cebra.mover();

        }

        public static void visitarRinoceronte()
        {
            Rinoceronte rinoceronte = new Rinoceronte("Gloria", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", rinoceronte);
            rinoceronte.sonar();
            rinoceronte.comer();
            rinoceronte.mover();

        }

        public static void visitarPanda()
        {
            Panda panda = new Panda("Alexa", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", panda);
            panda.sonar();
            panda.comer();
            panda.mover();

        }

        public static void visitarPavoReal()
        {
            PavoReal pavoReal = new PavoReal("Dominik", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", pavoReal);
            pavoReal.sonar();
            pavoReal.comer();
            pavoReal.mover();

        }
        public static void visitarTortuga()
        {
            Tortuga tortuga = new Tortuga("Tuti", "Hembra");
            Console.WriteLine("Esta es la jaula de {0}", tortuga);
            tortuga.sonar();
            tortuga.comer();
            tortuga.mover();

        }
    }

}
