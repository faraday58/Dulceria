using System;
namespace Dulceria
{
   abstract class Dulce
    {
        private string sabor;
        private float ancho;
        private float alto;
        private int peso;
        private string marca;

        public string Sabor { get => sabor; set => sabor = value; }
        public float Ancho { get => ancho; set => ancho = value; }
        public float Alto { get => alto; set => alto = value; }
        public int Peso { get => peso; set => peso = value; }
        public string Marca { get => marca; set => marca = value; }

        public virtual void ElevarTemperatura()
        {
            Console.WriteLine("Elevando Temperatura");
        }
        public virtual void VaciarEnMolde()
        {
            Console.WriteLine("Vaciando en el molde");
        }

        public virtual void Refrigerar()
        {
            Console.WriteLine("Refrigerando ");

        }

    }
}
