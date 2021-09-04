using System;

namespace capi1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap1 cap1 = new Cap1();
            Cap2 cap2 = new Cap2();
            Cap3 cap3 = new Cap3();

            int opcion = 0;

            Console.WriteLine("Capitulo 1\n1.Ejercicio 1\n2.Ejercicio 5\n");
            Console.WriteLine("Capitulo 2\n3.Ejercicio 1\n4.Ejercicio 3\n5.Ejercicio 5\n");
            Console.WriteLine("Capitulo 3\n6.Ejercicio 1\n7.Ejercicio 4\n8.Salir\n");

            while(opcion != 8)
            {
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cap1.imprimirNombre();
                        break;
                    case 2:
                        cap1.agregarMensaje();
                        break;
                    case 3:
                        Console.WriteLine(cap2.perimetroPoligonoRegular(10, 20));
                        break;
                    case 4:
                        Console.WriteLine(cap2.tranformarRadiane(100));
                        break;
                    case 5:
                        cap2.conversionDolarEuro();
                        break;
                    case 6:
                        cap3.esPar();
                        break;
                    case 7:
                        cap3.diaSemana();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Opcion invalidad");
                        break;
                }
            }


        }
    }
}
