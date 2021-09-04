using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capi1_3
{
    class Cap3
    {
        public void esPar()
        {
            int num;
            Console.Write("digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }

        public void diaSemana()
        {
            int num;
            Console.Write("digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num == 1)
            {
                Console.WriteLine("Domingo");
            }

            if (num == 2)
            {
                Console.WriteLine("Lunes");
            }

            if (num == 3)
            {
                Console.WriteLine("Martes");
            }

            if (num == 4)
            {
                Console.WriteLine("Miercoles");
            }

            if (num == 5)
            {
                Console.WriteLine("Jueves");
            }

            if (num == 6)
            {
                Console.WriteLine("Viernes");
            }

            if (num == 7)
            {
                Console.WriteLine("Sabado");
            }

            if(num != 1 && num != 2 && num != 3 && num != 4 && num != 5 && num != 6 && num != 7)
            {
                Console.WriteLine("numero de semana no valido");
            }

        }
    }
}
