using System;

namespace Dulceria
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a la máquina de Dulces");
            Console.WriteLine("Elige entre las siguientes opciones:");
            Console.WriteLine("1. Chocolate predeterminada \n2.-Agrega tu marca de chocolate " +
                "\n 3.-Chocolate (Marca y Sabor)   \n 4.-Gelatina \n 5.-Gomita  ");
            byte opcion =byte.Parse( Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Chocolate miChocolate = new Chocolate();                    
                    break;
                case 2:
                    Console.WriteLine("Introduce la marca de tu chocolate");
                    string marca = Console.ReadLine();
                    Chocolate suChocolate = new Chocolate(marca);
                    break;
                case 3:
                    Console.WriteLine("Introduce marca y sabor");
                    Console.WriteLine("Marca :");
                    marca = Console.ReadLine();
                    Console.WriteLine("Introduce el Sabor");
                    string sabor = Console.ReadLine();
                    suChocolate = new Chocolate(marca, sabor);
                    break;
                case 4:
                    Gelatina miGelatina = new Gelatina();
                    Console.WriteLine("Sabor: {0} \n Marca: {1} \n Peso: {2}[g]" +
                        " Ancho: {3} [mm] \n Alto: {4} [mm]", miGelatina.Sabor, miGelatina.Marca,
                         miGelatina.Ancho,miGelatina.Alto);
                    break;
                case 5:
                    Gomitas miGomita = new Gomitas();
                    Console.WriteLine("Sabor: {0} \n Marca: {1}" +
                        "\n Peso: { 2}[g] \n Ancho: {3} \n Altura: {4}[mm]", miGomita.Sabor, miGomita.Marca, 
                        miGomita.Peso, miGomita.Ancho, miGomita.Alto);
    
                    break;
                default:
                    Console.WriteLine("Ingresa una opción válida");
                    break;

            }
            Console.ReadLine();


        }
    }
}
