using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MiAgencia";
            Console.WriteLine("Selecciona una opcion de captura: ");
            Console.WriteLine("1. Capturar moto");
            Console.WriteLine("2. Capturar auto");
            Console.WriteLine("3. Capturar camioneta");

            int menu = int.Parse(Console.ReadLine());
            int anio, llantas, color;
            string modelo;

            switch (menu)
            {
                case 1:
                    Console.WriteLine("111");
                    break;
                case 2:
                    Console.WriteLine("Numero de llantas: ");
                    llantas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Modelo: ");
                    modelo = Console.ReadLine();

                    Console.WriteLine("Año: ");
                    anio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Color: 1 - 7");
                    color = int.Parse(Console.ReadLine());

                    Automovil miAuto = new Automovil();
                    miAuto.Id = 1;
                    miAuto.Llantas = llantas;
                    miAuto.Modelo = modelo;
                    miAuto.Anio = anio;

                    string res = miAuto.Capturar();
                    Console.WriteLine(res);

                    Console.ReadKey();

                    break;
                case 3:
                    Console.WriteLine("333");
                    break;
                default:
                    Console.WriteLine("Opcion seleccionada no existe.");
                    break;
            }
        }
    }
}
