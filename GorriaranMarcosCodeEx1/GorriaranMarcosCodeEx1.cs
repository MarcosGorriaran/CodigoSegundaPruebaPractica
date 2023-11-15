/*
 * Autor: Marcos Gorriaran
 * Fecha: 15/11/2023
 * Ejercicio 1:
 *  Implementa en C# el següent disseny de solució en pseudocodi.
 *  Escriu els literals que falten:
 */
using System;

namespace SegonaProvaPractica
{
    class GorriaranMarcosCodeEx1
    {
        public static void Main()
        {
            const string FirstMsg = "Proporcioname un valor: ";
            const string SecondMsg = "El valor proporcionado tiene esta cantidad de digitos: ";

            int num, digit=0;

            Console.WriteLine(FirstMsg);
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                while (num > 0)
                {
                    num = num / 10;
                    digit = digit + 1;
                }
            }
            else
            {
                digit = 0;
            }

            Console.WriteLine(SecondMsg);
            Console.WriteLine(digit);
        }
    }
}