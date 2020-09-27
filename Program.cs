using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFÍOCLASE13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultadosuma, resultadoresta;
            String respuesta;

            Console.WriteLine("Bienvenido al programa para restar y sumar 2 numeros enteros.");
            do
            {
                Console.WriteLine("Ingrese el primer número entero:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número entero:");
                num2 = Convert.ToInt32(Console.ReadLine());
                resultadosuma = Operacion.SUMAR(num1, num2);
                resultadoresta = Operacion.RESTAR(num1, num2);
                Console.WriteLine("El resultado de  " + num1 + " + " + num2 + " es: " + resultadosuma);
                Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es: " + resultadoresta);

                Console.WriteLine("Ingrese S si quiere volver a ingresar 2 números, en caso contrario presione otra tecla.");
                respuesta = Console.ReadLine();
                Console.Clear();
            } while (respuesta == "S" || respuesta == "s");

            Console.WriteLine("Adiós, vuelva prontos...");
            Console.ReadKey();
        }
    }
}
