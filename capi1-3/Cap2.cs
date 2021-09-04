using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capi1_3
{
    class Cap2

    {
        public int perimetroPoligonoRegular(int numLado, int medidaLado)
        {
            return numLado * medidaLado;
        }

        public float tranformarRadiane(float grado)
        {
            return (float)(grado * 3.14 / 180);
        }

        public void conversionDolarEuro()
        {
            double cambioDolares = 56.82f, cambioEuro = 67.53f, dinero = 0f;
            int tipo;

            Console.Write("Digiste la cantidad de pesos dominicano: ");
            dinero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la opcion que desea:\n1.Cambiar a Dolares\n2.Cambiar a Euros ");
            Console.Write("Digite el tipo de cambio: ");
            tipo = Convert.ToInt32(Console.ReadLine());

            double conversion;

            if(tipo == 1)
            {
                conversion = dinero / cambioDolares;
                Console.WriteLine("la cantidad de Dolares es: " + conversion);
            }

            if(tipo == 2)
            {
                conversion = dinero / cambioEuro;
                Console.WriteLine("la cantidad de Euros es: " + conversion);
            }

            if(tipo != 1 && tipo != 2)
            {
                Console.WriteLine("esta opcion no es validad");
            }

        }




    }
}
