using System;

namespace Dulceria
{
    class Chocolate:Dulce
    {
        private string sabor;
        private float ancho;
        private float alto;
        private int peso;
        private string marca;

        

        public Chocolate()
        {
            sabor = "Amargo";
            ancho = 30f;
            alto = 10f;
            peso = 500;
            marca = "Choco Tavo";
            Console.WriteLine("Sabor:  {0}\n Ancho:  {1}" +
                "\n Alto:  {2}\n Peso: {3} \n Marca: {4}",sabor,ancho,alto,peso,marca );
            Console.WriteLine("Preparando Chocolate");
            ElevarTemperatura();
            VaciarEnMolde();
            Refrigerar();
            Console.WriteLine("Puedes tomar tu chocolate");

        }

        public Chocolate(string marca)
        {
            this.marca = marca;
            sabor = "Amargo";
            ancho = 30f;
            alto = 10f;
            peso = 500;
            Console.WriteLine("Sabor:  {0}\n Ancho:  {1}" +
               "\n Alto:  {2}\n Peso: {3} \n Marca: {4}", sabor, ancho, alto, peso, marca);
            Console.WriteLine("Preparando Chocolate");
            ElevarTemperatura();
            VaciarEnMolde();
            Refrigerar();
            Console.WriteLine("Puedes tomar tu chocolate");
        }

        public Chocolate(string marca, string sabor)
        {
            this.marca = marca;
            this.sabor = sabor;
            ancho = 30f;
            alto = 10f;
            peso = 500;
            Console.WriteLine("Sabor:  {0}\n Ancho:  {1}" +
               "\n Alto:  {2}\n Peso: {3} \n Marca: {4}", sabor, ancho, alto, peso, marca);
            Console.WriteLine("Preparando Chocolate");
            ElevarTemperatura();
            VaciarEnMolde();
            Refrigerar();
            Console.WriteLine("Puedes tomar tu chocolate");
        }

        public Chocolate(int peso)
        {
            this.peso = peso;
        }

    }
}
