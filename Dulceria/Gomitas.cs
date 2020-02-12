using System;


namespace Dulceria
{
    class Gomitas:Dulce
    {
        public Gomitas()
        {
            Sabor = "Cereza";
            Marca = "Rikolino";
            Peso = 20;
            Ancho = 5;
            Alto = 5;
            ElevarTemperatura();
            VaciarEnMolde();
            Refrigerar();
            Console.WriteLine("Puedes tomar tu gomita");
        }

        public override void ElevarTemperatura()
        {
            base.ElevarTemperatura();
            Console.WriteLine("Agregando Almidón ");
            Console.WriteLine("Agregando Azúcar ");
        }


    }
}
