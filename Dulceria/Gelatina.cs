using System;


namespace Dulceria
{
    class Gelatina : Dulce
    {
        public Gelatina()
        {
            Sabor = "Piña";
            Marca = "Jello";
            Alto = 20;
            Ancho = 15;
            Peso = 13;
            ElevarTemperatura();
            VaciarEnMolde();
            Refrigerar();
            Console.WriteLine("Puedes tomar tu gelatina.");
        }

        public override void ElevarTemperatura()
        {
            base.ElevarTemperatura();

            Console.WriteLine("Vertiendo Grenetina...");
            Console.WriteLine("Añadiendo Sabor...");
            Console.WriteLine("Añadiendo colorantes...");
        }
    }
}
