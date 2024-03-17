using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Leon
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Leon";

        public Leon(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }
        public Leon(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void  mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Carne");
        }
        
        public void sonar()
        {
            Console.WriteLine("BARRITO");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie; 
        }
    }
    class Elefante
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Elefante";

        public Elefante(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }
        public Elefante(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come hierbas");
        }

        public void sonar()
        {
            Console.WriteLine("Raaa");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Jirafa
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Jirafa";

        public Jirafa(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Jirafa(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Hojas");
        }

        public void sonar()
        {
            Console.WriteLine("Zumbaa");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Tigre
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Tigre";

        public Tigre(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Tigre(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Carne");
        }

        public void sonar()
        {
            Console.WriteLine("GRRRRRRR");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Mono
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Mono";

        public Mono(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Mono(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Banano");
        }

        public void sonar()
        {
            Console.WriteLine("AHHHAHH");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Oso
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Oso";

        public Oso(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }
        public Oso(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Carne");
        }

        public void sonar()
        {
            Console.WriteLine("Gjjjjj");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Cocodrilo
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Cocodrilo";

        public Cocodrilo(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Cocodrilo(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Carne");
        }

        public void sonar()
        {
            Console.WriteLine("SISEO");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }
    class Serpiente
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Serpiente";
        public Serpiente(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }
        public Serpiente(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come ratones");
        }

        public void sonar()
        {
            Console.WriteLine("ZSSSS");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Pingüino
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Pingüino";

        public Pingüino(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Pingüino(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }
        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Pescado");
        }

        public void sonar()
        {
            Console.WriteLine("GÜUU");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }
    class Lobo
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Lobo";

        public Lobo(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Lobo(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }
        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Carne");
        }

        public void sonar()
        {
            Console.WriteLine("AUUUU");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Cebra
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Cebra";

        public Cebra(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Cebra(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Hierbas");
        }

        public void sonar()
        {
            Console.WriteLine("RRRRRR");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Rinoceronte
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Rinoceronte";

        public Rinoceronte(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Rinoceronte(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }
        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Hierbas");
        }

        public void sonar()
        {
            Console.WriteLine("BRRRRRRR");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Panda
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Panda";

        public Panda(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Panda(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }

        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come Bambu");
        }

        public void sonar()
        {
            Console.WriteLine("BRRRRRRR");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class PavoReal
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Pavo Real";

        public PavoReal(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public PavoReal(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }
        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come semillas");
        }

        public void sonar()
        {
            Console.WriteLine("GLUGLU");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Tortuga
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Tortuga";
        public Tortuga(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Tortuga(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;


        }
        public void mover()
        {
            Console.WriteLine("Se mueve");

        }

        public void comer()
        {
            Console.WriteLine("Come hierbas");
        }

        public void sonar()
        {
            Console.WriteLine("AHAHA");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

}
